#pragma checksum "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed654314669909d9eae06d30623afd82e3563f5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offer_GetOfferById), @"mvc.1.0.view", @"/Views/Offer/GetOfferById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed654314669909d9eae06d30623afd82e3563f5f", @"/Views/Offer/GetOfferById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d194b80d01703f30b4bce0794a06429426d1b9ba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Offer_GetOfferById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CLassifiedsUIPortal.Models.OfferData>
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
#line 3 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
  
    ViewData["Title"] = "GetOfferById";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed654314669909d9eae06d30623afd82e3563f5f6807", async() => {
                WriteLiteral("\n\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 278, "\"", 288, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 314, "\"", 324, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <link href=\"https://fonts.googleapis.com/css?family=Roboto:100,300,400,500,700\" rel=\"stylesheet\">\n\n    <title>Corporate Classifieds</title>\n\n    <!-- Bootstrap core CSS -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ed654314669909d9eae06d30623afd82e3563f5f7754", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ed654314669909d9eae06d30623afd82e3563f5f8972", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ed654314669909d9eae06d30623afd82e3563f5f10149", async() => {
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
                WriteLiteral("\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed654314669909d9eae06d30623afd82e3563f5f12029", async() => {
                WriteLiteral(@"

    <!-- Wrapper -->
    <div id=""wrapper"">

        <!-- Main -->
        <div id=""main"">
            <div class=""inner"">
                <header id=""header"">
                    <div class=""logo"">
                        <a href=""index.html"">Corporate Classifieds</a>
                    </div>
                </header>
                <div>
                    <h4>Offer Details</h4>
                    <hr />
                    <dl class=""row"">
                        <dt class=""col-sm-2"">
                            ");
#nullable restore
#line 46 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayNameFor(model => model.OfferId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dt>\n                        <dd class=\"col-sm-10\">\n                            ");
#nullable restore
#line 49 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayFor(model => model.OfferId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-2\">\n                            ");
#nullable restore
#line 52 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayNameFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dt>\n                        <dd class=\"col-sm-10\">\n                            ");
#nullable restore
#line 55 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-2\">\n                            ");
#nullable restore
#line 58 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dt>\n                        <dd class=\"col-sm-10\">\n                            ");
#nullable restore
#line 61 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-2\">\n                            ");
#nullable restore
#line 64 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayNameFor(model => model.Likes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dt>\n                        <dd class=\"col-sm-10\">\n                            ");
#nullable restore
#line 67 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayFor(model => model.Likes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-2\">\n                            ");
#nullable restore
#line 70 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dt>\n                        <dd class=\"col-sm-10\">\n                            ");
#nullable restore
#line 73 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-2\">\n                            ");
#nullable restore
#line 76 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayNameFor(model => model.Details));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dt>\n                        <dd class=\"col-sm-10\">\n                            ");
#nullable restore
#line 79 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayFor(model => model.Details));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-2\">\n                            ");
#nullable restore
#line 82 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayNameFor(model => model.OpenedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dt>\n                        <dd class=\"col-sm-10\">\n                            ");
#nullable restore
#line 85 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayFor(model => model.OpenedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-2\">\n                            ");
#nullable restore
#line 88 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayNameFor(model => model.EngagedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dt>\n                        <dd class=\"col-sm-10\">\n                            ");
#nullable restore
#line 91 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayFor(model => model.EngagedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                        <dt class=\"col-sm-2\">\n                            ");
#nullable restore
#line 94 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayNameFor(model => model.ClosedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dt>\n                        <dd class=\"col-sm-10\">\n                            ");
#nullable restore
#line 97 "C:\Users\Hrushi\Desktop\Cognizant Doc\CorporateClassifieds-main\Mfrp_CorporateClassifieds-Initial\CorporateClassifieds\CLassifiedsUIPortal\CLassifiedsUIPortal\Views\Offer\GetOfferById.cshtml"
                       Write(Html.DisplayFor(model => model.ClosedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </dd>\n                    </dl>\n                </div>\n                <div>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed654314669909d9eae06d30623afd82e3563f5f21715", async() => {
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
                WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n");
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CLassifiedsUIPortal.Models.OfferData> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591