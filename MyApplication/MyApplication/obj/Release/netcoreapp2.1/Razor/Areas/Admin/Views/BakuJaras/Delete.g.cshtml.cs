#pragma checksum "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82700b56718016ba10104d9f85a254e53b5ca0e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BakuJaras_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/BakuJaras/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/BakuJaras/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_BakuJaras_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82700b56718016ba10104d9f85a254e53b5ca0e3", @"/Areas/Admin/Views/BakuJaras/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2120c96a385f5d4cca84fc368fa2fffbd127b30d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_BakuJaras_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyApplication.Models.BakuJara>
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>BakuJara</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(311, 45, false);
#line 16 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(356, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(400, 41, false);
#line 19 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(441, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(485, 45, false);
#line 22 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageText));

#line default
#line hidden
            EndContext();
            BeginContext(530, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(574, 41, false);
#line 25 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ImageText));

#line default
#line hidden
            EndContext();
            BeginContext(615, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(659, 41, false);
#line 28 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(700, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(744, 37, false);
#line 31 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(781, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(825, 44, false);
#line 34 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubTitle));

#line default
#line hidden
            EndContext();
            BeginContext(869, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(913, 40, false);
#line 37 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubTitle));

#line default
#line hidden
            EndContext();
            BeginContext(953, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(997, 44, false);
#line 40 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1085, 40, false);
#line 43 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1169, 40, false);
#line 46 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1253, 36, false);
#line 49 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1333, 41, false);
#line 52 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1418, 37, false);
#line 55 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1455, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1499, 49, false);
#line 58 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AboutTourText));

#line default
#line hidden
            EndContext();
            BeginContext(1548, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1592, 45, false);
#line 61 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AboutTourText));

#line default
#line hidden
            EndContext();
            BeginContext(1637, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1681, 51, false);
#line 64 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AboutTourNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1732, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1776, 47, false);
#line 67 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AboutTourNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1823, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1867, 45, false);
#line 70 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourImage));

#line default
#line hidden
            EndContext();
            BeginContext(1912, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1956, 41, false);
#line 73 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourImage));

#line default
#line hidden
            EndContext();
            BeginContext(1997, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2041, 44, false);
#line 76 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourName));

#line default
#line hidden
            EndContext();
            BeginContext(2085, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2129, 40, false);
#line 79 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourName));

#line default
#line hidden
            EndContext();
            BeginContext(2169, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2213, 51, false);
#line 82 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourInformation));

#line default
#line hidden
            EndContext();
            BeginContext(2264, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2308, 47, false);
#line 85 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourInformation));

#line default
#line hidden
            EndContext();
            BeginContext(2355, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2399, 45, false);
#line 88 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourVideo));

#line default
#line hidden
            EndContext();
            BeginContext(2444, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2488, 41, false);
#line 91 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourVideo));

#line default
#line hidden
            EndContext();
            BeginContext(2529, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2573, 47, false);
#line 94 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourCheckIn));

#line default
#line hidden
            EndContext();
            BeginContext(2620, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2664, 43, false);
#line 97 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourCheckIn));

#line default
#line hidden
            EndContext();
            BeginContext(2707, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2751, 44, false);
#line 100 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourText));

#line default
#line hidden
            EndContext();
            BeginContext(2795, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2839, 40, false);
#line 103 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourText));

#line default
#line hidden
            EndContext();
            BeginContext(2879, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2923, 44, false);
#line 106 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourTime));

#line default
#line hidden
            EndContext();
            BeginContext(2967, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3011, 40, false);
#line 109 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourTime));

#line default
#line hidden
            EndContext();
            BeginContext(3051, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3095, 50, false);
#line 112 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourAdditional));

#line default
#line hidden
            EndContext();
            BeginContext(3145, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3189, 46, false);
#line 115 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourAdditional));

#line default
#line hidden
            EndContext();
            BeginContext(3235, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3279, 56, false);
#line 118 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TourSecondAdditional));

#line default
#line hidden
            EndContext();
            BeginContext(3335, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3379, 52, false);
#line 121 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TourSecondAdditional));

#line default
#line hidden
            EndContext();
            BeginContext(3431, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3475, 42, false);
#line 124 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(3517, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3561, 38, false);
#line 127 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(3599, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3643, 48, false);
#line 130 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SecondNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3691, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3735, 44, false);
#line 133 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SecondNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3779, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3823, 41, false);
#line 136 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3864, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3908, 37, false);
#line 139 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3945, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3989, 47, false);
#line 142 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SiteAddress));

#line default
#line hidden
            EndContext();
            BeginContext(4036, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4080, 43, false);
#line 145 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SiteAddress));

#line default
#line hidden
            EndContext();
            BeginContext(4123, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4167, 43, false);
#line 148 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(4210, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4254, 39, false);
#line 151 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(4293, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4337, 41, false);
#line 154 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Event));

#line default
#line hidden
            EndContext();
            BeginContext(4378, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4422, 40, false);
#line 157 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Event.Id));

#line default
#line hidden
            EndContext();
            BeginContext(4462, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(4500, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fc740a115e14da4936a8e6e04d0975a", async() => {
                BeginContext(4526, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4536, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cfadb073ba694a1a8df25b84ec9d8a86", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 162 "C:\Users\User\source\repos\MyApplication\MyApplication\Areas\Admin\Views\BakuJaras\Delete.cshtml"
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
                BeginContext(4572, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(4656, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41a98ecf94254634b89d3a48ead7771b", async() => {
                    BeginContext(4678, 12, true);
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
                BeginContext(4694, 6, true);
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
            BeginContext(4707, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApplication.Models.BakuJara> Html { get; private set; }
    }
}
#pragma warning restore 1591
