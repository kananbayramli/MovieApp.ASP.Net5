#pragma checksum "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e41892506114433aed9aed61efcd6e6c3e32c3df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_List), @"mvc.1.0.view", @"/Views/Movies/List.cshtml")]
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
#nullable restore
#line 2 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\_ViewImports.cshtml"
using MovieApp.Web.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e41892506114433aed9aed61efcd6e6c3e32c3df", @"/Views/Movies/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc14869ebf8ca368e2cf85367b8547d3bc59494a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoviesViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Film List</h1>\r\n\r\n\r\n\r\n");
#nullable restore
#line 7 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\List.cshtml"
 if (Model.Movies.Count() > 0)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\List.cshtml"
     foreach (var movie in Model.Movies)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\List.cshtml"
   Write(await Html.PartialAsync("_movie", movie));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\List.cshtml"
                                                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\List.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        Bu kateqoriyada film tapilmadi . . .\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\List.cshtml"
 if (TempData["message"] != null)
{
    

#line default
#line hidden
#nullable disable
            DefineSection("message", async() => {
                WriteLiteral("\r\n        ");
#nullable restore
#line 26 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\List.cshtml"
   Write(await Html.PartialAsync("_message",(string)TempData["message"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
#nullable restore
#line 27 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\List.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            DefineSection("menu", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("\r\n    ");
#nullable restore
#line 38 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Movies\List.cshtml"
Write(await Component.InvokeAsync("Genres"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoviesViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
