#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab47cc35d35067b790d7fd793a303cf07763205f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DeliveryTable), @"mvc.1.0.view", @"/Views/Shared/_DeliveryTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_DeliveryTable.cshtml", typeof(AspNetCore.Views_Shared__DeliveryTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab47cc35d35067b790d7fd793a303cf07763205f", @"/Views/Shared/_DeliveryTable.cshtml")]
    public class Views_Shared__DeliveryTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSklad.Models.DeliveryModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 55, true);
            WriteLiteral("\n<div id=\"InnerTable\">\n\n\n    <h6 style=\"color:#ff0000\">");
            EndContext();
            BeginContext(93, 17, false);
#line 6 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                         Write(ViewData["error"]);

#line default
#line hidden
            EndContext();
            BeginContext(110, 328, true);
            WriteLiteral(@"</h6>
    <h6>Материалы и оборудование</h6>
    <table class=""table table-sm table-bordered table-hover"">
        <thead>
            <tr style=""background:#EEF3F6"">
                <th>#</th>
                <th>Наименование</th>
                <th>Eд. изм</th>
                <th>Кол-во</th>
                <th>Прочее</th>
");
            EndContext();
#line 16 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                   if (ViewBag.state != "проведен")
                    {

#line default
#line hidden
            BeginContext(511, 9, true);
            WriteLiteral("<th></th>");
            EndContext();
#line 17 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                              }
                

#line default
#line hidden
            BeginContext(540, 52, true);
            WriteLiteral("\n            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 23 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
             if (Model != null)
            {
                int n = 1;


                

#line default
#line hidden
#line 28 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                 foreach (var item in Model.DeviceDeliveries)
                {

#line default
#line hidden
            BeginContext(747, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(801, 1, false);
#line 31 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                       Write(n);

#line default
#line hidden
            EndContext();
            BeginContext(802, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(837, 20, false);
#line 32 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                       Write(item.DeviceType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(857, 105, true);
            WriteLiteral("</td>\n                        <td>шт</td>\n                        <td>1</td>\n                        <td>");
            EndContext();
            BeginContext(963, 17, false);
#line 35 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                       Write(item.SerialNumber);

#line default
#line hidden
            EndContext();
            BeginContext(980, 7, true);
            WriteLiteral("</td>\n\n");
            EndContext();
#line 37 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                         if (item.DeliveryAct.DeliveryState.Description == "в работе")
                        {

#line default
#line hidden
            BeginContext(1100, 293, true);
            WriteLiteral(@"                            <td>
                                <form action=""/Delivery/DeleteDeviceFromDeliveryTable"" data-ajax=""true"" data-ajax-mode=""replace"" data-ajax-update=""#InnerTable"" id=""form0"" method=""post"">
                                    <input type=""hidden"" name=""DeliveryId""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1393, "\"", 1409, 1);
#line 41 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
WriteAttributeValue("", 1401, item.Id, 1401, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1410, 73, true);
            WriteLiteral(" />\n                                    <input type=\"hidden\" name=\"ActId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1483, "\"", 1510, 1);
#line 42 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
WriteAttributeValue("", 1491, item.DeliveryActId, 1491, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1511, 299, true);
            WriteLiteral(@" />
                                    <div class=""text-center"">
                                        <input id=""Submit1"" type=""submit"" value=""Удалить"" class=""btn btn-danger"" />
                                    </div>
                                </form>
                            </td>
");
            EndContext();
#line 48 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                        }

#line default
#line hidden
            BeginContext(1836, 26, true);
            WriteLiteral("                    </tr>\n");
            EndContext();
#line 50 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                    n++;
                }

#line default
#line hidden
#line 52 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                 foreach (var item in Model.MaterialDeliveries)
                 {

#line default
#line hidden
            BeginContext(1988, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(2042, 1, false);
#line 55 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                       Write(n);

#line default
#line hidden
            EndContext();
            BeginContext(2043, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(2078, 22, false);
#line 56 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                       Write(item.MaterialType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2100, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(2135, 27, false);
#line 57 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                       Write(item.MaterialType.Unit.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2162, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(2197, 21, false);
#line 58 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                       Write(Math.Abs(item.Volume));

#line default
#line hidden
            EndContext();
            BeginContext(2218, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(2253, 10, false);
#line 59 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                       Write(item.Other);

#line default
#line hidden
            EndContext();
            BeginContext(2263, 7, true);
            WriteLiteral("</td>\n\n");
            EndContext();
#line 61 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                         if (item.DeliveryAct.DeliveryState.Description == "в работе")
                        {

#line default
#line hidden
            BeginContext(2383, 295, true);
            WriteLiteral(@"                            <td>
                                <form action=""/Delivery/DeleteMaterialFromDeliveryTable"" data-ajax=""true"" data-ajax-mode=""replace"" data-ajax-update=""#InnerTable"" id=""form0"" method=""post"">
                                    <input type=""hidden"" name=""DeliveryId""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2678, "\"", 2694, 1);
#line 65 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
WriteAttributeValue("", 2686, item.Id, 2686, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2695, 73, true);
            WriteLiteral(" />\n                                    <input type=\"hidden\" name=\"ActId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2768, "\"", 2795, 1);
#line 66 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
WriteAttributeValue("", 2776, item.DeliveryActId, 2776, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2796, 299, true);
            WriteLiteral(@" />
                                    <div class=""text-center"">
                                        <input id=""Submit1"" type=""submit"" value=""Удалить"" class=""btn btn-danger"" />
                                    </div>
                                </form>
                            </td>
");
            EndContext();
#line 72 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                        }

#line default
#line hidden
            BeginContext(3121, 26, true);
            WriteLiteral("                    </tr>\n");
            EndContext();
#line 74 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                    n++;
                 }

#line default
#line hidden
#line 75 "D:\Repos\Store-master\WebSklad\Views\Shared\_DeliveryTable.cshtml"
                  
            }

#line default
#line hidden
            BeginContext(3205, 42, true);
            WriteLiteral("        </tbody>\n\n        </table>\n</div>\n");
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
