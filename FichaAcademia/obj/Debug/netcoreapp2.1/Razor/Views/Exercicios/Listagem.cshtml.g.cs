#pragma checksum "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Exercicios\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c4593e1148521133055ffc65b37ac9da6cc9eec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exercicios_Listagem), @"mvc.1.0.view", @"/Views/Exercicios/Listagem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Exercicios/Listagem.cshtml", typeof(AspNetCore.Views_Exercicios_Listagem))]
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
#line 1 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\_ViewImports.cshtml"
using FichaAcademia;

#line default
#line hidden
#line 2 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\_ViewImports.cshtml"
using FichaAcademia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4593e1148521133055ffc65b37ac9da6cc9eec", @"/Views/Exercicios/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13081fbd4135203d621391681268fce7feedca99", @"/Views/_ViewImports.cshtml")]
    public class Views_Exercicios_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FichaAcademia.Dominio.Models.Exercicio>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Fichas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Exercicios\Listagem.cshtml"
  
    ViewData["Title"] = "Escola seus exercicios";

#line default
#line hidden
            BeginContext(120, 147, true);
            WriteLiteral("\r\n<h5>Escola seus exercicios</h5>\r\n\r\n\r\n<table class=\"table striped hover highçight\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(268, 40, false);
#line 14 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Exercicios\Listagem.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(308, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(364, 54, false);
#line 17 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Exercicios\Listagem.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoriaExercicio));

#line default
#line hidden
            EndContext();
            BeginContext(418, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 23 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Exercicios\Listagem.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(553, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(614, 39, false);
#line 27 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Exercicios\Listagem.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(653, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(721, 58, false);
#line 30 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Exercicios\Listagem.cshtml"
               Write(Html.DisplayFor(modelItem => item.CategoriaExercicio.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(779, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 848, "\"", 910, 5);
            WriteAttributeValue("", 858, "ExibirModal(", 858, 12, true);
#line 33 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Exercicios\Listagem.cshtml"
WriteAttributeValue("", 870, item.ExercicioId, 870, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 887, ",", 887, 1, true);
#line 33 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Exercicios\Listagem.cshtml"
WriteAttributeValue(" ", 888, ViewData["AlunoId"], 889, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 909, ")", 909, 1, true);
            EndWriteAttribute();
            BeginContext(911, 96, true);
            WriteLiteral(" class=\"btn-small light-blue darken-2\">Adicionar</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 36 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Exercicios\Listagem.cshtml"
        }

#line default
#line hidden
            BeginContext(1018, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(1044, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c4593e1148521133055ffc65b37ac9da6cc9eec7812", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-AlunoId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Exercicios\Listagem.cshtml"
                                                     WriteLiteral(ViewData["AlunoId"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["AlunoId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-AlunoId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["AlunoId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1135, 1027, true);
            WriteLiteral(@"


<div id=""modal1"" class=""modal"">
    <div class=""modal-content"">
        <h4>Adicionar Exercicio</h4>

        <div class=""row"">
            <div class=""input-field col s6"">
                <input id=""Frequencia"" type=""text"" class=""validate"" />
                <label for=""Frequencia"">Frequência</label>
            </div>
        </div>


        <div class=""row"">
            <div class=""input-field col s6"">
                <input id=""Repeticoes"" type=""text"" class=""validate"" />
                <label for=""Repeticoes"">Repetições</label>
            </div>
        </div>


        <div class=""row"">
            <div class=""input-field col s6"">
                <input id=""Carga"" type=""text"" class=""validate"" />
                <label for=""Carga"">Carga</label>
            </div>
        </div>


    </div>
    <div class=""modal-footer"">
        <a class=""modal-close btn green accent-4"">Não</a>
        <a class=""modal-close btn red accent-4 btnConfirmar"">Sim</a>
    </div>
</div>");
            WriteLiteral("\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2181, 2895, true);
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            $("".modal"").modal();
        })

        function ExibirModal(exercicioId, fichaId) {


            $(""#modal1"").modal(""open"");

            $("".btnConfirmar"").on('click', function () {
                var frequencia = parseInt($(""#Frequencia"").val());
                var repeticoes = parseInt($(""#Repeticoes"").val());
                var carga = parseInt($(""#Carga"").val());

                if ((Number.isInteger(frequencia) && frequencia > 0)
                    && (Number.isInteger(repeticoes) && repeticoes > 0)
                    && (Number.isInteger(carga) && carga > 0)) {
                    $.ajax({
                        method: ""POST"",
                        url: ""/Exercicios/AdicionarExercicio"",
                        data: {
                            exercicioId: exercicioId,
                            frequencia: frequencia,
                            repeticoes: repeticoes,
                        ");
                WriteLiteral(@"    carga: carga,
                            fichaId: fichaId
                        },
                        success: function (data) {
                            if (data) {
                                $(""#modal1"").modal(""close"");
                                $(""#modal1"").modal(""destroy"");
                                $("".modal"").modal("""");
                                $("".btnConfirmar"").unbind('click');
                                $(""#Frequencia"").val('');
                                $(""#Repeticoes"").val('');
                                $(""#Carga"").val('');
                                M.toast({ html: 'Exercicio inserido com sucesso!' })
                            }
                            else {
                                $(""#modal1"").modal(""close"");
                                $(""#modal1"").modal(""destroy"");
                                $("".modal"").modal("""");
                                $("".btnConfirmar"").unbind('click');
           ");
                WriteLiteral(@"                     $(""#Frequencia"").val('');
                                $(""#Repeticoes"").val('');
                                $(""#Carga"").val('');
                                M.toast({ html: 'Exercicio já inserido na ficha!' })
                            }
                        }
                    });
                }

                else {
                    $(""#modal1"").modal(""close"");
                    $(""#modal1"").modal(""destroy"");
                    $("".modal"").modal("""");
                    $("".btnConfirmar"").unbind('click');
                    $(""#Frequencia"").val('');
                    $(""#Repeticoes"").val('');
                    $(""#Carga"").val('');
                    M.toast({ html: 'Informações inválidas!' })
                }

            });
        }

    </script>

");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FichaAcademia.Dominio.Models.Exercicio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
