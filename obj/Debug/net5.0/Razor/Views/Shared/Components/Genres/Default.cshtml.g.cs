#pragma checksum "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Shared\Components\Genres\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fd4d80ee32d85aae14e6adbecea41834a132131"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Genres_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Genres/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd4d80ee32d85aae14e6adbecea41834a132131", @"/Views/Shared/Components/Genres/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc14869ebf8ca368e2cf85367b8547d3bc59494a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Genres_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Genre>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\">\r\n    <a href=\"/movies/list\"");
            BeginWriteAttribute("class", " \r\n       class=\"", 74, "\"", 187, 3);
            WriteAttributeValue("", 91, "list-group-item", 91, 15, true);
            WriteAttributeValue(" ", 106, "list-group-item-action", 107, 23, true);
#nullable restore
#line 5 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue("\r\n        ", 129, ViewBag.SelectedGenre == null ? "active" : "", 139, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">All Films</a>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Shared\Components\Genres\Default.cshtml"
     foreach (var genre in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 258, "\"", 292, 2);
            WriteAttributeValue("", 265, "/movies/list/", 265, 13, true);
#nullable restore
#line 10 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue("", 278, genre.GenreId, 278, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", "\r\n           class=\"", 293, "\"", 433, 3);
            WriteAttributeValue("", 313, "list-group-item", 313, 15, true);
            WriteAttributeValue(" ", 328, "list-group-item-action", 329, 23, true);
#nullable restore
#line 11 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue(" \r\n           ", 351, ViewBag.SelectedGenre == genre.GenreId.ToString() ? "active" : "", 365, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 13 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Shared\Components\Genres\Default.cshtml"
Write(genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 14 "C:\Users\SAMSUNG\source\repos\MovieApp\MovieApp.Web\Views\Shared\Components\Genres\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Genre>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
