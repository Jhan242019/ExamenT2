#pragma checksum "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e24c10d767cce435846aff90e2579d3000d8448"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokemon_Editar), @"mvc.1.0.view", @"/Views/Pokemon/Editar.cshtml")]
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
#line 1 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\_ViewImports.cshtml"
using T2Pokemon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\_ViewImports.cshtml"
using T2Pokemon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e24c10d767cce435846aff90e2579d3000d8448", @"/Views/Pokemon/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e14159fc99585bbb84af89ce6103357ad2bcd1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Pokemon_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/pokemon/editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
   var poke = (Pokemon)Model; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e24c10d767cce435846aff90e2579d3000d84485147", async() => {
                WriteLiteral("\n    <header>\n            <div class=\"container\">\n                <h1 class=\"h-100 badge badge-dark\">Usuario: ");
#nullable restore
#line 6 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
                                                       Write(User.Claims.FirstOrDefault().Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\n            </div>\n        </header>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<h1>Capturar Pokemon</h1>\n<div class=\"row\">\n    <div class=\"col-6\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e24c10d767cce435846aff90e2579d3000d84486689", async() => {
                WriteLiteral("\n\n            <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 431, "\"", 447, 1);
#nullable restore
#line 16 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
WriteAttributeValue("", 439, poke.Id, 439, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n\n            <div class=\"form-group\">\n                <label>Imagen</label>\n            </div>\n            <div class=\"form-group\">\n                <input type=\"file\" name=\"image\"");
                BeginWriteAttribute("value", " value=\"", 631, "\"", 651, 1);
#nullable restore
#line 22 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
WriteAttributeValue("", 639, poke.Imagen, 639, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                ");
#nullable restore
#line 23 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
           Write(Html.ValidationMessage("Imagen"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n            <div class=\"form-group\">\n                <label>Nombre</label>\n                <input class=\"form-control\" name=\"Nombre\"");
                BeginWriteAttribute("value", " value=\"", 858, "\"", 878, 1);
#nullable restore
#line 28 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
WriteAttributeValue("", 866, poke.Nombre, 866, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n                ");
#nullable restore
#line 29 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
           Write(Html.ValidationMessage("Nombre"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n            <div class=\"form-group\">\n                <label>Elemento</label>\n                <select name=\"IdTipo\" class=\"form-control\">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e24c10d767cce435846aff90e2579d3000d84489397", async() => {
                    WriteLiteral("-- Selecciona una opcion --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 36 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
                     foreach (var item in ViewBag.Elementos)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
                         if (poke.Elementos == item)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e24c10d767cce435846aff90e2579d3000d844811292", async() => {
#nullable restore
#line 40 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
                                                         Write(item.Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
#nullable restore
#line 40 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
                                                                                    }
                        else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e24c10d767cce435846aff90e2579d3000d844813980", async() => {
#nullable restore
#line 43 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
                                            Write(item.Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 44 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 8\T2\T2Pokemon\T2Pokemon\Views\Pokemon\Editar.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                 </select>\n            </div>\n\n            <button class=\"btn btn-primary\">Guardar</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n");
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
