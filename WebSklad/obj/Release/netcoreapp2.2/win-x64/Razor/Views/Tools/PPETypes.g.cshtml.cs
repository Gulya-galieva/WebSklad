#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Tools\PPETypes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea95bacdf89176afa3e6f642d5fdc39c10da14b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tools_PPETypes), @"mvc.1.0.view", @"/Views/Tools/PPETypes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tools/PPETypes.cshtml", typeof(AspNetCore.Views_Tools_PPETypes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea95bacdf89176afa3e6f642d5fdc39c10da14b1", @"/Views/Tools/PPETypes.cshtml")]
    public class Views_Tools_PPETypes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "D:\Repos\Store-master\WebSklad\Views\Tools\PPETypes.cshtml"
  
    ViewData["Title"] = "PPETypes";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(88, 600, true);
            WriteLiteral(@"
<h3>Виды инструмента и СИЗ</h3>
<form action=""/Tools/AddPPEType"" data-ajax=""true"" data-ajax-mode=""replace"" data-ajax-update=""#materialTypesTable"" id=""form0"" method=""post"">

    <div class=""row"">

        <div class=""col-md-12 mb-3"">

            <label for=""name"">Наименование</label>
            <input id=""name"" type=""text"" name=""Name"" class=""form-control"" autocomplete=""off"" required />

        </div>
    </div>

    <div class=""text-right"">
        <input id=""post"" type=""submit"" value=""Добавить"" class=""btn btn-primary"" />
    </div>
</form>
<h6>&#8195</h6>
<div id=""materialTypesTable"">
    ");
            EndContext();
            BeginContext(689, 30, false);
#line 26 "D:\Repos\Store-master\WebSklad\Views\Tools\PPETypes.cshtml"
Write(Html.Partial("_PPETypesTable"));

#line default
#line hidden
            EndContext();
            BeginContext(719, 9, true);
            WriteLiteral("\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591