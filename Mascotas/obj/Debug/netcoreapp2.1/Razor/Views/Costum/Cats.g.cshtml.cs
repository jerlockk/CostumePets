#pragma checksum "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Cats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "815afdbbb9e903c81db1b3dab7303475c5d5c7af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Costum_Cats), @"mvc.1.0.view", @"/Views/Costum/Cats.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Costum/Cats.cshtml", typeof(AspNetCore.Views_Costum_Cats))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815afdbbb9e903c81db1b3dab7303475c5d5c7af", @"/Views/Costum/Cats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d78754ddb0c6e5ecb42ce2e5fa8bf351c79da00", @"/Views/_ViewImports.cshtml")]
    public class Views_Costum_Cats : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("producto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("images-catalog img-effect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Cats.cshtml"
  
    ViewData["Title"] = "Para tu SuperCat";

#line default
#line hidden
            BeginContext(78, 89, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-8\">\n        <h2 class=\"text-center page-header\">");
            EndContext();
            BeginContext(168, 17, false);
#line 7 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Cats.cshtml"
                                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(185, 45, true);
            WriteLiteral("</h2>\n        <br>\n        <div class=\"row\">\n");
            EndContext();
#line 10 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Cats.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(285, 128, true);
            WriteLiteral("                <div class=\"col-md-3 text-center card-col\">\n                    <div class=\"card-prod\">\n                        ");
            EndContext();
            BeginContext(413, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34922d12c7c24ff08359d2909dd92602", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 423, "~/images/Products/", 423, 18, true);
#line 14 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Cats.cshtml"
AddHtmlAttributeValue("", 441, Html.DisplayFor(modelItem =>
                        item.Imagen.ImageUrl), 441, 75, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(567, 165, true);
            WriteLiteral("\n                        <div class=\"card-content\">\n                            <p class=\"text-italic title-bold\" style=\"margin: 0\">\n                                ");
            EndContext();
            BeginContext(733, 49, false);
#line 18 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Cats.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NombreProducto));

#line default
#line hidden
            EndContext();
            BeginContext(782, 153, true);
            WriteLiteral("\n                            </p>\n                            <hr style=\"margin: 0\">\n                            <p class=\"text-justify p-prod-truncate\">");
            EndContext();
            BeginContext(936, 46, false);
#line 21 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Cats.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(982, 55, true);
            WriteLiteral("</p>\n                            <p class=\"price-prod\">");
            EndContext();
            BeginContext(1038, 41, false);
#line 22 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Cats.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 86, true);
            WriteLiteral("</p>\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 26 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Cats.cshtml"
            }

#line default
#line hidden
            BeginContext(1179, 61, true);
            WriteLiteral("        </div>\n    </div>\n    <div class=\"col-md-4\">\n        ");
            EndContext();
            BeginContext(1241, 22, false);
#line 30 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Cats.cshtml"
   Write(Html.Partial("_Aside"));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 20, true);
            WriteLiteral("\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
