#pragma checksum "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c84669fe0323ee0dee33ed860fe4fa6ab63d44e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Details), @"mvc.1.0.view", @"/Views/Member/Details.cshtml")]
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
#line 1 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\_ViewImports.cshtml"
using AspNet_MVC_Session;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\_ViewImports.cshtml"
using AspNet_MVC_Session.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84669fe0323ee0dee33ed860fe4fa6ab63d44e8", @"/Views/Member/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b562e69f108f7101ced63eb8d6c2eb63cca4e278", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNet_MVC_Session.Models.Member>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
  
    ViewData["Title"] = "Member Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>\r\n    Member Details\r\n</h1>\r\n<hr />\r\n<div>\r\n    <table class=\"table\">\r\n        <tbody>\r\n            <tr>\r\n                <th scope=\"row\">\r\n                    ");
#nullable restore
#line 16 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 19 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 27 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">\r\n                    ");
#nullable restore
#line 48 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">\r\n                    ");
#nullable restore
#line 56 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.BirthPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayFor(model => model.BirthPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">\r\n                    ");
#nullable restore
#line 64 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">\r\n                    ");
#nullable restore
#line 72 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "C:\Users\DucAnhPC\Documents\Code Sandbox\learning-spaces\AspNet-MVC-Session\Views\Member\Details.cshtml"
               Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNet_MVC_Session.Models.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591
