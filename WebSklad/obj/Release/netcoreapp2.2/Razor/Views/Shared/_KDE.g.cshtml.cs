#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Shared\_KDE.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4df710c039f08eafb68f516a5e5671e319a0a801"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__KDE), @"mvc.1.0.view", @"/Views/Shared/_KDE.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_KDE.cshtml", typeof(AspNetCore.Views_Shared__KDE))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4df710c039f08eafb68f516a5e5671e319a0a801", @"/Views/Shared/_KDE.cshtml")]
    public class Views_Shared__KDE : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DbManager.KDE>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Repos\Store-master\WebSklad\Views\Shared\_KDE.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(43, 4, true);
            WriteLiteral("<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 47, "\"", 65, 2);
            WriteAttributeValue("", 52, "KDE_", 52, 4, true);
#line 4 "D:\Repos\Store-master\WebSklad\Views\Shared\_KDE.cshtml"
WriteAttributeValue("", 56, Model.Id, 56, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(66, 146, true);
            WriteLiteral(">\n    <div class=\"card\">\n        <div class=\"card-header\">\n            <div class=\"d-flex\">\n                <div class=\"p-2\">\n                    ");
            EndContext();
            BeginContext(213, 18, false);
#line 9 "D:\Repos\Store-master\WebSklad\Views\Shared\_KDE.cshtml"
               Write(Model.KDEType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(231, 166, true);
            WriteLiteral("\n                </div>\n                <div class=\"ml-auto p-2\">\n                    <button class=\"btn btn-outline-success\" data-toggle=\"modal\" data-target=\"#addPU\"");
            EndContext();
            BeginWriteAttribute("onmouseover", " onmouseover=\"", 397, "\"", 427, 3);
            WriteAttributeValue("", 411, "KDEId(", 411, 6, true);
#line 12 "D:\Repos\Store-master\WebSklad\Views\Shared\_KDE.cshtml"
WriteAttributeValue("", 417, Model.Id, 417, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 426, ")", 426, 1, true);
            EndWriteAttribute();
            BeginContext(428, 112, true);
            WriteLiteral("> Добавить ПУ</button>\n                </div>\n            </div>\n        </div>\n        <div class=\"card-body\">\n");
            EndContext();
#line 17 "D:\Repos\Store-master\WebSklad\Views\Shared\_KDE.cshtml"
             foreach (DbManager.Device device in Model.Devices)
            {

#line default
#line hidden
            BeginContext(618, 86, true);
            WriteLiteral("            <div class=\"d-flex\">\n                <div class=\"p-2\">\n                   ");
            EndContext();
            BeginContext(705, 19, false);
#line 21 "D:\Repos\Store-master\WebSklad\Views\Shared\_KDE.cshtml"
              Write(device.SerialNumber);

#line default
#line hidden
            EndContext();
            BeginContext(724, 124, true);
            WriteLiteral("\n                </div>\n                <div class=\"ml-auto p-2\">\n                    <button class=\"btn btn-outline-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 848, "\"", 901, 5);
            WriteAttributeValue("", 858, "DeletePU(\'", 858, 10, true);
#line 24 "D:\Repos\Store-master\WebSklad\Views\Shared\_KDE.cshtml"
WriteAttributeValue("", 868, device.SerialNumber, 868, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 888, "\',", 888, 2, true);
#line 24 "D:\Repos\Store-master\WebSklad\Views\Shared\_KDE.cshtml"
WriteAttributeValue(" ", 890, Model.Id, 891, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 900, ")", 900, 1, true);
            EndWriteAttribute();
            BeginContext(902, 54, true);
            WriteLiteral(">-</button>\n                </div>\n            </div>\n");
            EndContext();
#line 27 "D:\Repos\Store-master\WebSklad\Views\Shared\_KDE.cshtml"
            }

#line default
#line hidden
            BeginContext(970, 33, true);
            WriteLiteral("        </div>\n    </div>\n</div>\n");
            EndContext();
#line 31 "D:\Repos\Store-master\WebSklad\Views\Shared\_KDE.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DbManager.KDE> Html { get; private set; }
    }
}
#pragma warning restore 1591
