#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52370cfa107fb974c87aae4926802b05acdaa516"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DeliveryTableDeviceMoving), @"mvc.1.0.view", @"/Views/Shared/_DeliveryTableDeviceMoving.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_DeliveryTableDeviceMoving.cshtml", typeof(AspNetCore.Views_Shared__DeliveryTableDeviceMoving))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52370cfa107fb974c87aae4926802b05acdaa516", @"/Views/Shared/_DeliveryTableDeviceMoving.cshtml")]
    public class Views_Shared__DeliveryTableDeviceMoving : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSklad.Models.DeliveryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/css/print.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52370cfa107fb974c87aae4926802b05acdaa5163503", async() => {
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
            BeginContext(89, 55, true);
            WriteLiteral("\n<div id=\"InnerTable\">\n\n\n    <h6 style=\"color:#ff0000\">");
            EndContext();
            BeginContext(145, 17, false);
#line 6 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml"
                         Write(ViewData["error"]);

#line default
#line hidden
            EndContext();
            BeginContext(162, 260, true);
            WriteLiteral(@"</h6>
    <h6>Оборудование</h6>
    <table class=""table table-sm table-bordered table-hover"">
        <thead>
            <tr style=""background:#EEF3F6"">
                <th>#</th>
                <th>Наименование</th>
                <th>Заводской номер</th>
");
            EndContext();
#line 14 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml"
                   if (ViewBag.state != "проведен")
                    {

#line default
#line hidden
            BeginContext(496, 50, true);
            WriteLiteral("                        <th class=\"no-print\"></th>");
            EndContext();
#line 16 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml"
                                                  }
                

#line default
#line hidden
            BeginContext(566, 52, true);
            WriteLiteral("\n            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 22 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml"
             if (Model != null)
            {
                int n = 1;


                

#line default
#line hidden
#line 27 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml"
                 foreach (var item in Model.DeviceDeliveries)
                {

#line default
#line hidden
            BeginContext(773, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(827, 1, false);
#line 30 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml"
                       Write(n);

#line default
#line hidden
            EndContext();
            BeginContext(828, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(863, 20, false);
#line 31 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml"
                       Write(item.DeviceType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(883, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(918, 17, false);
#line 32 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml"
                       Write(item.SerialNumber);

#line default
#line hidden
            EndContext();
            BeginContext(935, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 33 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml"
                         if (item.DeliveryAct.DeliveryState.Description == "в работе")
                        {

#line default
#line hidden
            BeginContext(1054, 293, true);
            WriteLiteral(@"                            <td>
                                <form action=""/Delivery/DeleteDeviceFromDeliveryTable"" data-ajax=""true"" data-ajax-mode=""replace"" data-ajax-update=""#InnerTable"" id=""form0"" method=""post"">
                                    <input type=""hidden"" name=""DeliveryId""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1347, "\"", 1363, 1);
#line 37 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml"
WriteAttributeValue("", 1355, item.Id, 1355, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1364, 73, true);
            WriteLiteral(" />\n                                    <input type=\"hidden\" name=\"ActId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1437, "\"", 1464, 1);
#line 38 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml"
WriteAttributeValue("", 1445, item.DeliveryActId, 1445, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1465, 299, true);
            WriteLiteral(@" />
                                    <div class=""text-center"">
                                        <input id=""Submit1"" type=""submit"" value=""Удалить"" class=""btn btn-danger"" />
                                    </div>
                                </form>
                            </td>
");
            EndContext();
#line 44 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml"
                        }

#line default
#line hidden
            BeginContext(1790, 26, true);
            WriteLiteral("                    </tr>\n");
            EndContext();
#line 46 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml"
                    n++;
                }

#line default
#line hidden
#line 47 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTableDeviceMoving.cshtml"
                 

            }

#line default
#line hidden
            BeginContext(1874, 38, true);
            WriteLiteral("        </tbody>\n\n    </table>\n</div>\n");
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
