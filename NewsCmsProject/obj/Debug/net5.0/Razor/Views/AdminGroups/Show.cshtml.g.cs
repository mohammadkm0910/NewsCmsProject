#pragma checksum "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a61170382da7b2fc58c802d86ff3a17654176251"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminGroups_Show), @"mvc.1.0.view", @"/Views/AdminGroups/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a61170382da7b2fc58c802d86ff3a17654176251", @"/Views/AdminGroups/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1320fa374142449869e422d0887fb1938f6a5002", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminGroups_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsCmsProject.Models.Entities.Group>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card-main main-border\">\r\n    <div class=\"card-header\">\r\n        <h2>جزئیات گروه</h2>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>عنوان گروه:</dt>\r\n            <dd>");
#nullable restore
#line 10 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Show.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <dt>تاریخ ایجاد:</dt>\r\n            <dd>");
#nullable restore
#line 12 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Show.cshtml"
           Write(Model.CreatedAt.ToSolar());

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n            <dt>تاریخ بروزرسانی:</dt>\r\n            <dd>");
#nullable restore
#line 14 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Show.cshtml"
            Write(Model.UpdatedAt?.ToSolar() ?? "...");

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        </dl>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsCmsProject.Models.Entities.Group> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
