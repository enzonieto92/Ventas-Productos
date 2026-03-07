using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;
using Ventas_Productos.Data;
using Ventas_Productos.Domain;

namespace Ventas_Productos.UI
{
    public partial class view_historial : BaseForm
    {
        private readonly DatabaseService dbService;
        private readonly FormDragSnapBehavior _snapBehavior;
        public view_historial()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            dbService = new DatabaseService();
            _snapBehavior = new FormDragSnapBehavior(this, help_bar_panel);
            scrollbar_productos.Scroll += (s, e) =>
            {
                dgv_historial.FirstDisplayedScrollingRowIndex = scrollbar_productos.Value;
            };
            dgv_historial.MouseWheel += dgv_productos_MouseWheel;
            dgv_historial.MouseEnter += (s, e) => dgv_historial.Focus();
        }
        private void CargarVentas()
        {
            var historial = dbService.ObtenerVentas();
            dgv_historial.DataSource = historial;
            dgv_historial.Columns["IdVenta"].Visible = false;
            dgv_historial.Columns["Total"].DefaultCellStyle.Format = "C2";
            dgv_historial.Columns["Total"].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight;
            dgv_historial.Columns["Fecha"].DefaultCellStyle.Format = "dddd, dd/MM/yyyy, HH:mm 'Hs'";
            dgv_historial.Columns["Fecha"].DefaultCellStyle.FormatProvider =
                CultureInfo.GetCultureInfo("es-AR");
            dgv_historial.ClearSelection();
            ActualizarScroll();
            CalcularTotal();
        }
        private void CalcularTotal()
        {
            Decimal Total = 0;
            foreach (DataGridViewRow row in dgv_historial.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    Total += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }
            lbl_total_acumulado.Text = Total.ToString("N2", new System.Globalization.CultureInfo("es-AR"));
        }
        private void CargarVentas(DateTime desde, DateTime hasta)
        {
            var historial = dbService.ObtenerVentas(desde, hasta);
            dgv_historial.DataSource = historial;
            dgv_historial.Columns["IdVenta"].Visible = false;
            dgv_historial.Columns["Total"].DefaultCellStyle.Format = "C2";
            dgv_historial.Columns["Total"].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight;
            dgv_historial.Columns["Fecha"].DefaultCellStyle.Format = "dddd, dd/MM/yyyy, HH:mm 'Hs'";
            dgv_historial.Columns["Fecha"].DefaultCellStyle.FormatProvider =
                CultureInfo.GetCultureInfo("es-AR");
            dgv_historial.ClearSelection();
            ActualizarScroll();
            CalcularTotal();
        }
        private void dgv_productos_MouseWheel(object sender, MouseEventArgs e)
        {
            if (dgv_historial.RowCount == 0) return;

            int visibles = dgv_historial.DisplayedRowCount(false);
            int max = dgv_historial.RowCount - visibles;

            int actual = dgv_historial.FirstDisplayedScrollingRowIndex;

            int lineas = SystemInformation.MouseWheelScrollLines;
            int delta = (e.Delta > 0 ? -lineas : lineas);

            int nuevo = actual + delta;
            nuevo = Math.Max(0, Math.Min(max, nuevo));

            dgv_historial.FirstDisplayedScrollingRowIndex = nuevo;
            scrollbar_productos.SetValue(nuevo);
        }
        private void ActualizarScroll()
        {
            int visibles = dgv_historial.DisplayedRowCount(false);
            int total = dgv_historial.RowCount;

            if (total <= visibles)
            {
                scrollbar_productos.Enabled = false;
                scrollbar_productos.Visible = false;
                return;
            }

            scrollbar_productos.Enabled = true;
            scrollbar_productos.Visible = true;

            scrollbar_productos.Minimum = 0;
            scrollbar_productos.Maximum = total - visibles;
            scrollbar_productos.LargeChange = visibles;
        }
        private void view_historial_Load(object sender, EventArgs e)
        {
            seleccionar(btn_todo);
            CargarVentas();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cerrar_MouseEnter(object sender, EventArgs e)
        {
            btn_cerrar.BackColor = Color.IndianRed;
        }

        private void btn_cerrar_MouseLeave(object sender, EventArgs e)
        {
            btn_cerrar.BackColor = Color.FromArgb(85, 99, 115);
        }

        private void dgv_historial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var venta  =  (Venta)dgv_historial.Rows[e.RowIndex].DataBoundItem;
            Debug.Write(venta.IdVenta.ToString());
            var items = dbService.ObtenerItems(venta.IdVenta);
            Form view_detalles = new view_historial_detalles(venta, items);
            view_detalles.ShowDialog();
           
        }

        private void dgv_historial_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                e.ToolTipText = dgv_historial.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            }
        }

        public void seleccionar (Button button)
        {
            foreach (Button btn in pnl_botones.Controls)
            {
                if (btn != button)
                {
                    btn.BackColor = Color.FromArgb(79, 116, 149);
                    btn.FlatAppearance.MouseOverBackColor =  Color.FromArgb(114, 149, 175);
                }
            }
            button.BackColor = Color.FromArgb(85, 99, 115);
            button.FlatAppearance.MouseOverBackColor =  Color.FromArgb(85, 99, 115);
        }

        private void btn_todo_Click(object sender, EventArgs e)
        {
            seleccionar(btn_todo);
            CargarVentas();
        }

        private void btn_este_mes_Click(object sender, EventArgs e)
        {
            seleccionar(btn_este_mes);
            DateTime Fecha = DateTime.Now;
            int Mes = Fecha.Month;
            int Año = Fecha.Year;
            DateTime desde = new DateTime(Año, Mes, 1);
            DateTime hasta = desde.AddMonths(1);

            CargarVentas(desde, hasta);
        }
        private void btn_esta_semana_Click(object sender, EventArgs e)
        {
            seleccionar(btn_esta_semana);
            DateTime hoy = DateTime.Now;

            // Calcular cuántos días han pasado desde el lunes
            int diasDesdeElLunes = ((int)hoy.DayOfWeek - (int)DayOfWeek.Monday + 7) % 7;

            DateTime desde = hoy.AddDays(-diasDesdeElLunes).Date; // Lunes a las 00:00:00
            DateTime hasta = desde.AddDays(7);                    // Domingo a las 00:00:00 (o usa hoy si no quieres días futuros)

            CargarVentas(desde, hasta);
        }

        private void btn_hoy_Click(object sender, EventArgs e)
        {
            seleccionar(btn_hoy);
            DateTime desde = DateTime.Today;        // Hoy a las 00:00:00
            DateTime hasta = DateTime.Now;          // Ahora (hora actual)
            CargarVentas(desde, hasta);
        }
    }
}
