#pragma checksum "C:\Users\brhacke\source\repos\College Board PoC Model\College Board PoC Model\Views\Session\SignedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a33e11fa841f6f7c35e60982dff3fa106d933351"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Session_SignedOut), @"mvc.1.0.view", @"/Views/Session/SignedOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Session/SignedOut.cshtml", typeof(AspNetCore.Views_Session_SignedOut))]
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
#line 1 "C:\Users\brhacke\source\repos\College Board PoC Model\College Board PoC Model\Views\_ViewImports.cshtml"
using College_Board_PoC_Model;

#line default
#line hidden
#line 2 "C:\Users\brhacke\source\repos\College Board PoC Model\College Board PoC Model\Views\_ViewImports.cshtml"
using College_Board_PoC_Model.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33e11fa841f6f7c35e60982dff3fa106d933351", @"/Views/Session/SignedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27c5b3fd0342d51ec79c7c32e12d0d710f007b3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Session_SignedOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\brhacke\source\repos\College Board PoC Model\College Board PoC Model\Views\Session\SignedOut.cshtml"
  
    ViewData["Title"] = "Sign Out";

#line default
#line hidden
            BeginContext(44, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(49, 17, false);
#line 4 "C:\Users\brhacke\source\repos\College Board PoC Model\College Board PoC Model\Views\Session\SignedOut.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(66, 69, true);
            WriteLiteral(".</h2>\r\n<p class=\"text-success\">You have successfully signed out.</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
