#pragma checksum "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a380a58a281f00966e53627596e202419075ab4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BookPartial), @"mvc.1.0.view", @"/Views/Shared/_BookPartial.cshtml")]
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
#line 1 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\_ViewImports.cshtml"
using PustokTemp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\_ViewImports.cshtml"
using PustokTemp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\_ViewImports.cshtml"
using PustokTemp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\_ViewImports.cshtml"
using PustokTemp.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a380a58a281f00966e53627596e202419075ab4", @"/Views/Shared/_BookPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8baa339307ce9d8c94c410edba1ac34a1ac737f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BookPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addtobasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("single-btn add-book-btn2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("single-btn book-detail-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
 foreach (var book in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-4 col-sm-6\">\r\n        <div class=\"product-card\">\r\n            <div class=\"product-grid-content\">\r\n                <div class=\"product-header\">\r\n                    <a href=\"#\" class=\"author\">\r\n                        ");
#nullable restore
#line 10 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
                   Write(book.Author.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <h3><a href=\"product-details.html\">");
#nullable restore
#line 12 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
                                                  Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                </div>\r\n                <div class=\"product-card--body\">\r\n                    <div class=\"card-image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2a380a58a281f00966e53627596e202419075ab46896", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 573, "~/uploads/book/", 573, 15, true);
#nullable restore
#line 16 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
AddHtmlAttributeValue("", 588, book.BookImages.FirstOrDefault(x=>x.PosterStatus==true)?.Image, 588, 63, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"hover-contents\">\r\n                            <a href=\"product-details.html\" class=\"hover-image\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2a380a58a281f00966e53627596e202419075ab48699", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 839, "~/uploads/book/", 839, 15, true);
#nullable restore
#line 19 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
AddHtmlAttributeValue("", 854, book.BookImages.FirstOrDefault(x=>x.PosterStatus==false)?.Image, 854, 64, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </a>\r\n                            <div class=\"hover-btns\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a380a58a281f00966e53627596e202419075ab410452", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-shopping-basket\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
                                                                                    WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
                                                                                                              Write(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <a href=\"wishlist.html\" class=\"single-btn\">\r\n                                    <i class=\"fas fa-heart\"></i>\r\n                                </a>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a380a58a281f00966e53627596e202419075ab413888", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-random\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
                                                                               WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
                                                                                                         Write(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <a href=\"#\"\r\n                                   class=\"single-btn show-product-modal\" data-id=\"");
#nullable restore
#line 32 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
                                                                             Write(book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    <i class=\"fas fa-eye\"></i>\r\n                                </a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"price-block\">\r\n");
#nullable restore
#line 39 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
                         if (book.DiscountPrice > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price\">£");
#nullable restore
#line 41 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
                                             Write(book.SalePrice-book.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <del class=\"price-old\">£");
#nullable restore
#line 42 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
                                                Write(book.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                            <span class=\"price-discount\">");
#nullable restore
#line 43 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
                                                    Write(book.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 44 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price\">£");
#nullable restore
#line 47 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
                                            Write(book.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 48 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"product-list-content\">\r\n                <div class=\"card-image\">\r\n                    <img src=\"image/products/product-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2860, "\"", 2866, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""product-card--body"">
                    <div class=""product-header"">
                        <a href=""#"" class=""author"">
                            Gpple
                        </a>
                        <h3>
                            <a href=""product-details.html"" tabindex=""0"">
                                Qpple cPad with Retina
                                Display MD510LL/A
                            </a>
                        </h3>
                    </div>
                    <article>
                        <h2 class=""sr-only"">Card List Article</h2>
                        <p>
                            More room to move. With 80GB or 160GB of storage and up to 40 hours
                            of battery life, the new iPod classic lets you enjoy
                            up to 40,000 songs or..
                        </p>
                    </article>
                    <div class=""price-block"">
      ");
            WriteLiteral(@"                  <span class=""price"">£51.20</span>
                        <del class=""price-old"">£51.20</del>
                        <span class=""price-discount"">20%</span>
                    </div>
                    <div class=""rating-block"">
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star ""></span>
                    </div>
                    <div class=""btn-block"">
                        <a href=""#"" class=""btn btn-outlined"">Add To Cart</a>
                        <a href=""#"" class=""card-link"">
                            <i class=""fas fa-heart""></i> Add To
                            Wishlist
                        </a>
                        <a href=""#"" class=""card-link"">
                            <i class=""fas fa-");
            WriteLiteral("random\"></i> Add To\r\n                            Cart\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 103 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookPartial.cshtml"

}

#line default
#line hidden
#nullable disable
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
