#pragma checksum "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d79234feb7fd2cb0ec27282e0651db263151cb19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_EndDetails), @"mvc.1.0.view", @"/Views/Order/EndDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/EndDetails.cshtml", typeof(AspNetCore.Views_Order_EndDetails))]
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
#line 1 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\_ViewImports.cshtml"
using BlondeHeaven.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\_ViewImports.cshtml"
using BlondeHeaven;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d79234feb7fd2cb0ec27282e0651db263151cb19", @"/Views/Order/EndDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184979d09fef8b924246761d6c1c1c5e201d2f82", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_EndDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlondeHeaven.ViewModels.Base.OrderModelView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
  
    ViewData["Title"] = "历史订单";

#line default
#line hidden
            BeginContext(94, 19, true);
            WriteLiteral("\r\n\r\n<h2>历史记录</h2>\r\n");
            EndContext();
#line 9 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
 foreach (var noodle in Model.Orders)
{


#line default
#line hidden
            BeginContext(157, 42, true);
            WriteLiteral("    <div class=\"caption\">\r\n        <h3>价格 ");
            EndContext();
            BeginContext(200, 12, false);
#line 13 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
          Write(noodle.Price);

#line default
#line hidden
            EndContext();
            BeginContext(212, 25, true);
            WriteLiteral("</h3>\r\n        <p>单子创建时间 ");
            EndContext();
            BeginContext(238, 15, false);
#line 14 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
             Write(noodle.DateTime);

#line default
#line hidden
            EndContext();
            BeginContext(253, 22, true);
            WriteLiteral("</p>\r\n        <p>店铺名字 ");
            EndContext();
            BeginContext(276, 21, false);
#line 15 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
           Write(noodle.ShopKeeperName);

#line default
#line hidden
            EndContext();
            BeginContext(297, 22, true);
            WriteLiteral("</p>\r\n        <p>商品名字 ");
            EndContext();
            BeginContext(320, 20, false);
#line 16 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
           Write(noodle.CommodityName);

#line default
#line hidden
            EndContext();
            BeginContext(340, 20, true);
            WriteLiteral("</p>\r\n        <p>地址 ");
            EndContext();
            BeginContext(361, 14, false);
#line 17 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
         Write(noodle.Address);

#line default
#line hidden
            EndContext();
            BeginContext(375, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(393, 24, false);
#line 18 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
      Write(noodle.ApplicationUserId);

#line default
#line hidden
            EndContext();
            BeginContext(417, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(435, 18, false);
#line 19 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
      Write(noodle.CommodityId);

#line default
#line hidden
            EndContext();
            BeginContext(453, 20, true);
            WriteLiteral("</p>\r\n        <p>名字 ");
            EndContext();
            BeginContext(474, 11, false);
#line 20 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
         Write(noodle.Name);

#line default
#line hidden
            EndContext();
            BeginContext(485, 20, true);
            WriteLiteral("</p>\r\n        <p>备注 ");
            EndContext();
            BeginContext(506, 14, false);
#line 21 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
         Write(noodle.Remarks);

#line default
#line hidden
            EndContext();
            BeginContext(520, 22, true);
            WriteLiteral("</p>\r\n        <p>电话号码 ");
            EndContext();
            BeginContext(543, 12, false);
#line 22 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
           Write(noodle.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(555, 20, true);
            WriteLiteral("</p>\r\n        <p>邮箱 ");
            EndContext();
            BeginContext(576, 12, false);
#line 23 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
         Write(noodle.Email);

#line default
#line hidden
            EndContext();
            BeginContext(588, 22, true);
            WriteLiteral("</p>\r\n        <p>预约时间 ");
            EndContext();
            BeginContext(611, 22, false);
#line 24 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
           Write(noodle.CreateCommodity);

#line default
#line hidden
            EndContext();
            BeginContext(633, 103, true);
            WriteLiteral("</p>\r\n        <p>--------------------------------------------------------------------</p>\r\n    </div>\r\n");
            EndContext();
#line 29 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
     if (User.IsInRole("AdminShop"))
    {
        

#line default
#line hidden
#line 31 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
         if (noodle.IsRemo == true)
        {

#line default
#line hidden
            BeginContext(833, 29, true);
            WriteLiteral("            <h1>订单已经完成</h1>\r\n");
            EndContext();
#line 34 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(898, 28, true);
            WriteLiteral("            <h1>订单未完成</h1>\r\n");
            EndContext();
#line 38 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
        }

#line default
#line hidden
#line 38 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
         
    }

#line default
#line hidden
#line 39 "C:\Users\大大卷泡泡乐\Desktop\金发天国\BlondeHeaven2.0\BlondeHeavenWeb\BlondeHeaven\Views\Order\EndDetails.cshtml"
     


}

#line default
#line hidden
            BeginContext(951, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
