using System.Windows.Forms;
using System.Drawing;
namespace Ventas_Productos.UI
{
    partial class view_historial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_historial));
            this.help_bar_panel = new System.Windows.Forms.Panel();
            this.pnl_ventas = new System.Windows.Forms.Panel();
            this.scrollbar_productos = new ScrollBar();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.dgv_historial = new System.Windows.Forms.DataGridView();
            this.lbl_productos = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_esta_semana = new System.Windows.Forms.Button();
            this.btn_este_mes = new System.Windows.Forms.Button();
            this.btn_todo = new System.Windows.Forms.Button();
            this.btn_hoy = new System.Windows.Forms.Button();
            this.pnl_botones = new System.Windows.Forms.Panel();
            this.pnl_ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).BeginInit();
            this.pnl_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // help_bar_panel
            // 
            this.help_bar_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.help_bar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.help_bar_panel.Location = new System.Drawing.Point(0, -1);
            this.help_bar_panel.Name = "help_bar_panel";
            this.help_bar_panel.Size = new System.Drawing.Size(512, 23);
            this.help_bar_panel.TabIndex = 12;
            // 
            // pnl_ventas
            // 
            this.pnl_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.pnl_ventas.Controls.Add(this.scrollbar_productos);
            this.pnl_ventas.Controls.Add(this.lbl_total);
            this.pnl_ventas.Controls.Add(this.lbl_fecha);
            this.pnl_ventas.Controls.Add(this.dgv_historial);
            this.pnl_ventas.Location = new System.Drawing.Point(10, 120);
            this.pnl_ventas.Name = "pnl_ventas";
            this.pnl_ventas.Size = new System.Drawing.Size(514, 409);
            this.pnl_ventas.TabIndex = 18;
            // 
            // scrollbar_productos
            // 
            this.scrollbar_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scrollbar_productos.LargeChange = 10;
            this.scrollbar_productos.Location = new System.Drawing.Point(501, 62);
            this.scrollbar_productos.Maximum = 100;
            this.scrollbar_productos.Minimum = 0;
            this.scrollbar_productos.Name = "scrollbar_productos";
            this.scrollbar_productos.Size = new System.Drawing.Size(4, 331);
            this.scrollbar_productos.TabIndex = 21;
            this.scrollbar_productos.Text = "scrollBar1";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Lao Sans Pro", 12F);
            this.lbl_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_total.Location = new System.Drawing.Point(447, 34);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbl_total.Size = new System.Drawing.Size(44, 29);
            this.lbl_total.TabIndex = 20;
            this.lbl_total.Text = "Total";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Lao Sans Pro", 12F);
            this.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_fecha.Location = new System.Drawing.Point(11, 34);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lbl_fecha.Size = new System.Drawing.Size(54, 29);
            this.lbl_fecha.TabIndex = 19;
            this.lbl_fecha.Text = "Fecha";
            // 
            // dgv_historial
            // 
            this.dgv_historial.AllowUserToAddRows = false;
            this.dgv_historial.AllowUserToDeleteRows = false;
            this.dgv_historial.AllowUserToResizeColumns = false;
            this.dgv_historial.AllowUserToResizeRows = false;
            this.dgv_historial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_historial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_historial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.dgv_historial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_historial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_historial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historial.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_historial.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_historial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_historial.EnableHeadersVisualStyles = false;
            this.dgv_historial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.dgv_historial.Location = new System.Drawing.Point(11, 62);
            this.dgv_historial.Name = "dgv_historial";
            this.dgv_historial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_historial.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_historial.RowHeadersVisible = false;
            this.dgv_historial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lao Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(106)))), ((int)(((byte)(133)))));
            this.dgv_historial.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_historial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_historial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_historial.ShowCellErrors = false;
            this.dgv_historial.ShowEditingIcon = false;
            this.dgv_historial.ShowRowErrors = false;
            this.dgv_historial.Size = new System.Drawing.Size(480, 331);
            this.dgv_historial.StandardTab = true;
            this.dgv_historial.TabIndex = 3;
            this.dgv_historial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_historial_CellDoubleClick);
            this.dgv_historial.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dgv_historial_CellToolTipTextNeeded);
            // 
            // lbl_productos
            // 
            this.lbl_productos.AutoSize = true;
            this.lbl_productos.Font = new System.Drawing.Font("Lao Sans Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_productos.Location = new System.Drawing.Point(163, 42);
            this.lbl_productos.Name = "lbl_productos";
            this.lbl_productos.Size = new System.Drawing.Size(213, 31);
            this.lbl_productos.TabIndex = 14;
            this.lbl_productos.Text = "Historial de Ventas";
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
            this.btn_cerrar.Location = new System.Drawing.Point(510, -1);
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
            // btn_esta_semana
            // 
            this.btn_esta_semana.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_esta_semana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(102)))), ((int)(((byte)(133)))));
            this.btn_esta_semana.FlatAppearance.BorderSize = 0;
            this.btn_esta_semana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(149)))), ((int)(((byte)(175)))));
            this.btn_esta_semana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.btn_esta_semana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_esta_semana.Font = new System.Drawing.Font("Lao Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_esta_semana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_esta_semana.Location = new System.Drawing.Point(248, 0);
            this.btn_esta_semana.Name = "btn_esta_semana";
            this.btn_esta_semana.Size = new System.Drawing.Size(98, 24);
            this.btn_esta_semana.TabIndex = 22;
            this.btn_esta_semana.Text = "Esta Semana";
            this.btn_esta_semana.UseVisualStyleBackColor = false;
            this.btn_esta_semana.Click += new System.EventHandler(this.btn_esta_semana_Click);
            // 
            // btn_este_mes
            // 
            this.btn_este_mes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_este_mes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(102)))), ((int)(((byte)(133)))));
            this.btn_este_mes.FlatAppearance.BorderSize = 0;
            this.btn_este_mes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(149)))), ((int)(((byte)(175)))));
            this.btn_este_mes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.btn_este_mes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_este_mes.Font = new System.Drawing.Font("Lao Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_este_mes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_este_mes.Location = new System.Drawing.Point(169, 0);
            this.btn_este_mes.Name = "btn_este_mes";
            this.btn_este_mes.Size = new System.Drawing.Size(73, 24);
            this.btn_este_mes.TabIndex = 23;
            this.btn_este_mes.Text = "Este Mes";
            this.btn_este_mes.UseVisualStyleBackColor = false;
            this.btn_este_mes.Click += new System.EventHandler(this.btn_este_mes_Click);
            // 
            // btn_todo
            // 
            this.btn_todo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(102)))), ((int)(((byte)(133)))));
            this.btn_todo.FlatAppearance.BorderSize = 0;
            this.btn_todo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(149)))), ((int)(((byte)(175)))));
            this.btn_todo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.btn_todo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_todo.Font = new System.Drawing.Font("Lao Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_todo.Location = new System.Drawing.Point(100, 0);
            this.btn_todo.Name = "btn_todo";
            this.btn_todo.Size = new System.Drawing.Size(63, 24);
            this.btn_todo.TabIndex = 24;
            this.btn_todo.Text = "Todo";
            this.btn_todo.UseVisualStyleBackColor = false;
            this.btn_todo.Click += new System.EventHandler(this.btn_todo_Click);
            // 
            // btn_hoy
            // 
            this.btn_hoy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_hoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(102)))), ((int)(((byte)(133)))));
            this.btn_hoy.FlatAppearance.BorderSize = 0;
            this.btn_hoy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(149)))), ((int)(((byte)(175)))));
            this.btn_hoy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(141)))), ((int)(((byte)(155)))));
            this.btn_hoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hoy.Font = new System.Drawing.Font("Lao Sans Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_hoy.Location = new System.Drawing.Point(352, 0);
            this.btn_hoy.Name = "btn_hoy";
            this.btn_hoy.Size = new System.Drawing.Size(60, 24);
            this.btn_hoy.TabIndex = 25;
            this.btn_hoy.Text = "Hoy";
            this.btn_hoy.UseVisualStyleBackColor = false;
            this.btn_hoy.Click += new System.EventHandler(this.btn_hoy_Click);
            // 
            // pnl_botones
            // 
            this.pnl_botones.Controls.Add(this.btn_hoy);
            this.pnl_botones.Controls.Add(this.btn_esta_semana);
            this.pnl_botones.Controls.Add(this.btn_todo);
            this.pnl_botones.Controls.Add(this.btn_este_mes);
            this.pnl_botones.Location = new System.Drawing.Point(12, 90);
            this.pnl_botones.Name = "pnl_botones";
            this.pnl_botones.Size = new System.Drawing.Size(512, 24);
            this.pnl_botones.TabIndex = 22;
            // 
            // view_historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(106)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(535, 657);
            this.ControlBox = false;
            this.Controls.Add(this.help_bar_panel);
            this.Controls.Add(this.pnl_ventas);
            this.Controls.Add(this.lbl_productos);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.pnl_botones);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "view_historial";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.view_historial_Load);
            this.pnl_ventas.ResumeLayout(false);
            this.pnl_ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).EndInit();
            this.pnl_botones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_cerrar;
        private Label lbl_productos;
        private Panel pnl_ventas;
        private DataGridView dgv_historial;
        private Panel help_bar_panel;
        private Label lbl_total;
        private Label lbl_fecha;
        private ScrollBar scrollbar_productos;
        private Button btn_esta_semana;
        private Button btn_este_mes;
        private Button btn_todo;
        private Button btn_hoy;
        private Panel pnl_botones;
    }
}