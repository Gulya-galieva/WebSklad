#pragma checksum "D:\Repos\Store-master\WebSklad\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbe6ea27d91774da1a00a4dadceded544a5c2511"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 6 "D:\Repos\Store-master\WebSklad\Views\Account\Register.cshtml"
using WebSklad.App_code;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbe6ea27d91774da1a00a4dadceded544a5c2511", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSklad.Models.RegisterModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Repos\Store-master\WebSklad\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Регистрация";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(152, 1827, true);
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
            <label for=""Name"">ФИО</label>
            <input type=""text"" id=""Name"" name=""Name"" class=""form-control"" placeholder=""ФИО"" required="""">
        </div>
    </div>

    <div class=""row"">

        <div class=""col-md-12 mb-3"">

            <label for=""Select"">Роль пользователя</label>
            <select id=""Select"" name=""Role"" class=""form-control"" required="""">

                ");
            EndContext();
            BeginContext(1980, 46, false);
#line 65 "D:\Repos\Store-master\WebSklad\Views\Account\Register.cshtml"
           Write(SelectHelper.CreateSelect(Html, ViewBag.roles));

#line default
#line hidden
            EndContext();
            BeginContext(2026, 243, true);
            WriteLiteral("\n\n            </select>\n            <span asp-validation-for=\"Role\" />\n\n        </div>\n\n    </div>\n\n\n    <div class=\"text-right\">\n        <input id=\"post\" type=\"submit\" value=\"Зарегистрировать\" class=\"btn btn-primary\" />\n    </div>\n\n</form>\n\n\n");
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
