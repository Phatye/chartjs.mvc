using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJs.Mvc.Data
{
    public class DataProperty
    {
        public IEnumerable<string> Labels { get; set; }
        public IEnumerable<DataSet> Datasets { get; set; }
    }
}
