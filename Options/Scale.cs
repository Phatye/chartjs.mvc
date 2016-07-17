using System.Collections.Generic;

namespace ChartJs.Mvc.Options
{
    public class Scale
    {
        public List<Axes> XAxes { get; set; }
        public List<Axes> YAxes { get; set; }
    }

    public class Axes
    {
        public GridLine GridLines { get; set; }
        public bool? Stacked { get; set; }
        public string Id { get; set; }
        public bool? Display { get; set; }
        public string Position { get; set; }
        public Tick Ticks { get; set; }
    }

    public class GridLine
    {
        public bool? Display { get; set; }
    }

    public class Tick
    {
        public bool? BeginAtZero { get; set; }
    }
}