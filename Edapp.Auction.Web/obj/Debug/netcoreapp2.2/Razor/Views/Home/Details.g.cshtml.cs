#pragma checksum "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ac2a0640c04431437c0f3fa34250606b410fc98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\_ViewImports.cshtml"
using Edapp.Auction.Web;

#line default
#line hidden
#line 2 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\_ViewImports.cshtml"
using Edapp.Auction.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ac2a0640c04431437c0f3fa34250606b410fc98", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"414e1e5c448fb89f383a2fab36174335623ecd3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-lg btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
  
    ViewData["Title"] = Model.Title;

#line default
#line hidden
            BeginContext(76, 64, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"text-left\">\r\n        ");
            EndContext();
            BeginContext(140, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ac2a0640c04431437c0f3fa34250606b410fc986293", async() => {
                BeginContext(230, 17, true);
                WriteLiteral("Back to all items");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 9 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
                                                                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(251, 118, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-12 col-md-8\">\r\n            <h1 class=\"d-block d-md-none\">");
            EndContext();
            BeginContext(370, 11, false);
#line 13 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(381, 93, true);
            WriteLiteral("</h1>\r\n            <div>\r\n                <div class=\"text-center\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 474, "\"", 498, 1);
#line 16 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
WriteAttributeValue("", 480, Model.PicturePath, 480, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(499, 18, true);
            WriteLiteral(" data-zoom-image=\"");
            EndContext();
            BeginContext(518, 17, false);
#line 16 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
                                                              Write(Model.PicturePath);

#line default
#line hidden
            EndContext();
            BeginContext(535, 154, true);
            WriteLiteral("\" alt=\"\">\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"col-12 col-md-4\">\r\n            <h1 class=\"d-none d-md-block\">");
            EndContext();
            BeginContext(690, 11, false);
#line 22 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(701, 134, true);
            WriteLiteral("</h1>\r\n            <div>\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <p>");
            EndContext();
            BeginContext(836, 17, false);
#line 26 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
                      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(853, 132, true);
            WriteLiteral("</p>\r\n                        <h5 class=\"card-title\">Current Bid</h5>\r\n                        <p class=\"card-text\" id=\"itemPrice\">£");
            EndContext();
            BeginContext(986, 11, false);
#line 28 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
                                                        Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(997, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 29 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
                         if (Model.EndTime > DateTime.UtcNow)
                        {

#line default
#line hidden
            BeginContext(1093, 63, true);
            WriteLiteral("                            <p class=\"card-text\">Auction Ends: ");
            EndContext();
            BeginContext(1157, 13, false);
#line 31 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
                                                          Write(Model.EndTime);

#line default
#line hidden
            EndContext();
            BeginContext(1170, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 32 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1260, 68, true);
            WriteLiteral("                            <p class=\"card-text\">Auction ended</p>\r\n");
            EndContext();
#line 36 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(1355, 72, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 40 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
             if (User.Identity.IsAuthenticated && Model.EndTime > DateTime.UtcNow)
            {

#line default
#line hidden
            BeginContext(1526, 310, true);
            WriteLiteral(@"                <div class=""form-group mb-3"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">£</span>
                        <input id=""bid-amount"" maxlength=""12"" required type=""number"" name=""bidAmount"" class=""form-control"" placeholder=""Amount""");
            EndContext();
            BeginWriteAttribute("min", " min=\"", 1836, "\"", 1869, 1);
#line 45 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
WriteAttributeValue("", 1842, Model.Price.ToString("F2"), 1842, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1870, 172, true);
            WriteLiteral(">\r\n                    </div>\r\n                    <button class=\"btn btn-danger btn-lg btn-block mt-1\" type=\"submit\" id=\"button-bid\">Bid</button>\r\n                </div>\r\n");
            EndContext();
#line 49 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
            }
            else if (!User.Identity.IsAuthenticated)
            {

#line default
#line hidden
            BeginContext(2126, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2142, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ac2a0640c04431437c0f3fa34250606b410fc9814715", async() => {
                BeginContext(2270, 14, true);
                WriteLiteral("Sign In To Bid");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
                                                                                                                  WriteLiteral(Model.ReturnUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2288, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 53 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(2305, 73, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<input type=\"hidden\" id=\"consoleId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2378, "\"", 2395, 1);
#line 58 "C:\Code\Edapp.Auction\Edapp.Auction.Web\Views\Home\Details.cshtml"
WriteAttributeValue("", 2386, Model.Id, 2386, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2396, 7, true);
            WriteLiteral(" />\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2422, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2428, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ac2a0640c04431437c0f3fa34250606b410fc9818309", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2476, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2482, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ac2a0640c04431437c0f3fa34250606b410fc9819565", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2517, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
