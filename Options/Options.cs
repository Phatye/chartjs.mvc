using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJs.Mvc.Options
{
    public class OptionProperty
    {
        public ChartTitle Title { get; set; }
        public Scale Scales { get; set; }
        public bool Responsive { get; set; }
        public LegendProperty Legend { get; set; }
    }
}