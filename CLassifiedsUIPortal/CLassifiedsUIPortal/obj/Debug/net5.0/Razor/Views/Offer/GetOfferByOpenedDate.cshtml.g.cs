#pragma checksum "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "505ff3d160e2eb4cbc8bb7fbd67e056780a5e21e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offer_GetOfferByOpenedDate), @"mvc.1.0.view", @"/Views/Offer/GetOfferByOpenedDate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"505ff3d160e2eb4cbc8bb7fbd67e056780a5e21e", @"/Views/Offer/GetOfferByOpenedDate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d194b80d01703f30b4bce0794a06429426d1b9ba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Offer_GetOfferByOpenedDate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CLassifiedsUIPortal.Models.OfferData>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/flex-slider.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/templatemo-style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("is-preload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
  
    ViewData["Title"] = "GetOfferByOpenedDate";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "505ff3d160e2eb4cbc8bb7fbd67e056780a5e21e6876", async() => {
                WriteLiteral("\n\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 299, "\"", 309, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 335, "\"", 345, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <link href=\"https://fonts.googleapis.com/css?family=Roboto:100,300,400,500,700\" rel=\"stylesheet\">\n\n    <title>Corporate Classifieds</title>\n\n    <!-- Bootstrap core CSS -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "505ff3d160e2eb4cbc8bb7fbd67e056780a5e21e7823", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "505ff3d160e2eb4cbc8bb7fbd67e056780a5e21e9041", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "505ff3d160e2eb4cbc8bb7fbd67e056780a5e21e10218", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "505ff3d160e2eb4cbc8bb7fbd67e056780a5e21e12104", async() => {
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

                <h1>Get Offer By Posted Date</h1>
                <br/>
                <br/>
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>
                                ");
#nullable restore
#line 54 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                           Write(Html.DisplayNameFor(model => model.OfferId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </th>\n                            <th>\n                                ");
#nullable restore
#line 57 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                           Write(Html.DisplayNameFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </th>\n                            <th>\n                                ");
#nullable restore
#line 60 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </th>\n                            <th>\n                                ");
#nullable restore
#line 63 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                           Write(Html.DisplayNameFor(model => model.Likes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </th>\n                            <th>\n                                ");
#nullable restore
#line 66 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </th>\n                            <th>\n                                ");
#nullable restore
#line 69 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                           Write(Html.DisplayNameFor(model => model.Details));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </th>\n                            <th>\n                                ");
#nullable restore
#line 72 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                           Write(Html.DisplayNameFor(model => model.OpenedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </th>\n                            <th>\n                                ");
#nullable restore
#line 75 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                           Write(Html.DisplayNameFor(model => model.EngagedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </th>\n                            <th>\n                                ");
#nullable restore
#line 78 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                           Write(Html.DisplayNameFor(model => model.ClosedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            </th>\n                            <th></th>\n                        </tr>\n                    </thead>\n                    <tbody>\n");
#nullable restore
#line 84 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\n                                <td>\n                                    ");
#nullable restore
#line 88 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                               Write(Html.DisplayFor(modelItem => item.OfferId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 91 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                               Write(Html.DisplayFor(modelItem => item.EmployeeId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 94 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 97 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Likes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 100 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 103 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Details));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 106 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                               Write(Html.DisplayFor(modelItem => item.OpenedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 109 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                               Write(Html.DisplayFor(modelItem => item.EngagedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 112 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ClosedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </td>\n\n                            </tr>\n");
#nullable restore
#line 116 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferByOpenedDate.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </tbody>\n\n                </table>\n                <br/>\n                <br/>\n                <div>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "505ff3d160e2eb4cbc8bb7fbd67e056780a5e21e23132", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n            </div>\n        </div>\n</div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n   \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CLassifiedsUIPortal.Models.OfferData>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
