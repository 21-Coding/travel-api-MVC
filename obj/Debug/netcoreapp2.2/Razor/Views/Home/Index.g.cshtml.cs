#pragma checksum "C:\Users\dzham\desktop\travel-api-MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b2fb477a8428bb9e8925631b6efb3630a51ef0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\dzham\desktop\travel-api-MVC\Views\_ViewImports.cshtml"
using TravelApiMVC;

#line default
#line hidden
#line 2 "C:\Users\dzham\desktop\travel-api-MVC\Views\_ViewImports.cshtml"
using TravelApiMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b2fb477a8428bb9e8925631b6efb3630a51ef0d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af2089794ecb5b00b701b89af240e4c0485f77c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\dzham\desktop\travel-api-MVC\Views\Home\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 41, true);
            WriteLiteral("\r\n<h1>Welcome to the Travel API!</h1>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\dzham\desktop\travel-api-MVC\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(111, 31, true);
            WriteLiteral("  <p>You are now logged in as: ");
            EndContext();
            BeginContext(143, 18, false);
#line 9 "C:\Users\dzham\desktop\travel-api-MVC\Views\Home\Index.cshtml"
                          Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(161, 7, true);
            WriteLiteral("!</p>\r\n");
            EndContext();
#line 11 "C:\Users\dzham\desktop\travel-api-MVC\Views\Home\Index.cshtml"
       using (Html.BeginForm("LogOff", "Account"))
  {

#line default
#line hidden
            BeginContext(227, 70, true);
            WriteLiteral("      <input type=\"submit\" class=\"btn btn-danger\" value=\"Log out\" />\r\n");
            EndContext();
#line 14 "C:\Users\dzham\desktop\travel-api-MVC\Views\Home\Index.cshtml"
  }

#line default
#line hidden
#line 14 "C:\Users\dzham\desktop\travel-api-MVC\Views\Home\Index.cshtml"
   
}

#line default
#line hidden
            BeginContext(305, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\dzham\desktop\travel-api-MVC\Views\Home\Index.cshtml"
 if (!User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(348, 138, true);
            WriteLiteral("  <p>You are not logged in.</p>\r\n  <p>You may browse, but you must be registered and logged in to modify items on this website.</p>\r\n  <p>");
            EndContext();
            BeginContext(487, 64, false);
#line 21 "C:\Users\dzham\desktop\travel-api-MVC\Views\Home\Index.cshtml"
Write(Html.ActionLink("Register a new account", "Register", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(551, 11, true);
            WriteLiteral("</p>  \r\n<p>");
            EndContext();
            BeginContext(563, 65, false);
#line 22 "C:\Users\dzham\desktop\travel-api-MVC\Views\Home\Index.cshtml"
Write(Html.ActionLink("Log in to existing account", "Login", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(628, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 23 "C:\Users\dzham\desktop\travel-api-MVC\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(637, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(643, 63, false);
#line 25 "C:\Users\dzham\desktop\travel-api-MVC\Views\Home\Index.cshtml"
Write(Html.ActionLink("See all destinations", "Index", "Destination"));

#line default
#line hidden
            EndContext();
            BeginContext(706, 6, true);
            WriteLiteral("</p>\r\n");
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
