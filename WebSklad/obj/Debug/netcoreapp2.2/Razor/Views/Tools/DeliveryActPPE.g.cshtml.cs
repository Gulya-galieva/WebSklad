#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "029a4ac250579cb60f6cc38727bfe1b33d1be943"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tools_DeliveryActPPE), @"mvc.1.0.view", @"/Views/Tools/DeliveryActPPE.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tools/DeliveryActPPE.cshtml", typeof(AspNetCore.Views_Tools_DeliveryActPPE))]
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
#line 2 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
using WebSklad.Models;

#line default
#line hidden
#line 3 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
using DbManager;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"029a4ac250579cb60f6cc38727bfe1b33d1be943", @"/Views/Tools/DeliveryActPPE.cshtml")]
    public class Views_Tools_DeliveryActPPE : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSklad.Models.DeliveryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Tools/AddPPE"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#Table"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formaction", new global::Microsoft.AspNetCore.Html.HtmlString("~/Delivery/ProcessDelivery"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btn2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formaction", new global::Microsoft.AspNetCore.Html.HtmlString("~/Delivery/DeleteDeliveryAct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btn1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Удалить акт"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
  
    ViewData["Title"] = "DeliveryActPPE";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(172, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(178, 11, false);
#line 9 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
Write(ViewBag.str);

#line default
#line hidden
            EndContext();
            BeginContext(189, 23, true);
            WriteLiteral("</h2>\n<h5>Статус акта: ");
            EndContext();
            BeginContext(213, 13, false);
#line 10 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
            Write(ViewBag.state);

#line default
#line hidden
            EndContext();
            BeginContext(226, 34, true);
            WriteLiteral("</h5>\n\n\n<h5 style=\"color:#ff0000\">");
            EndContext();
            BeginContext(261, 17, false);
#line 13 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
                     Write(ViewData["error"]);

#line default
#line hidden
            EndContext();
            BeginContext(278, 9, true);
            WriteLiteral("</h5>\n\n\n\n");
            EndContext();
#line 17 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
 if (ViewBag.state == "в работе")
{
    


#line default
#line hidden
            BeginContext(329, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(333, 1288, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "029a4ac250579cb60f6cc38727bfe1b33d1be9439471", async() => {
                BeginContext(456, 157, true);
                WriteLiteral("\n\n        <div class=\"row\">\n\n            <div class=\"col-md-6 mb-3\">\n                <label for=\"MaterialId\">Вид инструмента или СИЗ</label>\n                ");
                EndContext();
                BeginContext(614, 118, false);
#line 27 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
           Write(Html.DropDownList("PPEId", ViewBag.listMaterials as SelectList, new { @class = "form-control", @autocomplete = "on" }));

#line default
#line hidden
                EndContext();
                BeginContext(732, 264, true);
                WriteLiteral(@"
            </div>

            <div class=""col-md-6 mb-3"">
                <label for=""Volume"">Кол-во</label>
                <input id=""Volume"" type=""number"" name=""Volume"" class=""form-control"" autocomplete=""off"" required  />
            </div>

        </div>

");
                EndContext();
#line 37 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
         if (((string)ViewBag.str).StartsWith("Акт выдачи"))
        {

#line default
#line hidden
                BeginContext(1067, 138, true);
                WriteLiteral("        <div class=\"row\">\n            <div class=\"col-md-12 mb-3\">\n                <label for=\"WorkerId\">Работник</label>\n                ");
                EndContext();
                BeginContext(1206, 151, false);
#line 42 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
           Write(Html.DropDownList("WorkerId", ViewBag.workers as SelectList, new {@form = "form5", @class = "form-control", @autocomplete = "on", @required = "true" }));

#line default
#line hidden
                EndContext();
                BeginContext(1357, 35, true);
                WriteLiteral("\n            </div>\n        </div>\n");
                EndContext();
#line 45 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
        }

#line default
#line hidden
                BeginContext(1402, 79, true);
                WriteLiteral("\n        <div class=\"text-right\">\n            <input type=\"hidden\" name=\"ActId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1481, "\"", 1503, 1);
#line 48 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
WriteAttributeValue("", 1489, ViewBag.actId, 1489, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1504, 110, true);
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
            BeginContext(1621, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 52 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
}

#line default
#line hidden
            BeginContext(1624, 37, true);
            WriteLiteral("<h6>&#8195</h6>\n<div id=\"Table\">\n    ");
            EndContext();
            BeginContext(1662, 40, false);
#line 55 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
Write(Html.Partial("_DeliveryTablePPE", Model));

#line default
#line hidden
            EndContext();
            BeginContext(1702, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
#line 57 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
 if (ViewBag.state == "в работе")
{

#line default
#line hidden
            BeginContext(1746, 74, true);
            WriteLiteral("    <form method=\"post\" id=\"form5\">\n        <input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1820, "\"", 1842, 1);
#line 60 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
WriteAttributeValue("", 1828, ViewBag.actId, 1828, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1843, 146, true);
            WriteLiteral(" />\n        <div class=\"row justify-content-end\">\n            <div class=\"col-md-2\">\n                <div class=\"text-right\">\n                    ");
            EndContext();
            BeginContext(1989, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "029a4ac250579cb60f6cc38727bfe1b33d1be94315317", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 64 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
AddHtmlAttributeValue("", 2067, ViewBag.buttonText, 2067, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2114, 139, true);
            WriteLiteral("\n                </div>\n            </div>\n            <div class=\"col-md-2\">\n                <div class=\"text-right\">\n                    ");
            EndContext();
            BeginContext(2253, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "029a4ac250579cb60f6cc38727bfe1b33d1be94317301", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2371, 70, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </form>\n");
            EndContext();
#line 74 "D:\Repos\Store-master\WebSklad\Views\Tools\DeliveryActPPE.cshtml"
}

#line default
#line hidden
            BeginContext(2443, 205, true);
            WriteLiteral("<script type=\"text/javascript\">\n\n    $(\'#Table\').bind(\"DOMSubtreeModified\", function () {\n        $(\'#Volume\').val(\'\');\n        $(\'#Other\').val(\'\');\n        $(\'#SerialNumber\').val(\'\');\n\n    })\n\n</script>\n\n");
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