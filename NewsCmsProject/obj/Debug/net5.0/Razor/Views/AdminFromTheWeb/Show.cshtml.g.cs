#pragma checksum "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminFromTheWeb\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73a485096aaa050818428aa37d46bbccf0764300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminFromTheWeb_Show), @"mvc.1.0.view", @"/Views/AdminFromTheWeb/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73a485096aaa050818428aa37d46bbccf0764300", @"/Views/AdminFromTheWeb/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1320fa374142449869e422d0887fb1938f6a5002", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminFromTheWeb_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsCmsProject.Models.Entities.FromTheWeb>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminFromTheWeb\Show.cshtml"
  
    ViewData["Title"] = "???????????? ?????? ???????? ??????";
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-12\">\r\n    <div class=\"card-main\">\r\n        <div class=\"card-header\">\r\n            <h2>???????????? ?????? ???????? ??????</h2>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <dl class=\"dl-horizontal\">\r\n                <dt>");
#nullable restore
#line 14 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminFromTheWeb\Show.cshtml"
               Write(Html.DisplayNameFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n                <dd>");
#nullable restore
#line 15 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminFromTheWeb\Show.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                <dt>");
#nullable restore
#line 16 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminFromTheWeb\Show.cshtml"
               Write(Html.DisplayNameFor(m => m.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n                <dd>");
#nullable restore
#line 17 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminFromTheWeb\Show.cshtml"
               Write(Model.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                <dt>");
#nullable restore
#line 18 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminFromTheWeb\Show.cshtml"
               Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n                <dd>");
#nullable restore
#line 19 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminFromTheWeb\Show.cshtml"
                Write($"{Model.User.Firstname} {Model.User.Lastname}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                <dt>");
#nullable restore
#line 20 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminFromTheWeb\Show.cshtml"
               Write(Html.DisplayNameFor(m => m.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n                <dd>");
#nullable restore
#line 21 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminFromTheWeb\Show.cshtml"
               Write(Model.CreatedAt.ToSolar());

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                <dt>");
#nullable restore
#line 22 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminFromTheWeb\Show.cshtml"
               Write(Html.DisplayNameFor(m => m.UpdatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n                <dd>");
#nullable restore
#line 23 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminFromTheWeb\Show.cshtml"
                Write(Model.UpdatedAt?.ToSolar() ?? "...");

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-12\">\r\n    <div class=\"card-main mt-1\">\r\n        <div class=\"card-body row\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73a485096aaa050818428aa37d46bbccf07643008363", async() => {
                WriteLiteral("????????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73a485096aaa050818428aa37d46bbccf07643009613", async() => {
                WriteLiteral("??????????????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminFromTheWeb\Show.cshtml"
                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsCmsProject.Models.Entities.FromTheWeb> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
