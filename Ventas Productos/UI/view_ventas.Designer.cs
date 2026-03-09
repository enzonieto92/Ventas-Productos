using System.Drawing;
using System.Windows.Forms;

namespace Ventas_Productos
{
    partial class view_ventas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_ventas));
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txtbox_busqueda = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_suma = new System.Windows.Forms.Label();
            this.srch_bar_panel = new System.Windows.Forms.Panel();
            this.icono_busqueda = new System.Windows.Forms.Label();
            this.help_bar_panel = new System.Windows.Forms.Panel();
            this.btn_user = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.pruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.verStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_fecha_hora = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.lbl_venta = new System.Windows.Forms.Label();
            this.panel_ventas = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_ganancias = new System.Windows.Forms.Label();
            this.lbl_borrar_seleccion = new System.Windows.Forms.Label();
            this.btn_borrar_seleccion = new System.Windows.Forms.Button();
            this.lbl_total_txt = new System.Windows.Forms.Label();
            this.pnl_ventas = new System.Windows.Forms.Panel();
            this.scrollbar_ventas = new ScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ventas = new System.Windows.Forms.DataGridView();
            this.pnl_der = new System.Windows.Forms.Panel();
            this.pnl_productos = new System.Windows.Forms.Panel();
            this.scrollbar_productos = new ScrollBar();
            this.lbl_productos = new System.Windows.Forms.Label();
            this.verEstadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.srch_bar_panel.SuspendLayout();
            this.help_bar_panel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel_ventas.SuspendLayout();
            this.pnl_ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            this.pnl_der.SuspendLayout();
            this.pnl_productos.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_productos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_productos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_productos.EnableHeadersVisualStyles = false;
            this.dgv_productos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.dgv_productos.Location = new System.Drawing.Point(14, 50);
            this.dgv_productos.MultiSelect = false;
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_productos.RowHeadersVisible = false;
            this.dgv_productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(106)))), ((int)(((byte)(133)))));
            this.dgv_productos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_productos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.ShowCellErrors = false;
            this.dgv_productos.ShowEditingIcon = false;
            this.dgv_productos.ShowRowErrors = false;
            this.dgv_productos.Size = new System.Drawing.Size(280, 331);
            this.dgv_productos.StandardTab = true;
            this.dgv_productos.TabIndex = 0;
            this.dgv_productos.VirtualMode = true;
            this.dgv_productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellDoubleClick);
            this.dgv_productos.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dgv_productos_CellToolTipTextNeeded);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_limpiar.Enabled = false;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_limpiar.Location = new System.Drawing.Point(201, 438);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(116, 40);
            this.btn_limpiar.TabIndex = 2;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_confirmar.Enabled = false;
            this.btn_confirmar.FlatAppearance.BorderSize = 0;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_confirmar.Location = new System.Drawing.Point(3, 438);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(117, 40);
            this.btn_confirmar.TabIndex = 3;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // txtbox_busqueda
            // 
            this.txtbox_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbox_busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.txtbox_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbox_busqueda.Location = new System.Drawing.Point(51, 8);
            this.txtbox_busqueda.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtbox_busqueda.Name = "txtbox_busqueda";
            this.txtbox_busqueda.Size = new System.Drawing.Size(240, 22);
            this.txtbox_busqueda.TabIndex = 6;
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_total.Location = new System.Drawing.Point(272, 385);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbl_total.Size = new System.Drawing.Size(86, 46);
            this.lbl_total.TabIndex = 8;
            this.lbl_total.Text = "$ 0,00";
            this.lbl_total.UseCompatibleTextRendering = true;
            // 
            // lbl_suma
            // 
            this.lbl_suma.AutoSize = true;
            this.lbl_suma.BackColor = System.Drawing.Color.Transparent;
            this.lbl_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_suma.Location = new System.Drawing.Point(404, 432);
            this.lbl_suma.Name = "lbl_suma";
            this.lbl_suma.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbl_suma.Size = new System.Drawing.Size(0, 40);
            this.lbl_suma.TabIndex = 9;
            // 
            // srch_bar_panel
            // 
            this.srch_bar_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.srch_bar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.srch_bar_panel.Controls.Add(this.icono_busqueda);
            this.srch_bar_panel.Controls.Add(this.txtbox_busqueda);
            this.srch_bar_panel.Location = new System.Drawing.Point(540, 28);
            this.srch_bar_panel.Name = "srch_bar_panel";
            this.srch_bar_panel.Size = new System.Drawing.Size(317, 37);
            this.srch_bar_panel.TabIndex = 10;
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
            // help_bar_panel
            // 
            this.help_bar_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.help_bar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.help_bar_panel.Controls.Add(this.btn_user);
            this.help_bar_panel.Controls.Add(this.toolStrip1);
            this.help_bar_panel.Controls.Add(this.btn_minimizar);
            this.help_bar_panel.Controls.Add(this.btn_max);
            this.help_bar_panel.Controls.Add(this.btn_cerrar);
            this.help_bar_panel.Location = new System.Drawing.Point(0, 0);
            this.help_bar_panel.Name = "help_bar_panel";
            this.help_bar_panel.Size = new System.Drawing.Size(897, 23);
            this.help_bar_panel.TabIndex = 11;
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_user.FlatAppearance.BorderSize = 0;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_user.Image = global::Ventas_Productos.Properties.Resources.user;
            this.btn_user.Location = new System.Drawing.Point(0, 0);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(34, 24);
            this.btn_user.TabIndex = 14;
            this.btn_user.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton5});
            this.toolStrip1.Location = new System.Drawing.Point(41, -1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(406, 26);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(64, 23);
            this.toolStripDropDownButton1.Text = "Ventas";
            this.toolStripDropDownButton1.ToolTipText = "Ventas";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 24);
            this.toolStripMenuItem1.Text = "Historial";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pruebaToolStripMenuItem,
            this.verProductosToolStripMenuItem});
            this.toolStripDropDownButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(85, 23);
            this.toolStripDropDownButton2.Text = "Productos";
            // 
            // pruebaToolStripMenuItem
            // 
            this.pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            this.pruebaToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.pruebaToolStripMenuItem.Text = "Agregar Producto";
            this.pruebaToolStripMenuItem.Click += new System.EventHandler(this.pruebaToolStripMenuItem_Click);
            // 
            // verProductosToolStripMenuItem
            // 
            this.verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            this.verProductosToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.verProductosToolStripMenuItem.Text = "Editar Productos";
            this.verProductosToolStripMenuItem.Click += new System.EventHandler(this.verProductosToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verStockToolStripMenuItem});
            this.toolStripDropDownButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.ShowDropDownArrow = false;
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(54, 23);
            this.toolStripDropDownButton3.Text = "Stock";
            // 
            // verStockToolStripMenuItem
            // 
            this.verStockToolStripMenuItem.Name = "verStockToolStripMenuItem";
            this.verStockToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.verStockToolStripMenuItem.Text = "Ver Stock";
            this.verStockToolStripMenuItem.Click += new System.EventHandler(this.verStockToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verEstadísticasToolStripMenuItem});
            this.toolStripDropDownButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.ShowDropDownArrow = false;
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(79, 23);
            this.toolStripDropDownButton4.Text = "Reportes";
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.toolStripDropDownButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.ShowDropDownArrow = false;
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(111, 23);
            this.toolStripDropDownButton5.Text = "Configuración";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_minimizar.Image = global::Ventas_Productos.Properties.Resources.minimize;
            this.btn_minimizar.Location = new System.Drawing.Point(822, -2);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(24, 27);
            this.btn_minimizar.TabIndex = 19;
            this.btn_minimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_max.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_max.Image = global::Ventas_Productos.Properties.Resources.maximize;
            this.btn_max.Location = new System.Drawing.Point(846, 0);
            this.btn_max.Margin = new System.Windows.Forms.Padding(4);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(24, 25);
            this.btn_max.TabIndex = 18;
            this.btn_max.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_max.UseVisualStyleBackColor = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cerrar.Image = global::Ventas_Productos.Properties.Resources.x;
            this.btn_cerrar.Location = new System.Drawing.Point(873, 0);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(24, 23);
            this.btn_cerrar.TabIndex = 12;
            this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            this.btn_cerrar.MouseEnter += new System.EventHandler(this.btn_cerrar_MouseEnter);
            this.btn_cerrar.MouseLeave += new System.EventHandler(this.btn_cerrar_MouseLeave);
            // 
            // lbl_fecha_hora
            // 
            this.lbl_fecha_hora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_fecha_hora.AutoSize = true;
            this.lbl_fecha_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_fecha_hora.Location = new System.Drawing.Point(690, 32);
            this.lbl_fecha_hora.Name = "lbl_fecha_hora";
            this.lbl_fecha_hora.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbl_fecha_hora.Size = new System.Drawing.Size(155, 25);
            this.lbl_fecha_hora.TabIndex = 17;
            this.lbl_fecha_hora.Text = "Jueves 12/12/12 59:59 hs";
            this.lbl_fecha_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_menu
            // 
            this.panel_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_menu.Controls.Add(this.lbl_venta);
            this.panel_menu.Controls.Add(this.panel_ventas);
            this.panel_menu.Controls.Add(this.srch_bar_panel);
            this.panel_menu.Controls.Add(this.pnl_der);
            this.panel_menu.Location = new System.Drawing.Point(12, 61);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(874, 566);
            this.panel_menu.TabIndex = 12;
            // 
            // lbl_venta
            // 
            this.lbl_venta.AutoSize = true;
            this.lbl_venta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_venta.Location = new System.Drawing.Point(47, 16);
            this.lbl_venta.Name = "lbl_venta";
            this.lbl_venta.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbl_venta.Size = new System.Drawing.Size(109, 34);
            this.lbl_venta.TabIndex = 13;
            this.lbl_venta.Text = "Venta N°: ";
            // 
            // panel_ventas
            // 
            this.panel_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(106)))), ((int)(((byte)(133)))));
            this.panel_ventas.Controls.Add(this.label4);
            this.panel_ventas.Controls.Add(this.lbl_ganancias);
            this.panel_ventas.Controls.Add(this.lbl_borrar_seleccion);
            this.panel_ventas.Controls.Add(this.btn_borrar_seleccion);
            this.panel_ventas.Controls.Add(this.lbl_total_txt);
            this.panel_ventas.Controls.Add(this.lbl_total);
            this.panel_ventas.Controls.Add(this.pnl_ventas);
            this.panel_ventas.Location = new System.Drawing.Point(21, 68);
            this.panel_ventas.Name = "panel_ventas";
            this.panel_ventas.Size = new System.Drawing.Size(495, 491);
            this.panel_ventas.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(53, 429);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.label4.Size = new System.Drawing.Size(203, 46);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ganancias hoy:";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // lbl_ganancias
            // 
            this.lbl_ganancias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ganancias.AutoSize = true;
            this.lbl_ganancias.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ganancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ganancias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_ganancias.Location = new System.Drawing.Point(272, 432);
            this.lbl_ganancias.Name = "lbl_ganancias";
            this.lbl_ganancias.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbl_ganancias.Size = new System.Drawing.Size(0, 43);
            this.lbl_ganancias.TabIndex = 20;
            this.lbl_ganancias.UseCompatibleTextRendering = true;
            // 
            // lbl_borrar_seleccion
            // 
            this.lbl_borrar_seleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_borrar_seleccion.AutoSize = true;
            this.lbl_borrar_seleccion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_borrar_seleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_borrar_seleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lbl_borrar_seleccion.Location = new System.Drawing.Point(49, 350);
            this.lbl_borrar_seleccion.Name = "lbl_borrar_seleccion";
            this.lbl_borrar_seleccion.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbl_borrar_seleccion.Size = new System.Drawing.Size(107, 25);
            this.lbl_borrar_seleccion.TabIndex = 18;
            this.lbl_borrar_seleccion.Text = "Borrar Selección";
            this.lbl_borrar_seleccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_borrar_seleccion
            // 
            this.btn_borrar_seleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_borrar_seleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_borrar_seleccion.Enabled = false;
            this.btn_borrar_seleccion.FlatAppearance.BorderSize = 0;
            this.btn_borrar_seleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar_seleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar_seleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_borrar_seleccion.Image = global::Ventas_Productos.Properties.Resources.x;
            this.btn_borrar_seleccion.Location = new System.Drawing.Point(15, 353);
            this.btn_borrar_seleccion.MaximumSize = new System.Drawing.Size(26, 26);
            this.btn_borrar_seleccion.Name = "btn_borrar_seleccion";
            this.btn_borrar_seleccion.Size = new System.Drawing.Size(26, 26);
            this.btn_borrar_seleccion.TabIndex = 19;
            this.btn_borrar_seleccion.UseVisualStyleBackColor = false;
            this.btn_borrar_seleccion.Click += new System.EventHandler(this.btn_borrar_seleccion_Click);
            // 
            // lbl_total_txt
            // 
            this.lbl_total_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total_txt.AutoSize = true;
            this.lbl_total_txt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_total_txt.Location = new System.Drawing.Point(174, 385);
            this.lbl_total_txt.Name = "lbl_total_txt";
            this.lbl_total_txt.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbl_total_txt.Size = new System.Drawing.Size(87, 46);
            this.lbl_total_txt.TabIndex = 18;
            this.lbl_total_txt.Text = "Total: ";
            this.lbl_total_txt.UseCompatibleTextRendering = true;
            // 
            // pnl_ventas
            // 
            this.pnl_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.pnl_ventas.Controls.Add(this.scrollbar_ventas);
            this.pnl_ventas.Controls.Add(this.label3);
            this.pnl_ventas.Controls.Add(this.label2);
            this.pnl_ventas.Controls.Add(this.label1);
            this.pnl_ventas.Controls.Add(this.dgv_ventas);
            this.pnl_ventas.Location = new System.Drawing.Point(15, 13);
            this.pnl_ventas.Name = "pnl_ventas";
            this.pnl_ventas.Size = new System.Drawing.Size(467, 334);
            this.pnl_ventas.TabIndex = 17;
            // 
            // scrollbar_ventas
            // 
            this.scrollbar_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scrollbar_ventas.LargeChange = 10;
            this.scrollbar_ventas.Location = new System.Drawing.Point(448, 50);
            this.scrollbar_ventas.Maximum = 100;
            this.scrollbar_ventas.Minimum = 0;
            this.scrollbar_ventas.Name = "scrollbar_ventas";
            this.scrollbar_ventas.Size = new System.Drawing.Size(4, 265);
            this.scrollbar_ventas.TabIndex = 4;
            this.scrollbar_ventas.Text = "scrollBar1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(391, 8);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.label3.Size = new System.Drawing.Size(53, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(208, 8);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(33, 8);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Producto";
            // 
            // dgv_ventas
            // 
            this.dgv_ventas.AllowUserToAddRows = false;
            this.dgv_ventas.AllowUserToDeleteRows = false;
            this.dgv_ventas.AllowUserToResizeColumns = false;
            this.dgv_ventas.AllowUserToResizeRows = false;
            this.dgv_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.dgv_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventas.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ventas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ventas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_ventas.EnableHeadersVisualStyles = false;
            this.dgv_ventas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.dgv_ventas.Location = new System.Drawing.Point(33, 50);
            this.dgv_ventas.MultiSelect = false;
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ventas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_ventas.RowHeadersVisible = false;
            this.dgv_ventas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(106)))), ((int)(((byte)(133)))));
            this.dgv_ventas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_ventas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ventas.ShowCellErrors = false;
            this.dgv_ventas.ShowEditingIcon = false;
            this.dgv_ventas.ShowRowErrors = false;
            this.dgv_ventas.Size = new System.Drawing.Size(404, 265);
            this.dgv_ventas.StandardTab = true;
            this.dgv_ventas.TabIndex = 3;
            this.dgv_ventas.VirtualMode = true;
            this.dgv_ventas.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dgv_ventas_CellToolTipTextNeeded);
            this.dgv_ventas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_ventas_RowsAdded);
            this.dgv_ventas.SelectionChanged += new System.EventHandler(this.dgv_ventas_SelectionChanged);
            // 
            // pnl_der
            // 
            this.pnl_der.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_der.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(106)))), ((int)(((byte)(133)))));
            this.pnl_der.Controls.Add(this.pnl_productos);
            this.pnl_der.Controls.Add(this.btn_confirmar);
            this.pnl_der.Controls.Add(this.btn_limpiar);
            this.pnl_der.Location = new System.Drawing.Point(540, 68);
            this.pnl_der.Name = "pnl_der";
            this.pnl_der.Size = new System.Drawing.Size(320, 491);
            this.pnl_der.TabIndex = 3;
            // 
            // pnl_productos
            // 
            this.pnl_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.pnl_productos.Controls.Add(this.scrollbar_productos);
            this.pnl_productos.Controls.Add(this.lbl_productos);
            this.pnl_productos.Controls.Add(this.dgv_productos);
            this.pnl_productos.Location = new System.Drawing.Point(0, 13);
            this.pnl_productos.Name = "pnl_productos";
            this.pnl_productos.Size = new System.Drawing.Size(320, 400);
            this.pnl_productos.TabIndex = 12;
            // 
            // scrollbar_productos
            // 
            this.scrollbar_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scrollbar_productos.LargeChange = 10;
            this.scrollbar_productos.Location = new System.Drawing.Point(303, 50);
            this.scrollbar_productos.Maximum = 100;
            this.scrollbar_productos.Minimum = 0;
            this.scrollbar_productos.Name = "scrollbar_productos";
            this.scrollbar_productos.Size = new System.Drawing.Size(4, 331);
            this.scrollbar_productos.TabIndex = 3;
            this.scrollbar_productos.Text = "scrollBar1";
            // 
            // lbl_productos
            // 
            this.lbl_productos.AutoSize = true;
            this.lbl_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_productos.Location = new System.Drawing.Point(104, 20);
            this.lbl_productos.Name = "lbl_productos";
            this.lbl_productos.Size = new System.Drawing.Size(109, 25);
            this.lbl_productos.TabIndex = 2;
            this.lbl_productos.Text = "Productos";
            // 
            // verEstadísticasToolStripMenuItem
            // 
            this.verEstadísticasToolStripMenuItem.Name = "verEstadísticasToolStripMenuItem";
            this.verEstadísticasToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.verEstadísticasToolStripMenuItem.Text = "Ver Estadísticas";
            this.verEstadísticasToolStripMenuItem.Click += new System.EventHandler(this.verEstadísticasToolStripMenuItem_Click);
            // 
            // view_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(106)))), ((int)(((byte)(133)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(898, 698);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_fecha_hora);
            this.Controls.Add(this.lbl_suma);
            this.Controls.Add(this.help_bar_panel);
            this.Controls.Add(this.panel_menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "view_ventas";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.view_ventas_Load);
            this.Shown += new System.EventHandler(this.view_ventas_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.view_ventas_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.srch_bar_panel.ResumeLayout(false);
            this.srch_bar_panel.PerformLayout();
            this.help_bar_panel.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_ventas.ResumeLayout(false);
            this.panel_ventas.PerformLayout();
            this.pnl_ventas.ResumeLayout(false);
            this.pnl_ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            this.pnl_der.ResumeLayout(false);
            this.pnl_productos.ResumeLayout(false);
            this.pnl_productos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgv_productos;
        private Button btn_limpiar;
        private Button btn_confirmar;
        private TextBox txtbox_busqueda;
        private Label lbl_total;
        private Label lbl_suma;
        private Panel srch_bar_panel;
        private Button btn_cerrar;
        private Panel help_bar_panel;
        private Button btn_max;
        private Button btn_minimizar;
        private Panel panel_menu;
        private Label icono_busqueda;
        private Panel panel_ventas;
        private Panel pnl_productos;
        private Label lbl_productos;
        private DataGridView dgv_ventas;
        private Label lbl_venta;
        private Panel pnl_ventas;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripDropDownButton toolStripDropDownButton4;
        private ToolStripDropDownButton toolStripDropDownButton5;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem pruebaToolStripMenuItem;
        private Button btn_user;
        private Label lbl_total_txt;
        private ToolStripMenuItem verProductosToolStripMenuItem;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel pnl_der;
        private ToolStripMenuItem verStockToolStripMenuItem;
        private Label lbl_fecha_hora;
        private ScrollBar scrollbar_productos;
        private ScrollBar scrollbar_ventas;
        private Button btn_borrar_seleccion;
        private Label lbl_borrar_seleccion;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Label label4;
        private Label lbl_ganancias;
        private ToolStripMenuItem verEstadísticasToolStripMenuItem;
    }
}
