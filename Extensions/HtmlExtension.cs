using System;
using System.Text;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ChartJs.Mvc;

namespace ChartJs.Mvc.Extensions
{
    public static class HtmlExtension
    {
        public static MvcHtmlString CreateChartJs(this HtmlHelper helper, string canvasId, Chart chart)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                TypeNameHandling = TypeNameHandling.None,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var chartJson = JsonConvert.SerializeObject(chart, settings);


            StringBuilder sb = new StringBuilder();
            string context = canvasId + "_ctx";

            sb.Append("<script>");

            sb.AppendFormat("var {0} = document.getElementById('{1}').getContext('2d');", context, canvasId);
            sb.AppendFormat("var myChart = new Chart({0}, {1});", context, chartJson);
            sb.Append("</script>");

            return MvcHtmlString.Create(sb.ToString());
        }
    }
}
