#pragma checksum "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b04184ff1a1b76c739e37b2f986fb0bf176ec16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Softwares_Visualizar), @"mvc.1.0.view", @"/Views/Softwares/Visualizar.cshtml")]
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
#line 2 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Visualizar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Visualizar.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b04184ff1a1b76c739e37b2f986fb0bf176ec16", @"/Views/Softwares/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f717150c73b45b794f089d375627cb053b546dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Softwares_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGV.Models.Softwares>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/softwares/editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Visualizar.cshtml"
  
    ViewData["Title"] = "Visualizar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"">
    $(document).ready(function () {
        $(""input.valor"").maskMoney({ showSymbol: true, symbol: ""R$"", decimal: ""."", thousands: "","" });
    });
</script>
<!--Início do form de cadastro de usuários-->
<div class=""conteudo-inf-pessoais"">
    <div class=""primeiro-box-cadastrar"">
        <div class=""card"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b04184ff1a1b76c739e37b2f986fb0bf176ec164786", async() => {
                WriteLiteral(@"
                <div class=""card-body"">
                    <h4 class=""card-title"">Informações do Software/Licença</h4>
                    <div class=""form-group row"">
                        <label for=""fname""
                               class=""col-sm-3 text-end control-label col-form-label"">Nome</label>
                        <div class=""col-sm-9"">
                            <input hidden");
                BeginWriteAttribute("value", " value=\"", 998, "\"", 1015, 1);
#nullable restore
#line 24 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Visualizar.cshtml"
WriteAttributeValue("", 1006, Model.ID, 1006, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"id\" name=\"id\">\r\n                            <input readonly type=\"text\" class=\"form-control\" id=\"nome\"");
                BeginWriteAttribute("value", " value=\"", 1123, "\"", 1142, 1);
#nullable restore
#line 25 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Visualizar.cshtml"
WriteAttributeValue("", 1131, Model.Nome, 1131, 11, false);

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
                            <input readonly type=""text"" class=""form-control"" id=""responsavel""");
                BeginWriteAttribute("value", " value=\"", 1572, "\"", 1598, 1);
#nullable restore
#line 33 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Visualizar.cshtml"
WriteAttributeValue("", 1580, Model.Responsavel, 1580, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""lname"" class=""col-sm-3 text-end control-label col-form-label"">
                            Valor
                        </label>
                        <div class=""col-sm-9"">
                            <input readonly type=""text"" class=""valor"" id=""valor""");
                BeginWriteAttribute("value", " value=\"", 2009, "\"", 2074, 1);
#nullable restore
#line 41 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Visualizar.cshtml"
WriteAttributeValue("", 2017, Model.Valor.ToString("F2", CultureInfo.InvariantCulture), 2017, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""lname"" class=""col-sm-3 text-end control-label col-form-label"">
                            Data da Compra
                        </label>
                        <div class=""col-sm-9"">
                            <input readonly type=""text"" class=""form-control"" id=""datacompra""");
                BeginWriteAttribute("value", " value=\"", 2506, "\"", 2552, 2);
#nullable restore
#line 49 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Visualizar.cshtml"
WriteAttributeValue("", 2514, Model.DataCompra.ToShortDateString(), 2514, 37, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2551, "", 2552, 1, true);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""email1""
                               class=""col-sm-3 text-end control-label col-form-label"">Validade</label>
                        <div class=""col-sm-9"">
                            <input readonly type=""text"" class=""form-control"" id=""validade""");
                BeginWriteAttribute("value", " value=\"", 2953, "\"", 2976, 1);
#nullable restore
#line 56 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Visualizar.cshtml"
WriteAttributeValue("", 2961, Model.Validade, 2961, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label for=""email1""
                               class=""col-sm-3 text-end control-label col-form-label"">Data de vencimento</label>
                        <div class=""col-sm-9"">
                            <input readonly type=""text"" class=""form-control"" id=""vencimento""");
                BeginWriteAttribute("value", " value=\"", 3389, "\"", 3434, 1);
#nullable restore
#line 63 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Visualizar.cshtml"
WriteAttributeValue("", 3397, Model.Vencimento.ToShortDateString(), 3397, 37, false);

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
                            <textarea readonly class=""form-control"">");
#nullable restore
#line 70 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Visualizar.cshtml"
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
                        <a href=""/softwares/"" class=""btn btn-success text-white"">Voltar</a>
                        <a");
                BeginWriteAttribute("href", " href=\"", 4134, "\"", 4168, 2);
                WriteAttributeValue("", 4141, "/softwares/editar/", 4141, 18, true);
#nullable restore
#line 77 "C:\Apps\SGV\MVC\SGV_MVC\SGV\Views\Softwares\Visualizar.cshtml"
WriteAttributeValue("", 4159, Model.ID, 4159, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info\">Editar</a>\r\n                    </div>\r\n                </div>\r\n            ");
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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