#pragma checksum "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "593609565b680feacc402828ed0ae73328c43006"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Delete), @"mvc.1.0.view", @"/Views/Shop/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Delete.cshtml", typeof(AspNetCore.Views_Shop_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"593609565b680feacc402828ed0ae73328c43006", @"/Views/Shop/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184979d09fef8b924246761d6c1c1c5e201d2f82", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlondeHeaven.ViewModels.ShopViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(90, 77, true);
            WriteLiteral("<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(168, 38, false);
#line 10 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(206, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(250, 34, false);
#line 13 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(284, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(328, 53, false);
#line 16 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationUserId));

#line default
#line hidden
            EndContext();
            BeginContext(381, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(425, 49, false);
#line 19 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationUserId));

#line default
#line hidden
            EndContext();
            BeginContext(474, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(518, 40, false);
#line 22 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(558, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(602, 36, false);
#line 25 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(638, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(682, 43, false);
#line 28 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(725, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(769, 39, false);
#line 31 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(808, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(852, 41, false);
#line 34 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(893, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(937, 37, false);
#line 37 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(974, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1018, 41, false);
#line 40 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1103, 37, false);
#line 43 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1184, 41, false);
#line 46 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sales));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1269, 37, false);
#line 49 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Shop\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sales));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1344, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593609565b680feacc402828ed0ae73328c4300610512", async() => {
                BeginContext(1370, 82, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"确认删除\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1452, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593609565b680feacc402828ed0ae73328c4300610985", async() => {
                    BeginContext(1474, 2, true);
                    WriteLiteral("返回");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1480, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1493, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlondeHeaven.ViewModels.ShopViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
