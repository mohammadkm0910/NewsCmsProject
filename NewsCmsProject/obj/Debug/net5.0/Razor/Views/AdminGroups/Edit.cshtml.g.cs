#pragma checksum "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5a1ca086c222f461a09bed466c4d5b239eed093"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminGroups_Edit), @"mvc.1.0.view", @"/Views/AdminGroups/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a1ca086c222f461a09bed466c4d5b239eed093", @"/Views/AdminGroups/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1320fa374142449869e422d0887fb1938f6a5002", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminGroups_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsCmsProject.Models.Entities.Group>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""card-main main-border"">
    <div class=""card-header"">
        <h2>فرم ویرایش گروه</h2>
    </div>
    <div class=""card-body"">
        <section>
            <div class=""form-horizontal"">
                <label for=""title"">عنوان گروه</label>
                <input type=""text"" class=""form-control"" id=""title"" name=""title""");
            BeginWriteAttribute("value", " value=\"", 386, "\"", 406, 1);
#nullable restore
#line 11 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Edit.cshtml"
WriteAttributeValue("", 394, Model.Title, 394, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"عنوان گروه را وارد کنید\">\r\n            </div>\r\n            <div class=\"form-horizontal main-border\">\r\n                <a class=\"btn btn-success offset-form\"");
            BeginWriteAttribute("onclick", " onclick=\"", 577, "\"", 611, 3);
            WriteAttributeValue("", 587, "onEditGroup(\'", 587, 13, true);
#nullable restore
#line 14 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Edit.cshtml"
WriteAttributeValue("", 600, Model.Id, 600, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 609, "\')", 609, 2, true);
            EndWriteAttribute();
            WriteLiteral(">ذخیره اطلاعات</a>\r\n                <a class=\"btn btn-info mr-2\" onclick=\"onCloseAlertify()\">بازگشت</a>\r\n            </div>\r\n        </section>\r\n    </div>\r\n</div>");
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
