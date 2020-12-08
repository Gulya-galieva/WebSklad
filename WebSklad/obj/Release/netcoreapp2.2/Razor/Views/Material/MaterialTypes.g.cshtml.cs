#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Material\MaterialTypes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "286e17aeaf46f7db403ee30249c5641ddd7d2fc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Material_MaterialTypes), @"mvc.1.0.view", @"/Views/Material/MaterialTypes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Material/MaterialTypes.cshtml", typeof(AspNetCore.Views_Material_MaterialTypes))]
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
#line 1 "D:\Repos\Store-master\WebSklad\Views\Material\MaterialTypes.cshtml"
using DbManager;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286e17aeaf46f7db403ee30249c5641ddd7d2fc9", @"/Views/Material/MaterialTypes.cshtml")]
    public class Views_Material_MaterialTypes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MaterialType>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "D:\Repos\Store-master\WebSklad\Views\Material\MaterialTypes.cshtml"
  
    ViewData["Title"] = "Виды материалов";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(146, 531, true);
            WriteLiteral(@"<h3>Виды материалов</h3>
<form action=""/Material/AddMaterialType"" data-ajax=""true"" data-ajax-mode=""replace"" data-ajax-update=""#materialTypesTable"" id=""form0"" method=""post"">

    <div class=""row"">

        <div class=""col-md-4 mb-3"">

            <label for=""name"">Наименование материала</label>
            <input id=""name"" type=""text"" name=""Name"" class=""form-control"" autocomplete=""off"" required />

        </div>

        <div class=""col-md-4 mb-3"">
            <label for=""MaterialUnitId"">Еденица измерения</label>
            ");
            EndContext();
            BeginContext(678, 124, false);
#line 22 "D:\Repos\Store-master\WebSklad\Views\Material\MaterialTypes.cshtml"
       Write(Html.DropDownList("MaterialUnitId", ViewBag.listItems as SelectList, new { @class = "form-control", @autocomplete = "off" }));

#line default
#line hidden
            EndContext();
            BeginContext(802, 571, true);
            WriteLiteral(@"
        </div>
        <div class=""col-md-4 mb-3"">
            <label for=""Price"">Цена за ед. изм., руб.</label>
            <input type=""text"" id=""Price"" class=""form-control"" name=""Price"" required pattern=""\d+(,\d{1,10})?"" />
        </div>

    </div>

    <div class=""text-right"">
        <a href=""/Material/UpdatePrice""><input id=""update"" type=""button"" value=""Импорт цен материалов"" class=""btn btn-primary"" /></a>
        <input id=""post"" type=""submit"" value=""Добавить"" class=""btn btn-primary"" />
    </div>
</form>
<h6>&#8195</h6>
<div id=""materialTypesTable"">
    ");
            EndContext();
            BeginContext(1374, 35, false);
#line 38 "D:\Repos\Store-master\WebSklad\Views\Material\MaterialTypes.cshtml"
Write(Html.Partial("_MaterialTypesTable"));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 468, true);
            WriteLiteral(@"
</div>
<script>
 function PriceImport() {
     var xhr = new XMLHttpRequest();
     var body = """";
     xhr.responseType = """";
        
        xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
      
               }
        
        }
        xhr.open(""POST"", '/Material/UpdatePrice', true);
        xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
        xhr.send(body);
        }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MaterialType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
