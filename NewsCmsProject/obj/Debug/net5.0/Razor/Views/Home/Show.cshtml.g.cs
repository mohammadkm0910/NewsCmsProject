#pragma checksum "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84b67187abcd791c1a1026ca9eba6c1d8453dd39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\_ViewImports.cshtml"
using NewsCmsProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\_ViewImports.cshtml"
using NewsCmsProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\_ViewImports.cshtml"
using NewsCmsProject.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b67187abcd791c1a1026ca9eba6c1d8453dd39", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1320fa374142449869e422d0887fb1938f6a5002", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsCmsProject.Models.Dto.App.ShowNews>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/asset/app/image/Mahak.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/asset/app/image/Toranji-Ad.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
  
    ViewData["Title"] = Model.Title;
    Layout = "_AppLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Main", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6 first-ad\">\r\n            <a href=\"#\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "84b67187abcd791c1a1026ca9eba6c1d8453dd396696", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </a>\r\n        </div>\r\n        <div class=\"col-md-6 first-ad\">\r\n            <a href=\"#\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "84b67187abcd791c1a1026ca9eba6c1d8453dd397999", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </a>\r\n        </div>\r\n    </div>\r\n    <div class=\"row card-image-post\">\r\n        <div class=\"image-box\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "84b67187abcd791c1a1026ca9eba6c1d8453dd399317", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 606, "~/", 606, 2, true);
#nullable restore
#line 24 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
AddHtmlAttributeValue("", 608, Model.Image, 608, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
AddHtmlAttributeValue("", 627, Model.Title, 627, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <div class=\"info-box\">\r\n            <p>\r\n                <i class=\"fas fa-user\"></i>\r\n                ??????????: ");
#nullable restore
#line 29 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
                  Write(Model.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n            <p>?????????? ????????????: ");
#nullable restore
#line 31 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
                        Write(Model.CreatedAt.ToSolar());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>?????????? ??????????: ");
#nullable restore
#line 32 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
                       Write(Model.Comments.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>\r\n                <i class=\"fas fa-list-alt\"></i>\r\n                ????????:");
#nullable restore
#line 35 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
                Write(Model.GroupTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"title-box\"><h5>");
#nullable restore
#line 38 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
                              Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"col-md-8 col-9 p-0\">\r\n    <div class=\"card-main-large\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "84b67187abcd791c1a1026ca9eba6c1d8453dd3913163", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1233, "~/", 1233, 2, true);
#nullable restore
#line 44 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
AddHtmlAttributeValue("", 1235, Model.Image, 1235, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1254, "~/", 1254, 2, true);
#nullable restore
#line 44 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
AddHtmlAttributeValue("", 1256, Model.Title, 1256, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"p-4\">\r\n            ");
#nullable restore
#line 46 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
       Write(Html.Raw(Model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"card-main-large mt-2 p-0\">\r\n");
#nullable restore
#line 50 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
         if (User?.Identity?.IsAuthenticated ?? false)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 main-form fix-show-form\" id=\"form-comment\">\r\n                <header>\r\n                    <h5>?????? ?????? ?????? ??????????</h5>\r\n                </header>\r\n                <input type=\"hidden\" id=\"newsId\" name=\"newsId\"");
            BeginWriteAttribute("value", " value=\"", 1712, "\"", 1729, 1);
#nullable restore
#line 56 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
WriteAttributeValue("", 1720, Model.Id, 1720, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""form-group"">
                    <label for=""comment"" class=""label-text"">?????? ????????????</label>
                    <textarea class=""input-text"" placeholder=""???????????? ?????? ???? ???????? ????????"" name=""comment"" id=""comment""></textarea>
                </div>
                <div class=""form-group checkbox-row"">
                    <label>
                        ???????????? ?????????? ???????????? ???? ???????? ???? ???????????? ???????? ????.
                        <input type=""checkbox"" name=""accept"" id=""accept"">
                        <span class=""checkbox-mark""></span>
                    </label>
                </div>
                <div class=""form-group"">
                    <input type=""button"" class=""btn btn-block"" id=""insert-comment"" value=""?????? ??????"">
                </div>
            </div>
");
#nullable restore
#line 72 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-12 main-form fix-show-form"" id=""form-comment"">
                <header>
                    <h5>?????? ???????? ???????? ???????? ???????? ??????!</h5>
                </header>
                <div class=""row"">
                    <div class=""col-md-6"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84b67187abcd791c1a1026ca9eba6c1d8453dd3917794", async() => {
                WriteLiteral("?????? ??????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84b67187abcd791c1a1026ca9eba6c1d8453dd3919342", async() => {
                WriteLiteral("????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 88 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 90 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
     if (Model.Comments.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-main-large mt-2 p-0\">\r\n");
#nullable restore
#line 93 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
             foreach (var comment in Model.Comments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row comments\">\r\n                    <div class=\"avatar\">\r\n                        <span class=\"fas fa-users\"></span>\r\n                    </div>\r\n                    <div class=\"comment-info\">\r\n                        <h4>");
#nullable restore
#line 100 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
                       Write(comment.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>");
#nullable restore
#line 101 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
                      Write(comment.CreatedAt.ToSolar());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-12 text\">\r\n                        <p>");
#nullable restore
#line 104 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
                      Write(comment.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 107 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 109 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-main-large mt-2 p-0\">\r\n            <div class=\"comment-no\">???????? ???????? ?????????? ???????? ??????????</div>\r\n        </div>\r\n");
#nullable restore
#line 115 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 120 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
     if (Context.IsInternetExplore())
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <script>
            function autosize(textarea) {
                $(textarea).height(1);
                $(textarea).height($(textarea).prop(""scrollHeight""));
            }
            $(function () {
                $(document).on(""input"", ""textarea"", function () {
                    autosize(this);
                });
                $(""textarea"").each(function () {
                    autosize(this);
                });
            });
        </script>
");
#nullable restore
#line 136 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Home\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
        $('#insert-comment').on('click', function () {
            let data = {
                newsId: $('#newsId').val(),
                comment: $('#comment').val(),
                accept: $('#accept').prop('checked')
            };
            $.post('/Home/Comment-Store', data).done(function (response) {
                if (response.isSuccess) {
                    alertify.alert('???????? ??????????', response.message, function () {
                        window.location.reload();
                    });
                } else {
                    alertify.error(response.message);
                }
            }).fail(function () {
                alertify.error('???????? ?????????????????? ???? ???? ??????!');
            });
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsCmsProject.Models.Dto.App.ShowNews> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
