#pragma checksum "C:\Users\diego.p.campos\Desktop\projetos\estudos\dotnet web api\ProdutosAPI\ProdutosAPI\Views\Produtos\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b9337c1bcc63a2aa8a539ea9914e6c1fc0d38ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Create), @"mvc.1.0.view", @"/Views/Produtos/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b9337c1bcc63a2aa8a539ea9914e6c1fc0d38ee", @"/Views/Produtos/Create.cshtml")]
    public class Views_Produtos_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProdutosAPI.Data.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\diego.p.campos\Desktop\projetos\estudos\dotnet web api\ProdutosAPI\ProdutosAPI\Views\Produtos\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Produto</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label""></label>
                <input asp-for=""Nome"" class=""form-control"" />
                <span asp-validation-for=""Nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Preco"" class=""control-label""></label>
                <input asp-for=""Preco"" class=""form-control"" />
                <span asp-validation-for=""Preco"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Estoque"" class=""control-label""></label>
                <input asp-for=""Estoque"" class=""form-control"" />
                <span asp-validation-for=""Estoque"" class=""text-danger""></span>
            </div>");
            WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\diego.p.campos\Desktop\projetos\estudos\dotnet web api\ProdutosAPI\ProdutosAPI\Views\Produtos\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProdutosAPI.Data.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
