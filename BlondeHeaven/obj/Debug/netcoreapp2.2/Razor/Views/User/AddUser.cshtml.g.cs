#pragma checksum "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\User\AddUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c718f7023e6c85a2e1eb859af798da2f0f6df19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_AddUser), @"mvc.1.0.view", @"/Views/User/AddUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/AddUser.cshtml", typeof(AspNetCore.Views_User_AddUser))]
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
#line 1 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\_ViewImports.cshtml"
using BlondeHeaven.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\_ViewImports.cshtml"
using BlondeHeaven;

#line default
#line hidden
#line 1 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\User\AddUser.cshtml"
using BlondeHeaven.ViewModels.User;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c718f7023e6c85a2e1eb859af798da2f0f6df19", @"/Views/User/AddUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184979d09fef8b924246761d6c1c1c5e201d2f82", @"/Views/_ViewImports.cshtml")]
    public class Views_User_AddUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserAddViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\User\AddUser.cshtml"
  
    ViewBag.Title = "添加用户";

#line default
#line hidden
            BeginContext(100, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(107, 13, false);
#line 8 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\User\AddUser.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(120, 1110, true);
            WriteLiteral(@"</h2>

<form method=""post"">
    <div class=""form-group row"">
        <label asp-for=""UserName"" class=""col-sm-2""></label>
        <div class=""col-sm-10"">
            <input class=""form-control"" asp-for=""UserName"">
            <span class=""invalid"" asp-validation-for=""UserName""></span>
        </div>
    </div>

    <div class=""form-group row"">
        <label asp-for=""Email"" class=""col-sm-2""></label>
        <div class=""col-sm-10"">
            <input class=""form-control"" asp-for=""Email"">
            <span class=""invalid"" asp-validation-for=""Email""></span>
        </div>
    </div>

    <div class=""form-group row"">
        <label asp-for=""Password"" class=""col-sm-2""></label>
        <div class=""col-sm-10"">
            <input class=""form-control"" asp-for=""Password"">
            <span class=""invalid"" asp-validation-for=""Password""></span>
        </div>
    </div>
    <div class=""invalid"" asp-validation-summary=""ModelOnly"">
    </div>

    <button type=""submit"" class=""btn btn-primary"">提交");
            WriteLiteral("</button>\r\n\r\n    <a asp-action=\"Index\" class=\"btn btn-secondary\">返回列表</a>\r\n\r\n\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserAddViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
