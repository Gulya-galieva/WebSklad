#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45d1ba9b88a2b38deb3d9a4fdd8894544fdc1457"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Delivery_DeliveryActOutcome), @"mvc.1.0.view", @"/Views/Delivery/DeliveryActOutcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Delivery/DeliveryActOutcome.cshtml", typeof(AspNetCore.Views_Delivery_DeliveryActOutcome))]
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
#line 2 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
using DbManager;

#line default
#line hidden
#line 3 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
using WebSklad.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45d1ba9b88a2b38deb3d9a4fdd8894544fdc1457", @"/Views/Delivery/DeliveryActOutcome.cshtml")]
    public class Views_Delivery_DeliveryActOutcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSklad.Models.DeliveryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Delivery/AddMaterial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#Table"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Delivery/AddSet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Delivery/AddDevice"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formaction", new global::Microsoft.AspNetCore.Html.HtmlString("~/Delivery/ProcessDelivery"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btn2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formaction", new global::Microsoft.AspNetCore.Html.HtmlString("~/Delivery/DeleteDeliveryAct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btn1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Удалить акт"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
  
    ViewData["Title"] = "DeliveryTable";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(171, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(177, 11, false);
#line 9 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
Write(ViewBag.str);

#line default
#line hidden
            EndContext();
            BeginContext(188, 23, true);
            WriteLiteral("</h2>\n<h5>Статус акта: ");
            EndContext();
            BeginContext(212, 13, false);
#line 10 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
            Write(ViewBag.state);

#line default
#line hidden
            EndContext();
            BeginContext(225, 21, true);
            WriteLiteral("</h5>\n<h5>Работник : ");
            EndContext();
            BeginContext(247, 14, false);
#line 11 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
          Write(ViewBag.worker);

#line default
#line hidden
            EndContext();
            BeginContext(261, 33, true);
            WriteLiteral("</h5>\n\n<h5 style=\"color:#ff0000\">");
            EndContext();
            BeginContext(295, 17, false);
#line 13 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
                     Write(ViewData["error"]);

#line default
#line hidden
            EndContext();
            BeginContext(312, 9, true);
            WriteLiteral("</h5>\n\n\n\n");
            EndContext();
#line 17 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
 if (ViewBag.state == "в работе")
{

#line default
#line hidden
            BeginContext(357, 23, true);
            WriteLiteral("    <h4>Материалы</h4>\n");
            EndContext();
            BeginContext(381, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(385, 1241, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45d1ba9b88a2b38deb3d9a4fdd8894544fdc145711440", async() => {
                BeginContext(516, 147, true);
                WriteLiteral("\n\n        <div class=\"row\">\n\n            <div class=\"col-md-4 mb-3\">\n                <label for=\"MaterialId\">Вид материала</label>\n                ");
                EndContext();
                BeginContext(664, 143, false);
#line 27 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
           Write(Html.DropDownList("MaterialId", ViewBag.listMaterials as SelectList, new { @class = "form-control", @required = "true", @autocomplete = "on" }));

#line default
#line hidden
                EndContext();
                BeginContext(807, 602, true);
                WriteLiteral(@"
            </div>

            <div class=""col-md-4 mb-3"">
                <label for=""Volume"">Кол-во</label>
                <input id=""Volume"" type=""text"" name=""Volume"" class=""form-control"" autocomplete=""off"" required pattern=""\d+(,\d{1,10})?"" placeholder=""58,67"" />

            </div>

            <div class=""col-md-4 mb-3"">
                <label for=""Other"">Прочее</label>
                <input id=""Other"" type=""text"" name=""Other"" class=""form-control"" autocomplete=""off"" />
            </div>
        </div>

        <div class=""text-right"">
            <input type=""hidden"" name=""ContractId""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1409, "\"", 1436, 1);
#line 43 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
WriteAttributeValue("", 1417, ViewBag.contractId, 1417, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1437, 49, true);
                WriteLiteral(" />\n            <input type=\"hidden\" name=\"ActId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1486, "\"", 1508, 1);
#line 44 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
WriteAttributeValue("", 1494, ViewBag.actId, 1494, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1509, 110, true);
                WriteLiteral(" />\n            <input id=\"post\" type=\"submit\" value=\"Добавить\" class=\"btn btn-primary\" />\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1626, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1628, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1632, 936, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45d1ba9b88a2b38deb3d9a4fdd8894544fdc145715523", async() => {
                BeginContext(1758, 136, true);
                WriteLiteral("\n\n        <div class=\"row\">\n            <div class=\"col-md-8 mb-3\">\n                <label for=\"SetId\">Комплект</label>\n                ");
                EndContext();
                BeginContext(1895, 111, false);
#line 54 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
           Write(Html.DropDownList("SetId", ViewBag.setItems as SelectList, new { @class = "form-control", @required = "true" }));

#line default
#line hidden
                EndContext();
                BeginContext(2006, 345, true);
                WriteLiteral(@"
            </div>

            <div class=""col-md-4 mb-3"">
                <label for=""Volume"">Кол-во</label>
                <input id=""Volume"" type=""number"" name=""Volume"" class=""form-control"" autocomplete=""off"" required />
            </div>
        </div>

        <div class=""text-right"">
            <input type=""hidden"" name=""ContractId""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2351, "\"", 2378, 1);
#line 64 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
WriteAttributeValue("", 2359, ViewBag.contractId, 2359, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2379, 49, true);
                WriteLiteral(" />\n            <input type=\"hidden\" name=\"ActId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2428, "\"", 2450, 1);
#line 65 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
WriteAttributeValue("", 2436, ViewBag.actId, 2436, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2451, 110, true);
                WriteLiteral(" />\n            <input id=\"post\" type=\"submit\" value=\"Добавить\" class=\"btn btn-primary\" />\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2568, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(2571, 30, true);
            WriteLiteral("    <h4>Оборудование</h4>\n    ");
            EndContext();
            BeginContext(2601, 771, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45d1ba9b88a2b38deb3d9a4fdd8894544fdc145719318", async() => {
                BeginContext(2730, 425, true);
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-md-12 mb-3"">
                <label for=""SerialNumber"">Заводской номер</label>
                <input id=""SerialNumber"" type=""text"" name=""SerialNumber"" class=""form-control"" autocomplete=""off"" placeholder=""14-15 цифр"" required pattern=""[0-9]{14,15}"" />
            </div>
        </div>

        <div class=""text-right"">
            <input type=""hidden"" name=""ContractId""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3155, "\"", 3182, 1);
#line 81 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
WriteAttributeValue("", 3163, ViewBag.contractId, 3163, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3183, 49, true);
                WriteLiteral(" />\n            <input type=\"hidden\" name=\"ActId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3232, "\"", 3254, 1);
#line 82 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
WriteAttributeValue("", 3240, ViewBag.actId, 3240, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3255, 110, true);
                WriteLiteral(" />\n            <input id=\"post\" type=\"submit\" value=\"Добавить\" class=\"btn btn-primary\" />\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3372, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(3374, 122, true);
            WriteLiteral("    <div class=\"row\">\n        <div class=\"col-md-12 mb-3\">\n            <label for=\"WorkerId\">Работник</label>\n            ");
            EndContext();
            BeginContext(3497, 173, false);
#line 90 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
       Write(Html.DropDownList("WorkerId", ViewBag.workers as SelectList, new { @onchange = "val()", @form = "form5", @class = "form-control", @autocomplete = "on", @required = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(3670, 27, true);
            WriteLiteral("\n        </div>\n    </div>\n");
            EndContext();
#line 93 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
}

#line default
#line hidden
            BeginContext(3699, 37, true);
            WriteLiteral("<h6>&#8195</h6>\n<div id=\"Table\">\n    ");
            EndContext();
            BeginContext(3737, 37, false);
#line 96 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
Write(Html.Partial("_DeliveryTable", Model));

#line default
#line hidden
            EndContext();
            BeginContext(3774, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
#line 98 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
 if (ViewBag.state == "в работе")
{

#line default
#line hidden
            BeginContext(3818, 74, true);
            WriteLiteral("    <form method=\"post\" id=\"form5\">\n        <input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3892, "\"", 3914, 1);
#line 101 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
WriteAttributeValue("", 3900, ViewBag.actId, 3900, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3915, 146, true);
            WriteLiteral(" />\n        <div class=\"row justify-content-end\">\n            <div class=\"col-md-2\">\n                <div class=\"text-right\">\n                    ");
            EndContext();
            BeginContext(4061, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45d1ba9b88a2b38deb3d9a4fdd8894544fdc145724706", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 105 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
AddHtmlAttributeValue("", 4139, ViewBag.buttonText, 4139, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4186, 139, true);
            WriteLiteral("\n                </div>\n            </div>\n            <div class=\"col-md-2\">\n                <div class=\"text-right\">\n                    ");
            EndContext();
            BeginContext(4325, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45d1ba9b88a2b38deb3d9a4fdd8894544fdc145726702", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_17);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4443, 70, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </form>\n");
            EndContext();
#line 115 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActOutcome.cshtml"
}

#line default
#line hidden
            BeginContext(4515, 775, true);
            WriteLiteral(@"<script type=""text/javascript"">

    $('#Table').bind(""DOMSubtreeModified"", function () {
        $('#Volume').val('');
        $('#Other').val('');
        $('#SerialNumber').val('');

    })

</script>

<script>
    function val() {
        d = document.getElementById(""WorkerId"").value;
        var xhr = new XMLHttpRequest();
        var body = ""WorkerId="" + + encodeURIComponent(d);

        xhr.onreadystatechange = function () {
            if (xhr.readyState === 4 && xhr.status === 200 && xhr.responseText.length > 0) {
                alert(xhr.responseText);
            }
        }

        xhr.open(""POST"", '/Delivery/CheckWorker', true);
        xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
        xhr.send(body);
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSklad.Models.DeliveryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
