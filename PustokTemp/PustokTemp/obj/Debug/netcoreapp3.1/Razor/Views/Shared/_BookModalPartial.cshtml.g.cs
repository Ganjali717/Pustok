#pragma checksum "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "934acbbb319169a2dff77f794c96143522a43d09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BookModalPartial), @"mvc.1.0.view", @"/Views/Shared/_BookModalPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"934acbbb319169a2dff77f794c96143522a43d09", @"/Views/Shared/_BookModalPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8baa339307ce9d8c94c410edba1ac34a1ac737f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BookModalPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-5\">\r\n        <!-- Product Details Slider Big Image-->\r\n        <div>\r\n            <div class=\"single-slide\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "934acbbb319169a2dff77f794c96143522a43d094059", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 193, "~/assets/image/products/", 193, 24, true);
#nullable restore
#line 8 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
AddHtmlAttributeValue("", 217, Model.BookImages.FirstOrDefault(x=>x.PosterStatus==true)?.Image, 217, 64, false);

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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <!-- Product Details Slider Nav -->\r\n    </div>\r\n    <div class=\"col-lg-7 mt--30 mt-lg--30\">\r\n        <div class=\"product-details-info pl-lg--30 \">\r\n            <p class=\"tag-block\">\r\n                Tags:\r\n");
#nullable restore
#line 17 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
                 for (int i = 0; i < Model.BookTags.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\">");
#nullable restore
#line 19 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
                           Write(Model.BookTags[i].Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 20 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
                Write(i!=Model.BookTags.Count-1?",":"");

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
                                                       
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\r\n            <h3 class=\"product-title\">");
#nullable restore
#line 23 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <ul class=\"list-unstyled\">\r\n                <li>Genre: <a href=\"#\" class=\"list-value font-weight-bold genre-name\"> ");
#nullable restore
#line 25 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
                                                                                  Write(Model.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                <li>Product Code: <span class=\"list-value\"> ");
#nullable restore
#line 26 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
                                                       Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                <li>Availability: <span class=\"list-value\"> ");
#nullable restore
#line 27 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
                                                        Write(Model.IsAvailable?"In Stock":"Out Stock");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n            </ul>\r\n            <div class=\"price-block\">\r\n                <span class=\"price-new\">£ ");
#nullable restore
#line 30 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
                                      Write(Model.SalePrice-Model.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 31 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
                 if (Model.DiscountPrice > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <del class=\"price-old\">£ ");
#nullable restore
#line 33 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
                                        Write(Model.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n");
#nullable restore
#line 34 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"rating-widget\">\r\n                <div class=\"rating-block\">\r\n");
#nullable restore
#line 38 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
                     for (int i = 1; i <= 5; i++)
                    {
                        if (i <= Model.Rate)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"fas fa-star star_on\"></span>\r\n");
#nullable restore
#line 43 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"fas fa-star \"></span>\r\n");
#nullable restore
#line 47 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"

                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""review-widget"">
                    <a href=""#"">(1 Reviews)</a> <span>|</span>
                    <a href=""#"">Write a review</a>
                </div>
            </div>
            <article class=""product-details-article"">
                <h4 class=""sr-only"">Product Summery</h4>
                <p>
                   ");
#nullable restore
#line 59 "C:\Users\LENOVO\OneDrive\Desktop\PustokTemp\PustokTemp\Views\Shared\_BookModalPartial.cshtml"
              Write(Model.InfoText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </article>
            <div class=""add-to-cart-row"">
                <div class=""count-input-block"">
                    <span class=""widget-label"">Qty</span>
                    <input type=""number"" class=""form-control text-center"" value=""1"">
                </div>
                <div class=""add-cart-btn"">
                    <a href=""#"" class=""btn btn-outlined--primary"">
                        <span class=""plus-icon"">+</span>Add to Cart
                    </a>
                </div>
            </div>
            <div class=""compare-wishlist-row"">
                <a href=""#"" class=""add-link""><i class=""fas fa-heart""></i>Add to Wish List</a>
                <a href=""#"" class=""add-link""><i class=""fas fa-random""></i>Add to Compare</a>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
