#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Shared\_PPETypesTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93b00943369455954a4c809c2aca19431aae6dbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PPETypesTable), @"mvc.1.0.view", @"/Views/Shared/_PPETypesTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PPETypesTable.cshtml", typeof(AspNetCore.Views_Shared__PPETypesTable))]
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
#line 1 "D:\Repos\Store-master\WebSklad\Views\Shared\_PPETypesTable.cshtml"
using DbManager;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93b00943369455954a4c809c2aca19431aae6dbe", @"/Views/Shared/_PPETypesTable.cshtml")]
    public class Views_Shared__PPETypesTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PPE>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 55, true);
            WriteLiteral("\n<div id=\"InnerTable\">\n\n\n    <h6 style=\"color:#ff0000\">");
            EndContext();
            BeginContext(98, 13, false);
#line 7 "D:\Repos\Store-master\WebSklad\Views\Shared\_PPETypesTable.cshtml"
                         Write(ViewBag.error);

#line default
#line hidden
            EndContext();
            BeginContext(111, 273, true);
            WriteLiteral(@"</h6>

    <table class=""table table-sm table-bordered table-hover"">
        <thead>
            <tr style=""background:#EEF3F6"">
                <th>#</th>
                <th>Наименование</th>
                 <th></th>
            </tr>
        </thead>

        <tbody>
");
            EndContext();
#line 19 "D:\Repos\Store-master\WebSklad\Views\Shared\_PPETypesTable.cshtml"
              
                int n = 0;
                foreach (var item in Model)
                {
                    n++;


#line default
#line hidden
            BeginContext(514, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(568, 1, false);
#line 26 "D:\Repos\Store-master\WebSklad\Views\Shared\_PPETypesTable.cshtml"
                       Write(n);

#line default
#line hidden
            EndContext();
            BeginContext(569, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(604, 9, false);
#line 27 "D:\Repos\Store-master\WebSklad\Views\Shared\_PPETypesTable.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(613, 285, true);
            WriteLiteral(@"</td>
                        
                        <td>
                            <form action=""/Tools/DeletePPEType"" data-ajax=""true"" data-ajax-mode=""replace"" data-ajax-update=""#InnerTable"" id=""form0"" method=""post"">
                                <input type=""hidden"" name=""id""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 898, "\"", 914, 1);
#line 31 "D:\Repos\Store-master\WebSklad\Views\Shared\_PPETypesTable.cshtml"
WriteAttributeValue("", 906, item.Id, 906, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(915, 305, true);
            WriteLiteral(@" />
                                <div class=""text-center"">
                                    <input id=""Submit1"" type=""submit"" value=""Удалить"" class=""btn btn-danger"" />
                                </div>
                            </form>
                        </td>
                    </tr>
");
            EndContext();
#line 38 "D:\Repos\Store-master\WebSklad\Views\Shared\_PPETypesTable.cshtml"

                }
            

#line default
#line hidden
            BeginContext(1253, 37, true);
            WriteLiteral("        </tbody>\n\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PPE>> Html { get; private set; }
    }
}
#pragma warning restore 1591
