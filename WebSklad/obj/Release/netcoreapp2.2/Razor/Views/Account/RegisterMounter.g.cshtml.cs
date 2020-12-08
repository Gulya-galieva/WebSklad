#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Account\RegisterMounter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1eec310eca88ab354cb0e9a67c178564529ab5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RegisterMounter), @"mvc.1.0.view", @"/Views/Account/RegisterMounter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/RegisterMounter.cshtml", typeof(AspNetCore.Views_Account_RegisterMounter))]
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
#line 6 "D:\Repos\Store-master\WebSklad\Views\Account\RegisterMounter.cshtml"
using WebSklad.App_code;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1eec310eca88ab354cb0e9a67c178564529ab5f", @"/Views/Account/RegisterMounter.cshtml")]
    public class Views_Account_RegisterMounter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSklad.Models.RegisterModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Repos\Store-master\WebSklad\Views\Account\RegisterMounter.cshtml"
  
    ViewData["Title"] = "Регистрация";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(152, 1503, true);
            WriteLiteral(@"
<form action=""/Account/Register"" asp-antiforgery=""true"" method=""post"">

    <h1 class=""h3 mb-3 font-weight-normal"">Регистрация нового пользователя</h1>

    <div class=""row"">

        <div class=""col-md-6 mb-3"">

            <label for=""inputEmail"">Email</label>
            <input type=""text"" id=""inputEmail"" name=""Email"" class=""form-control"" placeholder=""Email"" required="""">
            <span asp-validation-for=""Email"" />

        </div>

        <div class=""col-md-6 mb-3"">
            <label for=""inputLogin"">Логин</label>
            <input type=""text"" id=""inputLogin"" name=""Login"" class=""form-control"" placeholder=""Login"" required="""" autofocus="""">
            <span asp-validation-for=""Login"" />
        </div>

    </div>

    <div class=""row"">

        <div class=""col-md-6 mb-3"">

            <label for=""inputPassword"">Пароль</label>
            <input type=""password"" id=""inputPassword"" name=""Password"" class=""form-control"" placeholder=""Password"" required="""">
            <span asp-validation-for=""Password"" />
");
            WriteLiteral(@"
        </div>

        <div class=""col-md-6 mb-3"">

            <label for=""confirmPassword"">Подтверждение пароля</label>
            <input type=""password"" id=""confirmPassword"" name=""ConfirmPassword"" class=""form-control"" placeholder=""Confirm Password"" required="""">
            <span asp-validation-for=""ConfirmPassword"" />

        </div>

    </div>

    <div class=""row"">

        <div class=""col-md-12 mb-3"">
            <label for=""WorkerId"">Монтажник</label>
            ");
            EndContext();
            BeginContext(1656, 135, false);
#line 54 "D:\Repos\Store-master\WebSklad\Views\Account\RegisterMounter.cshtml"
       Write(Html.DropDownList("WorkerId", ViewBag.Workers as SelectList, new { @class = "form-control", @autocomplete = "on", @required = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(1791, 237, true);
            WriteLiteral("\n        </div>\n    </div>\n\n    \n\n\n    <div class=\"text-right\">\n        <input name=\"Role\" type=\"hidden\" value=\"mounter\" />\n        <input id=\"post\" type=\"submit\" value=\"Зарегистрировать\" class=\"btn btn-primary\" />\n    </div>\n\n</form>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSklad.Models.RegisterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
