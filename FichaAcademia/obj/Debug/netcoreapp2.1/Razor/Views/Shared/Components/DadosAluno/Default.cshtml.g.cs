#pragma checksum "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Shared\Components\DadosAluno\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92d355d671205ea37e6dc6567f7fb4d334ed3fd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DadosAluno_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DadosAluno/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/DadosAluno/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_DadosAluno_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92d355d671205ea37e6dc6567f7fb4d334ed3fd5", @"/Views/Shared/Components/DadosAluno/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13081fbd4135203d621391681268fce7feedca99", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DadosAluno_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FichaAcademia.Dominio.Models.Aluno>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 145, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <h5>Dados do Aluno</h5>\r\n    <hr />\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col s4\">\r\n            <p><strong>Nome: </strong>");
            EndContext();
            BeginContext(189, 18, false);
#line 10 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Shared\Components\DadosAluno\Default.cshtml"
                                 Write(Model.NomeCompleto);

#line default
#line hidden
            EndContext();
            BeginContext(207, 93, true);
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div class=\"col s4\">\r\n            <p><strong>Idade: </strong>");
            EndContext();
            BeginContext(301, 11, false);
#line 14 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Shared\Components\DadosAluno\Default.cshtml"
                                  Write(Model.Idade);

#line default
#line hidden
            EndContext();
            BeginContext(312, 92, true);
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div class=\"col s4\">\r\n            <p><strong>Peso: </strong>");
            EndContext();
            BeginContext(405, 10, false);
#line 18 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Shared\Components\DadosAluno\Default.cshtml"
                                 Write(Model.Peso);

#line default
#line hidden
            EndContext();
            BeginContext(415, 135, true);
            WriteLiteral("</p>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col s4\">\r\n            <p><strong>Objetivo: </strong>");
            EndContext();
            BeginContext(551, 19, false);
#line 26 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Shared\Components\DadosAluno\Default.cshtml"
                                     Write(Model.Objetivo.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(570, 97, true);
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div class=\"col s4\">\r\n            <p><strong>Descrição: </strong>");
            EndContext();
            BeginContext(668, 24, false);
#line 30 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Shared\Components\DadosAluno\Default.cshtml"
                                      Write(Model.Objetivo.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(692, 97, true);
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div class=\"col s4\">\r\n            <p><strong>Professor: </strong>");
            EndContext();
            BeginContext(790, 20, false);
#line 34 "C:\Users\JFurqu1m\Desktop\Course\FichaAcademia\FichaAcademia\Views\Shared\Components\DadosAluno\Default.cshtml"
                                      Write(Model.Professor.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(810, 42, true);
            WriteLiteral("</p>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FichaAcademia.Dominio.Models.Aluno> Html { get; private set; }
    }
}
#pragma warning restore 1591
