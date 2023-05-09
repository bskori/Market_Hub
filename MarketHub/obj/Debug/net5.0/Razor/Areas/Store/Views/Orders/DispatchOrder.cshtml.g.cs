#pragma checksum "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c30c3ca5f85d6a20e1558c5aedaa737e492eb956"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Store_Views_Orders_DispatchOrder), @"mvc.1.0.view", @"/Areas/Store/Views/Orders/DispatchOrder.cshtml")]
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
#line 1 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\_ViewImports.cshtml"
using StoreApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\_ViewImports.cshtml"
using StoreApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30c3ca5f85d6a20e1558c5aedaa737e492eb956", @"/Areas/Store/Views/Orders/DispatchOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6bbf60ea478b9b514db2faf0dfabbd30b1d6471", @"/Areas/Store/Views/_ViewImports.cshtml")]
    public class Areas_Store_Views_Orders_DispatchOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserOrder>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n      <div class=\"row\">\r\n           <div class=\"col-md-12\">\r\n               <table class=\"table table-bordered\">\r\n                   <tr>\r\n                       <td> Order ID </td>\r\n                       <td>");
#nullable restore
#line 8 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
                      Write(Model.UserOrderID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   </tr>\r\n                   <tr>\r\n                       <td> First Name </td>\r\n                       <td>");
#nullable restore
#line 12 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
                      Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   </tr>\r\n                   <tr>\r\n                       <td> Order Date </td>\r\n                       <td>");
#nullable restore
#line 16 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
                      Write(Model.OrderDateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   </tr>\r\n                   <tr>\r\n                       <td> Is Paid </td>\r\n                       <td>");
#nullable restore
#line 20 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
                      Write(Model.IsPaid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                   </tr>
               </table>
                <h2> Order Details </h2>
                <table class=""table table-bordered"">
                    <tr>
                        <td> Sr. No </td>
                        <td> Product Name </td>
                        <td> Photo</td>
                        <td> Qty </td>
                        <td> Price </td>
                        <td> Amount </td>
                    </tr>
");
#nullable restore
#line 33 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
                      int srno = 1; decimal? amount, totalamount = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
                     foreach (var temp in Model.UserOrderDets)
                    {
                        amount = temp.Qty * temp.Price;
                        totalamount += amount;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 39 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
                           Write(srno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
                           Write(temp.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><img");
            BeginWriteAttribute("src", " src=\"", 1619, "\"", 1648, 1);
#nullable restore
#line 41 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
WriteAttributeValue("", 1625, temp.Product.PhotoPath, 1625, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" /></td>\r\n                            <td>");
#nullable restore
#line 42 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
                           Write(temp.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
                           Write(temp.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 45 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
                           Write(amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 48 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
                        srno++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"5\" class=\"alert-danger text-right\">Total:=>");
#nullable restore
#line 51 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
                                                                           Write(totalamount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td></td>\r\n                    </tr>\r\n                </table>\r\n               <br />\r\n               ");
#nullable restore
#line 56 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
          Write(Html.ActionLink("Dispatch Order", "ExecuteDispatchOrder", "Orders", new {id=@Model.UserOrderID},new {@class="btn btn-success"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               &nbsp; &nbsp;\r\n               ");
#nullable restore
#line 58 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Areas\Store\Views\Orders\DispatchOrder.cshtml"
          Write(Html.ActionLink("Back","Index","Orders", null, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n           </div>\r\n      </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591
