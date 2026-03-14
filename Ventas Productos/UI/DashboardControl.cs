using LiveCharts;
using LiveCharts.Wpf;
using Ventas_Productos.Data;
using System.Linq;
using System;
using System.Drawing;
using System.Windows.Media;
using System.Windows.Forms;
using Ventas_Productos.Domain;
namespace Ventas_Productos.UI
{
    public partial class DashboardControl : UserControl
    {
        private readonly DatabaseService dbService;
        public event EventHandler VolverAVentas;
        public DashboardControl()
        {
            dbService = new DatabaseService();
            InitializeComponent();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            CargarVendidos();
            CargarVentasSemanales();
            CargarGanancias();
        }
        private void CargarVendidos()
        {
            var datos = dbService.ObtenerProductosMasVendidos();
            datos.Reverse();
            cartesianChart1.Series = new SeriesCollection
                {
                    new RowSeries
                    {
                        Title = "Unidades",
                        Values = new ChartValues<int>(datos.Select(d => d.Cantidad)),
                        
                        DataLabels = true
                    }
                };

            // RowSeries: los NOMBRES van en el eje Y
            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisY.Add(new Axis
            {
                Labels = datos.Select(d => d.NombreProducto).ToArray(),
                Separator = new Separator { IsEnabled = false }
            });

            // RowSeries: los VALORES van en el eje X
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis
            {
                MinValue = 0,
                LabelFormatter = v => v.ToString("N0"),
                Separator = new Separator { IsEnabled = false }
            });
            cartesianChart1.Background =
    new System.Windows.Media.SolidColorBrush(
        System.Windows.Media.Color.FromRgb(83, 106, 133));
        }
        private void CargarVentasSemanales()
        {
            var datos = dbService.ObtenerVentasSemanales();

            cartesianChart2.Series = new SeriesCollection
    {
        new LineSeries
        {
            Title           = "Total vendido",
            Values          = new ChartValues<decimal>(datos.Select(d => d.TotalSemana)),
            PointGeometry   = DefaultGeometries.Circle,   // puntos visibles
            PointGeometrySize = 10,
            DataLabels      = true,
            LabelPoint      = p => "$" + p.Y.ToString("N0")
        }
    };

            // Eje X → etiquetas de semana
            cartesianChart2.AxisX.Clear();
            cartesianChart2.AxisX.Add(new Axis
            {
                Labels = datos.Select(d => d.Etiqueta).ToArray(),
                Separator = new Separator { IsEnabled = false }
            });

            // Eje Y → valores monetarios
            cartesianChart2.AxisY.Clear();
            cartesianChart2.AxisY.Add(new Axis
            {
                MinValue = 0,
                LabelFormatter = v => "$" + v.ToString("N0"),
                Separator = new Separator { IsEnabled = false }
            });

            cartesianChart2.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(83, 106, 133));
        }
        private void CargarGanancias()
        {
            var datos = dbService.ObtenerGananciasMensuales();

            cartesianChart3.Series = new SeriesCollection
    {
        new LineSeries
        {
            Title             = "Ganancia",
            Values            = new ChartValues<decimal>(datos.Select(d => d.TotalGanancia)),
            PointGeometry     = DefaultGeometries.Circle,
            PointGeometrySize = 10,
            DataLabels        = true,
            LabelPoint        = p => "$" + p.Y.ToString("N0")
        }
    };

            cartesianChart3.AxisX.Clear();
            cartesianChart3.AxisX.Add(new Axis
            {
                Labels = datos.Select(d => d.Etiqueta).ToArray(),
                Separator = new Separator { IsEnabled = false }
            });

            cartesianChart3.AxisY.Clear();
            cartesianChart3.AxisY.Add(new Axis
            {
                MinValue = 0,
                LabelFormatter = v => "$" + v.ToString("N0"),
                Separator = new Separator { IsEnabled = false }
            });

            cartesianChart3.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(83, 106, 133));
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            VolverAVentas?.Invoke(this, EventArgs.Empty);
        }
    }
}
