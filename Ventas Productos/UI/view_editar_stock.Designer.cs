using System.Windows.Forms;

namespace Ventas_Productos.UI
{
    partial class view_editar_stock
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
            this.help_bar_panel = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lbl_productos = new System.Windows.Forms.Label();
            this.txtbox_cantidad = new System.Windows.Forms.TextBox();
            this.srch_bar_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.help_bar_panel.SuspendLayout();
            this.srch_bar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // help_bar_panel
            // 
            this.help_bar_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.help_bar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.help_bar_panel.Controls.Add(this.btn_cerrar);
            this.help_bar_panel.Location = new System.Drawing.Point(1, -1);
            this.help_bar_panel.Name = "help_bar_panel";
            this.help_bar_panel.Size = new System.Drawing.Size(312, 23);
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
            this.btn_cerrar.Image = global::Ventas_Productos.Properties.Resources.x;
            this.btn_cerrar.Location = new System.Drawing.Point(286, 0);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(24, 23);
            this.btn_cerrar.TabIndex = 17;
            this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_cerrar_MouseClick);
            this.btn_cerrar.MouseEnter += new System.EventHandler(this.btn_cerrar_MouseEnter);
            this.btn_cerrar.MouseLeave += new System.EventHandler(this.btn_cerrar_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lao Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(92, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Editar Stock";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_confirmar.FlatAppearance.BorderSize = 0;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Lao Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_confirmar.Location = new System.Drawing.Point(12, 274);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(117, 40);
            this.btn_confirmar.TabIndex = 23;
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
            this.btn_limpiar.Location = new System.Drawing.Point(182, 274);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(116, 40);
            this.btn_limpiar.TabIndex = 22;
            this.btn_limpiar.Text = "Cancelar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // lbl_productos
            // 
            this.lbl_productos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_productos.AutoSize = true;
            this.lbl_productos.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_productos.Location = new System.Drawing.Point(95, 171);
            this.lbl_productos.Name = "lbl_productos";
            this.lbl_productos.Size = new System.Drawing.Size(73, 20);
            this.lbl_productos.TabIndex = 2;
            this.lbl_productos.Text = "Cantidad";
            // 
            // txtbox_cantidad
            // 
            this.txtbox_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbox_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.txtbox_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_cantidad.Font = new System.Drawing.Font("Lao Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbox_cantidad.Location = new System.Drawing.Point(12, 6);
            this.txtbox_cantidad.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtbox_cantidad.Name = "txtbox_cantidad";
            this.txtbox_cantidad.Size = new System.Drawing.Size(97, 24);
            this.txtbox_cantidad.TabIndex = 6;
            this.txtbox_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_cantidad_KeyPress);
            // 
            // srch_bar_panel
            // 
            this.srch_bar_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.srch_bar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.srch_bar_panel.Controls.Add(this.txtbox_cantidad);
            this.srch_bar_panel.Location = new System.Drawing.Point(97, 194);
            this.srch_bar_panel.Name = "srch_bar_panel";
            this.srch_bar_panel.Size = new System.Drawing.Size(121, 37);
            this.srch_bar_panel.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(95, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Producto:";
            // 
            // lbl_producto
            // 
            this.lbl_producto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_producto.Location = new System.Drawing.Point(150, 128);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(0, 20);
            this.lbl_producto.TabIndex = 26;
            // 
            // view_editar_stock
            // 
            this.AcceptButton = this.btn_confirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(106)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(310, 326);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srch_bar_panel);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.lbl_productos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.help_bar_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "view_editar_stock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.view_stock_edicion_Load);
            this.help_bar_panel.ResumeLayout(false);
            this.srch_bar_panel.ResumeLayout(false);
            this.srch_bar_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_cerrar;
        private Panel help_bar_panel;
        private Label label2;
        private Button btn_confirmar;
        private Button btn_limpiar;
        private Label lbl_productos;
        private TextBox txtbox_cantidad;
        private Panel srch_bar_panel;
        private Label label1;
        private Label lbl_producto;
    }
}