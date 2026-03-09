using System.Windows.Forms;
using System.Drawing;
namespace Ventas_Productos.UI
{
    partial class view_historial_detalles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_historial_detalles));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_ganancias = new System.Windows.Forms.Label();
            this.lbl_total_venta = new System.Windows.Forms.Label();
            this.lbl_total_ = new System.Windows.Forms.Label();
            this.lbl_fecha_hora = new System.Windows.Forms.Label();
            this.lbl_fecha_venta = new System.Windows.Forms.Label();
            this.lbl_productos = new System.Windows.Forms.Label();
            this.help_bar_panel = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.pnl_dgv = new System.Windows.Forms.Panel();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.help_bar_panel.SuspendLayout();
            this.pnl_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ganancias
            // 
            this.lbl_ganancias.AutoSize = true;
            this.lbl_ganancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ganancias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_ganancias.Location = new System.Drawing.Point(264, 504);
            this.lbl_ganancias.Name = "lbl_ganancias";
            this.lbl_ganancias.Size = new System.Drawing.Size(0, 29);
            this.lbl_ganancias.TabIndex = 27;
            // 
            // lbl_total_venta
            // 
            this.lbl_total_venta.AutoSize = true;
            this.lbl_total_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_total_venta.Location = new System.Drawing.Point(219, 451);
            this.lbl_total_venta.Name = "lbl_total_venta";
            this.lbl_total_venta.Size = new System.Drawing.Size(0, 29);
            this.lbl_total_venta.TabIndex = 26;
            // 
            // lbl_total_
            // 
            this.lbl_total_.AutoSize = true;
            this.lbl_total_.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_total_.Location = new System.Drawing.Point(130, 451);
            this.lbl_total_.Name = "lbl_total_";
            this.lbl_total_.Size = new System.Drawing.Size(93, 29);
            this.lbl_total_.TabIndex = 25;
            this.lbl_total_.Text = "Total: $";
            // 
            // lbl_fecha_hora
            // 
            this.lbl_fecha_hora.AutoSize = true;
            this.lbl_fecha_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_fecha_hora.Location = new System.Drawing.Point(35, 131);
            this.lbl_fecha_hora.Name = "lbl_fecha_hora";
            this.lbl_fecha_hora.Size = new System.Drawing.Size(161, 29);
            this.lbl_fecha_hora.TabIndex = 17;
            this.lbl_fecha_hora.Text = "Fecha y Hora:";
            // 
            // lbl_fecha_venta
            // 
            this.lbl_fecha_venta.AutoSize = true;
            this.lbl_fecha_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_fecha_venta.Location = new System.Drawing.Point(187, 131);
            this.lbl_fecha_venta.Name = "lbl_fecha_venta";
            this.lbl_fecha_venta.Size = new System.Drawing.Size(0, 29);
            this.lbl_fecha_venta.TabIndex = 16;
            // 
            // lbl_productos
            // 
            this.lbl_productos.AutoSize = true;
            this.lbl_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_productos.Location = new System.Drawing.Point(121, 60);
            this.lbl_productos.Name = "lbl_productos";
            this.lbl_productos.Size = new System.Drawing.Size(202, 29);
            this.lbl_productos.TabIndex = 15;
            this.lbl_productos.Text = "Detalles de Venta";
            // 
            // help_bar_panel
            // 
            this.help_bar_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.help_bar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.help_bar_panel.Controls.Add(this.btn_cerrar);
            this.help_bar_panel.Location = new System.Drawing.Point(-3, -1);
            this.help_bar_panel.Name = "help_bar_panel";
            this.help_bar_panel.Size = new System.Drawing.Size(447, 23);
            this.help_bar_panel.TabIndex = 19;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(423, 0);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(24, 23);
            this.btn_cerrar.TabIndex = 20;
            this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            this.btn_cerrar.MouseEnter += new System.EventHandler(this.btn_cerrar_MouseEnter);
            this.btn_cerrar.MouseLeave += new System.EventHandler(this.btn_cerrar_MouseLeave);
            // 
            // pnl_dgv
            // 
            this.pnl_dgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.pnl_dgv.Controls.Add(this.lbl_cantidad);
            this.pnl_dgv.Controls.Add(this.dgv_items);
            this.pnl_dgv.Controls.Add(this.lbl_precio);
            this.pnl_dgv.Controls.Add(this.lbl_nombre);
            this.pnl_dgv.Location = new System.Drawing.Point(27, 169);
            this.pnl_dgv.Name = "pnl_dgv";
            this.pnl_dgv.Size = new System.Drawing.Size(387, 258);
            this.pnl_dgv.TabIndex = 24;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_cantidad.Location = new System.Drawing.Point(302, 14);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbl_cantidad.Size = new System.Drawing.Size(73, 29);
            this.lbl_cantidad.TabIndex = 23;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // dgv_items
            // 
            this.dgv_items.AllowUserToAddRows = false;
            this.dgv_items.AllowUserToDeleteRows = false;
            this.dgv_items.AllowUserToResizeColumns = false;
            this.dgv_items.AllowUserToResizeRows = false;
            this.dgv_items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_items.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.dgv_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_items.ColumnHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_items.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_items.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_items.EnableHeadersVisualStyles = false;
            this.dgv_items.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.dgv_items.Location = new System.Drawing.Point(14, 53);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_items.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_items.RowHeadersVisible = false;
            this.dgv_items.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(106)))), ((int)(((byte)(133)))));
            this.dgv_items.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_items.ShowCellErrors = false;
            this.dgv_items.ShowEditingIcon = false;
            this.dgv_items.ShowRowErrors = false;
            this.dgv_items.Size = new System.Drawing.Size(361, 189);
            this.dgv_items.StandardTab = true;
            this.dgv_items.TabIndex = 18;
            this.dgv_items.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dgv_items_CellToolTipTextNeeded);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_precio.Location = new System.Drawing.Point(184, 14);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbl_precio.Size = new System.Drawing.Size(53, 29);
            this.lbl_precio.TabIndex = 22;
            this.lbl_precio.Text = "Precio";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_nombre.Location = new System.Drawing.Point(14, 14);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbl_nombre.Size = new System.Drawing.Size(133, 29);
            this.lbl_nombre.TabIndex = 21;
            this.lbl_nombre.Text = "Nombre Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(107, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ganancias:";
            // 
            // view_historial_detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(106)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(444, 556);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ganancias);
            this.Controls.Add(this.lbl_total_venta);
            this.Controls.Add(this.lbl_total_);
            this.Controls.Add(this.lbl_fecha_hora);
            this.Controls.Add(this.lbl_fecha_venta);
            this.Controls.Add(this.lbl_productos);
            this.Controls.Add(this.help_bar_panel);
            this.Controls.Add(this.pnl_dgv);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "view_historial_detalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.view_historial_detalles_Load);
            this.help_bar_panel.ResumeLayout(false);
            this.pnl_dgv.ResumeLayout(false);
            this.pnl_dgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_productos;
        private Label lbl_fecha_venta;
        private Label lbl_fecha_hora;
        private DataGridView dgv_items;
        private Panel help_bar_panel;
        private Button btn_cerrar;
        private Label lbl_nombre;
        private Label lbl_precio;
        private Label lbl_cantidad;
        private Panel pnl_dgv;
        private Label lbl_total_;
        private Label lbl_total_venta;
        private Label lbl_ganancias;
        private Label label1;
    }
}