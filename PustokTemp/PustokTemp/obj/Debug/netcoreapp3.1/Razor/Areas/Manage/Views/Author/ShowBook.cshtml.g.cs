#pragma checksum "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\Author\ShowBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7ddabab226cc27a79abe0daefa7f6400851fd7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Author_ShowBook), @"mvc.1.0.view", @"/Areas/Manage/Views/Author/ShowBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ddabab226cc27a79abe0daefa7f6400851fd7a", @"/Areas/Manage/Views/Author/ShowBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f5541caaaa0a259c1f04290b20142de59e3aa2", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Author_ShowBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\Author\ShowBook.cshtml"
  
    ViewData["Title"] = "Index";
    int order = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Books</h1>


<div class=""container-fluid"">
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Book Name</th>
                <th scope=""col"">BooksCount</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\Author\ShowBook.cshtml"
             foreach (var books in Model)
            {
                order++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 24 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\Author\ShowBook.cshtml"
                               Write(order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\Author\ShowBook.cshtml"
                   Write(books.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\Author\ShowBook.cshtml"
                   Write(books.Name.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 28 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Areas\Manage\Views\Author\ShowBook.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
