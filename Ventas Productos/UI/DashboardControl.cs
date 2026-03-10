using LiveCharts;
using LiveCharts.Wpf;
using Ventas_Productos.Data;
using System.Linq;
using System;
using System.Windows.Forms;
using System.Windows.Media;
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
            cartesianChart1.Background = new SolidColorBrush(Color.FromRgb(83, 106, 133));
        }


        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            VolverAVentas?.Invoke(this, EventArgs.Empty);
        }
    }
}
