#pragma checksum "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2002aa6fc1fce8a6b9801ad6f60e3ecc9bce16d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BilgehPages_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/BilgehPages/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/BilgehPages/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_BilgehPages_Details))]
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
#line 1 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\_ViewImports.cshtml"
using MyApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2002aa6fc1fce8a6b9801ad6f60e3ecc9bce16d", @"/Areas/Admin/Views/BilgehPages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2120c96a385f5d4cca84fc368fa2fffbd127b30d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_BilgehPages_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyApplication.Models.BilgehPage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>BilgehPage</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(269, 45, false);
#line 15 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(314, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(358, 41, false);
#line 18 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(399, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(443, 45, false);
#line 21 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageText));

#line default
#line hidden
            EndContext();
            BeginContext(488, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(532, 41, false);
#line 24 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.ImageText));

#line default
#line hidden
            EndContext();
            BeginContext(573, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(617, 41, false);
#line 27 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(658, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(702, 37, false);
#line 30 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(739, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(783, 44, false);
#line 33 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubTitle));

#line default
#line hidden
            EndContext();
            BeginContext(827, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(871, 40, false);
#line 36 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubTitle));

#line default
#line hidden
            EndContext();
            BeginContext(911, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(955, 44, false);
#line 39 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(999, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1043, 40, false);
#line 42 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1127, 40, false);
#line 45 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1211, 36, false);
#line 48 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1291, 41, false);
#line 51 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1376, 37, false);
#line 54 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1413, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1457, 49, false);
#line 57 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AboutTourText));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1550, 45, false);
#line 60 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.AboutTourText));

#line default
#line hidden
            EndContext();
            BeginContext(1595, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1639, 51, false);
#line 63 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AboutTourNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1690, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1734, 47, false);
#line 66 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.AboutTourNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1825, 45, false);
#line 69 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TourImage));

#line default
#line hidden
            EndContext();
            BeginContext(1870, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1914, 41, false);
#line 72 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.TourImage));

#line default
#line hidden
            EndContext();
            BeginContext(1955, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1999, 44, false);
#line 75 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TourName));

#line default
#line hidden
            EndContext();
            BeginContext(2043, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2087, 40, false);
#line 78 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.TourName));

#line default
#line hidden
            EndContext();
            BeginContext(2127, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2171, 51, false);
#line 81 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TourInformation));

#line default
#line hidden
            EndContext();
            BeginContext(2222, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2266, 47, false);
#line 84 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.TourInformation));

#line default
#line hidden
            EndContext();
            BeginContext(2313, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2357, 45, false);
#line 87 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TourVideo));

#line default
#line hidden
            EndContext();
            BeginContext(2402, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2446, 41, false);
#line 90 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.TourVideo));

#line default
#line hidden
            EndContext();
            BeginContext(2487, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2531, 47, false);
#line 93 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TourCheckIn));

#line default
#line hidden
            EndContext();
            BeginContext(2578, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2622, 43, false);
#line 96 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.TourCheckIn));

#line default
#line hidden
            EndContext();
            BeginContext(2665, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2709, 44, false);
#line 99 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TourText));

#line default
#line hidden
            EndContext();
            BeginContext(2753, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2797, 40, false);
#line 102 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.TourText));

#line default
#line hidden
            EndContext();
            BeginContext(2837, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2881, 44, false);
#line 105 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TourTime));

#line default
#line hidden
            EndContext();
            BeginContext(2925, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2969, 40, false);
#line 108 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.TourTime));

#line default
#line hidden
            EndContext();
            BeginContext(3009, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3053, 50, false);
#line 111 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TourAdditional));

#line default
#line hidden
            EndContext();
            BeginContext(3103, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3147, 46, false);
#line 114 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.TourAdditional));

#line default
#line hidden
            EndContext();
            BeginContext(3193, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3237, 56, false);
#line 117 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TourAdditionalSecond));

#line default
#line hidden
            EndContext();
            BeginContext(3293, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3337, 52, false);
#line 120 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.TourAdditionalSecond));

#line default
#line hidden
            EndContext();
            BeginContext(3389, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3433, 42, false);
#line 123 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(3475, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3519, 38, false);
#line 126 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(3557, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3601, 48, false);
#line 129 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SecondNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3649, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3693, 44, false);
#line 132 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.SecondNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3737, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3781, 41, false);
#line 135 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3822, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3866, 37, false);
#line 138 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3903, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3947, 47, false);
#line 141 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SiteAddress));

#line default
#line hidden
            EndContext();
            BeginContext(3994, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4038, 43, false);
#line 144 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.SiteAddress));

#line default
#line hidden
            EndContext();
            BeginContext(4081, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4125, 43, false);
#line 147 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(4168, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4212, 39, false);
#line 150 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(4251, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(4298, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbfc6ce83a834a14bbe2cc5b1818e1eb", async() => {
                BeginContext(4344, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 155 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BilgehPages\Details.cshtml"
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
            BeginContext(4352, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(4360, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d574c9ca67843548b3d9419a7421cac", async() => {
                BeginContext(4382, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4398, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApplication.Models.BilgehPage> Html { get; private set; }
    }
}
#pragma warning restore 1591
