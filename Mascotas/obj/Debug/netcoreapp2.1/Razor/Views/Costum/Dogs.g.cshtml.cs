#pragma checksum "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Dogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99a4f3ce7d9605452e6eb748a15491358e534e39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Costum_Dogs), @"mvc.1.0.view", @"/Views/Costum/Dogs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Costum/Dogs.cshtml", typeof(AspNetCore.Views_Costum_Dogs))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99a4f3ce7d9605452e6eb748a15491358e534e39", @"/Views/Costum/Dogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d78754ddb0c6e5ecb42ce2e5fa8bf351c79da00", @"/Views/_ViewImports.cshtml")]
    public class Views_Costum_Dogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("producto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("images-catalog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Dogs.cshtml"
  
    ViewData["Title"] = "Para tu SuperCan";

#line default
#line hidden
            BeginContext(78, 89, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-9\">\n        <h2 class=\"text-center page-header\">");
            EndContext();
            BeginContext(168, 17, false);
#line 7 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Dogs.cshtml"
                                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(185, 45, true);
            WriteLiteral("</h2>\n        <br>\n        <div class=\"row\">\n");
            EndContext();
#line 10 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Dogs.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(285, 128, true);
            WriteLiteral("                <div class=\"col-md-3 text-center card-col\">\n                    <div class=\"card-prod\">\n                        ");
            EndContext();
            BeginContext(413, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "469ef29b1d9c48498e2eaeae38837c1b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 423, "~/images/Products/", 423, 18, true);
#line 14 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Dogs.cshtml"
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
            BeginContext(556, 165, true);
            WriteLiteral("\n                        <div class=\"card-content\">\n                            <p class=\"text-italic title-bold\" style=\"margin: 0\">\n                                ");
            EndContext();
            BeginContext(722, 49, false);
#line 18 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Dogs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NombreProducto));

#line default
#line hidden
            EndContext();
            BeginContext(771, 137, true);
            WriteLiteral("\n                            </p>\n                            <hr style=\"margin: 0\">\n                            <p class=\"text-justify\">");
            EndContext();
            BeginContext(909, 46, false);
#line 21 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Dogs.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(955, 55, true);
            WriteLiteral("</p>\n                            <p class=\"price-prod\">");
            EndContext();
            BeginContext(1011, 41, false);
#line 22 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Dogs.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 86, true);
            WriteLiteral("</p>\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 26 "/home/jerlock/RiderProjects/CostumePets/Mascotas/Views/Costum/Dogs.cshtml"
            }

#line default
#line hidden
            BeginContext(1152, 67, true);
            WriteLiteral("        </div>\n    </div>\n    <div class=\"col-md-3\"></div>\n</div>\n\n");
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
