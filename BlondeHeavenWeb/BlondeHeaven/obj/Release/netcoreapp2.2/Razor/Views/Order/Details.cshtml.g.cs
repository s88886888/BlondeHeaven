#pragma checksum "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81fe7042cb8413979fee7ddf363df313b74ac97e"
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
#line 1 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\_ViewImports.cshtml"
using BlondeHeaven.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\_ViewImports.cshtml"
using BlondeHeaven;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81fe7042cb8413979fee7ddf363df313b74ac97e", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184979d09fef8b924246761d6c1c1c5e201d2f82", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlondeHeaven.ViewModels.Base.OrderModelView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
   ViewData["Title"] = "详细信息"; 

#line default
#line hidden
            BeginContext(88, 17, true);
            WriteLiteral("\r\n<h2>订单详细</h2>\r\n");
            EndContext();
#line 6 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
 foreach (var noodle in Model.Orders)
{


#line default
#line hidden
            BeginContext(149, 34, true);
            WriteLiteral("<div class=\"caption\">\r\n    <h3>价格 ");
            EndContext();
            BeginContext(184, 12, false);
#line 10 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
      Write(noodle.Price);

#line default
#line hidden
            EndContext();
            BeginContext(196, 21, true);
            WriteLiteral("</h3>\r\n    <p>单子创建时间 ");
            EndContext();
            BeginContext(218, 15, false);
#line 11 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
         Write(noodle.DateTime);

#line default
#line hidden
            EndContext();
            BeginContext(233, 18, true);
            WriteLiteral("</p>\r\n    <p>店铺名字 ");
            EndContext();
            BeginContext(252, 21, false);
#line 12 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
       Write(noodle.ShopKeeperName);

#line default
#line hidden
            EndContext();
            BeginContext(273, 18, true);
            WriteLiteral("</p>\r\n    <p>商品名字 ");
            EndContext();
            BeginContext(292, 20, false);
#line 13 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
       Write(noodle.CommodityName);

#line default
#line hidden
            EndContext();
            BeginContext(312, 16, true);
            WriteLiteral("</p>\r\n    <p>地址 ");
            EndContext();
            BeginContext(329, 14, false);
#line 14 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
     Write(noodle.Address);

#line default
#line hidden
            EndContext();
            BeginContext(343, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(357, 24, false);
#line 15 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
  Write(noodle.ApplicationUserId);

#line default
#line hidden
            EndContext();
            BeginContext(381, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(395, 18, false);
#line 16 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
  Write(noodle.CommodityId);

#line default
#line hidden
            EndContext();
            BeginContext(413, 16, true);
            WriteLiteral("</p>\r\n    <p>名字 ");
            EndContext();
            BeginContext(430, 11, false);
#line 17 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
     Write(noodle.Name);

#line default
#line hidden
            EndContext();
            BeginContext(441, 16, true);
            WriteLiteral("</p>\r\n    <p>备注 ");
            EndContext();
            BeginContext(458, 14, false);
#line 18 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
     Write(noodle.Remarks);

#line default
#line hidden
            EndContext();
            BeginContext(472, 18, true);
            WriteLiteral("</p>\r\n    <p>电话号码 ");
            EndContext();
            BeginContext(491, 12, false);
#line 19 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
       Write(noodle.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(503, 16, true);
            WriteLiteral("</p>\r\n    <p>邮箱 ");
            EndContext();
            BeginContext(520, 12, false);
#line 20 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
     Write(noodle.Email);

#line default
#line hidden
            EndContext();
            BeginContext(532, 18, true);
            WriteLiteral("</p>\r\n    <p>预约时间 ");
            EndContext();
            BeginContext(551, 22, false);
#line 21 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
       Write(noodle.CreateCommodity);

#line default
#line hidden
            EndContext();
            BeginContext(573, 95, true);
            WriteLiteral("</p>\r\n    <p>--------------------------------------------------------------------</p>\r\n</div>\r\n");
            EndContext();
#line 24 "C:\Users\Administrator\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\Details.cshtml"
}

#line default
#line hidden
            BeginContext(671, 4, true);
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
