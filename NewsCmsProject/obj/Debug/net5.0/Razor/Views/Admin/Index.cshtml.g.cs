#pragma checksum "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5fe4e17bbb03262ba7ff3cd246c0c1cbb709d6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5fe4e17bbb03262ba7ff3cd246c0c1cbb709d6a", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1320fa374142449869e422d0887fb1938f6a5002", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsCmsProject.Models.Dto.DashboardAdmin>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/asset/plugin/chartist-js/chartist.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/asset/plugin/chartist-js/chartist.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "مدیریت سایت";
    Layout = "_AdminLayout";
    ViewBag.BaseUrl = "news";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f5fe4e17bbb03262ba7ff3cd246c0c1cbb709d6a4912", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-3 col-sm-6\">\r\n        <div class=\"card gradient-mint\">\r\n            <p><i class=\"fas fa-pager\"></i></p>\r\n            <h3>تعداد اخبار قابل نمایش</h3>\r\n            <p>");
#nullable restore
#line 19 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Admin\Index.cshtml"
          Write(Model.NewsDisplayedCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-3 col-sm-6\">\r\n        <div class=\"card gradient-light-blue-cyan\">\r\n            <p><i class=\"fas fa-pager\"></i></p>\r\n            <h3>تعداد اخبار</h3>\r\n            <p>");
#nullable restore
#line 26 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Admin\Index.cshtml"
          Write(Model.NewsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-3 col-sm-6\">\r\n        <div class=\"card gradient-orange-amber\">\r\n            <p><i class=\"fas fa-layer-group\"></i></p>\r\n            <h3>تعداد نظرات تایید شده</h3>\r\n            <p>");
#nullable restore
#line 33 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Admin\Index.cshtml"
          Write(Model.CommentApprovedCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-3 col-sm-6\">\r\n        <div class=\"card bg-info\">\r\n            <p><i class=\"fas fa-layer-group\"></i></p>\r\n            <h3>تعداد گروه های خبری</h3>\r\n            <p>");
#nullable restore
#line 40 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Admin\Index.cshtml"
          Write(Model.GroupNewsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-6"">
        <div class=""card-main"">
            <div class=""card-header"">
                <h2>کاربران وب سایت</h2>
            </div>
            <div class=""card-body row"">
                <div class=""col-6"">
                    <div class=""card gradient-red-pink"">
                        <p><i class=""fas fa-comment-alt""></i></p>
                        <h3>تعداد نظرات</h3>
                        <p>");
#nullable restore
#line 55 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Admin\Index.cshtml"
                      Write(Model.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""col-6"">
                    <div class=""card gradient-mint"">
                        <p><i class=""fas fa-user""></i></p>
                        <h3>تعداد کاربران سایت</h3>
                        <p>");
#nullable restore
#line 62 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Admin\Index.cshtml"
                      Write(Model.UserSiteCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-6"">
        <div class=""card-main"">
            <div class=""card-header"">
                <h2>میزان استفاده از مرورگر ها</h2>
            </div>
            <div class=""card-body"">
                <div class=""browser-chart""></div>
                <div class=""list-browser"">
                    <p><span class=""bg-success""></span>اپرا</p>
                    <p><span class=""bg-primary""></span>فایرفاکس</p>
                    <p><span class=""bg-danger""></span>کروم</p>
                    <p><span class=""bg-warning""></span>سافاری</p>
                    <p><span class=""bg-info""></span>دیگر</p>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5fe4e17bbb03262ba7ff3cd246c0c1cbb709d6a10298", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        new Chartist.Pie("".browser-chart"", {
            series: [10, 30, 37, 18, 3]
        }, {
            donut: true,
            donutWidth: 30,
            donutSolid: true,
            startAngle: 270,
            showLabel: true
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsCmsProject.Models.Dto.DashboardAdmin> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591