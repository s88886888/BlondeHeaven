#pragma checksum "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e889807cc5adfb34dc5cb1be414e28511c5c83e7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e889807cc5adfb34dc5cb1be414e28511c5c83e7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlondeHeaven.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(134, 16, true);
            WriteLiteral("\n<h2>产品列表</h2>\n\n");
            EndContext();
#line 10 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Home\Index.cshtml"
 foreach (var noodle in Model.Noodles)
{

#line default
#line hidden
            BeginContext(191, 93, true);
            WriteLiteral("    <div class=\"col-sm-4 col-lg-4 col-md-4\">\n        <div class=\"thumbnail\">\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 284, "\"", 306, 1);
#line 14 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Home\Index.cshtml"
WriteAttributeValue("", 290, noodle.ImageURL, 290, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(307, 83, true);
            WriteLiteral(" alt=\"\">\n            <div class=\"caption\">\n                <h3 class=\"pull-right\">￥");
            EndContext();
            BeginContext(391, 12, false);
#line 16 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Home\Index.cshtml"
                                   Write(noodle.Price);

#line default
#line hidden
            EndContext();
            BeginContext(403, 47, true);
            WriteLiteral("</h3>\n                <h3>\n                    ");
            EndContext();
            BeginContext(450, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d538e4fb04e4847a7c4d11ecb49379d", async() => {
                BeginContext(568, 11, false);
#line 20 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Home\Index.cshtml"
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
#line 20 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Home\Index.cshtml"
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
            BeginContext(583, 42, true);
            WriteLiteral("\n                </h3>\n                <p>");
            EndContext();
            BeginContext(626, 23, false);
#line 22 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Home\Index.cshtml"
              Write(noodle.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(649, 50, true);
            WriteLiteral("</p>\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 26 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(701, 39, true);
            WriteLiteral("\n<h2>评价</h2>\n\n<div class=\"list-group\">\n");
            EndContext();
#line 31 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Home\Index.cshtml"
     foreach (var feedback in Model.Feedbacks)
    {

#line default
#line hidden
            BeginContext(793, 151, true);
            WriteLiteral("        <a class=\"list-group-item\">\n            <div class=\"d-flex w-100 justify-content-between\">\n                <h5 class=\"list-group-item-heading\">");
            EndContext();
            BeginContext(945, 13, false);
#line 35 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Home\Index.cshtml"
                                               Write(feedback.Name);

#line default
#line hidden
            EndContext();
            BeginContext(958, 48, true);
            WriteLiteral("</h5>\n                <small class=\"pull-right\">");
            EndContext();
            BeginContext(1007, 22, false);
#line 36 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Home\Index.cshtml"
                                     Write(feedback.CreateDateUTC);

#line default
#line hidden
            EndContext();
            BeginContext(1029, 72, true);
            WriteLiteral("</small>\n            </div>\n            <p class=\"list-group-item-text\">");
            EndContext();
            BeginContext(1102, 16, false);
#line 38 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Home\Index.cshtml"
                                       Write(feedback.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1118, 18, true);
            WriteLiteral("</p>\n        </a>\n");
            EndContext();
#line 40 "C:\Users\大大卷泡泡乐\Desktop\ASP.NetMVC-Demo\BlondeHeaven\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1142, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlondeHeaven.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
