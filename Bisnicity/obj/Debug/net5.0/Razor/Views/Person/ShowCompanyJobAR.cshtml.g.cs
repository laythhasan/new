#pragma checksum "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fad3bff590f86832c880ca24df1137d82ae8492"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_ShowCompanyJobAR), @"mvc.1.0.view", @"/Views/Person/ShowCompanyJobAR.cshtml")]
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
#line 1 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
using Bisnicity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fad3bff590f86832c880ca24df1137d82ae8492", @"/Views/Person/ShowCompanyJobAR.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867b26f07787ce3ed897daa89fe895608c099590", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_ShowCompanyJobAR : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShowCompanyViewmodel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/logo-businicity.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image/x-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/logowhite.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Person", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowCompanyJobAR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Aplayjob", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family: \'Rubik\', sans-serif;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fad3bff590f86832c880ca24df1137d82ae84928079", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

    <meta http-equiv=""Content-Type"" content=""text/html;charset=UTF-8"">

    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.14.0/css/all.css"">
    <link rel=""stylesheet"" href=""../css/layout.css"">
    <link rel=""stylesheet"" href=""../css/img.css"">
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Cabin:ital,wght@0,500;0,600;1,500&family=Fjalla+One&family=Rubik:ital,wght@0,300;0,400;0,500;0,600;1,300;1,400;1,500&display=swap""
          rel=""stylesheet"">
 ");
                WriteLiteral(@"   <link rel=""stylesheet"" href=""https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"" />

    <link href=""https://fonts.googleapis.com/css2?family=Amiri:ital@0;1&family=Cabin:ital,wght@0,500;0,600;1,500&family=Fjalla+One&family=Rubik:ital,wght@0,300;0,400;0,500;0,600;1,300;1,400;1,500&display=swap""
          rel=""stylesheet"">

    <title>Businicity Home Page</title>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3fad3bff590f86832c880ca24df1137d82ae84929834", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fad3bff590f86832c880ca24df1137d82ae849211808", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n    <nav class=\"navbar navbar-expand-lg navbar-light bg-light shadow\"\r\n         style=\"background-image: url(../assets/images/footer.png);\">\r\n        <div class=\"container-fluid\">\r\n            <a class=\"navbar-brand text-white\"");
                BeginWriteAttribute("href", " href=", 1960, "", 1995, 1);
#nullable restore
#line 44 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
WriteAttributeValue("", 1966, Url.Action("IndexAR","Home"), 1966, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3fad3bff590f86832c880ca24df1137d82ae849212732", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </a>\r\n\r\n            <a class=\"navbar-brand text-white fs-2\"");
                BeginWriteAttribute("href", " href=", 2183, "", 2218, 1);
#nullable restore
#line 49 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
WriteAttributeValue("", 2189, Url.Action("IndexAR","Home"), 2189, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Businicity</a>
            <button class=""navbar-toggler collapsed bg-white"" type=""button"" data-bs-toggle=""collapse""
                    data-bs-target=""#navbar-content"">
                <div class=""hamburger-toggle"">
                    <div class=""hamburger"">
                        <span></span>
                        <span></span>
                        <span></span>
                    </div>
                </div>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbar-content"" style=""margin-left: 50%;"">
                <ul class=""navbar-nav mr-auto mb-2 mb-lg-0"">
                    <li class=""nav-item"">
                        <a class=""nav-link active text-white fs-6"" aria-current=""page""");
                BeginWriteAttribute("href", " href=", 2967, "", 3002, 1);
#nullable restore
#line 63 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
WriteAttributeValue("", 2973, Url.Action("IndexAR","Home"), 2973, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" dir=\"rtl\" lang=\"ar\">الصفحة الرئيسية</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link text-white fs-6\"");
                BeginWriteAttribute("href", " href=", 3173, "", 3210, 1);
#nullable restore
#line 66 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
WriteAttributeValue("", 3179, Url.Action("AboutUsAR","Home"), 3179, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" dir=\"rtl\" lang=\"ar\">من نحن </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link text-white fs-6\"");
                BeginWriteAttribute("href", " href=", 3373, "", 3409, 1);
#nullable restore
#line 69 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
WriteAttributeValue("", 3379, Url.Action("Solution","Home"), 3379, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" dir=\"rtl\" lang=\"ar\"> حلول </a>\r\n                    </li>\r\n\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link text-white fs-6\"");
                BeginWriteAttribute("href", " href=", 3573, "", 3612, 1);
#nullable restore
#line 73 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
WriteAttributeValue("", 3579, Url.Action("ContactUsAR","Home"), 3579, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" dir=\"rtl\" lang=\"ar\">أتصل بنا </a>\r\n                    </li>\r\n\r\n                </ul>\r\n                <div class=\"d-flex ms-auto\">\r\n\r\n                    <a class=\"text-white fs-5\" style=\"text-decoration: none;\"");
                BeginWriteAttribute("href", " href=", 3825, "", 3859, 1);
#nullable restore
#line 79 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
WriteAttributeValue("", 3831, Url.Action("Index1","Home"), 3831, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">|EN </a>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n\r\n    <div class=\"container-fluid card shadow mt-4\">\r\n        <div class=\"row\">\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fad3bff590f86832c880ca24df1137d82ae849218243", async() => {
                    WriteLiteral(@"

                <div class=""input-group mt-1 mb-1"">
                    <input class=""form-control border-2"" name=""job"" id=""job"" type=""search"" placeholder=""Search""
                           aria-label=""Search"">
                    <button class=""btn  text-white border-1 bg-dark""
                            type=""submit"">
                        بحث
                    </button>

                </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            <!-- loop -->\r\n");
#nullable restore
#line 103 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-sm-6 border-end border-bottom p-4 text-white cartCompany\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-12 text-dark\">\r\n                            <h2 class=\"text-center\">");
#nullable restore
#line 108 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
                                               Write(item.NameJob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            <h5 class=\"text-center mt-3\">");
#nullable restore
#line 109 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
                                                    Write(item.CompanyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\r\n                        </div>\r\n                        <div class=\"col-md-6 mt-4 text-dark\">\r\n                            <h6><i class=\"fas fa-envelope\"></i> ");
#nullable restore
#line 113 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
                                                           Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h6>\r\n                            <h6><i class=\"fas fa-phone-square-alt\"></i> ");
#nullable restore
#line 114 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
                                                                   Write(item.PhoneNo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                            <h6><i class=\"fas fa-map-marker-alt\"></i> ");
#nullable restore
#line 115 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
                                                                 Write(item.City);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                            <h6><i class=\"fab fa-linkedin\"></i> ");
#nullable restore
#line 116 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
                                                           Write(item.Linklinkedin);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                            <a");
                BeginWriteAttribute("href", " href=", 5446, "", 5534, 1);
#nullable restore
#line 117 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
WriteAttributeValue("", 5452, Url.Action("Aplayjob","Person",new { id = item.jobvacancyid, id2 = item.userid }), 5452, 82, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn text-white"" style=""background-color:#15878e;"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">Apply</a>

                        </div>
                        <div class=""col-md-6 mt-2 text-dark"">
                            <label class=""fs-5""> Requirements :</label>
                            <h6> ");
#nullable restore
#line 122 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
                            Write(item.Requirements);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                            <label class=\"mt-3 fs-5\">Experince :</label>\r\n                            <h6>");
#nullable restore
#line 124 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
                           Write(item.Experience);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 128 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div>
    </div>
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"">
        <div class=""modal-dialog"">

            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Applay Job</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                </div>

                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fad3bff590f86832c880ca24df1137d82ae849225359", async() => {
                    WriteLiteral("\r\n                    <P> Would you like to apply for this job </P>\r\n                    <div class=\"modal-footer\">\r\n");
                    WriteLiteral("                        <input type=\"submit\" value=\"Save\" class=\"btn btn-success\" data-bs-dismiss=\"modal\" />\r\n                    </div>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


            </div>
        </div>
    </div>



    <footer class=""bg-dark p-4 text-white text-center"" style=""background-image: url(../assets/images/footer.png);"">
        <div style=""margin-bottom: 1%;"">
            <a dir=""rtl"" lang=""ar"" class=""text-white"" style=""text-decoration: none; padding: 1%;""");
                BeginWriteAttribute("href", " href=", 7358, "", 7393, 1);
#nullable restore
#line 157 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
WriteAttributeValue("", 7364, Url.Action("IndexAR","Home"), 7364, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <i class=\"fas fa-home\"></i>\r\n                الصفحة الرئيسية\r\n            </a>\r\n            <a dir=\"rtl\" lang=\"ar\" class=\"text-white\" style=\"text-decoration: none; padding: 1%;\"");
                BeginWriteAttribute("href", " href=", 7589, "", 7626, 1);
#nullable restore
#line 161 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
WriteAttributeValue("", 7595, Url.Action("AboutUsAR","Home"), 7595, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <i class=\"fab fa-angular\"></i>\r\n                من نحن\r\n            </a>\r\n            <a dir=\"rtl\" lang=\"ar\" class=\"text-white\" style=\"text-decoration: none; padding: 1%;\"");
                BeginWriteAttribute("href", " href=", 7816, "", 7855, 1);
#nullable restore
#line 165 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Person\ShowCompanyJobAR.cshtml"
WriteAttributeValue("", 7822, Url.Action("ContactUsAR","Home"), 7822, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                <i class=""far fa-address-book""></i> أتصل بنا
            </a>
        </div>
        <small>(c) 2021-2022 Written by BusinessCity</small>
        <div class=""icons"">
            <a href=""#"" target=""_blank"">
                <i class=""fab fa-whatsapp""></i>
            </a>
            <a href=""#"" target=""_blank"">
                <i class=""fab fa-instagram""></i>
            </a>
            <a href=""#"" target=""_blank"">
                <i class=""fab fa-facebook""></i>
            </a>
            <a href=""#"" target=""_blank"">
                <i class=""fab fa-linkedin""></i>
            </a>
        </div>
    </footer>


    <script src=""https://cdn.jsdelivr.net/npm/popperjs/core@2.9.2/dist/umd/popper.min.js""
            integrity=""sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js""
            integrity=""sha384-cVKIPhGW");
                WriteLiteral("iC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF\"\r\n            crossorigin=\"anonymous\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-1.12.4.js""></script>
    <script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>
    <script>
        $(document).ready(function () {
            $(""#job"").autocomplete({
                source: 'api/GetDate/Search'
            });
        });
    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShowCompanyViewmodel>> Html { get; private set; }
    }
}
#pragma warning restore 1591