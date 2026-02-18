namespace Ventas_Productos.UI
{
    partial class view_autenticar
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
            this.lbl_fecha_hora = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.srch_bar_panel = new System.Windows.Forms.Panel();
            this.icono_busqueda = new System.Windows.Forms.Label();
            this.txtbox_busqueda = new System.Windows.Forms.TextBox();
            this.srch_bar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_fecha_hora
            // 
            this.lbl_fecha_hora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_fecha_hora.AutoSize = true;
            this.lbl_fecha_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha_hora.Font = new System.Drawing.Font("Lao Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_fecha_hora.Location = new System.Drawing.Point(52, 25);
            this.lbl_fecha_hora.Name = "lbl_fecha_hora";
            this.lbl_fecha_hora.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbl_fecha_hora.Size = new System.Drawing.Size(138, 26);
            this.lbl_fecha_hora.TabIndex = 18;
            this.lbl_fecha_hora.Text = "Escriba la contraseña";
            this.lbl_fecha_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_cerrar.Location = new System.Drawing.Point(222, 0);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(24, 23);
            this.btn_cerrar.TabIndex = 13;
            this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            this.btn_cerrar.MouseEnter += new System.EventHandler(this.btn_cerrar_MouseEnter);
            this.btn_cerrar.MouseLeave += new System.EventHandler(this.btn_cerrar_MouseLeave);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_confirmar.FlatAppearance.BorderSize = 0;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Lao Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_confirmar.Location = new System.Drawing.Point(60, 117);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(117, 40);
            this.btn_confirmar.TabIndex = 11;
            this.btn_confirmar.Text = "Aceptar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // srch_bar_panel
            // 
            this.srch_bar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.srch_bar_panel.Controls.Add(this.icono_busqueda);
            this.srch_bar_panel.Controls.Add(this.txtbox_busqueda);
            this.srch_bar_panel.Location = new System.Drawing.Point(15, 66);
            this.srch_bar_panel.Name = "srch_bar_panel";
            this.srch_bar_panel.Size = new System.Drawing.Size(205, 37);
            this.srch_bar_panel.TabIndex = 12;
            // 
            // icono_busqueda
            // 
            this.icono_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.icono_busqueda.AutoSize = true;
            this.icono_busqueda.Image = global::Ventas_Productos.Properties.Resources.lock_;
            this.icono_busqueda.Location = new System.Drawing.Point(0, 1);
            this.icono_busqueda.MinimumSize = new System.Drawing.Size(34, 35);
            this.icono_busqueda.Name = "icono_busqueda";
            this.icono_busqueda.Size = new System.Drawing.Size(34, 35);
            this.icono_busqueda.TabIndex = 12;
            // 
            // txtbox_busqueda
            // 
            this.txtbox_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.txtbox_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_busqueda.Font = new System.Drawing.Font("Lao Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbox_busqueda.Location = new System.Drawing.Point(47, 6);
            this.txtbox_busqueda.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.txtbox_busqueda.Name = "txtbox_busqueda";
            this.txtbox_busqueda.PasswordChar = '*';
            this.txtbox_busqueda.Size = new System.Drawing.Size(141, 24);
            this.txtbox_busqueda.TabIndex = 6;
            // 
            // view_autenticar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(106)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(247, 170);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_fecha_hora);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.srch_bar_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "view_autenticar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.srch_bar_panel.ResumeLayout(false);
            this.srch_bar_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel srch_bar_panel;
        private System.Windows.Forms.Label icono_busqueda;
        private System.Windows.Forms.TextBox txtbox_busqueda;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_fecha_hora;
    }
}