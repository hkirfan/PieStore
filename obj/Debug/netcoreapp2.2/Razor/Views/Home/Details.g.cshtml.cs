#pragma checksum "C:\www\BethanysPieShop\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63c819b3465dc43db72a792b50d46de9aa49f021"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\www\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.Models;

#line default
#line hidden
#line 2 "C:\www\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63c819b3465dc43db72a792b50d46de9aa49f021", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"894da19dcc8310d740856d36fa8bcad95a6ffc63", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(19, 10, false);
#line 3 "C:\www\BethanysPieShop\Views\Home\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(29, 42, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"thumbnail\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 71, "\"", 88, 1);
#line 6 "C:\www\BethanysPieShop\Views\Home\Details.cshtml"
WriteAttributeValue("", 77, Model.Name, 77, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 89, "\"", 110, 1);
#line 6 "C:\www\BethanysPieShop\Views\Home\Details.cshtml"
WriteAttributeValue("", 95, Model.ImageUrl, 95, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(111, 66, true);
            WriteLiteral(">\r\n    <div class=\"caption-full\">\r\n        <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(178, 11, false);
#line 8 "C:\www\BethanysPieShop\Views\Home\Details.cshtml"
                          Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(189, 33, true);
            WriteLiteral("</h3>\r\n        <h3>\r\n            ");
            EndContext();
            BeginContext(223, 10, false);
#line 10 "C:\www\BethanysPieShop\Views\Home\Details.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(233, 29, true);
            WriteLiteral("\r\n        </h3>\r\n        <h4>");
            EndContext();
            BeginContext(263, 22, false);
#line 12 "C:\www\BethanysPieShop\Views\Home\Details.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(285, 18, true);
            WriteLiteral("</h4>\r\n        <p>");
            EndContext();
            BeginContext(304, 21, false);
#line 13 "C:\www\BethanysPieShop\Views\Home\Details.cshtml"
      Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(325, 28, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pie> Html { get; private set; }
    }
}
#pragma warning restore 1591