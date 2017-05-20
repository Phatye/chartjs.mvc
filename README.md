# chartjs.mvc
.Net MVC wrapper for Chart.Js V 2 charting library

# Usage
h2. Sample Usage

h3. Create data in C# file

//set Y-Axis values
var yAxis = new List<double> { 1, 5, 6, 3, 6 };
//set X-Axis values
var xAxis = new List<string> { "One", "Five", "Six", "Three", "Six" };

//create a dataset for the y-axis value
var dataset = new DataSet
            {
                Data = yAxis,
				//set background color if you want different colors xAxis values
				//setting a single background color e.g. BackgroundColor = ChartJs.Mvc.Extensions.ColorConverter.GetHexValue(Color.Blue), will use the same color for all xAxis values
                BackgroundColor = new List<string> {
                    ChartJs.Mvc.Extensions.ColorConverter.GetHexValue(Color.Blue),
                    ChartJs.Mvc.Extensions.ColorConverter.GetHexValue(Color.Green),
                    ChartJs.Mvc.Extensions.ColorConverter.GetHexValue(Color.GreenYellow),
                    ChartJs.Mvc.Extensions.ColorConverter.GetHexValue(Color.Yellow),
                    ChartJs.Mvc.Extensions.ColorConverter.GetHexValue(Color.Orange)
                },
				//if there is need to fill the color e.g in bar and pie charts
                Fill = true,
                Label = "Series of numbers",
				//the type of chart to draw with the dataset
				Type = Chart.ChartType.bar.ToString(),
            };

//create an instance of the chart
var chart = new Chart
            {
				//accepts a list of datasets. A dataset represents a chart to be plotted on the canvas
                Data = new DataProperty
                {
                    Datasets = new List<DataSet> { dataset },
                    Labels = xAxis
                },
                Type = Chart.ChartType.bar.ToString(),
				//option property for the chart
                Options = option
            };

//pass the chart to the view
return View("ChartDisplay", chart);

h3. Displaying chart in View
//import ChartJs.Mvc
@using ChartJs.Mvc.Extensions;

//display the chart in a div
//you need to create a canvas with an id and use the id when creating the chart
<div class="row text-center">
    <div class="row panel panel-chart">
        <canvas class="text-center" id="SampleChart" height="500" width="500"></canvas>
        @Html.CreateChartJs("SampleChart", Model)
    </div>
</div>

h2. Option Property

Title - set tiltle of the chart.
Responsive - sets if the chart should be responsive to the view.
Legend - where and if the legend should show.
Scales - scaling for the Y-Axis

h4. Sample Option property for combination chart with two different y-axis vlues

internal static OptionProperty ChartJsDualYOptions(string text = "", string axes1Id = "y1", string axes2Id = "y2")
{
	return new OptionProperty
	{
		Title = new ChartTitle { Display = true, Text = text, FontSize = 18 },
		Responsive = false,
		Legend = new LegendProperty { Position = "bottom" },
		Scales = new Scale
		{
			XAxes = new List<Axes> { new Axes { GridLines = new GridLine { Display = false } } },
			YAxes = new List<Axes> {
				new Axes { Id = axes1Id, Display = true, Position = "left", GridLines = new GridLine { Display = true }, Ticks = new Tick { BeginAtZero = true } },
			new Axes { Id = axes2Id, Display = true, Position = "right", GridLines = new GridLine { Display = true }, Ticks = new Tick { BeginAtZero = true } }
			}
		}
	};
}
