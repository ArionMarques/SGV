#pragma checksum "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1743b162412898f25c9d24787fd64b8babce242e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AlteracaoFuncional_Visualizar), @"mvc.1.0.view", @"/Views/AlteracaoFuncional/Visualizar.cshtml")]
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
#line 2 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Visualizar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Visualizar.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1743b162412898f25c9d24787fd64b8babce242e", @"/Views/AlteracaoFuncional/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f717150c73b45b794f089d375627cb053b546dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_AlteracaoFuncional_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGV.Models.RecursosHumanos.AlteracaoFuncional>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/AlreacaoFuncional.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/alteracaofuncional/Salvar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\AlteracaoFuncional\Visualizar.cshtml"
  
    ViewData["Title"] = "Novo";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1743b162412898f25c9d24787fd64b8babce242e5348", async() => {
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
            WriteLiteral("\n<!--Início do cadastro de solicitação de acesso-->\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1743b162412898f25c9d24787fd64b8babce242e6512", async() => {
                WriteLiteral(@"
    <div class=""conteudo-inf-pessoais"">
        <div class=""primeiro-box-cadastrar"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Solicitação de Alteração Funcional</h5>
                    <div class=""form-group row"">
                        <label for=""fname""
                               class=""col-sm-3 text-end control-label col-form-label"">Nome Completo</label>
                        <div class=""col-sm-9"">
                            <input type=""text"" class=""form-control"" id=""Nome"" name=""nome"" readonly>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""fname""
                               class=""col-sm-3 text-end control-label col-form-label"">Setor de Origem</label>
                        <div class=""col-sm-9"">
                            <input type=""text"" class=""form-control"" id=""Nome"" name=""nome"" readonly>
                        </div>");
                WriteLiteral(@"
                    </div>
                    <div class=""form-group row"">
                        <label for=""fname""
                               class=""col-sm-3 text-end control-label col-form-label"">Função de Origem</label>
                        <div class=""col-sm-9"">
                            <input type=""text"" class=""form-control"" id=""Nome"" name=""nome"" readonly>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""fname""
                               class=""col-sm-3 text-end control-label col-form-label"">Cargo de Origem</label>
                        <div class=""col-sm-9"">
                            <input type=""text"" class=""form-control"" id=""Nome"" name=""nome"" readonly>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""Data_Comeco""
                               class=""col-sm-3 text-end control-label col-form-labe");
                WriteLiteral(@"l"">Início das atividades</label>
                        <div class=""col-sm-9"">
                            <input type=""date"" class=""form-control"" id=""Data_Comeco"" name=""Data_Comeco"" readonly>
                        </div>
                    </div>
                </div>
                <div class=""border-top"">
                    <div class=""card-body"">
                        <button type=""submit"" class=""btn btn-success text-white"" value=""gravar"" name=""submitButton"">Gravar</button>
                        <a href=""/alteracaofuncional/novo"" class=""btn btn-primary"">Limpar</a>
                        <a href=""/alteracaofuncional/"" class=""btn btn-danger text-white"">Cancelar</a>
                        <a href=""/alteracaofuncional/editar/"" class=""btn btn-info"">Editar</a>
                    </div>
                </div>

            </div>
        </div>
        <div class=""segundo-box-solicitar"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""card-title""");
                WriteLiteral(@"></h5>
                    <div class=""form-group row"">
                        <label for=""local"" class=""col-sm-3 text-end control-label col-form-label"">
                            Setor de destino
                        </label>
                        <div class=""col-md-9"">
                            <input type=""text"" class=""form-control"" id=""Nome"" name=""nome"" readonly>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""local"" class=""col-sm-3 text-end control-label col-form-label"">
                            Função de destino
                        </label>
                        <div class=""col-md-9"">
                            <input type=""text"" class=""form-control"" id=""Nome"" name=""nome"" readonly>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""local"" class=""col-sm-3 text-end control-label col-form-label"">
      ");
                WriteLiteral(@"                      Cargo de destino
                        </label>
                        <div class=""col-md-9"">
                            <input type=""text"" class=""form-control"" id=""Nome"" name=""nome"" readonly>
                        </div>
                    </div>
                    <div class=""check-box"">
                        <input class=""form-check-input"" type=""checkbox"" value=""true"" id=""AcessoInternet"" name=""AcessoInternet"" readonly>
                        <label class=""col-form-label"" for=""flexCheckChecked"">
                            Alterações efetivadas
                        </label>
                    </div>
                    <div class=""form-group row"" style=""margin-left:1.8%"" readonly>
                        <h6>Observações</h6>
                    </div>
                    <div class=""form-group row"">
                        <div class=""col-sm-9"">
                            <textarea class=""box-obs"" id=""observacoes"" name=""observacoes""></textarea>
                        <");
                WriteLiteral("/div>\n                    </div>\n                </div>\n\n            </div>\n        </div>\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGV.Models.RecursosHumanos.AlteracaoFuncional> Html { get; private set; }
    }
}
#pragma warning restore 1591