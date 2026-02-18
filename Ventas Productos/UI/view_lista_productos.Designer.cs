using System.Windows.Forms;
using System.Drawing;


namespace Ventas_Productos.UI
{
    partial class view_lista_productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_lista_productos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_productos = new System.Windows.Forms.Panel();
            this.scrollbar_productos = new ScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_productos = new System.Windows.Forms.Label();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.srch_bar_panel = new System.Windows.Forms.Panel();
            this.icono_busqueda = new System.Windows.Forms.Label();
            this.txtbox_busqueda = new System.Windows.Forms.TextBox();
            this.help_bar_panel = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.eliminar_producto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editar_producto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.srch_bar_panel.SuspendLayout();
            this.help_bar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_productos
            // 
            this.pnl_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.pnl_productos.Controls.Add(this.scrollbar_productos);
            this.pnl_productos.Controls.Add(this.label2);
            this.pnl_productos.Controls.Add(this.label1);
            this.pnl_productos.Controls.Add(this.lbl_productos);
            this.pnl_productos.Controls.Add(this.dgv_productos);
            this.pnl_productos.Location = new System.Drawing.Point(41, 94);
            this.pnl_productos.Name = "pnl_productos";
            this.pnl_productos.Size = new System.Drawing.Size(574, 368);
            this.pnl_productos.TabIndex = 12;
            // 
            // scrollbar_productos
            // 
            this.scrollbar_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scrollbar_productos.LargeChange = 10;
            this.scrollbar_productos.Location = new System.Drawing.Point(556, 83);
            this.scrollbar_productos.Maximum = 100;
            this.scrollbar_productos.Minimum = 0;
            this.scrollbar_productos.Name = "scrollbar_productos";
            this.scrollbar_productos.Size = new System.Drawing.Size(4, 268);
            this.scrollbar_productos.TabIndex = 18;
            this.scrollbar_productos.Text = "scrollBar1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lao Sans Pro", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(243, 51);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.label2.Size = new System.Drawing.Size(53, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lao Sans Pro", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Producto";
            // 
            // lbl_productos
            // 
            this.lbl_productos.AutoSize = true;
            this.lbl_productos.Font = new System.Drawing.Font("Lao Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_productos.Location = new System.Drawing.Point(242, 13);
            this.lbl_productos.Name = "lbl_productos";
            this.lbl_productos.Size = new System.Drawing.Size(109, 27);
            this.lbl_productos.TabIndex = 2;
            this.lbl_productos.Text = "Productos";
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AllowUserToResizeColumns = false;
            this.dgv_productos.AllowUserToResizeRows = false;
            this.dgv_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.dgv_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.ColumnHeadersVisible = false;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminar_producto,
            this.editar_producto});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lao Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_productos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_productos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_productos.EnableHeadersVisualStyles = false;
            this.dgv_productos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.dgv_productos.Location = new System.Drawing.Point(27, 83);
            this.dgv_productos.MultiSelect = false;
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_productos.RowHeadersVisible = false;
            this.dgv_productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(106)))), ((int)(((byte)(133)))));
            this.dgv_productos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_productos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.ShowCellErrors = false;
            this.dgv_productos.ShowEditingIcon = false;
            this.dgv_productos.ShowRowErrors = false;
            this.dgv_productos.Size = new System.Drawing.Size(520, 264);
            this.dgv_productos.StandardTab = true;
            this.dgv_productos.TabIndex = 0;
            this.dgv_productos.VirtualMode = true;
            this.dgv_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellContentClick);
            this.dgv_productos.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dgv_productos_CellToolTipTextNeeded);
            // 
            // srch_bar_panel
            // 
            this.srch_bar_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.srch_bar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.srch_bar_panel.Controls.Add(this.icono_busqueda);
            this.srch_bar_panel.Controls.Add(this.txtbox_busqueda);
            this.srch_bar_panel.Location = new System.Drawing.Point(41, 43);
            this.srch_bar_panel.Name = "srch_bar_panel";
            this.srch_bar_panel.Size = new System.Drawing.Size(574, 37);
            this.srch_bar_panel.TabIndex = 20;
            // 
            // icono_busqueda
            // 
            this.icono_busqueda.AutoSize = true;
            this.icono_busqueda.Image = global::Ventas_Productos.Properties.Resources.search;
            this.icono_busqueda.Location = new System.Drawing.Point(11, 1);
            this.icono_busqueda.MinimumSize = new System.Drawing.Size(34, 35);
            this.icono_busqueda.Name = "icono_busqueda";
            this.icono_busqueda.Size = new System.Drawing.Size(34, 35);
            this.icono_busqueda.TabIndex = 12;
            // 
            // txtbox_busqueda
            // 
            this.txtbox_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbox_busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.txtbox_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_busqueda.Font = new System.Drawing.Font("Lao Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbox_busqueda.Location = new System.Drawing.Point(65, 9);
            this.txtbox_busqueda.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtbox_busqueda.Name = "txtbox_busqueda";
            this.txtbox_busqueda.Size = new System.Drawing.Size(482, 24);
            this.txtbox_busqueda.TabIndex = 6;
            // 
            // help_bar_panel
            // 
            this.help_bar_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.help_bar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.help_bar_panel.Controls.Add(this.btn_cerrar);
            this.help_bar_panel.Location = new System.Drawing.Point(-2, -1);
            this.help_bar_panel.Name = "help_bar_panel";
            this.help_bar_panel.Size = new System.Drawing.Size(659, 23);
            this.help_bar_panel.TabIndex = 18;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(633, 0);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(24, 23);
            this.btn_cerrar.TabIndex = 17;
            this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            this.btn_cerrar.MouseEnter += new System.EventHandler(this.btn_cerrar_MouseEnter);
            this.btn_cerrar.MouseLeave += new System.EventHandler(this.btn_cerrar_MouseLeave);
            // 
            // eliminar_producto
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lao Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_producto.DefaultCellStyle = dataGridViewCellStyle2;
            this.eliminar_producto.FillWeight = 60F;
            this.eliminar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar_producto.HeaderText = "Eliminar";
            this.eliminar_producto.Name = "eliminar_producto";
            this.eliminar_producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.eliminar_producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminar_producto.Text = "Eliminar";
            this.eliminar_producto.UseColumnTextForButtonValue = true;
            // 
            // editar_producto
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lao Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar_producto.DefaultCellStyle = dataGridViewCellStyle3;
            this.editar_producto.FillWeight = 60F;
            this.editar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar_producto.HeaderText = "Editar";
            this.editar_producto.Name = "editar_producto";
            this.editar_producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editar_producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editar_producto.Text = "Editar";
            this.editar_producto.UseColumnTextForButtonValue = true;
            // 
            // view_lista_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(106)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(657, 486);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_productos);
            this.Controls.Add(this.srch_bar_panel);
            this.Controls.Add(this.help_bar_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "view_lista_productos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.view_lista_productos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.view_lista_productos_KeyPress);
            this.pnl_productos.ResumeLayout(false);
            this.pnl_productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.srch_bar_panel.ResumeLayout(false);
            this.srch_bar_panel.PerformLayout();
            this.help_bar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_cerrar;
        private Panel help_bar_panel;
        private Panel srch_bar_panel;
        private Label icono_busqueda;
        private TextBox txtbox_busqueda;
        private Panel pnl_productos;
        private Label lbl_productos;
        private DataGridView dgv_productos;
        private Label label2;
        private Label label1;
        private ScrollBar scrollbar_productos;
        private DataGridViewButtonColumn eliminar_producto;
        private DataGridViewButtonColumn editar_producto;
    }
}