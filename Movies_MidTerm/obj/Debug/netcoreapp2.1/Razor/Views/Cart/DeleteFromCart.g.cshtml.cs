#pragma checksum "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\DeleteFromCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94a0f36ffa449201cb9f40aac57d758a9ec58101"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_DeleteFromCart), @"mvc.1.0.view", @"/Views/Cart/DeleteFromCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/DeleteFromCart.cshtml", typeof(AspNetCore.Views_Cart_DeleteFromCart))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94a0f36ffa449201cb9f40aac57d758a9ec58101", @"/Views/Cart/DeleteFromCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c582d4d2f5925218f408e4fbb67b855f877263ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_DeleteFromCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\DeleteFromCart.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 237, true);
            WriteLiteral("\r\n<h2>Your Cart</h2>\r\n<div class=\"container\">\r\n    <div class=\"row alert alert-info\">\r\n        <h4 class=\"pull-left\">Your Cart</h4><input type=\"button\" id=\"proccedtoShipping\" value=\"Proceed to Shipping\" class=\"btn btn-success pull-right\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 280, "\"", 337, 3);
            WriteAttributeValue("", 290, "location.href=\'", 290, 15, true);
#line 9 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\DeleteFromCart.cshtml"
WriteAttributeValue("", 305, Url.Action("Index", "Address"), 305, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 336, "\'", 336, 1, true);
            EndWriteAttribute();
            BeginContext(338, 59, true);
            WriteLiteral(">\r\n    </div>\r\n        <div class=\"row alert alert-info\">\r\n");
            EndContext();
#line 12 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\DeleteFromCart.cshtml"
             foreach (var item in ViewBag.cartItems)
        {
            int i = 0;
            //var temp= JsonConvert.SerializeObject(movie);

#line default
#line hidden
            BeginContext(547, 131, true);
            WriteLiteral("            <div class=\"col-xs-2\">\r\n                <a href=\"#\" class=\"thumbnail\" style=\"width:135px;\">\r\n\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 678, "\"", 716, 1);
#line 19 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\DeleteFromCart.cshtml"
WriteAttributeValue("", 684, Url.Content((string)item.image), 684, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(717, 144, true);
            WriteLiteral(" alt=\"ASP.NET\" class=\"img-responsive\" />\r\n\r\n                </a>\r\n                <strong class=\"text-uppercase text-danger\"> Title:</strong>   ");
            EndContext();
            BeginContext(862, 10, false);
#line 22 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\DeleteFromCart.cshtml"
                                                                         Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(872, 83, true);
            WriteLiteral(" <br>\r\n                <strong class=\"text-uppercase text-danger\">Price :</strong>$");
            EndContext();
            BeginContext(956, 10, false);
#line 23 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\DeleteFromCart.cshtml"
                                                                       Write(item.price);

#line default
#line hidden
            EndContext();
            BeginContext(966, 267, true);
            WriteLiteral(@"
                <div class=""text-success"">
                    <strong>  In Stock. </strong><br>              Eligible For Free Shipping <br />
                </div>
                <input type=""button"" id=""deleteFromCart"" value=""Delete"" class=""btn btn-primary""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1233, "\"", 1300, 3);
            WriteAttributeValue("", 1243, "location.href=\'", 1243, 15, true);
#line 27 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\DeleteFromCart.cshtml"
WriteAttributeValue("", 1258, Url.Action("DeleteFromCart", "Cart",++i), 1258, 41, false);

#line default
#line hidden
            WriteAttributeValue("", 1299, "\'", 1299, 1, true);
            EndWriteAttribute();
            BeginContext(1301, 25, true);
            WriteLiteral(">\r\n\r\n            </div>\r\n");
            EndContext();
#line 31 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Cart\DeleteFromCart.cshtml"
                    

        }

#line default
#line hidden
            BeginContext(1363, 109, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-xs-4 text-primary\" style=\"border-left:5px\"></div>\r\n\r\n    </div>\r\n\r\n\r\n");
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
