#pragma checksum "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\AddToCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b48d5eee1cfab4d428c9f7ef5989741b9f70febf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_AddToCart), @"mvc.1.0.view", @"/Views/Cart/AddToCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/AddToCart.cshtml", typeof(AspNetCore.Views_Cart_AddToCart))]
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
#line 1 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\_ViewImports.cshtml"
using Movies_MidTerm;

#line default
#line hidden
#line 2 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\_ViewImports.cshtml"
using Movies_MidTerm.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b48d5eee1cfab4d428c9f7ef5989741b9f70febf", @"/Views/Cart/AddToCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c582d4d2f5925218f408e4fbb67b855f877263ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_AddToCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\AddToCart.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 220, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row alert alert-success\">\r\n        <h4 class=\"pull-left\">Your Cart</h4><input type=\"button\" id=\"proccedtoShipping\" value=\"Proceed to Shipping\" class=\"btn btn-success pull-right\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 263, "\"", 320, 3);
            WriteAttributeValue("", 273, "location.href=\'", 273, 15, true);
#line 8 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\AddToCart.cshtml"
WriteAttributeValue("", 288, Url.Action("Index", "Address"), 288, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 319, "\'", 319, 1, true);
            EndWriteAttribute();
            BeginContext(321, 55, true);
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"row alert alert-info\">\r\n");
            EndContext();
#line 11 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\AddToCart.cshtml"
         foreach (var item in ViewBag.cartItems)
        {
            int i = 0;
            //var temp= JsonConvert.SerializeObject(movie);

#line default
#line hidden
            BeginContext(522, 131, true);
            WriteLiteral("            <div class=\"col-xs-2\">\r\n                <a href=\"#\" class=\"thumbnail\" style=\"width:135px;\">\r\n\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 653, "\"", 691, 1);
#line 18 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\AddToCart.cshtml"
WriteAttributeValue("", 659, Url.Content((string)item.image), 659, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(692, 144, true);
            WriteLiteral(" alt=\"ASP.NET\" class=\"img-responsive\" />\r\n\r\n                </a>\r\n                <strong class=\"text-uppercase text-danger\"> Title:</strong>   ");
            EndContext();
            BeginContext(837, 10, false);
#line 21 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\AddToCart.cshtml"
                                                                         Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(847, 83, true);
            WriteLiteral(" <br>\r\n                <strong class=\"text-uppercase text-danger\">Price :</strong>$");
            EndContext();
            BeginContext(931, 10, false);
#line 22 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\AddToCart.cshtml"
                                                                       Write(item.price);

#line default
#line hidden
            EndContext();
            BeginContext(941, 267, true);
            WriteLiteral(@"
                <div class=""text-success"">
                    <strong>  In Stock. </strong><br>              Eligible For Free Shipping <br />
                </div>
                <input type=""button"" id=""deleteFromCart"" value=""Delete"" class=""btn btn-primary""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1208, "\"", 1275, 3);
            WriteAttributeValue("", 1218, "location.href=\'", 1218, 15, true);
#line 26 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\AddToCart.cshtml"
WriteAttributeValue("", 1233, Url.Action("DeleteFromCart", "Cart",++i), 1233, 41, false);

#line default
#line hidden
            WriteAttributeValue("", 1274, "\'", 1274, 1, true);
            EndWriteAttribute();
            BeginContext(1276, 25, true);
            WriteLiteral(">\r\n\r\n            </div>\r\n");
            EndContext();
#line 30 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\AddToCart.cshtml"
                    

        }

#line default
#line hidden
            BeginContext(1338, 97, true);
            WriteLiteral("    </div>\r\n    <div class=\"col-xs-4 text-primary\" style=\"border-left:5px\"></div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591