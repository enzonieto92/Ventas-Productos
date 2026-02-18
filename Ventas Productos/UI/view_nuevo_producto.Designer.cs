using System.Windows.Forms;
using System.Drawing;

namespace Ventas_Productos.UI
{
    partial class view_nuevo_producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_nuevo_producto));
            this.lbl_productos = new System.Windows.Forms.Label();
            this.help_bar_panel = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.srch_bar_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_nombre = new System.Windows.Forms.TextBox();
            this.icono_busqueda = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbox_cod_barras = new System.Windows.Forms.TextBox();
            this.txtbox_precio = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tlsp_porcentaje = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lbl_precio_final = new System.Windows.Forms.Label();
            this.lbl_precio_porcentaje = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.srch_bar_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tlsp_porcentaje.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_productos
            // 
            this.lbl_productos.AutoSize = true;
            this.lbl_productos.Font = new System.Drawing.Font("Lao Sans Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_productos.Location = new System.Drawing.Point(132, 66);
            this.lbl_productos.Name = "lbl_productos";
            this.lbl_productos.Size = new System.Drawing.Size(186, 31);
            this.lbl_productos.TabIndex = 0;
            this.lbl_productos.Text = "Nuevo Producto";
            // 
            // help_bar_panel
            // 
            this.help_bar_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.help_bar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.help_bar_panel.Location = new System.Drawing.Point(0, 0);
            this.help_bar_panel.Name = "help_bar_panel";
            this.help_bar_panel.Size = new System.Drawing.Size(404, 23);
            this.help_bar_panel.TabIndex = 0;
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
            this.btn_cerrar.Location = new System.Drawing.Point(399, 0);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(24, 23);
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            this.btn_cerrar.MouseEnter += new System.EventHandler(this.btn_cerrar_MouseEnter);
            this.btn_cerrar.MouseLeave += new System.EventHandler(this.btn_cerrar_MouseLeave);
            // 
            // srch_bar_panel
            // 
            this.srch_bar_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.srch_bar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.srch_bar_panel.Controls.Add(this.label1);
            this.srch_bar_panel.Controls.Add(this.txtbox_nombre);
            this.srch_bar_panel.Location = new System.Drawing.Point(76, 149);
            this.srch_bar_panel.MaximumSize = new System.Drawing.Size(265, 37);
            this.srch_bar_panel.Name = "srch_bar_panel";
            this.srch_bar_panel.Size = new System.Drawing.Size(265, 37);
            this.srch_bar_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::Ventas_Productos.Properties.Resources.label;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.MinimumSize = new System.Drawing.Size(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 35);
            this.label1.TabIndex = 0;
            // 
            // txtbox_nombre
            // 
            this.txtbox_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbox_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.txtbox_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_nombre.Font = new System.Drawing.Font("Lao Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbox_nombre.Location = new System.Drawing.Point(66, 8);
            this.txtbox_nombre.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtbox_nombre.Name = "txtbox_nombre";
            this.txtbox_nombre.Size = new System.Drawing.Size(178, 24);
            this.txtbox_nombre.TabIndex = 1;
            this.txtbox_nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_nombre_KeyDown);
            // 
            // icono_busqueda
            // 
            this.icono_busqueda.AutoSize = true;
            this.icono_busqueda.Image = global::Ventas_Productos.Properties.Resources.scan;
            this.icono_busqueda.Location = new System.Drawing.Point(8, 0);
            this.icono_busqueda.MinimumSize = new System.Drawing.Size(34, 35);
            this.icono_busqueda.Name = "icono_busqueda";
            this.icono_busqueda.Size = new System.Drawing.Size(34, 35);
            this.icono_busqueda.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.icono_busqueda);
            this.panel1.Controls.Add(this.txtbox_cod_barras);
            this.panel1.Location = new System.Drawing.Point(76, 218);
            this.panel1.MaximumSize = new System.Drawing.Size(265, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 37);
            this.panel1.TabIndex = 2;
            // 
            // txtbox_cod_barras
            // 
            this.txtbox_cod_barras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbox_cod_barras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.txtbox_cod_barras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_cod_barras.Font = new System.Drawing.Font("Lao Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cod_barras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbox_cod_barras.Location = new System.Drawing.Point(66, 8);
            this.txtbox_cod_barras.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtbox_cod_barras.Name = "txtbox_cod_barras";
            this.txtbox_cod_barras.Size = new System.Drawing.Size(180, 24);
            this.txtbox_cod_barras.TabIndex = 2;
            this.txtbox_cod_barras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_cod_barras_KeyDown);
            // 
            // txtbox_precio
            // 
            this.txtbox_precio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbox_precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.txtbox_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_precio.Font = new System.Drawing.Font("Lao Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbox_precio.Location = new System.Drawing.Point(66, 8);
            this.txtbox_precio.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtbox_precio.Name = "txtbox_precio";
            this.txtbox_precio.Size = new System.Drawing.Size(178, 24);
            this.txtbox_precio.TabIndex = 3;
            this.txtbox_precio.TextChanged += new System.EventHandler(this.txtbox_precio_TextChanged);
            this.txtbox_precio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_precio_KeyDown);
            this.txtbox_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_precio_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtbox_precio);
            this.panel2.Location = new System.Drawing.Point(76, 283);
            this.panel2.MaximumSize = new System.Drawing.Size(265, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 37);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::Ventas_Productos.Properties.Resources.receipt;
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.MinimumSize = new System.Drawing.Size(34, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 35);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(87, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(87, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código de Barras";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(87, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Precio";
            // 
            // tlsp_porcentaje
            // 
            this.tlsp_porcentaje.AllowMerge = false;
            this.tlsp_porcentaje.AutoSize = false;
            this.tlsp_porcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.tlsp_porcentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tlsp_porcentaje.CanOverflow = false;
            this.tlsp_porcentaje.Dock = System.Windows.Forms.DockStyle.None;
            this.tlsp_porcentaje.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlsp_porcentaje.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.tlsp_porcentaje.Location = new System.Drawing.Point(75, 349);
            this.tlsp_porcentaje.Name = "tlsp_porcentaje";
            this.tlsp_porcentaje.Padding = new System.Windows.Forms.Padding(0);
            this.tlsp_porcentaje.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tlsp_porcentaje.ShowItemToolTips = false;
            this.tlsp_porcentaje.Size = new System.Drawing.Size(52, 37);
            this.tlsp_porcentaje.TabIndex = 4;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.AutoToolTip = false;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem5,
            this.toolStripMenuItem8,
            this.toolStripMenuItem10,
            this.toolStripMenuItem9});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton1.Image = global::Ventas_Productos.Properties.Resources.percentage;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.MergeIndex = 1;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripDropDownButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(50, 37);
            this.toolStripDropDownButton1.Text = "0%";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripDropDownButton1.ToolTipText = "0";
            this.toolStripDropDownButton1.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripDropDownButton1_DropDownItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Lao Sans Pro", 12F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem1.Text = "0%";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Lao Sans Pro", 12F);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem2.Text = "10%";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Lao Sans Pro", 12F);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem3.Text = "15%";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AutoSize = false;
            this.toolStripMenuItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Lao Sans Pro", 12F);
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem4.Text = "25%";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.AutoSize = false;
            this.toolStripMenuItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Lao Sans Pro", 12F);
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem6.Text = "30%";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.AutoSize = false;
            this.toolStripMenuItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Lao Sans Pro", 12F);
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem7.Text = "50%";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.AutoSize = false;
            this.toolStripMenuItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Lao Sans Pro", 12F);
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem5.Text = "75%";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.AutoSize = false;
            this.toolStripMenuItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Lao Sans Pro", 12F);
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem8.Text = "100%";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.AutoSize = false;
            this.toolStripMenuItem10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem10.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem10.Text = "150%";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.AutoSize = false;
            this.toolStripMenuItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem9.Font = new System.Drawing.Font("Lao Sans Pro", 12F);
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuItem9.Text = "200%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(87, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Agregar Porcentaje";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_confirmar.FlatAppearance.BorderSize = 0;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Lao Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_confirmar.Location = new System.Drawing.Point(78, 455);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(117, 40);
            this.btn_confirmar.TabIndex = 5;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Lao Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_limpiar.Location = new System.Drawing.Point(225, 455);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(116, 40);
            this.btn_limpiar.TabIndex = 6;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // lbl_precio_final
            // 
            this.lbl_precio_final.AutoSize = true;
            this.lbl_precio_final.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_final.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_precio_final.Location = new System.Drawing.Point(7, 8);
            this.lbl_precio_final.Name = "lbl_precio_final";
            this.lbl_precio_final.Size = new System.Drawing.Size(94, 20);
            this.lbl_precio_final.TabIndex = 0;
            this.lbl_precio_final.Text = "Precio Final:";
            // 
            // lbl_precio_porcentaje
            // 
            this.lbl_precio_porcentaje.AutoSize = true;
            this.lbl_precio_porcentaje.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_porcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_precio_porcentaje.Location = new System.Drawing.Point(96, 8);
            this.lbl_precio_porcentaje.Name = "lbl_precio_porcentaje";
            this.lbl_precio_porcentaje.Size = new System.Drawing.Size(52, 20);
            this.lbl_precio_porcentaje.TabIndex = 0;
            this.lbl_precio_porcentaje.Text = "$ 0.00";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.panel3.Controls.Add(this.lbl_precio_final);
            this.panel3.Controls.Add(this.lbl_precio_porcentaje);
            this.panel3.Location = new System.Drawing.Point(125, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 37);
            this.panel3.TabIndex = 0;
            // 
            // view_nuevo_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(106)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(423, 550);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tlsp_porcentaje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.srch_bar_panel);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.help_bar_panel);
            this.Controls.Add(this.lbl_productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "view_nuevo_producto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.view_nuevo_producto_Load);
            this.srch_bar_panel.ResumeLayout(false);
            this.srch_bar_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tlsp_porcentaje.ResumeLayout(false);
            this.tlsp_porcentaje.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_productos;
        private Panel help_bar_panel;
        private Button btn_cerrar;
        private Panel srch_bar_panel;
        private Label icono_busqueda;
        private TextBox txtbox_nombre;
        private Panel panel1;
        private Label label1;
        private TextBox txtbox_precio;
        private Panel panel2;
        private Label label2;
        private TextBox txtbox_cod_barras;
        private Label label3;
        private Label label4;
        private Label label5;
        private ToolStrip tlsp_porcentaje;
        private Label label7;
        private Button btn_confirmar;
        private Button btn_limpiar;
        private Label lbl_precio_final;
        private Label lbl_precio_porcentaje;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private Panel panel3;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem9;
    }
}