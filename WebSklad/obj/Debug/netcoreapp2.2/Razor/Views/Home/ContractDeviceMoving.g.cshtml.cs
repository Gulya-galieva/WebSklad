#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Home\ContractDeviceMoving.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74365497a9e3e1ef2e16a9d0783aeed67dbcf924"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContractDeviceMoving), @"mvc.1.0.view", @"/Views/Home/ContractDeviceMoving.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ContractDeviceMoving.cshtml", typeof(AspNetCore.Views_Home_ContractDeviceMoving))]
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
#line 1 "D:\Repos\Store-master\WebSklad\Views\Home\ContractDeviceMoving.cshtml"
using WebSklad.Models;

#line default
#line hidden
#line 2 "D:\Repos\Store-master\WebSklad\Views\Home\ContractDeviceMoving.cshtml"
using DbManager;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74365497a9e3e1ef2e16a9d0783aeed67dbcf924", @"/Views/Home/ContractDeviceMoving.cshtml")]
    public class Views_Home_ContractDeviceMoving : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-pressed", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Repos\Store-master\WebSklad\Views\Home\ContractDeviceMoving.cshtml"
  
    ViewData["Title"] = "DeviceMoving";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 39, true);
            WriteLiteral("\n<h2>Движение оборудования по договору ");
            EndContext();
            BeginContext(174, 33, false);
#line 8 "D:\Repos\Store-master\WebSklad\Views\Home\ContractDeviceMoving.cshtml"
                                  Write(((Contract)ViewBag.contract).Name);

#line default
#line hidden
            EndContext();
            BeginContext(208, 65, true);
            WriteLiteral("</h2>\n<div class=\"row\">\n\n    <div class=\"col-md-4 mb-3\">\n        ");
            EndContext();
            BeginContext(273, 342, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74365497a9e3e1ef2e16a9d0783aeed67dbcf9244831", async() => {
                BeginContext(414, 197, true);
                WriteLiteral("\n            <span class=\"button-icon\">\n                <i class=\"fas fa-arrow-right\"></i>\n                <i class=\"fas fa-wrench\"></i>\n            </span>\n            Выдать на настройку\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 282, "~/Delivery/ToTune/", 282, 18, true);
#line 12 "D:\Repos\Store-master\WebSklad\Views\Home\ContractDeviceMoving.cshtml"
AddHtmlAttributeValue("", 300, ((Contract)ViewBag.contract).Id, 300, 34, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(615, 53, true);
            WriteLiteral("\n    </div>\n\n    <div class=\"col-md-4 mb-3\">\n        ");
            EndContext();
            BeginContext(668, 340, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74365497a9e3e1ef2e16a9d0783aeed67dbcf9247060", async() => {
                BeginContext(813, 191, true);
                WriteLiteral("\n            <span class=\"button-icon\">\n                <i class=\"fas fa-arrow-right\"></i>\n                <i class=\"fas fa-box\"></i>\n            </span>\n            Выдать на сборку\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 677, "~/Delivery/ToAssembly/", 677, 22, true);
#line 22 "D:\Repos\Store-master\WebSklad\Views\Home\ContractDeviceMoving.cshtml"
AddHtmlAttributeValue("", 699, ((Contract)ViewBag.contract).Id, 699, 34, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1008, 53, true);
            WriteLiteral("\n    </div>\n\n    <div class=\"col-md-4 mb-3\">\n        ");
            EndContext();
            BeginContext(1061, 332, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74365497a9e3e1ef2e16a9d0783aeed67dbcf9249289", async() => {
                BeginContext(1188, 201, true);
                WriteLiteral("\n            <span class=\"button-icon\">\n                <i class=\"fas fa-arrow-right\"></i>\n                <i class=\"far fa-calendar-times\"></i>\n            </span>\n            Добавить в брак\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1070, "~/Delivery/Defect/", 1070, 18, true);
#line 32 "D:\Repos\Store-master\WebSklad\Views\Home\ContractDeviceMoving.cshtml"
AddHtmlAttributeValue("", 1088, ViewBag.contract.Id, 1088, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1393, 80, true);
            WriteLiteral("\n    </div>\n\n</div>\n\n<div class=\"row\">\n\n    <div class=\"col-md-4 mb-3\">\n        ");
            EndContext();
            BeginContext(1473, 343, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74365497a9e3e1ef2e16a9d0783aeed67dbcf92411550", async() => {
                BeginContext(1616, 196, true);
                WriteLiteral("\n            <span class=\"button-icon\">\n                <i class=\"fas fa-wrench\"></i>\n                <i class=\"fas fa-arrow-right\"></i>\n            </span>\n            Венуть с настройки\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1482, "~/Delivery/FromTune/", 1482, 20, true);
#line 46 "D:\Repos\Store-master\WebSklad\Views\Home\ContractDeviceMoving.cshtml"
AddHtmlAttributeValue("", 1502, ((Contract)ViewBag.contract).Id, 1502, 34, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1816, 55, true);
            WriteLiteral("\n    </div>\n\n\n\n    <div class=\"col-md-4 mb-3\">\n        ");
            EndContext();
            BeginContext(1871, 342, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74365497a9e3e1ef2e16a9d0783aeed67dbcf92413792", async() => {
                BeginContext(2018, 191, true);
                WriteLiteral("\n            <span class=\"button-icon\">\n                <i class=\"fas fa-box\"></i>\n                <i class=\"fas fa-arrow-right\"></i>\n            </span>\n            Венуть со сборки\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1880, "~/Delivery/FromAssembly/", 1880, 24, true);
#line 58 "D:\Repos\Store-master\WebSklad\Views\Home\ContractDeviceMoving.cshtml"
AddHtmlAttributeValue("", 1904, ((Contract)ViewBag.contract).Id, 1904, 34, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2213, 53, true);
            WriteLiteral("\n    </div>\n\n    <div class=\"col-md-4 mb-3\">\n        ");
            EndContext();
            BeginContext(2266, 276, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74365497a9e3e1ef2e16a9d0783aeed67dbcf92416029", async() => {
                BeginContext(2397, 141, true);
                WriteLiteral("\n            <span class=\"button-icon\">\n\n                <i class=\"fas fa-list-ol\"></i>\n            </span>\n            Список брака\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2275, "~/Delivery/DefectList/", 2275, 22, true);
#line 68 "D:\Repos\Store-master\WebSklad\Views\Home\ContractDeviceMoving.cshtml"
AddHtmlAttributeValue("", 2297, ViewBag.contract.Id, 2297, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2542, 333, true);
            WriteLiteral(@"
    </div>

</div>





<h4>Отчет по работнику</h4>
<div>
    <form action=""/Home/MakeWorkerReport"" data-ajax=""true"" data-ajax-mode=""replace"" data-ajax-update=""#Table"" id=""form0"" method=""post"">
        <div class=""row"">
            <div class=""col-md-12 mb-3"">
                <label for=""workerId"">Работник</label>
                ");
            EndContext();
            BeginContext(2876, 135, false);
#line 89 "D:\Repos\Store-master\WebSklad\Views\Home\ContractDeviceMoving.cshtml"
           Write(Html.DropDownList("workerId", ViewBag.workers as SelectList, new { @class = "form-control", @autocomplete = "on", @required = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(3011, 118, true);
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"text-right\">\n            <input type=\"hidden\" name=\"contractId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3129, "\"", 3171, 1);
#line 93 "D:\Repos\Store-master\WebSklad\Views\Home\ContractDeviceMoving.cshtml"
WriteAttributeValue("", 3137, ((Contract)ViewBag.contract).Id, 3137, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3172, 155, true);
            WriteLiteral(" />\n            <button type=\"submit\" class=\"btn btn-primary\">Сформировать</button>\n        </div>\n    </form>\n</div>\n<h6>&#8195</h6>\n<div id=\"Table\">\n    ");
            EndContext();
            BeginContext(3328, 34, false);
#line 100 "D:\Repos\Store-master\WebSklad\Views\Home\ContractDeviceMoving.cshtml"
Write(Html.Partial("_WorkerReportTable"));

#line default
#line hidden
            EndContext();
            BeginContext(3362, 11, true);
            WriteLiteral("\n</div>\n\n\n\n");
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
