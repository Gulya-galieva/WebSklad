#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Home\MounterReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a6604b90a11667da0855684353c9cc2f68a11d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MounterReport), @"mvc.1.0.view", @"/Views/Home/MounterReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MounterReport.cshtml", typeof(AspNetCore.Views_Home_MounterReport))]
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
#line 1 "D:\Repos\Store-master\WebSklad\Views\Home\MounterReport.cshtml"
using WebSklad.Models;

#line default
#line hidden
#line 2 "D:\Repos\Store-master\WebSklad\Views\Home\MounterReport.cshtml"
using DbManager;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a6604b90a11667da0855684353c9cc2f68a11d6", @"/Views/Home/MounterReport.cshtml")]
    public class Views_Home_MounterReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Repos\Store-master\WebSklad\Views\Home\MounterReport.cshtml"
  
    ViewData["Title"] = "DeviceMoving";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 35, true);
            WriteLiteral("\n<h4>Отчет по работнику (Контракт: ");
            EndContext();
            BeginContext(169, 21, false);
#line 8 "D:\Repos\Store-master\WebSklad\Views\Home\MounterReport.cshtml"
                             Write(ViewBag.contract.Name);

#line default
#line hidden
            EndContext();
            BeginContext(190, 288, true);
            WriteLiteral(@")</h4>
<div>
    <form action=""/Home/MakeMounterReport"" data-ajax=""true"" data-ajax-mode=""replace"" data-ajax-update=""#Table"" id=""form0"" method=""post"">
        <div class=""row"">
            <div class=""col-md-12 mb-3"">
                <label for=""workerId"">Работник</label>
                ");
            EndContext();
            BeginContext(479, 135, false);
#line 14 "D:\Repos\Store-master\WebSklad\Views\Home\MounterReport.cshtml"
           Write(Html.DropDownList("workerId", ViewBag.workers as SelectList, new { @class = "form-control", @autocomplete = "on", @required = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(614, 118, true);
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"text-right\">\n            <input type=\"hidden\" name=\"ContractId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 732, "\"", 774, 1);
#line 18 "D:\Repos\Store-master\WebSklad\Views\Home\MounterReport.cshtml"
WriteAttributeValue("", 740, ((Contract)ViewBag.contract).Id, 740, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(775, 155, true);
            WriteLiteral(" />\n            <button type=\"submit\" class=\"btn btn-primary\">Сформировать</button>\n        </div>\n    </form>\n</div>\n<h6>&#8195</h6>\n<div id=\"Table\">\n    ");
            EndContext();
            BeginContext(931, 34, false);
#line 25 "D:\Repos\Store-master\WebSklad\Views\Home\MounterReport.cshtml"
Write(Html.Partial("_WorkerReportTable"));

#line default
#line hidden
            EndContext();
            BeginContext(965, 8, true);
            WriteLiteral("\n</div>\n");
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
