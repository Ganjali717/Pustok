#pragma checksum "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\Author\Features.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cef894aa3576b32ec1024afb0711e4c7d5b8c7c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Author_Features), @"mvc.1.0.view", @"/Areas/Manage/Views/Author/Features.cshtml")]
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
#line 1 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\_ViewImports.cshtml"
using PustokTemp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\_ViewImports.cshtml"
using PustokTemp.Areas.Manage.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cef894aa3576b32ec1024afb0711e4c7d5b8c7c1", @"/Areas/Manage/Views/Author/Features.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"532deade0508c44dbf5a58858b676c7f143501ba", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Author_Features : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feature>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\Author\Features.cshtml"
  
    ViewData["Title"] = "Index";
    int order = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Features</h1>


<div class=""container-fluid"">
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Feature Name</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 19 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\Author\Features.cshtml"
             foreach (var features in Model)
            {
                order++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 23 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\Author\Features.cshtml"
                               Write(order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\Author\Features.cshtml"
                   Write(features.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 26 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\Author\Features.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feature>> Html { get; private set; }
    }
}
#pragma warning restore 1591
