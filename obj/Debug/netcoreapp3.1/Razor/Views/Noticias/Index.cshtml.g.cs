#pragma checksum "C:\Users\Pichau\Documents\Aula37E-Players - Parte 1 - Models\Views\Noticias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daefb966215e816cef03bd642afc9e7f666d3480"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Noticias_Index), @"mvc.1.0.view", @"/Views/Noticias/Index.cshtml")]
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
#line 1 "C:\Users\Pichau\Documents\Aula37E-Players - Parte 1 - Models\Views\_ViewImports.cshtml"
using Aula37E_Players___Parte_1___Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pichau\Documents\Aula37E-Players - Parte 1 - Models\Views\_ViewImports.cshtml"
using Aula37E_Players___Parte_1___Models.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daefb966215e816cef03bd642afc9e7f666d3480", @"/Views/Noticias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b522d2fa6ac613079127180cae651272a07f7b9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Noticias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Noticias>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Pichau\Documents\Aula37E-Players - Parte 1 - Models\Views\Noticias\Index.cshtml"
  
    ViewData["Title"] = "Equipes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "daefb966215e816cef03bd642afc9e7f666d34803805", async() => {
                WriteLiteral(@"
    <label for=""IdNoticia"">IdNoticia</label>
    <input type=""text"" name=""IdNoticia"" id=""IdNoticia"">

   
    <label for=""Titulo"">Titulo</label>
    <input type=""text"" name=""Titulo"" id=""Titulo"">

    
    <label for=""Texto"">Texto</label>
    <input type=""text"" name=""Texto"" id=""Texto"">


    <label for=""Imagem"">Imagem</label>
    <input type=""text"" name=""Imagem"" id=""Imagem"">

    <button type=""submit"">Cadastrar</button>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 6 "C:\Users\Pichau\Documents\Aula37E-Players - Parte 1 - Models\Views\Noticias\Index.cshtml"
AddHtmlAttributeValue("", 76, Url.Action("Cadastrar"), 76, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table table-responsive tabla-striped\">\r\n    <thead>\r\n        <th>Id</th>\r\n        <th>Titulo</th>\r\n        <th>Texto</th>\r\n        <th>Imagem</th>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Pichau\Documents\Aula37E-Players - Parte 1 - Models\Views\Noticias\Index.cshtml"
         foreach (var item in ViewBag.Noticias)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\Pichau\Documents\Aula37E-Players - Parte 1 - Models\Views\Noticias\Index.cshtml"
               Write(item.IdNoticia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\Pichau\Documents\Aula37E-Players - Parte 1 - Models\Views\Noticias\Index.cshtml"
               Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\Pichau\Documents\Aula37E-Players - Parte 1 - Models\Views\Noticias\Index.cshtml"
               Write(item.Texto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\Pichau\Documents\Aula37E-Players - Parte 1 - Models\Views\Noticias\Index.cshtml"
               Write(item.Imagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Pichau\Documents\Aula37E-Players - Parte 1 - Models\Views\Noticias\Index.cshtml"
        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Noticias> Html { get; private set; }
    }
}
#pragma warning restore 1591