#pragma checksum "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c47d290baa3d51c0c254a1e5d595a8008445a660"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Costum_Post), @"mvc.1.0.view", @"/Views/Costum/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Costum/Post.cshtml", typeof(AspNetCore.Views_Costum_Post))]
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
#line 1 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/_ViewImports.cshtml"
using Mascotas;

#line default
#line hidden
#line 2 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/_ViewImports.cshtml"
using Mascotas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c47d290baa3d51c0c254a1e5d595a8008445a660", @"/Views/Costum/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d78754ddb0c6e5ecb42ce2e5fa8bf351c79da00", @"/Views/_ViewImports.cshtml")]
    public class Views_Costum_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Post.cshtml"
  
    ViewData["Title"] = "COSTUMBLOG";

#line default
#line hidden
            BeginContext(55, 169, true);
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-md-8\">\n            <h3 class=\"text-center text-uppercase page-header title-bold\">\n                ");
            EndContext();
            BeginContext(225, 42, false);
#line 10 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Post.cshtml"
           Write(Html.DisplayFor(itemModel => Model.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(267, 85, true);
            WriteLiteral("\n            </h3>\n            <p class=\"text-center\">\n                Publicado en: ");
            EndContext();
            BeginContext(353, 52, false);
#line 13 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Post.cshtml"
                         Write(Html.DisplayFor(itemModel => Model.FechaPublicacion));

#line default
#line hidden
            EndContext();
            BeginContext(405, 68, true);
            WriteLiteral(" por CostumPet\n            </p>\n            <p class=\"text-center\">\n");
            EndContext();
#line 16 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Post.cshtml"
                  
                    var calificacion = 0.0;
                    if (Model.Calificaciones.Count > 1)
                    {
                        calificacion = Model.Calificaciones.Average(x => x.Valor);
                    }

                

#line default
#line hidden
            BeginContext(738, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 24 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Post.cshtml"
                 if ( calificacion == 0.0)
                {

#line default
#line hidden
            BeginContext(799, 48, true);
            WriteLiteral("                    <i class=\"far fa-star\"></i>\n");
            EndContext();
#line 27 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Post.cshtml"
                }
                else if(calificacion != Math.Floor(calificacion)) {
                    for (var i=0; i < calificacion-1; i++)
                    {

#line default
#line hidden
            BeginContext(1014, 52, true);
            WriteLiteral("                        <i class=\"fas fa-star\"></i>\n");
            EndContext();
#line 32 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Post.cshtml"
                    }

#line default
#line hidden
            BeginContext(1088, 57, true);
            WriteLiteral("                    <i class=\"fas fa-star-half-alt\"></i>\n");
            EndContext();
#line 34 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Post.cshtml"
                }
                else
                {
                    for (var i=0; i < calificacion; i++)
                    {

#line default
#line hidden
            BeginContext(1281, 52, true);
            WriteLiteral("                        <i class=\"fas fa-star\"></i>\n");
            EndContext();
#line 40 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Post.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1373, 75, true);
            WriteLiteral("            </p>\n        </div>\n        <div class=\"col-md-4\">\n            ");
            EndContext();
            BeginContext(1449, 22, false);
#line 45 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Post.cshtml"
       Write(Html.Partial("_Aside"));

#line default
#line hidden
            EndContext();
            BeginContext(1471, 33, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
