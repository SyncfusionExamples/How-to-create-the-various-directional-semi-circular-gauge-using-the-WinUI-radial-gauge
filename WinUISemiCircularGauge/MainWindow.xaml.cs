using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Syncfusion.UI.Xaml.Gauges;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUISemiCircularGauge
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            //// Creating grid.
            //Grid grid = new();
            //grid.ColumnDefinitions.Add(new ColumnDefinition());
            //grid.ColumnDefinitions.Add(new ColumnDefinition());
            //grid.RowDefinitions.Add(new RowDefinition());
            //grid.RowDefinitions.Add(new RowDefinition());

            //// Creating radial gauge.
            //SfRadialGauge radialGauge1 = new();
            //RadialAxis radialAxis1 = new()
            //{
            //    StartAngle = 180,
            //    EndAngle = 0,
            //    Interval = 10
            //};
            //radialGauge1.Axes.Add(radialAxis1);

            //// Set rows and columns of radial gauges.
            //Grid.SetColumn(radialGauge1, 0);
            //Grid.SetRow(radialGauge1, 0);
            //grid.Children.Add(radialGauge1);

            //SfRadialGauge radialGauge2 = new();
            //RadialAxis radialAxis2 = new()
            //{
            //    StartAngle = 0,
            //    EndAngle = 180,
            //    Interval = 10,
            //    IsInversed = true
            //};
            //radialGauge2.Axes.Add(radialAxis2);
            //Grid.SetColumn(radialGauge2, 1);
            //Grid.SetRow(radialGauge2, 0);
            //grid.Children.Add(radialGauge2);

            //SfRadialGauge radialGauge3 = new();
            //RadialAxis radialAxis3 = new()
            //{
            //    StartAngle = 90,
            //    EndAngle = 270,
            //    Interval = 10,
            //    IsInversed = true
            //};
            //radialGauge3.Axes.Add(radialAxis3);
            //Grid.SetColumn(radialGauge3, 0);
            //Grid.SetRow(radialGauge3, 1);
            //grid.Children.Add(radialGauge3);

            //SfRadialGauge radialGauge4 = new();
            //RadialAxis radialAxis4 = new()
            //{
            //    StartAngle = 270,
            //    EndAngle = 90,
            //    Interval = 10
            //};
            //radialGauge4.Axes.Add(radialAxis4);
            //Grid.SetColumn(radialGauge4, 1);
            //Grid.SetRow(radialGauge4, 1);
            //grid.Children.Add(radialGauge4);

            //this.Content = grid;
        }
    }
}
