#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActSet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c725095bf9ea01c86052ba1d75d4b9c20f1fd11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Delivery_DeliveryActSet), @"mvc.1.0.view", @"/Views/Delivery/DeliveryActSet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Delivery/DeliveryActSet.cshtml", typeof(AspNetCore.Views_Delivery_DeliveryActSet))]
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
#line 2 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActSet.cshtml"
using WebSklad.Models;

#line default
#line hidden
#line 3 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActSet.cshtml"
using DbManager;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c725095bf9ea01c86052ba1d75d4b9c20f1fd11", @"/Views/Delivery/DeliveryActSet.cshtml")]
    public class Views_Delivery_DeliveryActSet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSklad.Models.DeliveryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Delivery/ProcessDelivery"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Delivery/AddMaterial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#Table"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formaction", new global::Microsoft.AspNetCore.Html.HtmlString("~/Delivery/DeleteDeliveryAct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btn1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Удалить комплект"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActSet.cshtml"
  
    ViewData["Title"] = "DeliveryTable";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(171, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(177, 11, false);
#line 9 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActSet.cshtml"
Write(ViewBag.str);

#line default
#line hidden
            EndContext();
            BeginContext(188, 34, true);
            WriteLiteral("</h2>\n\n\n<h5 style=\"color:#ff0000\">");
            EndContext();
            BeginContext(223, 17, false);
#line 12 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActSet.cshtml"
                     Write(ViewData["error"]);

#line default
#line hidden
            EndContext();
            BeginContext(240, 27, true);
            WriteLiteral("</h5>\n\n<h4>Материалы</h4>\n\n");
            EndContext();
            BeginContext(267, 710, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c725095bf9ea01c86052ba1d75d4b9c20f1fd118588", async() => {
                BeginContext(334, 184, true);
                WriteLiteral("\n    <div class=\"row\">\n        <div class=\"col-md-12 mb-3\">\n            <label for=\"SetName\">Название комплекта</label>\n            <input type=\"text\" class=\"form-control\" id=\"SetName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 518, "\"", 571, 1);
#line 20 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActSet.cshtml"
WriteAttributeValue("", 526, ((DeliveryAct)ViewBag.deliveryAct).SetName, 526, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(572, 187, true);
                WriteLiteral(" form=\"form2\" name=\"SetName\" required />\n        </div>\n    </div>\n    <div class=\"row justify-content-end\">\n        <div class=\"col-md-3 mb-3\">\n            <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 759, "\"", 781, 1);
#line 25 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActSet.cshtml"
WriteAttributeValue("", 767, ViewBag.actId, 767, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(782, 87, true);
                WriteLiteral(" />\n            <div class=\"text-right\">\n                <input id=\"btn2\" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 869, "\"", 896, 1);
#line 27 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActSet.cshtml"
WriteAttributeValue("", 877, ViewBag.buttonText, 877, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(897, 73, true);
                WriteLiteral(" class=\"btn btn-primary\" />\n            </div>\n        </div>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(977, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(979, 1147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c725095bf9ea01c86052ba1d75d4b9c20f1fd1111863", async() => {
                BeginContext(1110, 135, true);
                WriteLiteral("\n\n    <div class=\"row\">\n\n        <div class=\"col-md-4 mb-3\">\n            <label for=\"MaterialTypeId\">Вид материала</label>\n            ");
                EndContext();
                BeginContext(1246, 123, false);
#line 39 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActSet.cshtml"
       Write(Html.DropDownList("MaterialId", ViewBag.listMaterials as SelectList, new { @class = "form-control", @autocomplete = "on" }));

#line default
#line hidden
                EndContext();
                BeginContext(1369, 556, true);
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
                BeginWriteAttribute("value", " value=\"", 1925, "\"", 1952, 1);
#line 57 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActSet.cshtml"
WriteAttributeValue("", 1933, ViewBag.contractId, 1933, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1953, 45, true);
                WriteLiteral(" />\n        <input type=\"hidden\" name=\"ActId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1998, "\"", 2020, 1);
#line 58 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActSet.cshtml"
WriteAttributeValue("", 2006, ViewBag.actId, 2006, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2021, 98, true);
                WriteLiteral(" />\n        <input id=\"post\" type=\"submit\" value=\"Добавить\" class=\"btn btn-primary\" />\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2126, 41, true);
            WriteLiteral("\n\n\n\n<h6>&#8195</h6>\n<div id=\"Table\">\n    ");
            EndContext();
            BeginContext(2168, 37, false);
#line 67 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActSet.cshtml"
Write(Html.Partial("_DeliveryTable", Model));

#line default
#line hidden
            EndContext();
            BeginContext(2205, 63, true);
            WriteLiteral("\n</div>\n<form method=\"post\">\n    <input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2268, "\"", 2290, 1);
#line 70 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActSet.cshtml"
WriteAttributeValue("", 2276, ViewBag.actId, 2276, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2291, 131, true);
            WriteLiteral(" />\n    <div class=\"row justify-content-end\">\n\n        <div class=\"col-md-2\">\n            <div class=\"text-right\">\n                ");
            EndContext();
            BeginContext(2422, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0c725095bf9ea01c86052ba1d75d4b9c20f1fd1116714", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2545, 258, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</form>

<script type=""text/javascript"">

    $('#Table').bind(""DOMSubtreeModified"", function () {
        $('#Volume').val('');
        $('#Other').val('');
        $('#SerialNumber').val('');

    })

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSklad.Models.DeliveryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591