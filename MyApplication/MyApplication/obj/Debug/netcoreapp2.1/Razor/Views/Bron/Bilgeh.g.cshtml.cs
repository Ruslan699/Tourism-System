#pragma checksum "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2daa331560149717e1dbecdd9537b2593266f788"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bron_Bilgeh), @"mvc.1.0.view", @"/Views/Bron/Bilgeh.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bron/Bilgeh.cshtml", typeof(AspNetCore.Views_Bron_Bilgeh))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2daa331560149717e1dbecdd9537b2593266f788", @"/Views/Bron/Bilgeh.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2120c96a385f5d4cca84fc368fa2fffbd127b30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Bron_Bilgeh : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyApplication.Models.ViewModels.BronBilgehModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(112, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(141, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "566413d923364cc0a7891a168ab7d0f3", async() => {
                BeginContext(147, 88, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Bilgeh</title>\r\n");
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
            BeginContext(242, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(244, 12051, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "098fcf72c69d40e1a63e5992cf95c61c", async() => {
                BeginContext(250, 1027, true);
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
                    <a href=""https://www.facebook.com"">
                        <i class=""fab fa-facebook""></i>
                    </a>
                    <a href=""https://www.instagram.com"">
                        <i class=""fab fa-instagram""></i>
                    </a>
                </li>

            </div>
        </div>


    </nav>


    <section id=""main"">

        <div class=""col-sm-12"">
         ");
                WriteLiteral("   ");
                EndContext();
                BeginContext(1277, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bdc0e355bd5f47329cd43343dfbbd358", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1287, "~/images/", 1287, 9, true);
#line 65 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
AddHtmlAttributeValue("", 1296, Model.BronBilgeh.ImagePath, 1296, 27, false);

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
                BeginContext(1325, 34, true);
                WriteLiteral("\r\n            <div class=\"title\"> ");
                EndContext();
                BeginContext(1360, 27, false);
#line 66 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
                           Write(Model.BronBilgeh.ImageTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1387, 741, true);
                WriteLiteral(@" </div>
        </div>
    </section>

    <main>

        <section id=""bronInfo"">
            <div class=""container"">

                <div class=""row"">
                    <div class=""col-md-8"">
                        <section class=""contacts"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""title"">
                                        Şəxsi Məlumat
                                    </div>

                                </div>

                            </div>

                            <div class=""row"">
                                <div class=""col-md-6"">
                                    ");
                EndContext();
                BeginContext(2129, 23, false);
#line 90 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
                               Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(2152, 4400, true);
                WriteLiteral(@"
                                    <label for=""lname""> Ad </label>
                                    <input type=""text"" id=""bName"" name=""lname"" placeholder=""Adınızı daxil edin"">
                                </div>
                                <div class=""col-md-6"">
                                    <label for=""lsurname""> Soyad </label>
                                    <input type=""text"" id=""bSurname"" name=""lsurname"" placeholder=""Soyadınızı daxil edin"">
                                </div>
                                <div class=""col-md-6"">
                                    <label for=""lsurname""> Email </label>
                                    <input type=""text"" id=""bEmail"" name=""email"" placeholder=""Email ünvanınızı daxil edin"">
                                </div>
                                <div class=""col-md-6"">
                                    <label for=""number""> Mobil Nömrəniz </label>
                                    <input type=""number"" id=""bNumber"" na");
                WriteLiteral(@"me=""number"" pattern=""[0-9]{3}-[2-9]{3}-[0-9]{2}-[0-9]{2}"" placeholder=""Mobil nömrənizi daxil edin"">
                                </div>

                                <div class=""col-md-6"">
                                    <label for=""test""> Passport Nömrəsi </label>
                                    <input type=""text"" id=""bPassport"" name=""passport"" placeholder=""Passport nömrənizi daxil edin"">
                                </div>

                                <div class=""col-md-6"">
                                    <label for=""test""> Doğum Tarixi </label>
                                    <input type=""date"" id=""bBirth"" name=""bdate"" placeholder=""Doğum tarixinizi daxil edin"" required>
                                </div>

                                <div class=""col-md-6"">
                                    <label for=""DateTime""> Turun Vaxtı </label>
                                    <input type=""datetime-local"" id=""datetim"">
                                </div>

 ");
                WriteLiteral(@"                               <div class=""col-md-6"">
                                    <label for=""test""> Adam Sayı </label>
                                    <div class=""row"">
                                        <div class=""col-md-4"">
                                            <label> Böyük </label>
                                            <input type=""number"" name=""big"" id=""big"" value=""1"">
                                        </div>
                                        <div class=""col-md-4"">
                                            <label> Uşaq </label>
                                            <input type=""number"" name=""child"" id=""child"" value=""0"">
                                        </div>
                                        <div class=""col-md-4"">
                                            <label> Körpə </label>
                                            <input type=""number"" name=""baby"" id=""baby"" value=""0"">
                                        </div>
   ");
                WriteLiteral(@"                                 </div>
                                </div>
                                <div class=""col-md-12"">
                                    <label for=""text"">
                                        Əlavə qeydlər
                                    </label>
                                    <textarea name=""additional"" id=""message"" placeholder=""Əlavə suallarızı bu xanada qeyd edə bilərsiniz""></textarea>
                                </div>

                                <div class=""col-md-12"">
                                    <div class=""actionsLeft"">
                                        <a href="""" id=""btnFinish"" class=""btnFinishOrder""> Turu Bron Et </a>
                                    </div>
                                </div>

                            </div>
                        </section>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""additional"">
                           ");
                WriteLiteral(@" <div class=""title"">
                                TUR HAQQINDA MƏLUMAT
                            </div>
                            <div class=""section"">
                                <div class=""name"">
                                    Oteli seç
                                </div>

");
                EndContext();
#line 165 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
                                 foreach (var item in Model.BronHotels)
                                {

#line default
#line hidden
                BeginContext(6660, 140, true);
                WriteLiteral("                                    <div class=\"value\">\r\n                                        <input type=\"radio\" name=\"tour77\" data-id=\"");
                EndContext();
                BeginContext(6801, 7, false);
#line 168 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
                                                                              Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(6808, 1, true);
                WriteLiteral("\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6809, "\"", 6828, 1);
#line 168 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
WriteAttributeValue("", 6817, item.Value, 6817, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6829, 142, true);
                WriteLiteral(" class=\"hotelPrice\" id=\"bilgeh\">\r\n                                        <label for=\"t77699\">\r\n\r\n                                            ");
                EndContext();
                BeginContext(6972, 9, false);
#line 171 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
                                       Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(6981, 66, true);
                WriteLiteral(" —\r\n                                            <span class=\"usd\">");
                EndContext();
                BeginContext(7048, 10, false);
#line 172 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
                                                         Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(7058, 104, true);
                WriteLiteral(" </span>\r\n                                        </label>\r\n                                    </div>\r\n");
                EndContext();
#line 175 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"

                                }

#line default
#line hidden
                BeginContext(7199, 242, true);
                WriteLiteral("\r\n\r\n                            </div>\r\n                            <div class=\"section\">\r\n                                <div class=\"labelFull\">\r\n                                    Tura daxildir:\r\n                                </div>\r\n\r\n");
                EndContext();
#line 185 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
                                 foreach (var item in Model.BronTitle)
                                {

#line default
#line hidden
                BeginContext(7548, 167, true);
                WriteLiteral("                                    <div class=\"valueHalf\">\r\n                                        <div class=\"icon\">\r\n                                            <i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 7715, "\"", 7745, 1);
#line 189 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
WriteAttributeValue("", 7723, item.TourIncludedIcon, 7723, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7746, 102, true);
                WriteLiteral("></i>\r\n                                        </div>\r\n                                        <span> ");
                EndContext();
                BeginContext(7849, 21, false);
#line 191 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
                                          Write(item.TourIncludedText);

#line default
#line hidden
                EndContext();
                BeginContext(7870, 54, true);
                WriteLiteral(" </span>\r\n                                    </div>\r\n");
                EndContext();
#line 193 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
                                }

#line default
#line hidden
                BeginContext(7959, 727, true);
                WriteLiteral(@"

                               
                            </div>
                            <div class=""section"">
                                <!--<div class=""valueEnd"">
                                <span class=""black"">
                                BUNDAN AŞAĞI QİYMƏT TAPMISIZ? BİZƏ BİLDİRİN BİZ DAHA SƏRFƏLİ QİYMƏT TƏQDİM EDƏK! </span>
                            </div> -->
                            </div>

                        </div>
                        <div class=""help"">
                            <div class=""title"">
                                KÖMƏK LAZIMDI?
                            </div>
                            <div class=""text"">
                                ");
                EndContext();
                BeginContext(8687, 30, false);
#line 211 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
                           Write(Model.BronBilgeh.AboutTourText);

#line default
#line hidden
                EndContext();
                BeginContext(8717, 284, true);
                WriteLiteral(@"
                            </div>
                            <div class=""links"">
                                <div class=""icon"">
                                    <i class=""fas fa-phone""></i>
                                </div>
                                <span> ");
                EndContext();
                BeginContext(9002, 32, false);
#line 217 "C:\Users\User\source\repos\MyApplication\MyApplication\Views\Bron\Bilgeh.cshtml"
                                  Write(Model.BronBilgeh.AboutTourNumber);

#line default
#line hidden
                EndContext();
                BeginContext(9034, 160, true);
                WriteLiteral(" </span>\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n\r\n        </section>\r\n");
                EndContext();
                DefineSection("script", async() => {
                    BeginContext(9219, 3066, true);
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
                    let a = 0;
                    $("".hotelPrice"").click(function () {
                       a = $(this).attr(""data-id"")
                        //console.log(a)
                    });
                    $(""#btnFinish"").click(function () {
                      ");
                    WriteLiteral(@"  let name = $(""#bName"").val();
                        let surname = $(""#bSurname"").val();
                        let email = $(""#bEmail"").val();
                        let phone = $(""#bNumber"").val();
                        let passportNumber = $(""#bPassport"").val();
                        let birth = $(""#bBirth"").val();
                        let parent = $(""#big"").val();
                        let child = $(""#child"").val();
                        let baby = $(""#baby"").val();
                        let message = $(""#message"").val();
                        let time = $(""#datetim"").val();
                        let hotel = a;
                        let __RequestVerificationToken = $(""input[name='__RequestVerificationToken']"").val();
                        $.ajax({
                            url: ""/Bron/Bilgeh"",
                            data: {
                                Name: name,
                                Surname: surname,
                                Email: ");
                    WriteLiteral(@"email,
                                Number: phone,
                                PassportNumber: passportNumber,
                                Birth: birth,
                                Parent: parent,
                                Child: child,
                                Baby: baby,
                                Message: message,
                                DateTime: time,
                                BronHotelId: hotel,
                                __RequestVerificationToken: __RequestVerificationToken
                            },
                            method: ""post"",
                            success: function (re) {

                                alert('You Bronned This Tour');
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
            BeginContext(12295, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApplication.Models.ViewModels.BronBilgehModel> Html { get; private set; }
    }
}
#pragma warning restore 1591