#pragma checksum "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d886933a699172c6bb2819d2a04b758dfad12bfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Softwares_Editar), @"mvc.1.0.view", @"/Views/Softwares/Editar.cshtml")]
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
#line 2 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Editar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Editar.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d886933a699172c6bb2819d2a04b758dfad12bfc", @"/Views/Softwares/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f717150c73b45b794f089d375627cb053b546dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Softwares_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGV.Models.Softwares>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/softwares/atualizar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Editar.cshtml"
  
    ViewData["Title"] = "Editar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!--Início do form de cadastro de usuários-->\n<div class=\"conteudo-inf-pessoais\">\n    <div class=\"primeiro-box-cadastrar\">\n        <div class=\"card\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d886933a699172c6bb2819d2a04b758dfad12bfc4548", async() => {
                WriteLiteral(@"
                <div class=""card-body"">
                    <h4 class=""card-title"">Cadastro de informações do Software/Licença</h4>
                    <div class=""form-group row"">
                        <label for=""fname""
                               class=""col-sm-3 text-end control-label col-form-label"">Nome</label>
                        <div class=""col-sm-9"">
                            <input hidden id=""sidebar"" name=""id""");
                BeginWriteAttribute("value", " value=\"", 822, "\"", 839, 1);
#nullable restore
#line 20 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Editar.cshtml"
WriteAttributeValue("", 830, Model.ID, 830, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                            <input type=\"text\" class=\"form-control\" id=\"Nome\" placeholder=\"Digite o nome do software/licença\" name=\"nome\"");
                BeginWriteAttribute("value", " value=\"", 979, "\"", 998, 1);
#nullable restore
#line 21 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Editar.cshtml"
WriteAttributeValue("", 987, Model.Nome, 987, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""lname"" class=""col-sm-3 text-end control-label col-form-label"">
                            Responsável
                        </label>
                        <div class=""col-sm-9"">
                            <input type=""text"" class=""form-control"" id=""responsavel"" placeholder=""Digite o nome do responsável pelo software/licença"" name=""responsavel""");
                BeginWriteAttribute("value", " value=\"", 1495, "\"", 1521, 1);
#nullable restore
#line 29 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Editar.cshtml"
WriteAttributeValue("", 1503, Model.Responsavel, 1503, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""email1""
                               class=""col-sm-3 text-end control-label col-form-label"">Valor</label>
                        <div class=""col-sm-9"">
                            <input type=""text"" class=""valor"" id=""valor"" placeholder=""digite o valor"" name=""valor""");
                BeginWriteAttribute("value", " value=\"", 1935, "\"", 2000, 1);
#nullable restore
#line 36 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Editar.cshtml"
WriteAttributeValue("", 1943, Model.Valor.ToString("F2", CultureInfo.InvariantCulture), 1943, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""cono1""
                               class=""col-sm-3 text-end control-label col-form-label"">Data da Compra</label>
                        <div class=""col-sm-9"">
                            <input type=""date"" class=""form-control"" id=""datacompra"" name=""datacompra""");
                BeginWriteAttribute("value", " value=\"", 2410, "\"", 2488, 1);
#nullable restore
#line 43 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Editar.cshtml"
WriteAttributeValue("", 2418, Model.DataCompra.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), 2418, 70, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""cono1""
                               class=""col-sm-3 text-end control-label col-form-label"">Validade</label>
                        <div class=""col-sm-9"">
                            <input type=""text"" class=""form-control"" id=""validade"" placeholder=""digite a validade da licença"" name=""validade""");
                BeginWriteAttribute("value", " value=\"", 2931, "\"", 2954, 1);
#nullable restore
#line 50 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Editar.cshtml"
WriteAttributeValue("", 2939, Model.Validade, 2939, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""cono1""
                               class=""col-sm-3 text-end control-label col-form-label"">Data do Vencimento</label>
                        <div class=""col-sm-9"">
                            <input type=""date"" class=""form-control"" id=""vencimento"" name=""vencimento""");
                BeginWriteAttribute("value", " value=\"", 3368, "\"", 3446, 1);
#nullable restore
#line 57 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Editar.cshtml"
WriteAttributeValue("", 3376, Model.Vencimento.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), 3376, 70, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""cono1""
                               class=""col-sm-3 text-end control-label col-form-label"">Finalidade</label>
                        <div class=""col-sm-9"">
                            <textarea class=""form-control"" placeholder=""digite aqui a finalidade do software"" id=""finalidade"" name=""finalidade"">");
#nullable restore
#line 64 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Editar.cshtml"
                                                                                                                                           Write(Model.Finalidade);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                        </div>
                    </div>

                </div>
                <div class=""border-top"">
                    <div class=""card-body"">
                        <button type=""submit"" class=""btn btn-success text-white"" value=""gravar"" name=""submitButton"">Gravar</button>
                        <a href=""/softwares/novo"" class=""btn btn-primary"">Limpar</a>
                        <a href=""/softwares/"" class=""btn btn-danger text-white"">Cancelar</a>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGV.Models.Softwares> Html { get; private set; }
    }
}
#pragma warning restore 1591