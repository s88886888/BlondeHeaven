#pragma checksum "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c29e5ee5b5290ac342c1d95caf08577f15cdf3ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Index.cshtml", typeof(AspNetCore.Views_Shop_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29e5ee5b5290ac342c1d95caf08577f15cdf3ef", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlondeHeaven.ViewModels.ShopModelView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(95, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
            BeginContext(130, 16, true);
            WriteLiteral("\n<h2>产品列表</h2>\n\n");
            EndContext();
#line 8 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Index.cshtml"
 foreach (var noodle in Model.ShopKeepers)
{

#line default
#line hidden
            BeginContext(191, 135, true);
            WriteLiteral("<div class=\"col-sm-4 col-lg-4 col-md-4\">\n    <div class=\"thumbnail\">\n        <div class=\"caption\">\n            <h3 class=\"pull-right\">￥");
            EndContext();
            BeginContext(327, 12, false);
#line 13 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Index.cshtml"
                               Write(noodle.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(339, 39, true);
            WriteLiteral("</h3>\n            <h3>\n                ");
            EndContext();
            BeginContext(378, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29abed02fb74429d87010a60ca66dcff", async() => {
                BeginContext(489, 11, false);
#line 17 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Index.cshtml"
                                        Write(noodle.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Index.cshtml"
                     WriteLiteral(noodle.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(504, 53, true);
            WriteLiteral("\n            </h3>\n\n            <h3>\n                ");
            EndContext();
            BeginContext(557, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c0b677fe1314bea8b49457a406c588d", async() => {
                BeginContext(667, 11, false);
#line 23 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Index.cshtml"
                                        Write(noodle.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Index.cshtml"
                     WriteLiteral(noodle.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(682, 34, true);
            WriteLiteral("\n            </h3>\n            <p>");
            EndContext();
            BeginContext(717, 12, false);
#line 25 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Index.cshtml"
          Write(noodle.Sales);

#line default
#line hidden
            EndContext();
            BeginContext(729, 20, true);
            WriteLiteral("</p>\n            <p>");
            EndContext();
            BeginContext(750, 12, false);
#line 26 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Index.cshtml"
          Write(noodle.Photo);

#line default
#line hidden
            EndContext();
            BeginContext(762, 37, true);
            WriteLiteral("</p>\n        </div>\n    </div>\n</div>");
            EndContext();
#line 29 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Index.cshtml"
      }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlondeHeaven.ViewModels.ShopModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591
