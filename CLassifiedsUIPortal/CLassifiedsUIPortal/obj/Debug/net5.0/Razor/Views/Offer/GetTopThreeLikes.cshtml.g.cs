#pragma checksum "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetTopThreeLikes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86f288f7cddfb9b868ebd46c3e8e3c54eca3af82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offer_GetTopThreeLikes), @"mvc.1.0.view", @"/Views/Offer/GetTopThreeLikes.cshtml")]
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
#line 1 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\_ViewImports.cshtml"
using CLassifiedsUIPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\_ViewImports.cshtml"
using CLassifiedsUIPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86f288f7cddfb9b868ebd46c3e8e3c54eca3af82", @"/Views/Offer/GetTopThreeLikes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d194b80d01703f30b4bce0794a06429426d1b9ba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Offer_GetTopThreeLikes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/fontawesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/templatemo-style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("GetOfferByTopThreeLikes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/browser.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/breakpoints.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/transition.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/owl-carousel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/custom.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("is-preload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f288f7cddfb9b868ebd46c3e8e3c54eca3af829170", async() => {
                WriteLiteral("\n\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 563, "\"", 573, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 599, "\"", 609, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <link href=\"https://fonts.googleapis.com/css?family=Roboto:100,300,400,500,700\" rel=\"stylesheet\">\n\n    <title>Corporate Classifieds</title>\n\n    <!-- Bootstrap core CSS -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "86f288f7cddfb9b868ebd46c3e8e3c54eca3af8210117", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n\n\n    <!-- Additional CSS Files -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "86f288f7cddfb9b868ebd46c3e8e3c54eca3af8211336", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "86f288f7cddfb9b868ebd46c3e8e3c54eca3af8212514", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f288f7cddfb9b868ebd46c3e8e3c54eca3af8214400", async() => {
                WriteLiteral(@"

    <!-- Wrapper -->
    <div id=""wrapper"">

        <!-- Main -->
        <div id=""main"">
            <div class=""inner"">

                <!-- Header -->
                <header id=""header"">
                    <div class=""logo"">
                        <a href=""index.html"">Corporate Classifieds</a>
                    </div>
                </header>

                <!-- Banner -->
                <!-- Search Box -->


                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f288f7cddfb9b868ebd46c3e8e3c54eca3af8215113", async() => {
                    WriteLiteral(@"

                    <h4>Get Top 3 Most Liked Offer Details by Category:</h4>

                    <div class=""input-group"">

                        <input type=""text"" class=""form-control rounded"" placeholder=""Enter Offer Category..."" name=""category"" aria-label=""Search"" aria-describedby=""search-addon"" required/>
                        <button type=""submit"" class=""btn btn-outline-primary"">search</button>
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n\n            </div>\n        </div>\n\n        <!-- Sidebar -->\n        <div id=\"sidebar\">\n\n            <div class=\"inner\">\n\n                <!-- Menu -->\n                <nav id=\"menu\">\n                    <ul>\n                        <li><a");
                BeginWriteAttribute("href", " href=\"", 2269, "\"", 2312, 1);
#nullable restore
#line 84 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetTopThreeLikes.cshtml"
WriteAttributeValue("", 2276, Url.Action("GetOffersList", "Home"), 2276, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Home</a></li>\n                        <li>\n                            <span class=\"opener\">Offers</span>\n                            <ul>\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 2491, "\"", 2527, 1);
#nullable restore
#line 88 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetTopThreeLikes.cshtml"
WriteAttributeValue("", 2498, Url.Action("GetId", "Offer"), 2498, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Offer Details by Id</a></li>\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 2596, "\"", 2638, 1);
#nullable restore
#line 89 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetTopThreeLikes.cshtml"
WriteAttributeValue("", 2603, Url.Action("GetCategory", "Offer"), 2603, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Offer Details by Category</a></li>\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 2713, "\"", 2760, 1);
#nullable restore
#line 90 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetTopThreeLikes.cshtml"
WriteAttributeValue("", 2720, Url.Action("GetTopThreeLikes", "Offer"), 2720, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Offer by Top 3 Likes</a></li>\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 2830, "\"", 2876, 1);
#nullable restore
#line 91 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetTopThreeLikes.cshtml"
WriteAttributeValue("", 2837, Url.Action("GetByOpenedDate", "Offer"), 2837, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Offer by Posted Date</a></li>\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 2946, "\"", 2988, 1);
#nullable restore
#line 92 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetTopThreeLikes.cshtml"
WriteAttributeValue("", 2953, Url.Action("EngageOffer", "Offer"), 2953, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Engage Offer </a></li>\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 3051, "\"", 3099, 1);
#nullable restore
#line 93 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetTopThreeLikes.cshtml"
WriteAttributeValue("", 3058, Url.Action("GetIdForEditOffer", "Offer"), 3058, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Edit Offer</a></li>\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 3159, "\"", 3199, 1);
#nullable restore
#line 94 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetTopThreeLikes.cshtml"
WriteAttributeValue("", 3166, Url.Action("PostOffer", "Offer"), 3166, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Add Offer</a></li>\n                            </ul>\n                        </li>\n                        <li>\n                            <span class=\"opener\">Employee</span>\n                            <ul>\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 3449, "\"", 3501, 1);
#nullable restore
#line 100 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetTopThreeLikes.cshtml"
WriteAttributeValue("", 3456, Url.Action("ViewEmployeeOffers", "Employee"), 3456, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">View Employee Offers</a></li>\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 3571, "\"", 3624, 1);
#nullable restore
#line 101 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetTopThreeLikes.cshtml"
WriteAttributeValue("", 3578, Url.Action("ViewMostLikedOffers", "Employee"), 3578, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">View Most Liked Offers</a></li>\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 3696, "\"", 3749, 1);
#nullable restore
#line 102 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetTopThreeLikes.cshtml"
WriteAttributeValue("", 3703, Url.Action("ViewEmployeeProfile", "Employee"), 3703, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">View Profile</a></li>\n                            </ul>\n                        </li>\n                        <li>\n                            <span class=\"opener\">Points</span>\n                            <ul>\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 4000, "\"", 4053, 1);
#nullable restore
#line 108 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetTopThreeLikes.cshtml"
WriteAttributeValue("", 4007, Url.Action("GetPointsByEmployeeId", "Points"), 4007, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Get Points of Employee</a></li>\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 4125, "\"", 4180, 1);
#nullable restore
#line 109 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetTopThreeLikes.cshtml"
WriteAttributeValue("", 4132, Url.Action("RefreshPointsByEmployee", "Points"), 4132, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Refresh Points of Employee</a></li>
                            </ul>
                        </li>
                        <li><a href=""#"">Logout</a></li>
                    </ul>
                </nav>


            </div>
        </div>

    </div>

    <!-- Scripts -->
    <!-- Bootstrap core JavaScript -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f288f7cddfb9b868ebd46c3e8e3c54eca3af8225809", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f288f7cddfb9b868ebd46c3e8e3c54eca3af8226907", async() => {
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
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f288f7cddfb9b868ebd46c3e8e3c54eca3af8228007", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f288f7cddfb9b868ebd46c3e8e3c54eca3af8229105", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f288f7cddfb9b868ebd46c3e8e3c54eca3af8230203", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f288f7cddfb9b868ebd46c3e8e3c54eca3af8231302", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86f288f7cddfb9b868ebd46c3e8e3c54eca3af8232401", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n\n</html>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
