#pragma checksum "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e7f84d670f3de12338c61a1cb98a6d82cb67f24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TabBooksPartial), @"mvc.1.0.view", @"/Views/Shared/_TabBooksPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7f84d670f3de12338c61a1cb98a6d82cb67f24", @"/Views/Shared/_TabBooksPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8baa339307ce9d8c94c410edba1ac34a1ac737f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TabBooksPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addbasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("single-btn add-book-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""product-slider multiple-row  slider-border-multiple-row  sb-slick-slider""
     data-slick-setting='{
                            ""autoplay"": true,
                            ""autoplaySpeed"": 8000,
                            ""slidesToShow"": 5,
                            ""rows"":1,
                            ""dots"":true
                        }' data-slick-responsive='[
                            {""breakpoint"":1200, ""settings"": {""slidesToShow"": 3} },
                            {""breakpoint"":768, ""settings"": {""slidesToShow"": 2} },
                            {""breakpoint"":480, ""settings"": {""slidesToShow"": 1} },
                            {""breakpoint"":320, ""settings"": {""slidesToShow"": 1} }
                        ]'>

");
#nullable restore
#line 17 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
     foreach (var book in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single-slide\">\r\n            <div class=\"product-card\">\r\n                <div class=\"product-header\">\r\n                    <a href=\"#\" class=\"author\">\r\n                        ");
#nullable restore
#line 23 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
                   Write(book.Author.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <h3>\r\n                        <a href=\"product-details.html\">\r\n                            ");
#nullable restore
#line 27 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
                       Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </h3>\r\n                </div>\r\n                <div class=\"product-card--body\">\r\n                    <div class=\"card-image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e7f84d670f3de12338c61a1cb98a6d82cb67f247096", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1398, "~/uploads/book/", 1398, 15, true);
#nullable restore
#line 33 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
AddHtmlAttributeValue("", 1413, book.BookImages.FirstOrDefault(x=>x.PosterStatus==true)?.Image, 1413, 63, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e7f84d670f3de12338c61a1cb98a6d82cb67f248907", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1664, "~/uploads/book/", 1664, 15, true);
#nullable restore
#line 36 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
AddHtmlAttributeValue("", 1679, book.BookImages.FirstOrDefault(x=>x.PosterStatus==false)?.Image, 1679, 64, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e7f84d670f3de12338c61a1cb98a6d82cb67f2410668", async() => {
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
#line 39 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
                                                                                  WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
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
            WriteLiteral(@"
                                <a href=""wishlist.html"" class=""single-btn"">
                                    <i class=""fas fa-heart""></i>
                                </a>
                                <a href=""compare.html"" class=""single-btn"">
                                    <i class=""fas fa-random""></i>
                                </a>
                                <a href=""#""
                                   class=""single-btn show-product-modal"" data-id=""");
#nullable restore
#line 49 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
                                                                             Write(book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    <i class=\"fas fa-eye\"></i>\r\n                                </a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"price-block\">\r\n");
#nullable restore
#line 56 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
                         if (book.DiscountPrice > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price\">£");
#nullable restore
#line 58 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
                                             Write(book.SalePrice-book.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <del class=\"price-old\">£");
#nullable restore
#line 59 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
                                                Write(book.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                            <span class=\"price-discount\">");
#nullable restore
#line 60 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
                                                    Write(book.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 61 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price\">£");
#nullable restore
#line 64 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
                                            Write(book.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 65 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 70 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_TabBooksPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
