#pragma checksum "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\Cart\GetCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d59887a2874023f02a58cd437a7bab92f3180fac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_GetCart), @"mvc.1.0.view", @"/Views/Cart/GetCart.cshtml")]
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
#line 1 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\_ViewImports.cshtml"
using StoreApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\_ViewImports.cshtml"
using StoreApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\Cart\GetCart.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d59887a2874023f02a58cd437a7bab92f3180fac", @"/Views/Cart/GetCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea24278335831e781c366fbbd35decd8c778477", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_GetCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PaymentMode", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakePayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-10\">\r\n     <h2> Cart For :=> ");
#nullable restore
#line 5 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\Cart\GetCart.cshtml"
                  Write(Context.Session.GetString("UserName"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n    <br />\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <td> Sr. No </td>\r\n            <td> Product Name </td>\r\n            <td> Qty </td>\r\n            <td> Price </td>\r\n            <td> Amount </td>\r\n        </tr>\r\n");
#nullable restore
#line 15 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\Cart\GetCart.cshtml"
          int srno = 1; decimal? amount, totalamount=0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\Cart\GetCart.cshtml"
         foreach (var temp in Model)
        {
            amount = temp.Qty * temp.Price;
            totalamount += amount;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n        <td>");
#nullable restore
#line 21 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\Cart\GetCart.cshtml"
       Write(srno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\Cart\GetCart.cshtml"
       Write(temp.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\Cart\GetCart.cshtml"
       Write(temp.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\Cart\GetCart.cshtml"
       Write(temp.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n           ");
#nullable restore
#line 26 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\Cart\GetCart.cshtml"
      Write(amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>");
#nullable restore
#line 28 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\Cart\GetCart.cshtml"
       Write(Html.ActionLink("Delete","DeleteCart","Cart",new {id=temp.CartID},new {@class="btn btn-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\Cart\GetCart.cshtml"
            srno++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td colspan=\"5\" class=\"alert-danger text-right\">Total:=>");
#nullable restore
#line 33 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\Cart\GetCart.cshtml"
                                                               Write(totalamount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"5\" class=\"alert-danger text-right\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d59887a2874023f02a58cd437a7bab92f3180fac7813", async() => {
                WriteLiteral("\r\n                    Select Payment Mode: \r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d59887a2874023f02a58cd437a7bab92f3180fac8136", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 40 "D:\Ri-Tech Projects\StoreApp\StoreApp\StoreApp\Views\Cart\GetCart.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.PaymentMode;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <input type=\"submit\" class=\"btn btn-danger\" value=\"Make Payment\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
