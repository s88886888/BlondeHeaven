#pragma checksum "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f76b37998d690daf7f3dac1d8121e2c63fff7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Details.cshtml", typeof(AspNetCore.Views_Order_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f76b37998d690daf7f3dac1d8121e2c63fff7f", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184979d09fef8b924246761d6c1c1c5e201d2f82", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlondeHeaven.ViewModels.Base.OrderModelView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(103, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\Order\Details.cshtml"
   ViewData["Title"] = "详细信息"; 

#line default
#line hidden
            BeginContext(139, 19, true);
            WriteLiteral("\r\n<h2>订单详细</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\Order\Details.cshtml"
 foreach (var noodle in Model.Orders)
{


#line default
#line hidden
            BeginContext(202, 40, true);
            WriteLiteral("    <div class=\"caption\">\r\n        <h3>￥");
            EndContext();
            BeginContext(243, 12, false);
#line 12 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\Order\Details.cshtml"
        Write(noodle.Price);

#line default
#line hidden
            EndContext();
            BeginContext(255, 18, true);
            WriteLiteral("</h3>\r\n        <p>");
            EndContext();
            BeginContext(274, 15, false);
#line 13 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\Order\Details.cshtml"
      Write(noodle.DateTime);

#line default
#line hidden
            EndContext();
            BeginContext(289, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(307, 11, false);
#line 14 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\Order\Details.cshtml"
      Write(noodle.Name);

#line default
#line hidden
            EndContext();
            BeginContext(318, 103, true);
            WriteLiteral("</p>\r\n        <p>--------------------------------------------------------------------</p>\r\n    </div>\r\n");
            EndContext();
#line 17 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\Order\Details.cshtml"
}

#line default
#line hidden
#line 18 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\Order\Details.cshtml"
 foreach (var noodles in Model.Commoditys)
{

#line default
#line hidden
            BeginContext(471, 24, true);
            WriteLiteral("    <div>\r\n        <h3>￥");
            EndContext();
            BeginContext(496, 12, false);
#line 21 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\Order\Details.cshtml"
        Write(noodles.Name);

#line default
#line hidden
            EndContext();
            BeginContext(508, 18, true);
            WriteLiteral("</h3>\r\n        <p>");
            EndContext();
            BeginContext(527, 13, false);
#line 22 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\Order\Details.cshtml"
      Write(noodles.Price);

#line default
#line hidden
            EndContext();
            BeginContext(540, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(558, 23, false);
#line 23 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\Order\Details.cshtml"
      Write(noodles.CreateCommodity);

#line default
#line hidden
            EndContext();
            BeginContext(581, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(599, 13, false);
#line 24 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\Order\Details.cshtml"
      Write(noodles.Photo);

#line default
#line hidden
            EndContext();
            BeginContext(612, 18, true);
            WriteLiteral("</p>\r\n    </div>\r\n");
            EndContext();
#line 26 "C:\Users\大大卷泡泡乐\Desktop\0.0\BlondeHeaven2.0\BlondeHeaven\Views\Order\Details.cshtml"
}

#line default
#line hidden
            BeginContext(633, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlondeHeaven.ViewModels.Base.OrderModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591
