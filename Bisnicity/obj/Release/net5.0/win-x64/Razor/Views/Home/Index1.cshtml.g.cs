#pragma checksum "C:\Users\FT-Design\Desktop\mmmmm\qqq\samer\ffinal\theend\Bisnicity\Bisnicity\Views\Home\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4dd8fe12bdfe2a3e3376801c9c3ef062a8bb10d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index1), @"mvc.1.0.view", @"/Views/Home/Index1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4dd8fe12bdfe2a3e3376801c9c3ef062a8bb10d", @"/Views/Home/Index1.cshtml")]
    public class Views_Home_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\FT-Design\Desktop\mmmmm\qqq\samer\ffinal\theend\Bisnicity\Bisnicity\Views\Home\Index1.cshtml"
   Layout = "_Layout";
  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .hero-image {
        background-image: url(""../assets/images/walkingBusinessMan.png"");
        background-color: #cccccc;
        height: 500px;
        background-position: center;
        background-repeat: no-repeat;
        background-size: cover;
        position: relative;
        margin-bottom: 1%;
        margin-top: -2%;
    }

    .hero-text {
        text-align: center;
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
        color: white;
    }
</style>

<section class=""my-5"">
    <div class=""container-fluid"">

        <div class=""hero-image"">
            <div class=""hero-text"">
                <h1 style=""font-size:50px"">Welcome To Busniscity</h1>
                <div class=""input-group"">
                    <input class=""form-control border-0 mr-2"" type=""search"" placeholder=""Search""
                           aria-label=""Search"">
                    <button class=""btn btn-success border-0"" style=""background-color: #2c8d97""
   ");
            WriteLiteral(@"                         type=""submit"">
                        Search
                    </button>

                </div>
                <!-- <h3>And I'm a Photographer</h3> -->
                <!-- <button>Hire me</button> -->
            </div>
        </div>
        <!-- Information -->
        <section class=""information"">
            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-lg-4 text-center p-5 text-white"">

                        <h4 class=""py-3 text-dark"">Business Services</h4>
                        <p class=""para-light text-dark"">
                            Unique services and solutions that we offer to businesses, shops and companies of different disciplines to contribute with you to developing your business and giving you the added value you desire
                        </p>
                        <div class=""d-grid gap-2"">
                            <a class=""btn text-white"" style=""background-color: #2c8d97;""");
            BeginWriteAttribute("href", " href=", 2109, "", 2144, 1);
#nullable restore
#line 58 "C:\Users\FT-Design\Desktop\mmmmm\qqq\samer\ffinal\theend\Bisnicity\Bisnicity\Views\Home\Index1.cshtml"
WriteAttributeValue("", 2115, Url.Action("Login","SignUp"), 2115, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Join</a>
                        </div>

                    </div>
                    <div class=""col-lg-4 text-center p-5"">

                        <h4 class=""py-3 text-dark"">Person Services</h4>
                        <p class=""para-light text-dark"">
                            Service packages for individuals, including training, employment and searching for vacancies through the broadcast engine designed specifically for these purposes.
                        </p>
                        <div class=""d-grid gap-2"">
                            <a class=""btn text-white"" style=""background-color: #2c8d97;""");
            BeginWriteAttribute("href", "\n                               href=", 2762, "", 2832, 1);
#nullable restore
#line 70 "C:\Users\FT-Design\Desktop\mmmmm\qqq\samer\ffinal\theend\Bisnicity\Bisnicity\Views\Home\Index1.cshtml"
WriteAttributeValue("", 2799, Url.Action("TraAndJobEn","Home"), 2799, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Join</a>
                        </div>
                    </div>
                    <div class=""col-lg-4 text-center p-5 text-white""
                         style=""background-color:white"">

                        <h4 class=""py-3 text-dark"">Leadership Services</h4>
                        <p class=""para-light text-dark"">
                            A wide range of new entrepreneurial services whose owners are looking for financiers and business partners to create or develop their ideas and translate them into reality
                        </p>
                        <div class=""d-grid gap-2"">

                            <a class=""btn text-white"" style=""background-color: #2c8d97;""");
            BeginWriteAttribute("href", " href=", 3529, "", 3567, 1);
#nullable restore
#line 82 "C:\Users\FT-Design\Desktop\mmmmm\qqq\samer\ffinal\theend\Bisnicity\Bisnicity\Views\Home\Index1.cshtml"
WriteAttributeValue("", 3535, Url.Action("IdeashowEn","Home"), 3535, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Join</a>\n                        </div>\n                    </div>\n                \n                </div>\n            </div> <!-- end of container -->\n        </section> <!-- end of information -->\n\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
