#pragma checksum "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Animation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "154b5bf73ba8b4a17d708c68362f28c0f3b11043"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animation_Index), @"mvc.1.0.view", @"/Views/Animation/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Animation/Index.cshtml", typeof(AspNetCore.Views_Animation_Index))]
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
#line 1 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Animation\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"154b5bf73ba8b4a17d708c68362f28c0f3b11043", @"/Views/Animation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c582d4d2f5925218f408e4fbb67b855f877263ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Animation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Animation\Index.cshtml"
  
    ViewData["Title"] = "Animation";

#line default
#line hidden
            BeginContext(72, 96, true);
            WriteLiteral("\r\n<h2>Animation Movies</h2>\r\n<div class=\"container alert alert-danger\">\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 10 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Animation\Index.cshtml"
         foreach (var movie in ViewBag.movies)
        {
            //var temp= JsonConvert.SerializeObject(movie);

#line default
#line hidden
            BeginContext(288, 199, true);
            WriteLiteral("            <div class=\"row\" style=\"margin-left:0px;\">\r\n                <div class=\"col-xs-2\">\r\n                    <a href=\"#\" class=\"thumbnail\" style=\"width:135px;\">\r\n\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 487, "\"", 526, 1);
#line 17 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Animation\Index.cshtml"
WriteAttributeValue("", 493, Url.Content((string)movie.image), 493, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(527, 275, true);
            WriteLiteral(@" alt=""ASP.NET"" class=""img-responsive"" />

                    </a>
                </div>
                <div class=""col-xs-6 text-primary"" style=""font-family: 'Open Sans', sans-serif;"">
                    <strong class=""text-uppercase text-danger""> Title:</strong>   ");
            EndContext();
            BeginContext(803, 11, false);
#line 22 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Animation\Index.cshtml"
                                                                             Write(movie.title);

#line default
#line hidden
            EndContext();
            BeginContext(814, 96, true);
            WriteLiteral(" <br>\r\n                    <strong class=\"text-uppercase text-danger\">Description:</strong>     ");
            EndContext();
            BeginContext(911, 17, false);
#line 23 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Animation\Index.cshtml"
                                                                                    Write(movie.description);

#line default
#line hidden
            EndContext();
            BeginContext(928, 96, true);
            WriteLiteral(" <br>\r\n                    <strong class=\"text-uppercase text-danger\">    Director:</strong>    ");
            EndContext();
            BeginContext(1025, 14, false);
#line 24 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Animation\Index.cshtml"
                                                                                    Write(movie.director);

#line default
#line hidden
            EndContext();
            BeginContext(1039, 94, true);
            WriteLiteral(" <br>\r\n                    <strong class=\"text-uppercase text-danger\">    Writer: </strong>   ");
            EndContext();
            BeginContext(1134, 12, false);
#line 25 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Animation\Index.cshtml"
                                                                                  Write(movie.writer);

#line default
#line hidden
            EndContext();
            BeginContext(1146, 89, true);
            WriteLiteral(" <br>\r\n                    <strong class=\"text-uppercase text-danger\">Stars:</strong>    ");
            EndContext();
            BeginContext(1236, 11, false);
#line 26 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Animation\Index.cshtml"
                                                                             Write(movie.stars);

#line default
#line hidden
            EndContext();
            BeginContext(1247, 87, true);
            WriteLiteral(" <br>\r\n                    <strong class=\"text-uppercase text-danger\">Price :</strong>$");
            EndContext();
            BeginContext(1335, 11, false);
#line 27 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Animation\Index.cshtml"
                                                                           Write(movie.price);

#line default
#line hidden
            EndContext();
            BeginContext(1346, 311, true);
            WriteLiteral(@"

                    <div class=""text-success"">
                        <strong>  In Stock. </strong>                Ships from and sold by MovieBuzz. Gift-wrap available. <br />
                    </div>
                    <input type=""button"" id=""addToCart"" value=""Add to Cart"" class=""btn btn-primary""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1657, "\"", 1896, 3);
            WriteAttributeValue("", 1667, "location.href=\'", 1667, 15, true);
#line 32 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Animation\Index.cshtml"
WriteAttributeValue("", 1682, Url.Action("AddToCart", "Cart",new { id =movie.id, title = movie.title, description=movie.description ,director=movie.director , writer=movie.writer ,stars=movie.stars, trailer=movie.trailer ,image=movie.image }), 1682, 213, false);

#line default
#line hidden
            WriteAttributeValue("", 1895, "\'", 1895, 1, true);
            EndWriteAttribute();
            BeginContext(1897, 209, true);
            WriteLiteral(">\r\n\r\n                </div>\r\n                <div class=\"col-xs-4 text-primary\">\r\n                    <strong> Watch the trailor </strong>\r\n                    <iframe type=\"text/html\" width=\"300\" height=\"200\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2106, "\"", 2126, 1);
#line 37 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Animation\Index.cshtml"
WriteAttributeValue("", 2112, movie.trailer, 2112, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2127, 92, true);
            WriteLiteral(" frameborder=\"0\"></iframe>\r\n\r\n                </div>\r\n            </div>\r\n            <hr>\r\n");
            EndContext();
#line 42 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Animation\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(2232, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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