#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Shared\_WorkerReportPPE.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6293e2378b06ae9719d80bdc28457ada42ab50b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__WorkerReportPPE), @"mvc.1.0.view", @"/Views/Shared/_WorkerReportPPE.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_WorkerReportPPE.cshtml", typeof(AspNetCore.Views_Shared__WorkerReportPPE))]
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
#line 1 "D:\Repos\Store-master\WebSklad\Views\Shared\_WorkerReportPPE.cshtml"
using DbManager;

#line default
#line hidden
#line 3 "D:\Repos\Store-master\WebSklad\Views\Shared\_WorkerReportPPE.cshtml"
using WebSklad.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6293e2378b06ae9719d80bdc28457ada42ab50b2", @"/Views/Shared/_WorkerReportPPE.cshtml")]
    public class Views_Shared__WorkerReportPPE : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PPEReportModel>>
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
            BeginContext(77, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6293e2378b06ae9719d80bdc28457ada42ab50b23693", async() => {
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
            BeginContext(129, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "D:\Repos\Store-master\WebSklad\Views\Shared\_WorkerReportPPE.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(152, 60, true);
            WriteLiteral("    <div id=\"InnerTable\">\n        <h6 style=\"color:#ff0000\">");
            EndContext();
            BeginContext(213, 17, false);
#line 8 "D:\Repos\Store-master\WebSklad\Views\Shared\_WorkerReportPPE.cshtml"
                             Write(ViewData["error"]);

#line default
#line hidden
            EndContext();
            BeginContext(230, 61, true);
            WriteLiteral("</h6>\n            <h6>Полученный инструмент и СИЗ работником ");
            EndContext();
            BeginContext(292, 14, false);
#line 9 "D:\Repos\Store-master\WebSklad\Views\Shared\_WorkerReportPPE.cshtml"
                                                  Write(ViewBag.worker);

#line default
#line hidden
            EndContext();
            BeginContext(306, 353, true);
            WriteLiteral(@"</h6>
            <table class=""table table-sm table-bordered table-hover"">
                <thead>
                    <tr style=""background:#EEF3F6"">
                        <th>#</th>
                        <th>Наименование</th>
                        <th>Кол-во (шт)</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 19 "D:\Repos\Store-master\WebSklad\Views\Shared\_WorkerReportPPE.cshtml"
                      
                        int n = 1;
                        

#line default
#line hidden
#line 21 "D:\Repos\Store-master\WebSklad\Views\Shared\_WorkerReportPPE.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(796, 69, true);
            WriteLiteral("                            <tr>\n                                <td>");
            EndContext();
            BeginContext(866, 1, false);
#line 24 "D:\Repos\Store-master\WebSklad\Views\Shared\_WorkerReportPPE.cshtml"
                               Write(n);

#line default
#line hidden
            EndContext();
            BeginContext(867, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(910, 9, false);
#line 25 "D:\Repos\Store-master\WebSklad\Views\Shared\_WorkerReportPPE.cshtml"
                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(919, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(962, 21, false);
#line 26 "D:\Repos\Store-master\WebSklad\Views\Shared\_WorkerReportPPE.cshtml"
                               Write(Math.Abs(item.Volume));

#line default
#line hidden
            EndContext();
            BeginContext(983, 40, true);
            WriteLiteral("</td>\n                            </tr>\n");
            EndContext();
#line 28 "D:\Repos\Store-master\WebSklad\Views\Shared\_WorkerReportPPE.cshtml"
                            n++;
                        }

#line default
#line hidden
            BeginContext(1105, 58, true);
            WriteLiteral("                </tbody>\n            </table>\n     </div>\n");
            EndContext();
#line 34 "D:\Repos\Store-master\WebSklad\Views\Shared\_WorkerReportPPE.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PPEReportModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591