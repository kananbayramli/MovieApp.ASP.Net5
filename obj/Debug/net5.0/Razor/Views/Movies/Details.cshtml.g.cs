#pragma checksum "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7189524ca85c0bc22cc43c132c348887e8aba90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\_ViewImports.cshtml"
using MovieApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7189524ca85c0bc22cc43c132c348887e8aba90", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18ddcc480ea34491095b40e6478b06e4a93bfa08", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 107, "\"", 133, 2);
            WriteAttributeValue("", 113, "/img/", 113, 5, true);
#nullable restore
#line 6 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\Details.cshtml"
WriteAttributeValue("", 118, Model.ImageUrl, 118, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\" />\r\n        </div>\r\n\r\n        <div class=\"col-md-9\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\Details.cshtml"
                                  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\Details.cshtml"
                                Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">");
#nullable restore
#line 13 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\Details.cshtml"
                                Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\Details.cshtml"
                 if (Model.Acters != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        <ul>\r\n");
#nullable restore
#line 18 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\Details.cshtml"
                             foreach (var acter in Model.Acters)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 20 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\Details.cshtml"
                               Write(acter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 21 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </p>\r\n");
#nullable restore
#line 24 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
