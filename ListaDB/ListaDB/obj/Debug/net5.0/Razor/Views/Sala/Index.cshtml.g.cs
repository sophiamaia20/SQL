#pragma checksum "C:\Users\android\Documents\MAIA C\ListaDB\ListaDB\Views\Sala\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0167e9c59eb04f072826e53760354ddefca7a896"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sala_Index), @"mvc.1.0.view", @"/Views/Sala/Index.cshtml")]
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
#line 1 "C:\Users\android\Documents\MAIA C\ListaDB\ListaDB\Views\_ViewImports.cshtml"
using ListaDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\android\Documents\MAIA C\ListaDB\ListaDB\Views\_ViewImports.cshtml"
using ListaDB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0167e9c59eb04f072826e53760354ddefca7a896", @"/Views/Sala/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97f84ae6743336c51fbd68fdc91e2cffafe090e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Sala_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Gestão de Salas</h2>\r\n<div>\r\n    <a class=\"btn btn-sucess\" href=\"Sala/Create\"> Novo</a>\r\n</div>\r\n<div>\r\n    <table>\r\n        <tr>\r\n            <td>#</td>\r\n            <td>Descricao</td>\r\n        </tr>\r\n");
#nullable restore
#line 16 "C:\Users\android\Documents\MAIA C\ListaDB\ListaDB\Views\Sala\Index.cshtml"
         foreach (var item in ViewBag.listasalas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\android\Documents\MAIA C\ListaDB\ListaDB\Views\Sala\Index.cshtml"
               Write(item.SALAID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\android\Documents\MAIA C\ListaDB\ListaDB\Views\Sala\Index.cshtml"
               Write(item.SALADESC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "C:\Users\android\Documents\MAIA C\ListaDB\ListaDB\Views\Sala\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
