#pragma checksum "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c96bcd6766917a5f12d436444dd11393c74964d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AlteracaoFuncional_Index), @"mvc.1.0.view", @"/Views/AlteracaoFuncional/Index.cshtml")]
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
#line 1 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\_ViewImports.cshtml"
using SGV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\_ViewImports.cshtml"
using SGV.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c96bcd6766917a5f12d436444dd11393c74964d3", @"/Views/AlteracaoFuncional/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f717150c73b45b794f089d375627cb053b546dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_AlteracaoFuncional_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<SGV.Models.RecursosHumanos.AlteracaoFuncional>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/alteracaofuncional/editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c96bcd6766917a5f12d436444dd11393c74964d35524", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c96bcd6766917a5f12d436444dd11393c74964d36636", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">
        <!-- Page Content  -->
        <div id=""content"">
            <table class=""table table-striped"" id=""tbUsuarios"">
                <thead>
                    <tr>
                        <th scope=""col"" class=""table-venax"">#</th>
                        <th scope=""col"" class=""table-venax"">Nome do Funcionário</th>
                        <th scope=""col"" class=""table-venax"">Setor destino</th>
                        <th scope=""col"" class=""table-venax"">Status</th>
                        <th scope=""col"" class=""table-venax"">Ação</th>
                        <th scope=""col"" class=""table-venax"">
                            <a href=""/alteracaofuncional/novo"">Novo</a>
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 29 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Index.cshtml"
                     foreach (var AlteracaoFuncional in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 32 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Index.cshtml"
                           Write(AlteracaoFuncional.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 33 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Index.cshtml"
                           Write(AlteracaoFuncional.NomeFuncionario);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 34 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Index.cshtml"
                           Write(AlteracaoFuncional.SetorDestino);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td>Aberto</td>\n                            <td>\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1590, "\"", 1650, 2);
                WriteAttributeValue("", 1597, "/AlteracaoFuncional/visualizar/", 1597, 31, true);
#nullable restore
#line 37 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Index.cshtml"
WriteAttributeValue("", 1628, AlteracaoFuncional.Id, 1628, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn\">Visualizar</a>\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1713, "\"", 1769, 2);
                WriteAttributeValue("", 1720, "/AlteracaoFuncional/editar/", 1720, 27, true);
#nullable restore
#line 38 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Index.cshtml"
WriteAttributeValue("", 1747, AlteracaoFuncional.Id, 1747, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn\">Editar</a>\n                            </td>\n                            <td></td>\n                        </tr>\n");
#nullable restore
#line 42 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\n            </table>\n            ");
#nullable restore
#line 45 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Index.cshtml"
       Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<SGV.Models.RecursosHumanos.AlteracaoFuncional>> Html { get; private set; }
    }
}
#pragma warning restore 1591
