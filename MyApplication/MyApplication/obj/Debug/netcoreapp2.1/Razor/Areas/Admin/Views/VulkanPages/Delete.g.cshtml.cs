#pragma checksum "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38acfc0902ac261002476ea6e6fa5fbe7d387c40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_VulkanPages_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/VulkanPages/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/VulkanPages/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_VulkanPages_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38acfc0902ac261002476ea6e6fa5fbe7d387c40", @"/Areas/Admin/Views/VulkanPages/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2120c96a385f5d4cca84fc368fa2fffbd127b30d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_VulkanPages_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyApplication.Models.VulkanPage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 171, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>VulkanPage</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(315, 52, false);
#line 16 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SecondAdditional));

#line default
#line hidden
            EndContext();
            BeginContext(367, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(411, 48, false);
#line 19 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SecondAdditional));

#line default
#line hidden
            EndContext();
            BeginContext(459, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(503, 45, false);
#line 22 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(548, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(592, 41, false);
#line 25 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(633, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(677, 45, false);
#line 28 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageText));

#line default
#line hidden
            EndContext();
            BeginContext(722, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(766, 41, false);
#line 31 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ImageText));

#line default
#line hidden
            EndContext();
            BeginContext(807, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(851, 41, false);
#line 34 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(892, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(936, 37, false);
#line 37 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(973, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1017, 44, false);
#line 40 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1105, 40, false);
#line 43 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1189, 44, false);
#line 46 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1277, 40, false);
#line 49 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(1317, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1361, 40, false);
#line 52 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1445, 36, false);
#line 55 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1525, 41, false);
#line 58 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1610, 37, false);
#line 61 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1691, 49, false);
#line 64 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AboutTourText));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1784, 45, false);
#line 67 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AboutTourText));

#line default
#line hidden
            EndContext();
            BeginContext(1829, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1873, 51, false);
#line 70 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AboutTourNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1924, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1968, 47, false);
#line 73 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AboutTourNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2015, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2059, 45, false);
#line 76 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourImage));

#line default
#line hidden
            EndContext();
            BeginContext(2104, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2148, 41, false);
#line 79 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourImage));

#line default
#line hidden
            EndContext();
            BeginContext(2189, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2233, 44, false);
#line 82 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourName));

#line default
#line hidden
            EndContext();
            BeginContext(2277, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2321, 40, false);
#line 85 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourName));

#line default
#line hidden
            EndContext();
            BeginContext(2361, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2405, 51, false);
#line 88 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourInformation));

#line default
#line hidden
            EndContext();
            BeginContext(2456, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2500, 47, false);
#line 91 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourInformation));

#line default
#line hidden
            EndContext();
            BeginContext(2547, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2591, 45, false);
#line 94 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourVideo));

#line default
#line hidden
            EndContext();
            BeginContext(2636, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2680, 41, false);
#line 97 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourVideo));

#line default
#line hidden
            EndContext();
            BeginContext(2721, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2765, 47, false);
#line 100 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourCheckIn));

#line default
#line hidden
            EndContext();
            BeginContext(2812, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2856, 43, false);
#line 103 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourCheckIn));

#line default
#line hidden
            EndContext();
            BeginContext(2899, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2943, 44, false);
#line 106 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourText));

#line default
#line hidden
            EndContext();
            BeginContext(2987, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3031, 40, false);
#line 109 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourText));

#line default
#line hidden
            EndContext();
            BeginContext(3071, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3115, 44, false);
#line 112 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourTime));

#line default
#line hidden
            EndContext();
            BeginContext(3159, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3203, 40, false);
#line 115 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourTime));

#line default
#line hidden
            EndContext();
            BeginContext(3243, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3287, 50, false);
#line 118 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourAdditional));

#line default
#line hidden
            EndContext();
            BeginContext(3337, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3381, 46, false);
#line 121 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourAdditional));

#line default
#line hidden
            EndContext();
            BeginContext(3427, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3471, 42, false);
#line 124 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(3513, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3557, 38, false);
#line 127 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(3595, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3639, 48, false);
#line 130 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SecondNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3687, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3731, 44, false);
#line 133 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SecondNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3775, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3819, 41, false);
#line 136 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3860, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3904, 37, false);
#line 139 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3941, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3985, 47, false);
#line 142 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SiteAddress));

#line default
#line hidden
            EndContext();
            BeginContext(4032, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4076, 43, false);
#line 145 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SiteAddress));

#line default
#line hidden
            EndContext();
            BeginContext(4119, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4163, 43, false);
#line 148 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(4206, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4250, 39, false);
#line 151 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(4289, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(4327, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99415801f8b34b508e806b2403b3a512", async() => {
                BeginContext(4353, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4363, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e59443d87dfd401d92cf93be1cee8b36", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 156 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\VulkanPages\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4399, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(4483, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "500bfcec7ab04bbfbdc94feebe39d09d", async() => {
                    BeginContext(4505, 12, true);
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
                BeginContext(4521, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4534, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApplication.Models.VulkanPage> Html { get; private set; }
    }
}
#pragma warning restore 1591
