using ChartJs.Mvc.Data;
using ChartJs.Mvc.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJs.Mvc
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Chart
    {
        public enum ChartType { line, bar, horizontalBar, radar, polarArea, pie, doughnut }
        
        public Chart()
        {

        }
        public Chart(string type, DataProperty data)
        {
            this.Type = type;
            this.Data = data;
        }

        public string Type { get; set; }
        public DataProperty Data { get; set; }
        public OptionProperty Options { get; set; }
    }
}
