#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41805b8db93f608e22e40e7b2df7e9dbd1edeec3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Delivery_DeliveryActView), @"mvc.1.0.view", @"/Views/Delivery/DeliveryActView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Delivery/DeliveryActView.cshtml", typeof(AspNetCore.Views_Delivery_DeliveryActView))]
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
#line 3 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
using WebSklad.Models;

#line default
#line hidden
#line 4 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
using DbManager;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41805b8db93f608e22e40e7b2df7e9dbd1edeec3", @"/Views/Delivery/DeliveryActView.cshtml")]
    public class Views_Delivery_DeliveryActView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSklad.Models.DeliveryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/css/print.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::WebSklad.Tags.BarCodeTagHelper __WebSklad_Tags_BarCodeTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
  
    ViewData["Title"] = "DeliveryTable";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(196, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(197, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "41805b8db93f608e22e40e7b2df7e9dbd1edeec34783", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(249, 64, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-12 mb-3\">\n        <h2>");
            EndContext();
            BeginContext(314, 11, false);
#line 13 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
       Write(ViewBag.str);

#line default
#line hidden
            EndContext();
            BeginContext(325, 99, true);
            WriteLiteral("</h2>\n    </div>\n</div>\n<div class=\"row\">\n    <div class=\"col-md-9 mb-1\">\n        <h5>Статус акта: ");
            EndContext();
            BeginContext(425, 13, false);
#line 18 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
                    Write(ViewBag.state);

#line default
#line hidden
            EndContext();
            BeginContext(438, 28, true);
            WriteLiteral("</h5>\n        <h5>Работник: ");
            EndContext();
            BeginContext(467, 14, false);
#line 19 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
                 Write(ViewBag.worker);

#line default
#line hidden
            EndContext();
            BeginContext(481, 81, true);
            WriteLiteral("</h5>\n    </div>\n    <div class=\"col-md-3 mb-3\">\n        <h6>&#8195</h6>\n        ");
            EndContext();
            BeginContext(562, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("barcode", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41805b8db93f608e22e40e7b2df7e9dbd1edeec37285", async() => {
            }
            );
            __WebSklad_Tags_BarCodeTagHelper = CreateTagHelper<global::WebSklad.Tags.BarCodeTagHelper>();
            __tagHelperExecutionContext.Add(__WebSklad_Tags_BarCodeTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "content", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 23 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
AddHtmlAttributeValue("", 580, ViewBag.actId, 580, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(630, 163, true);
            WriteLiteral("\n    </div>\n</div>\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        \n        <div class=\"text-right\">\n\n            <div class=\"loader\" id=\"Loading\" ></div>\n\n");
            EndContext();
#line 34 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
             if (((string)ViewBag.str).StartsWith("Акт выдачи со склада"))
            {

#line default
#line hidden
            BeginContext(882, 172, true);
            WriteLiteral("                <span class=\"print-icon\" onclick=\"GenerateExcel(\'GenerateExcelOutcomeAct\');\">\n                    <i class=\"far fa-file-excel\"></i>\n                </span>\n");
            EndContext();
#line 39 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
            }

#line default
#line hidden
            BeginContext(1068, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 40 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
             if (((string)ViewBag.str).StartsWith("Акт выдачи инструмента"))
            {

#line default
#line hidden
            BeginContext(1159, 168, true);
            WriteLiteral("                <span class=\"print-icon\" onclick=\"GenerateExcel(\'GenerateExcelPPEAct\');\">\n                    <i class=\"far fa-file-excel\"></i>\n                </span>\n");
            EndContext();
#line 45 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
            }

#line default
#line hidden
            BeginContext(1341, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 46 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
             if (((string)ViewBag.str).StartsWith("Акт возврата на склад"))
            {

#line default
#line hidden
            BeginContext(1431, 171, true);
            WriteLiteral("                <span class=\"print-icon\" onclick=\"GenerateExcel(\'GenerateExcelReturnAct\');\">\n                    <i class=\"far fa-file-excel\"></i>\n                </span>\n");
            EndContext();
#line 51 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
            }

#line default
#line hidden
            BeginContext(1616, 183, true);
            WriteLiteral("            <span class=\"print-icon\" onclick=\"window.print();\">\n                <i class=\"fas fa-print\"></i>\n            </span>\n        </div>\n\n    </div>\n</div>\n\n\n\n<div id=\"Table\">\n");
            EndContext();
#line 63 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
       if (ViewBag.actType == "брак")
        {
            

#line default
#line hidden
            BeginContext(1860, 44, false);
#line 65 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
       Write(Html.Partial("_DeliveryTableDefects", Model));

#line default
#line hidden
            EndContext();
#line 65 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
                                                         
        }
        if (ViewBag.actType == "прием инструмента и сиз" || ViewBag.actType == "выдача инструмента и сиз")
        {
            

#line default
#line hidden
            BeginContext(2045, 40, false);
#line 69 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
       Write(Html.Partial("_DeliveryTablePPE", Model));

#line default
#line hidden
            EndContext();
#line 69 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
                                                     
        }
        else
        {
            

#line default
#line hidden
            BeginContext(2132, 37, false);
#line 73 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
       Write(Html.Partial("_DeliveryTable", Model));

#line default
#line hidden
            EndContext();
#line 73 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
                                                  
        }
    

#line default
#line hidden
            BeginContext(2186, 215, true);
            WriteLiteral("</div>\n\n<script>\n    $(document).ready(function () {\n        $(\'#Loading\').hide();\n    });\n\n    function GenerateExcel(Action) {\n        var xhr = new XMLHttpRequest();\n        var body = \"id=\" + encodeURIComponent(");
            EndContext();
            BeginContext(2402, 13, false);
#line 85 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
                                         Write(ViewBag.actId);

#line default
#line hidden
            EndContext();
            BeginContext(2415, 1283, true);
            WriteLiteral(@");
        xhr.responseType = 'blob';
        $('#Loading').fadeIn();
        xhr.onreadystatechange = function () {
            if (xhr.readyState === 4 && xhr.status === 200) {
                LoadDocument(xhr);
                $('#Loading').fadeOut();
            }
            //else alert(""Не удалось сгенирировать файл!"");
        }

        xhr.open(""POST"", '/Delivery/' + Action, true);
        xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
        xhr.send(body);
    }

   

    function LoadDocument(xhr) {
        if (xhr.status == 200) {
            // Create a new Blob object using the
            //response data of the onload object
            var blob = new Blob([xhr.response], { type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet' });
            //Create a link element, hide it, direct
            //it towards the blob, and then 'click' it programatically
            let a = document.createElement(""a"");
            a.style = ""display: none"";
     ");
            WriteLiteral(@"       document.body.appendChild(a);
            //Create a DOMString representing the blob
            //and point the link element towards it
            let url = window.URL.createObjectURL(blob);
            a.href = url;
            a.download = 'Act'+ '");
            EndContext();
            BeginContext(3699, 13, false);
#line 117 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeliveryActView.cshtml"
                            Write(ViewBag.actId);

#line default
#line hidden
            EndContext();
            BeginContext(3712, 269, true);
            WriteLiteral(@"' + '.xlsx';
            //programatically click the link to trigger the download
            a.click();
            //release the reference to the file by revoking the Object URL
            window.URL.revokeObjectURL(url);
        } else {

        }
    };
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
