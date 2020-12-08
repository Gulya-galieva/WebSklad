using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace WebSklad.App_code
{
    public static class SelectHelper
    {
        public static HtmlString CreateSelect(this IHtmlHelper html, List<string> items)
        {
            string result = "";
            foreach (string item in items)
            {
                result += $"<option>{item}</option>";
            }
            return new HtmlString(result);
        }
    }
}
