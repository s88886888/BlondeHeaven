#pragma checksum "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "749a9d0e0406d0dccfbca9b8ddbc4fb45cd101c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Details), @"mvc.1.0.view", @"/Views/Shop/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Details.cshtml", typeof(AspNetCore.Views_Shop_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"749a9d0e0406d0dccfbca9b8ddbc4fb45cd101c5", @"/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlondeHeaven.ViewModels.ShopModelView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(89, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Details.cshtml"
 foreach (var noodle in Model.ShopKeepers)
{

#line default
#line hidden
            BeginContext(138, 154, true);
            WriteLiteral("    <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n        <div class=\"thumbnail\">\r\n            <div class=\"caption\">\r\n                <h3 class=\"pull-right\">￥");
            EndContext();
            BeginContext(293, 11, false);
#line 11 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Details.cshtml"
                                   Write(noodle.Name);

#line default
#line hidden
            EndContext();
            BeginContext(304, 51, true);
            WriteLiteral("</h3>\r\n\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(355, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1295b93d6eae4918bef3ebae0a908432", async() => {
                BeginContext(477, 2, true);
                WriteLiteral("详细");
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
#line 16 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Details.cshtml"
                         WriteLiteral(noodle.Name);

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
            BeginContext(483, 69, true);
            WriteLiteral("\r\n                </h3>\r\n\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(552, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e283e7ddb181400b9e57c91b1d402122", async() => {
                BeginContext(673, 2, true);
                WriteLiteral("删除");
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
#line 22 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Details.cshtml"
                         WriteLiteral(noodle.Name);

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
            BeginContext(679, 44, true);
            WriteLiteral("\r\n                </h3>\r\n                <p>");
            EndContext();
            BeginContext(724, 12, false);
#line 24 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Details.cshtml"
              Write(noodle.Sales);

#line default
#line hidden
            EndContext();
            BeginContext(736, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(762, 12, false);
#line 25 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Details.cshtml"
              Write(noodle.Photo);

#line default
#line hidden
            EndContext();
            BeginContext(774, 96, true);
            WriteLiteral("</p>\r\n                <h3>我是店铺 只是没有前端美化而已</h3>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 30 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Details.cshtml"
}

#line default
#line hidden
            BeginContext(873, 28, true);
            WriteLiteral("\r\n<div class=\"list-group\">\r\n");
            EndContext();
#line 33 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Details.cshtml"
     foreach (var feedback in Model.Commoditys)
    {

#line default
#line hidden
            BeginContext(957, 192, true);
            WriteLiteral("        <a class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h3>我是商品只是样式错了而已</h3>\r\n                <h5 class=\"list-group-item-heading\">");
            EndContext();
            BeginContext(1150, 13, false);
#line 38 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Details.cshtml"
                                               Write(feedback.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1163, 49, true);
            WriteLiteral("</h5>\r\n                <small class=\"pull-right\">");
            EndContext();
            BeginContext(1213, 14, false);
#line 39 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Details.cshtml"
                                     Write(feedback.Photo);

#line default
#line hidden
            EndContext();
            BeginContext(1227, 74, true);
            WriteLiteral("</small>\r\n            </div>\r\n            <p class=\"list-group-item-text\">");
            EndContext();
            BeginContext(1302, 14, false);
#line 41 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Details.cshtml"
                                       Write(feedback.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1316, 18, true);
            WriteLiteral("</p>\r\n        </a>");
            EndContext();
#line 42 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Shop\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1337, 27, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1364, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11e6389b4e5a448b8f6cb692ce506b4c", async() => {
                BeginContext(1386, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1402, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlondeHeaven.ViewModels.ShopModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591
