using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using NewsCmsProject.Extensions;
using NewsCmsProject.Models;
using NewsCmsProject.Models.Contexts;
using NewsCmsProject.Models.Dto;
using NewsCmsProject.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NewsCmsProject.Controllers
{
    public class AuthController : Controller
    {
        private readonly DatabaseContext _db;

        public AuthController(DatabaseContext context)
        {
            _db = context;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register([Bind("Firstname,Lastname,Email,Password,RePassword")] RequestRegisterUser request)
        {
            if (User.Identity?.IsAuthenticated ?? false)
            {
                TempData["Object"] = JsonConvert.SerializeObject(new ResultDto<RequestRegisterUser>
                { 
                    IsSuccess = false,
                    Message = "شما به حساب کاربری خود وارد شده اید! و در حال حاضر نمی توانید ثبت نام مجدد کنید",
                    Data = request
                });
                return Redirect(nameof(Register));
            }
            if (ModelState.IsValid)
            {
                var passwordHasher = new PasswordHasher();
                var user = new User
                {
                    Firstname = request.Firstname,
                    Lastname = request.Lastname,
                    Email = request.Email,
                    Password = passwordHasher.HashPassword(request.Password),
                    Permission = UserPermission.User
                };
                try
                {
                    await _db.Users.AddAsync(user);
                    await _db.SaveChangesAsync();
                    TempData["Message"] = "ثبت نام کاربر با موفقیت انجام شد";
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception)
                {
                    TempData["Object"] = JsonConvert.SerializeObject(new ResultDto<RequestRegisterUser>
                    {
                        IsSuccess = false,
                        Message = "خطای غیر منتظره ای رخ داد!",
                        Data = request
                    });
                    return Redirect(nameof(Register));
                }
            }
            return Redirect(nameof(Register));
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email,Password,IsRememberMe")] RequestLoginUser request)
        {
            if (User.Identity?.IsAuthenticated ?? false)
            {
                return Json(new ResultDto { IsSuccess = false, Message = "شما به حساب کاربری خود وارد شده اید!" });
            }
            if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
            {
                return Json(new ResultDto { IsSuccess = false, Message = "لطفاً فیلد های ضروری را وارد کنید!" });
            }
            var user = _db.Users.FirstOrDefault(u => u.Email.Equals(request.Email));
            if (user == null)
            {
                return Json(new ResultDto
                {
                    IsSuccess = false,
                    Message = "کاربری با چنین ایمیلی در سایت ثبت نام نکرده است!"
                });
            }
            var passwordHasher = new PasswordHasher();
            if (!passwordHasher.VerifyPassword(user.Password, request.Password))
            {
                return Json(new ResultDto { IsSuccess = false, Message = "رمز وارد شده اشتباه است!" });
            }
            string roleName = "NotRole";
            switch (user.Permission)
            {
                case UserPermission.User:
                    roleName = nameof(UserPermission.User);
                    break;
                case UserPermission.Admin:
                    roleName = nameof(UserPermission.Admin);
                    break;
            }
            var claims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new(ClaimTypes.Name, $"{user.Firstname} {user.Lastname}"),
                new(ClaimTypes.Email, request.Email),
                new(ClaimTypes.Role, roleName)
            };
            
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            var properties = new AuthenticationProperties
            {
                IsPersistent = request.IsRememberMe,
                ExpiresUtc = !request.IsRememberMe ? DateTime.Now.AddDays(1) : DateTime.Now.AddMonths(1)
            };
            await HttpContext.SignInAsync(principal, properties);
            return Json(new ResultDto { IsSuccess = true, Message = "کاربر گرامی شما با موفقیت وارد شده اید" });
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}