#pragma checksum "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e77ddf8591bea8d4f886259f16839a722a1d8e5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Costum_Posts), @"mvc.1.0.view", @"/Views/Costum/Posts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Costum/Posts.cshtml", typeof(AspNetCore.Views_Costum_Posts))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e77ddf8591bea8d4f886259f16839a722a1d8e5e", @"/Views/Costum/Posts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d78754ddb0c6e5ecb42ce2e5fa8bf351c79da00", @"/Views/_ViewImports.cshtml")]
    public class Views_Costum_Posts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductoPostMV>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("media-object"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image main"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Costum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
  
    ViewData["Title"] = "COSTUMBLOG";

#line default
#line hidden
            BeginContext(65, 135, true);
            WriteLiteral("<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-md-8\">\n            <h2 class=\"title-bold text-center title-blog\">");
            EndContext();
            BeginContext(201, 17, false);
#line 8 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
                                                     Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(218, 6, true);
            WriteLiteral("</h2>\n");
            EndContext();
#line 9 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
             foreach (var item in Model.Posts)
            {

#line default
#line hidden
            BeginContext(285, 105, true);
            WriteLiteral("                <div class=\"media\">\n                    <div class=\"media-left\">\n                        ");
            EndContext();
            BeginContext(390, 182, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "649bf42b30a749bc9cb9afa34adfabe5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 450, "~/images/Products/", 450, 18, true);
#line 14 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
AddHtmlAttributeValue("", 468, Html.DisplayFor(modelItem => item.Imagenes[0].ImageUrl), 468, 56, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(572, 209, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"media-body\">\n                        <p class=\"comment-cal\">\n                            <i class=\"far fa-comments\"></i>\n                            ");
            EndContext();
            BeginContext(782, 52, false);
#line 20 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Comentarios.Count));

#line default
#line hidden
            EndContext();
            BeginContext(834, 3, true);
            WriteLiteral(" |\n");
            EndContext();
#line 21 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
                              
                                var calificacion = 0.0;
                                var id = item.Id;
                                if (item.Calificaciones.Count > 0)
                                {
                                    calificacion = item.Calificaciones.Average(x => x.Valor);
                                }

                            

#line default
#line hidden
            BeginContext(1234, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 30 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
                             if ( calificacion == 0.0)
                            {

#line default
#line hidden
            BeginContext(1319, 60, true);
            WriteLiteral("                                <i class=\"far fa-star\"></i>\n");
            EndContext();
#line 33 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
                            }
                            else if(calificacion != Math.Floor(calificacion)) {
                                for (var i=0; i < calificacion-1; i++)
                                {

#line default
#line hidden
            BeginContext(1594, 64, true);
            WriteLiteral("                                    <i class=\"fas fa-star\"></i>\n");
            EndContext();
#line 38 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
                                }

#line default
#line hidden
            BeginContext(1692, 69, true);
            WriteLiteral("                                <i class=\"fas fa-star-half-alt\"></i>\n");
            EndContext();
#line 40 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
                            }
                            else
                            {
                                for (var i=0; i < calificacion; i++)
                                {

#line default
#line hidden
            BeginContext(1957, 64, true);
            WriteLiteral("                                    <i class=\"fas fa-star\"></i>\n");
            EndContext();
#line 46 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(2085, 79, true);
            WriteLiteral("                        </p>\n                        <h4 class=\"media-heading\">");
            EndContext();
            BeginContext(2165, 41, false);
#line 49 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(2206, 37, true);
            WriteLiteral("</h4>\n                        <small>");
            EndContext();
            BeginContext(2244, 51, false);
#line 50 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
                          Write(Html.DisplayFor(modelItem => item.FechaPublicacion));

#line default
#line hidden
            EndContext();
            BeginContext(2295, 36, true);
            WriteLiteral("</small>\n                        <p>");
            EndContext();
            BeginContext(2332, 44, false);
#line 51 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Contenido));

#line default
#line hidden
            EndContext();
            BeginContext(2376, 29, true);
            WriteLiteral("</p>\n                        ");
            EndContext();
            BeginContext(2405, 191, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de6b403b80054af5a4eaaabd61edfd51", async() => {
                BeginContext(2532, 60, true);
                WriteLiteral("\n                           Ver más\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
                                                                       WriteLiteral(id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2596, 72, true);
            WriteLiteral("\n                    </div>\n                </div>\n                <br>\n");
            EndContext();
#line 59 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
            }

#line default
#line hidden
            BeginContext(2682, 58, true);
            WriteLiteral("        </div>\n        <div class=\"col-md-4\">\n            ");
            EndContext();
            BeginContext(2741, 22, false);
#line 62 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Posts.cshtml"
       Write(Html.Partial("_Aside"));

#line default
#line hidden
            EndContext();
            BeginContext(2763, 35, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductoPostMV> Html { get; private set; }
    }
}
#pragma warning restore 1591