#pragma checksum "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59e7f4ba2148c55e94e9d8f1f4c47dd03c3887eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posvendas_Index), @"mvc.1.0.view", @"/Views/Posvendas/Index.cshtml")]
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
#line 1 "C:\Apps\SGV\MVC\SGV\SGV\Views\_ViewImports.cshtml"
using SGV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Apps\SGV\MVC\SGV\SGV\Views\_ViewImports.cshtml"
using SGV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e7f4ba2148c55e94e9d8f1f4c47dd03c3887eb", @"/Views/Posvendas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"917b74d9a1722968b4a305780b3999da314cb4c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Posvendas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Usuario.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
  
    ViewData["Title"] = "Relatorio";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://cdn.jsdelivr.net/npm/chart.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "59e7f4ba2148c55e94e9d8f1f4c47dd03c3887eb4609", async() => {
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
            WriteLiteral("\r\n<script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\" crossorigin=\"anonymous\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59e7f4ba2148c55e94e9d8f1f4c47dd03c3887eb5941", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">
        <!-- Page Content  -->
        <div id=""content"">
            
            <div class=""grupo-entrada"">
                <div class=""col-4"">
                    <div class=""list-group"" id=""list-tab"" role=""tablist"">
                        <a class=""list-group-item list-group-item-action ativo"" id=""list-menu-list"" data-bs-toggle=""list"" href=""#"" role=""tab"" aria-controls=""list-menu"">Relatórios</a>
                        <a class=""list-group-item list-group-item-action active"" id=""list-informatica-list"" data-bs-toggle=""list"" href=""#list-informatica"" role=""tab"" aria-controls=""list-home"">Total de chamados abertos por atendente</a>
                        <a class=""list-group-item list-group-item-action"" id=""list-comercial-list"" data-bs-toggle=""list"" href=""#list-comercial"" role=""tab"" aria-controls=""list-profile"">Chamados por top 10 produtos</a>
                        <a class=""list-group-item list-group-item-action"" id=""list-producao-list"" data-bs-toggle=""list"" href=""#li");
                WriteLiteral(@"st-UF"" role=""tab"" aria-controls=""list-messages"">Chamados por UF</a>
                        <a class=""list-group-item list-group-item-action"" id=""list-compras-list"" data-bs-toggle=""list"" href=""#list-abertos"" role=""tab"" aria-controls=""list-messages"">Chamados abertos e não encerrados</a>
                    </div>
                </div>
                <div class=""col-8"">
                    <div class=""tab-content"" id=""nav-tabContent"">
                        <div class=""tab-pane fade show active"" id=""list-informatica"" role=""tabpanel"" aria-labelledby=""list-home-list"">
                            <div class=""col-4"">
                                <canvas id=""myChart"" width=""400"" height=""400""></canvas>
                                <script>
                                    const ctx = document.getElementById('myChart').getContext('2d');
                                    const myChart = new Chart(ctx, {
                                        type: 'bar',
                                     ");
                WriteLiteral(@"   data: {
                                            labels: [""Wellington"", ""Rafaela"", ""Carla"", ""Ana Paula"", ""Thiago"", ""Jonas""],
                                            datasets: [{
                                                label: 'Total de chamados abertos por atendente',
                                                data: [");
#nullable restore
#line 37 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                  Write(ViewBag.AbertosWellington);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 37 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                                              Write(ViewBag.AbertosRafaela);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 37 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                                                                       Write(ViewBag.AbertosCarla);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 37 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                                                                                              Write(ViewBag.AbertosAna);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 37 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                                                                                                                   Write(ViewBag.AbertosThiago);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 37 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                                                                                                                                           Write(ViewBag.AbertosJonas);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
                                                backgroundColor: [
                                                    'rgba(255, 99, 132, 0.2)',
                                                    'rgba(54, 162, 235, 0.2)',
                                                    'rgba(255, 206, 86, 0.2)',
                                                    'rgba(75, 192, 192, 0.2)'
                                                ],
                                                borderColor: [
                                                    'rgba(255, 99, 132, 1)',
                                                    'rgba(54, 162, 235, 1)',
                                                    'rgba(255, 206, 86, 1)',
                                                    'rgba(75, 192, 192, 1)',
                                                ],
                                                borderWidth: 1
                                            }]
                                        }");
                WriteLiteral(@",
                                        options: {
                                            scales: {
                                                y: {
                                                    beginAtZero: true
                                                }
                                            }
                                        }
                                    });
                                </script>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""list-comercial"" role=""tabpanel"" aria-labelledby=""list-profile-list"">
                            <div class=""col-4"">
                                <canvas id=""myChart2"" width=""400"" height=""400""></canvas>
                                <script>
                                    const ctx2 = document.getElementById('myChart2').getContext('2d');
                                    const myChart2 = new Chart(ctx2, {
              ");
                WriteLiteral(@"                          type: 'pie',
                                        data: {
                                            labels: ['Vermelho', 'Azul', 'Amarelo'],
                                            datasets: [{
                                                label: 'Chamados por Atendente',
                                                data: [22, 9, 31],
                                                backgroundColor: [
                                                    'rgba(108, 138, 186, 0.7)',
                                                    'rgba(160, 169, 184, 0.7)',
                                                    'rgba(199, 40, 191, 0.7)',
                                                    'rgba(75, 192, 192, 0.7)',
                                                    'rgba(153, 102, 255, 0.7)',
                                                    'rgba(255, 159, 64, 0.7)'
                                                ],
                                       ");
                WriteLiteral(@"         borderColor: [
                                                    'rgba(255, 99, 132, 1)',
                                                    'rgba(54, 162, 235, 1)',
                                                    'rgba(255, 206, 86, 1)',
                                                    'rgba(75, 192, 192, 1)',
                                                    'rgba(153, 102, 255, 1)',
                                                    'rgba(255, 159, 64, 1)'
                                                ],
                                                borderWidth: 1
                                            }]
                                        },
                                        options: {
                                            scales: {
                                                y: {
                                                    beginAtZero: true
                                                }
                                        ");
                WriteLiteral(@"    }
                                        }
                                    });
                                </script>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""list-UF"" role=""tabpanel"" aria-labelledby=""list-messages-list"">
                            <div class=""col-4"">
                                <canvas id=""myChart3"" width=""400"" height=""400""></canvas>
                                <script>
                                    const ctx3 = document.getElementById('myChart3').getContext('2d');
                                    const myChart3 = new Chart(ctx3, {
                                        type: 'bar',
                                        data: {
                                            labels: ['RS', 'SC', 'SP', 'RJ','PR','MG'],
                                            datasets: [{
                                                label: 'Chamados por UF',
                     ");
                WriteLiteral("                           data: [");
#nullable restore
#line 117 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                  Write(ViewBag.RS);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 117 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                               Write(ViewBag.SC);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 117 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                                            Write(ViewBag.SP);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 117 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                                                         Write(ViewBag.RJ);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 117 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                                                                      Write(ViewBag.PR);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 117 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                                                                                   Write(ViewBag.MG);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
                                                backgroundColor: [
                                                    'rgba(255, 99, 132, 0.2)',
                                                    'rgba(54, 162, 235, 0.2)',
                                                    'rgba(255, 206, 86, 0.2)',
                                                    'rgba(75, 192, 192, 0.2)',
                                                    'rgba(153, 102, 255, 0.7)',
                                                    'rgba(255, 159, 64, 0.7)'
                                                ],
                                                borderColor: [
                                                    'rgba(255, 99, 132, 1)',
                                                    'rgba(54, 162, 235, 1)',
                                                    'rgba(255, 206, 86, 1)',
                                                    'rgba(75, 192, 192, 1)',
                                            ");
                WriteLiteral(@"        'rgba(153, 102, 255, 0.7)',
                                                    'rgba(255, 159, 64, 0.7)'
                                                ],
                                                borderWidth: 1
                                            }]
                                        },
                                        options: {
                                            scales: {
                                                y: {
                                                    beginAtZero: true
                                                }
                                            }
                                        }
                                    });
                                </script>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""list-abertos"" role=""tabpanel"" aria-labelledby=""list-settings-list"">
                            <div class=""col-4"">
  ");
                WriteLiteral(@"                              <canvas id=""myChart4"" width=""250"" height=""250""></canvas>
                                <script>
                                    const ctx4 = document.getElementById('myChart4').getContext('2d');
                                    const myChart4 = new Chart(ctx4, {
                                        type: 'doughnut',
                                        data: {
                                            labels: [""Wellington"", ""Rafaela"", ""Carla"", ""Ana Paula"", ""Thiago"", ""Jonas""],
                                            datasets: [{
                                                label: 'OS Abertas não Encerradas',
                                                data: [");
#nullable restore
#line 159 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                  Write(ViewBag.Wellington);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 159 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                                       Write(ViewBag.Rafaela);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 159 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                                                         Write(ViewBag.Carla);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 159 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                                                                         Write(ViewBag.Ana);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 159 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                                                                                       Write(ViewBag.Thiago);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 159 "C:\Apps\SGV\MVC\SGV\SGV\Views\Posvendas\Index.cshtml"
                                                                                                                                        Write(ViewBag.Jonas);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
                                                backgroundColor: [
                                                    'rgba(108, 138, 186, 0.7)',
                                                    'rgba(160, 169, 184, 0.7)',
                                                    'rgba(199, 40, 191, 0.7)',
                                                    'rgba(75, 192, 192, 0.7)',
                                                    'rgba(153, 102, 255, 0.7)',
                                                    'rgba(255, 159, 64, 0.7)'
                                                ],
                                                borderColor: [
                                                    'rgba(255, 99, 132, 1)',
                                                    'rgba(54, 162, 235, 1)',
                                                    'rgba(255, 206, 86, 1)',
                                                    'rgba(75, 192, 192, 1)',
                                          ");
                WriteLiteral(@"          'rgba(153, 102, 255, 1)',
                                                    'rgba(255, 159, 64, 1)'
                                                ],
                                                borderWidth: 1
                                            }]
                                        },
                                        options: {
                                            scales: {
                                                y: {
                                                    beginAtZero: true
                                                }
                                            }
                                        }
                                    });
                                </script>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
