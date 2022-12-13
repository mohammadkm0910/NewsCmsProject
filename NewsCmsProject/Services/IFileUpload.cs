using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using NewsCmsProject.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace NewsCmsProject.Services
{
    public interface IFileUpload
    {
        Task<ResultDto> UploadFile(IFormFile file, string oldPath = null);
        void RemoveImage(string oldPath);
    }
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _environment;

        public FileUpload(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public async Task<ResultDto> UploadFile(IFormFile file, string oldPath = null)
        {
            if (file == null || file.Length == 0)
            {
                return new ResultDto { IsSuccess = false, Message = null };
            }
            RemoveImage(oldPath);
            var folder = @"Images\News\";
            var uploadsRootFolder = Path.Combine(_environment.WebRootPath, folder);
            if (!Directory.Exists(uploadsRootFolder))
            {
                Directory.CreateDirectory(uploadsRootFolder);
            }
            var filename = DateTime.Now.Ticks.ToString() + file.FileName;
            var filePath = Path.Combine(uploadsRootFolder, filename);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            var path = $"{folder}{filename}".Replace("\\", "/");
            return new ResultDto { IsSuccess = true, Message = path };
        }
        public void RemoveImage(string oldPath)
        {
            if (oldPath != null)
            {
                oldPath = Path.Combine(_environment.WebRootPath, oldPath);
                oldPath = oldPath.Replace("/", "\\");
                if (File.Exists(oldPath)) File.Delete(oldPath);
            }
        }
    }
}