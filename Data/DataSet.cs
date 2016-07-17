using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJs.Mvc.Data
{
    public class DataSet
    {
        public IEnumerable<double> Data { get; set; }
        public string Label { get; set; }
        public bool? Fill { get; set; }
        public dynamic BackgroundColor { get; set; }
        public string BorderColor { get; set; }
        public dynamic PointBackgroundColor { get; set; }
        public string PointBorderColor { get; set; }
        public string Type { get; set; }   
        public string YAxisID { get; set; }
    }
}