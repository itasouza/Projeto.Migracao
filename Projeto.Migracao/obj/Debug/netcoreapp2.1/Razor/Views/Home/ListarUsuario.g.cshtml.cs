#pragma checksum "C:\Teste\Projeto.Migracao\Projeto.Migracao\Views\Home\ListarUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5e4b62b3cf7dfdd9702083a385ed1fb65ea2cc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListarUsuario), @"mvc.1.0.view", @"/Views/Home/ListarUsuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListarUsuario.cshtml", typeof(AspNetCore.Views_Home_ListarUsuario))]
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
#line 1 "C:\Teste\Projeto.Migracao\Projeto.Migracao\Views\_ViewImports.cshtml"
using Projeto.Migracao;

#line default
#line hidden
#line 2 "C:\Teste\Projeto.Migracao\Projeto.Migracao\Views\_ViewImports.cshtml"
using Projeto.Migracao.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5e4b62b3cf7dfdd9702083a385ed1fb65ea2cc2", @"/Views/Home/ListarUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"857571d538f80cd75ed4f6e8322f7fdc53c59587", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListarUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Projeto.Migracao.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Teste\Projeto.Migracao\Projeto.Migracao\Views\Home\ListarUsuario.cshtml"
  
    ViewData["Title"] = "ListarUsuario";

#line default
#line hidden
            BeginContext(104, 65, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n\r\n        <br />\r\n        <br />\r\n");
            EndContext();
#line 11 "C:\Teste\Projeto.Migracao\Projeto.Migracao\Views\Home\ListarUsuario.cshtml"
         if (TempData["confirmacao"] != null)
        {


#line default
#line hidden
            BeginContext(229, 184, true);
            WriteLiteral("            <div class=\"alert alert-success alert-dismissible\">\r\n                <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n                <strong>");
            EndContext();
            BeginContext(414, 23, false);
#line 16 "C:\Teste\Projeto.Migracao\Projeto.Migracao\Views\Home\ListarUsuario.cshtml"
                   Write(TempData["confirmacao"]);

#line default
#line hidden
            EndContext();
            BeginContext(437, 31, true);
            WriteLiteral("</strong>\r\n            </div>\r\n");
            EndContext();
#line 18 "C:\Teste\Projeto.Migracao\Projeto.Migracao\Views\Home\ListarUsuario.cshtml"

        }

#line default
#line hidden
            BeginContext(481, 44, true);
            WriteLiteral("\r\n        <p id=\"btnControle\">\r\n            ");
            EndContext();
            BeginContext(525, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2fd7944b49a44a4bc9a5d26df3ebdd6", async() => {
                BeginContext(603, 9, true);
                WriteLiteral("Adicionar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(616, 364, true);
            WriteLiteral(@"
        </p>



        <table id=""dados"" class=""table table-hover  table-striped display responsive nowrap table-sm "" cellspacing=""0"" width=""100%"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Login</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 36 "C:\Teste\Projeto.Migracao\Projeto.Migracao\Views\Home\ListarUsuario.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1045, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1100, 8, false);
#line 39 "C:\Teste\Projeto.Migracao\Projeto.Migracao\Views\Home\ListarUsuario.cshtml"
                       Write(item.iid);

#line default
#line hidden
            EndContext();
            BeginContext(1108, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1144, 10, false);
#line 40 "C:\Teste\Projeto.Migracao\Projeto.Migracao\Views\Home\ListarUsuario.cshtml"
                       Write(item.login);

#line default
#line hidden
            EndContext();
            BeginContext(1154, 110, true);
            WriteLiteral("</td>\r\n                        <td class=\"text-right\">\r\n                            <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1264, "\"", 1300, 2);
            WriteAttributeValue("", 1271, "/home/EditarUsuario/", 1271, 20, true);
#line 42 "C:\Teste\Projeto.Migracao\Projeto.Migracao\Views\Home\ListarUsuario.cshtml"
WriteAttributeValue("", 1291, item.iid, 1291, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1301, 67, true);
            WriteLiteral(">Editar</a>|\r\n                            <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1368, "\"", 1398, 2);
            WriteAttributeValue("", 1375, "/home/Deletar/", 1375, 14, true);
#line 43 "C:\Teste\Projeto.Migracao\Projeto.Migracao\Views\Home\ListarUsuario.cshtml"
WriteAttributeValue("", 1389, item.iid, 1389, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1399, 75, true);
            WriteLiteral(">Deletar</a>|\r\n                        </td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 47 "C:\Teste\Projeto.Migracao\Projeto.Migracao\Views\Home\ListarUsuario.cshtml"
                }

#line default
#line hidden
            BeginContext(1493, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n\r\n\r\n    </div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1571, 1357, true);
                WriteLiteral(@"
    <script>

        $(document).ready(function () {

             $('#dados').DataTable({
                ""orderMulti"": false,
                ""paging"": true,
                ""info"":false,
                 ""language"": {
                    ""lengthMenu"": ""Visualizando _MENU_ Registros por página"",
                    ""zeroRecords"": ""Não existe registros para visualização"",
                    ""info"": ""Mostrando página _PAGE_ de _PAGES_"",
                    ""infoEmpty"": ""No records available"",
                    ""sLoadingRecords"": ""Carregando..."",
                    ""sProcessing"": ""Processando..."",
                    ""sZeroRecords"": ""Nenhum registro encontrado"",
                    ""sSearch"": ""Pesquisar"",
                    ""infoFiltered"": ""(filtered from _MAX_ total records)"",
                    ""oPaginate"": {
                        ""sNext"": ""Próximo"",
                        ""sPrevious"": ""Anterior"",
                        ""sFirst"": ""Primeiro"",
                        ""sLast"":");
                WriteLiteral(@" ""Último""
                    },
                    ""oAria"": {
                        ""sSortAscending"": "": Ordenar colunas de forma ascendente"",
                        ""sSortDescending"": "": Ordenar colunas de forma descendente""
                    }
                }
            });

        });

    </script>



");
                EndContext();
            }
            );
            BeginContext(2931, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Projeto.Migracao.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
