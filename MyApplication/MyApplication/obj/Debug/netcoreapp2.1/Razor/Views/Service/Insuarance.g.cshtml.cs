#pragma checksum "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98ef63cad1fe17d873d01e227e02998dbf75cd66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Insuarance), @"mvc.1.0.view", @"/Views/Service/Insuarance.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Service/Insuarance.cshtml", typeof(AspNetCore.Views_Service_Insuarance))]
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
#line 1 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\_ViewImports.cshtml"
using MyApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98ef63cad1fe17d873d01e227e02998dbf75cd66", @"/Views/Service/Insuarance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2120c96a385f5d4cca84fc368fa2fffbd127b30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Insuarance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyApplication.Models.ViewModels.InsuaranceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sendmessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(115, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(144, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "667ff379f77548c6a49d452751840969", async() => {
                BeginContext(150, 92, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Insuarance</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(249, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(251, 7154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c349fec7067642b9bed5b4b94a19dbc2", async() => {
                BeginContext(257, 606, true);
                WriteLiteral(@"
    <nav>


        <div class=""container"">



            <div class=""navbar"">


                <a href=""#"" id=""menu-icon""> <i class=""fas fa-bars""></i> </a>

                <a href=""/About""> Haqqımızda </a>


                <a href=""/Azerbaijan""> Azərbaycan </a>

                <a href=""/Service""> Xidmətlər </a>

                <a href=""/Event""> Coming Events </a>

                <a href=""/OnlinePayment""> Online Odəniş </a>

                <a href=""/Contact"">
                    Əlaqə
                </a>

                <li class=""sign"">
                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=", 863, "", 894, 1);
#line 42 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
WriteAttributeValue("", 869, ViewBag.Setting.Facebook, 869, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(894, 136, true);
                WriteLiteral(">\r\n                        <i class=\"fab fa-facebook\">\r\n\r\n                        </i>\r\n                    </a>\r\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1030, "\"", 1063, 1);
#line 47 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
WriteAttributeValue("", 1037, ViewBag.Setting.Instagram, 1037, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1064, 264, true);
                WriteLiteral(@">
                        <i class=""fab fa-instagram""></i>
                    </a>
                    </a>
                </li>

            </div>
        </div>


    </nav>

    <section id=""main"">

        <div class=""col-sm-12"">
            ");
                EndContext();
                BeginContext(1328, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "626c001f5c3b48ed969f53d59cb89329", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1338, "~/images/", 1338, 9, true);
#line 62 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
AddHtmlAttributeValue("", 1347, Model.Insuarance.ImagePath, 1347, 27, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1376, 34, true);
                WriteLiteral("\r\n            <div class=\"title\"> ");
                EndContext();
                BeginContext(1411, 27, false);
#line 63 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
                           Write(Model.Insuarance.ImageTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1438, 285, true);
                WriteLiteral(@" </div>
        </div>
    </section>

    <main>
        <section id=""subMain"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""proposalTitle"">
                            ");
                EndContext();
                BeginContext(1724, 22, false);
#line 73 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
                       Write(Model.Insuarance.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1746, 118, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"proposalSubTitle\">\r\n                            ");
                EndContext();
                BeginContext(1865, 25, false);
#line 76 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
                       Write(Model.Insuarance.SubTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1890, 242, true);
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n                        <div class=\"textA\">\r\n                            <p>");
                EndContext();
                BeginContext(2133, 21, false);
#line 83 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
                          Write(Model.Insuarance.Text);

#line default
#line hidden
                EndContext();
                BeginContext(2154, 48, true);
                WriteLiteral("</p> <br> <br>\r\n                            <p> ");
                EndContext();
                BeginContext(2203, 24, false);
#line 84 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
                           Write(Model.Insuarance.SubText);

#line default
#line hidden
                EndContext();
                BeginContext(2227, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 85 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
                             foreach (var item in Model.InsuaranceDescriptions)
                            {

#line default
#line hidden
                BeginContext(2345, 36, true);
                WriteLiteral("                                <p> ");
                EndContext();
                BeginContext(2382, 20, false);
#line 87 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
                               Write(item.AboutInsuarance);

#line default
#line hidden
                EndContext();
                BeginContext(2402, 7, true);
                WriteLiteral(" </p>\r\n");
                EndContext();
#line 88 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
                            }

#line default
#line hidden
                BeginContext(2440, 175, true);
                WriteLiteral("\r\n                            <p> -------------- </p> <br>\r\n                            <p> ƏLAQƏ ÜÇÜN: </p>\r\n                            <p>\r\n                                ");
                EndContext();
                BeginContext(2616, 22, false);
#line 93 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
                           Write(Model.Insuarance.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(2638, 72, true);
                WriteLiteral("\r\n                                <br>\r\n                                ");
                EndContext();
                BeginContext(2711, 27, false);
#line 95 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
                           Write(Model.Insuarance.OtherPhone);

#line default
#line hidden
                EndContext();
                BeginContext(2738, 79, true);
                WriteLiteral("\r\n                                <br>\r\n                                Email: ");
                EndContext();
                BeginContext(2818, 22, false);
#line 97 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
                                  Write(Model.Insuarance.Email);

#line default
#line hidden
                EndContext();
                BeginContext(2840, 72, true);
                WriteLiteral("\r\n                                <br>\r\n                                ");
                EndContext();
                BeginContext(2913, 27, false);
#line 99 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
                           Write(Model.Insuarance.OtherPhone);

#line default
#line hidden
                EndContext();
                BeginContext(2940, 72, true);
                WriteLiteral("\r\n                                <br>\r\n                                ");
                EndContext();
                BeginContext(3013, 24, false);
#line 101 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
                           Write(Model.Insuarance.Address);

#line default
#line hidden
                EndContext();
                BeginContext(3037, 251, true);
                WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </main>\r\n    <section id=\"contacts\">\r\n\r\n        <div class=\"container\">\r\n\r\n            ");
                EndContext();
                BeginContext(3288, 2109, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71304999302c4b2d91554402e241a0a6", async() => {
                    BeginContext(3327, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(3346, 23, false);
#line 114 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Service\Insuarance.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                    EndContext();
                    BeginContext(3369, 2021, true);
                    WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""titleWrite"">

                            BİZƏ YAZIN

                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-md-4"">

                        <label for=""lname""> Ad </label>
                        <input type=""text"" name=""lname"" id=""name"" placeholder=""Adınızı daxil edin"">
                    </div>
                    <div class=""col-md-4"">

                        <label for=""lsurname""> Soyad </label>
                        <input type=""text"" name=""lsurname"" id=""surname"" placeholder=""Soyadınızı daxil edin"">
                    </div>
                    <div class=""col-md-4"">

                        <label for=""lsurname""> Email </label>
                        <input type=""text"" name=""email"" id=""email"" placeholder=""Email ünvanınızı daxil edin"">
                    </div>
");
                    WriteLiteral(@"                </div>

                <div class=""row"">


                    <div class=""col-md-4"">
                        <label for=""number""> Mobil Nömrəniz </label>
                        <input type=""number"" id=""number"" name=""number"" pattern=""[0-9]{3}-[2-9]{3}-[0-9]{2}-[0-9]{2}"" placeholder=""Mobil nömrənizi daxil edin"">
                    </div>

                    <div class=""col-md-8"">
                        <label for=""text""> Mesajınız</label>
                        <textarea name=""text"" id=""message"" placeholder=""Mesajınızı daxil edin""></textarea>
                    </div>

                </div>

                <div class=""row"">
                    <div class=""col-md-12"">

                        <div class=""submitBtn"">
                            <input type=""submit"" class=""button"" id=""button"" value=""Məktubu göndərin"" data-loading=""YÜklənir"">

                        </div>
                    </div>

                </div>
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5397, 38, true);
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </section>\r\n");
                EndContext();
                DefineSection("script", async() => {
                    BeginContext(5456, 1935, true);
                    WriteLiteral(@"
        <script>
            $(document).ready(function () {
                $.ajax({
                    url: ""/Home/Footer"",
                    method: ""get"",
                    success: function (re) {

                        $("".same"").append(re.addreses);
                        $("".sameTwo"").append(re.faxes);
                        $("".sameThree"").append(re.numbers);
                        $("".sameFour"").append(re.mails);
                        $("".sameFive"").append(re.siteadress);
                        $(""#titleee"").append(re.title);
                        $("".longText"").append(re.desciption);
                    }
                })
                $(""#button"").click(function () {
                    let name = $(""#name"").val();
                    let surname = $(""#surname"").val();
                    let email = $(""#email"").val();
                    let phone = $(""#number"").val();
                    let message = $(""#message"").val();
                    let __Reque");
                    WriteLiteral(@"stVerificationToken = $(""input[name='__RequestVerificationToken']"").val();
                    $.ajax({
                        url: ""/Service/Insuarance"",
                        data: {
                            Name: name,
                            Surname: surname,
                            Email: email,
                            Number: phone,
                            Messaging: message,
                            __RequestVerificationToken: __RequestVerificationToken
                        },
                        method: ""post"",
                        success: function (re) {

                            alert('Message sent');
                        },
                        error: function (re) {
                            alert('Error');
                        }
                    })
                })
            });

        </script>
        ");
                    EndContext();
                }
                );
                BeginContext(7394, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7405, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApplication.Models.ViewModels.InsuaranceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
