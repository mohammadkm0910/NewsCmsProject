#pragma checksum "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "586f387da17cad3ed4d85e2e85fe945e3af39fb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminGroups_Index), @"mvc.1.0.view", @"/Views/AdminGroups/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"586f387da17cad3ed4d85e2e85fe945e3af39fb5", @"/Views/AdminGroups/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1320fa374142449869e422d0887fb1938f6a5002", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminGroups_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NewsCmsProject.Models.Entities.Group>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Index.cshtml"
  
    ViewData["Title"] = "???????? ?????? ????????";
    Layout = "_AdminLayout";
    var rowsKey = 1;
    ViewBag.BaseUrl = "groups";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-main"">
    <div class=""card-header clearfix"">
        <h2>???????? ???????? ?????? ????????</h2>
        <button onclick=""createGroup()"" class=""btn btn-success"">?????????? ???????? ????????</button>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table-group"">
                <thead>
                    <tr>
                        <th>??????????</th>
                        <th>??????????</th>
                        <th>?????????? ??????????</th>
                        <th>?????????? ??????????????????</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 28 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td");
            BeginWriteAttribute("title", " title=\"", 984, "\"", 1000, 1);
#nullable restore
#line 31 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Index.cshtml"
WriteAttributeValue("", 992, item.Id, 992, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Index.cshtml"
                                            Write(rowsKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Index.cshtml"
                           Write(item.CreatedAt.ToSolar());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Index.cshtml"
                            Write(item.UpdatedAt?.ToSolar() ?? "...");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"single-line\">\r\n                                <a class=\"btn btn-warning btn-icon\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1328, "\"", 1359, 3);
            WriteAttributeValue("", 1338, "editGroup(\'", 1338, 11, true);
#nullable restore
#line 36 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Index.cshtml"
WriteAttributeValue("", 1349, item.Id, 1349, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1357, "\')", 1357, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n                                <a class=\"btn btn-info btn-icon\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1458, "\"", 1493, 3);
            WriteAttributeValue("", 1468, "openShowGroup(\'", 1468, 15, true);
#nullable restore
#line 37 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Index.cshtml"
WriteAttributeValue("", 1483, item.Id, 1483, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1491, "\')", 1491, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-info\"></i></a>\r\n                                <a class=\"btn btn-danger btn-icon\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1594, "\"", 1627, 3);
            WriteAttributeValue("", 1604, "deleteGroup(\'", 1604, 13, true);
#nullable restore
#line 38 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Index.cshtml"
WriteAttributeValue("", 1617, item.Id, 1617, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1625, "\')", 1625, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\mohammad\source\repos\NewsCmsProject\NewsCmsProject\Views\AdminGroups\Index.cshtml"
                        ++rowsKey;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function createGroup() {
            let url = '/Admin/Groups/Create';
            $.get(url, function (result) {
                alertify.confirm(
                    ""?????????? ???????? ????????"",
                    result,
                    function () {
                    },
                    function () {
                    }
                ).set('basic', true);
            });
        }
        function editGroup(id) {
            let url = '/Admin/Groups/Edit/' + id;
            $.get(url, function (result) {
                alertify.confirm(
                    ""???????????? ????????"",
                    result,
                    function () {
                    },
                    function () {
                    }
                ).set('basic', true);
            });
        }
        function openShowGroup(id) {
            let url = '/Admin/Groups/Show/' + id;
            $.get(url, function (result) {
                alertify.alert(
                ");
                WriteLiteral(@"    ""???????????? ????????"",
                    result
                );
            });
        }
        function deleteGroup(id) {
            alertify.confirm(
                ""?????? ????????"",
                ""?????? ???? ?????? ?????? ???????? ?????????????? ????????????"",
                function () {
                    $.post('/Admin/Groups/Destroy', { id: id }).done(function (result) {
                        if (!result.isSuccess) {
                            toastError(result.message, false, false);
                        } else {
                            flushMessages(result.message);
                        }
                    });
                },
                function () {
                    toastError(""?????? ???? ?????? ???????? ?????????? ?????? ??????"");
                }
            ).set('basic', false);
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NewsCmsProject.Models.Entities.Group>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
