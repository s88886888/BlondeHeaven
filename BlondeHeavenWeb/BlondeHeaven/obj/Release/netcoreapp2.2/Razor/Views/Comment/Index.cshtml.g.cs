#pragma checksum "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2506870e37f232124eefb7a77be2bc0444904323"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_Index), @"mvc.1.0.view", @"/Views/Comment/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comment/Index.cshtml", typeof(AspNetCore.Views_Comment_Index))]
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
#line 1 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\_ViewImports.cshtml"
using BlondeHeaven.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\_ViewImports.cshtml"
using BlondeHeaven;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2506870e37f232124eefb7a77be2bc0444904323", @"/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184979d09fef8b924246761d6c1c1c5e201d2f82", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlondeHeaven.ViewModels.Base.CommentModelView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(95, 33, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<div>\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(128, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2506870e37f232124eefb7a77be2bc04449043234149", async() => {
                BeginContext(185, 30, true);
                WriteLiteral("\r\n            有什么问题？\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(219, 53, true);
            WriteLiteral("\r\n    </h1>\r\n</div>\r\n\r\n\r\n\r\n<div class=\"list-group\">\r\n");
            EndContext();
#line 21 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Comment\Index.cshtml"
     foreach (var Com in Model.Comments)
    {

#line default
#line hidden
            BeginContext(321, 153, true);
            WriteLiteral("        <a class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"list-group-item-heading\">");
            EndContext();
            BeginContext(475, 8, false);
#line 25 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Comment\Index.cshtml"
                                               Write(Com.Name);

#line default
#line hidden
            EndContext();
            BeginContext(483, 49, true);
            WriteLiteral("</h5>\r\n                <small class=\"pull-right\">");
            EndContext();
            BeginContext(533, 12, false);
#line 26 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Comment\Index.cshtml"
                                     Write(Com.DateTime);

#line default
#line hidden
            EndContext();
            BeginContext(545, 74, true);
            WriteLiteral("</small>\r\n            </div>\r\n            <p class=\"list-group-item-text\">");
            EndContext();
            BeginContext(620, 11, false);
#line 28 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Comment\Index.cshtml"
                                       Write(Com.Content);

#line default
#line hidden
            EndContext();
            BeginContext(631, 18, true);
            WriteLiteral("</p>\r\n        </a>");
            EndContext();
#line 29 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Comment\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(652, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlondeHeaven.ViewModels.Base.CommentModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591
