#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Delivery\DeviceMoving\ToAssembly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a6c285a61a3d0f8d1b9e763cdb0095df9b3e4df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Delivery_DeviceMoving_ToAssembly), @"mvc.1.0.view", @"/Views/Delivery/DeviceMoving/ToAssembly.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Delivery/DeviceMoving/ToAssembly.cshtml", typeof(AspNetCore.Views_Delivery_DeviceMoving_ToAssembly))]
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
#line 1 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeviceMoving\ToAssembly.cshtml"
using WebSklad.Models;

#line default
#line hidden
#line 2 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeviceMoving\ToAssembly.cshtml"
using DbManager;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a6c285a61a3d0f8d1b9e763cdb0095df9b3e4df", @"/Views/Delivery/DeviceMoving/ToAssembly.cshtml")]
    public class Views_Delivery_DeviceMoving_ToAssembly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formaction", new global::Microsoft.AspNetCore.Html.HtmlString("~/Delivery/OpenDeliveryAct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btn1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Открыть"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formaction", new global::Microsoft.AspNetCore.Html.HtmlString("~/Delivery/CreateDeliveryAct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btn2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Новый акт выдачи на сборку"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeviceMoving\ToAssembly.cshtml"
  
    ViewData["Title"] = "ToAssembly";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 78, true);
            WriteLiteral("\n\n<div class=\"text-center\">\n    <h2>Выдача оборудования на сборку по договору ");
            EndContext();
            BeginContext(211, 33, false);
#line 10 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeviceMoving\ToAssembly.cshtml"
                                              Write(((Contract)ViewBag.contract).Name);

#line default
#line hidden
            EndContext();
            BeginContext(245, 166, true);
            WriteLiteral("</h2>\n    <span class=\"mnemo-icon\">\n        <i class=\"fas fa-arrow-right\"></i>\n        <i class=\"fas fa-box\"></i>\n\n    </span>\n</div>\n\n<form action=\"\" method=\"post\">\n");
            EndContext();
#line 19 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeviceMoving\ToAssembly.cshtml"
     if (((SelectList)ViewBag.listItems).Count() > 0)
    {

#line default
#line hidden
            BeginContext(471, 170, true);
            WriteLiteral("        <div class=\"row\">\n\n            <div class=\"col-md-12 mb-3\">\n\n                <label for=\"Select1\">Незавершенные операции выдачи на сборку</label>\n                ");
            EndContext();
            BeginContext(642, 100, false);
#line 26 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeviceMoving\ToAssembly.cshtml"
           Write(Html.DropDownList("deliveryActId", ViewBag.listItems as SelectList, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(742, 36, true);
            WriteLiteral("\n            </div>\n\n        </div>\n");
            EndContext();
#line 30 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeviceMoving\ToAssembly.cshtml"
    }

#line default
#line hidden
            BeginContext(784, 42, true);
            WriteLiteral("    <input type=\"hidden\" name=\"contractId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 826, "\"", 868, 1);
#line 31 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeviceMoving\ToAssembly.cshtml"
WriteAttributeValue("", 834, ((Contract)ViewBag.contract).Id, 834, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(869, 70, true);
            WriteLiteral(" />\n    <input type=\"hidden\" name=\"dType\" value=\"выдача на сборку\" /> ");
            EndContext();
            BeginContext(964, 44, true);
            WriteLiteral("\n\n    <div class=\"row justify-content-end\">\n");
            EndContext();
#line 35 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeviceMoving\ToAssembly.cshtml"
         if (((SelectList)ViewBag.listItems).Count() > 0)
        {

#line default
#line hidden
            BeginContext(1076, 96, true);
            WriteLiteral("            <div class=\"col-sm-2\">\n                <div class=\"text-right\">\n                    ");
            EndContext();
            BeginContext(1172, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a6c285a61a3d0f8d1b9e763cdb0095df9b3e4df9056", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1285, 43, true);
            WriteLiteral("\n                </div>\n            </div>\n");
            EndContext();
#line 42 "D:\Repos\Store-master\WebSklad\Views\Delivery\DeviceMoving\ToAssembly.cshtml"
        }

#line default
#line hidden
            BeginContext(1338, 84, true);
            WriteLiteral("        <div class=\"col-md-3\">\n            <div class=\"text-right\">\n                ");
            EndContext();
            BeginContext(1422, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a6c285a61a3d0f8d1b9e763cdb0095df9b3e4df10925", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1556, 59, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n\n\n</form>\n\n\n\n");
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
