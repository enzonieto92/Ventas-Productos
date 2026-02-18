using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas_Productos.Domain;

namespace Ventas_Productos.UI
{
    public partial class view_historial_detalles : BaseForm
    {
        private readonly FormDragSnapBehavior _snapBehavior;
        public view_historial_detalles(Venta venta, List<VentaItem> items)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            lbl_fecha_venta.Text = venta.Fecha.ToString();
            lbl_total_venta.Text = venta.Total.ToString();
            dgv_items.DataSource = items;

            _snapBehavior = new FormDragSnapBehavior(this, help_bar_panel);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_cerrar_MouseLeave(object sender, EventArgs e)
        {
            btn_cerrar.BackColor = Color.FromArgb(85, 99, 115);
        }

        private void btn_cerrar_MouseEnter(object sender, EventArgs e)
        {
            btn_cerrar.BackColor = Color.IndianRed;
        }

        private void dgv_items_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                e.ToolTipText = dgv_items.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            }
        }

        private void view_historial_detalles_Load(object sender, EventArgs e)
        {

            dgv_items.Columns.Remove("IdProducto");
            dgv_items.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_items.Columns["PrecioUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_items.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C2";
        }
    }
}
