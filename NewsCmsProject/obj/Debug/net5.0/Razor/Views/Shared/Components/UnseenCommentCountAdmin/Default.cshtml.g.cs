#pragma checksum "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Shared\Components\UnseenCommentCountAdmin\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "719ac793a1f9c50b635453067a3e87ccb061f05f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UnseenCommentCountAdmin_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UnseenCommentCountAdmin/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719ac793a1f9c50b635453067a3e87ccb061f05f", @"/Views/Shared/Components/UnseenCommentCountAdmin/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1320fa374142449869e422d0887fb1938f6a5002", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_UnseenCommentCountAdmin_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Shared\Components\UnseenCommentCountAdmin\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<li class=\"navigation\">\r\n    <a><i class=\"fas fa-bell\"></i></a>\r\n    <span id=\"unseen-label\">");
#nullable restore
#line 9 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\Shared\Components\UnseenCommentCountAdmin\Default.cshtml"
                       Write(Model.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
