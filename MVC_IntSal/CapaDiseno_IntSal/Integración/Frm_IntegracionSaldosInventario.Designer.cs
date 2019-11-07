﻿namespace CapaDiseno_IntSal.Integración
{
    partial class Frm_IntegracionSaldosInventario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pnl_Integracion = new System.Windows.Forms.Panel();
            this.Dgv_Integracion = new System.Windows.Forms.DataGridView();
            this.Tipo_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Lbl_Producto = new System.Windows.Forms.Label();
            this.Lbl_FechaInicio = new System.Windows.Forms.Label();
            this.Lbl_FechaFin = new System.Windows.Forms.Label();
            this.Cbo_Codigo = new System.Windows.Forms.ComboBox();
            this.Cbo_Producto = new System.Windows.Forms.ComboBox();
            this.Dtp_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Totales = new System.Windows.Forms.Label();
            this.Txt_CM = new System.Windows.Forms.TextBox();
            this.Txt_CF = new System.Windows.Forms.TextBox();
            this.Lbl_Integracion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Pnl_Integracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Integracion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Pnl_Integracion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 508);
            this.panel1.TabIndex = 0;
            // 
            // Pnl_Integracion
            // 
            this.Pnl_Integracion.BackColor = System.Drawing.Color.White;
            this.Pnl_Integracion.Controls.Add(this.Lbl_Integracion);
            this.Pnl_Integracion.Controls.Add(this.Txt_CF);
            this.Pnl_Integracion.Controls.Add(this.Txt_CM);
            this.Pnl_Integracion.Controls.Add(this.Lbl_Totales);
            this.Pnl_Integracion.Controls.Add(this.Dtp_FechaFin);
            this.Pnl_Integracion.Controls.Add(this.Dtp_FechaInicio);
            this.Pnl_Integracion.Controls.Add(this.Cbo_Producto);
            this.Pnl_Integracion.Controls.Add(this.Cbo_Codigo);
            this.Pnl_Integracion.Controls.Add(this.Lbl_FechaFin);
            this.Pnl_Integracion.Controls.Add(this.Lbl_FechaInicio);
            this.Pnl_Integracion.Controls.Add(this.Lbl_Producto);
            this.Pnl_Integracion.Controls.Add(this.Lbl_Codigo);
            this.Pnl_Integracion.Controls.Add(this.Dgv_Integracion);
            this.Pnl_Integracion.Location = new System.Drawing.Point(12, 12);
            this.Pnl_Integracion.Name = "Pnl_Integracion";
            this.Pnl_Integracion.Size = new System.Drawing.Size(636, 484);
            this.Pnl_Integracion.TabIndex = 0;
            // 
            // Dgv_Integracion
            // 
            this.Dgv_Integracion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Integracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Integracion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo_Movimiento,
            this.Cantidad_Movimiento,
            this.Cantidad_Inicial,
            this.Cantidad_Fin});
            this.Dgv_Integracion.Location = new System.Drawing.Point(0, 187);
            this.Dgv_Integracion.Name = "Dgv_Integracion";
            this.Dgv_Integracion.RowHeadersVisible = false;
            this.Dgv_Integracion.Size = new System.Drawing.Size(636, 221);
            this.Dgv_Integracion.TabIndex = 0;
            // 
            // Tipo_Movimiento
            // 
            this.Tipo_Movimiento.HeaderText = "Tipo_Movimiento";
            this.Tipo_Movimiento.Name = "Tipo_Movimiento";
            // 
            // Cantidad_Movimiento
            // 
            this.Cantidad_Movimiento.HeaderText = "Cantidad_Movimiento";
            this.Cantidad_Movimiento.Name = "Cantidad_Movimiento";
            // 
            // Cantidad_Inicial
            // 
            this.Cantidad_Inicial.HeaderText = "Cantidad_Inicial";
            this.Cantidad_Inicial.Name = "Cantidad_Inicial";
            // 
            // Cantidad_Fin
            // 
            this.Cantidad_Fin.HeaderText = "Cantidad_Fin";
            this.Cantidad_Fin.Name = "Cantidad_Fin";
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Location = new System.Drawing.Point(31, 102);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(43, 13);
            this.Lbl_Codigo.TabIndex = 1;
            this.Lbl_Codigo.Text = "Código:";
            // 
            // Lbl_Producto
            // 
            this.Lbl_Producto.AutoSize = true;
            this.Lbl_Producto.Location = new System.Drawing.Point(145, 102);
            this.Lbl_Producto.Name = "Lbl_Producto";
            this.Lbl_Producto.Size = new System.Drawing.Size(53, 13);
            this.Lbl_Producto.TabIndex = 2;
            this.Lbl_Producto.Text = "Producto:";
            // 
            // Lbl_FechaInicio
            // 
            this.Lbl_FechaInicio.AutoSize = true;
            this.Lbl_FechaInicio.Location = new System.Drawing.Point(316, 102);
            this.Lbl_FechaInicio.Name = "Lbl_FechaInicio";
            this.Lbl_FechaInicio.Size = new System.Drawing.Size(68, 13);
            this.Lbl_FechaInicio.TabIndex = 3;
            this.Lbl_FechaInicio.Text = "Fecha Inicio:";
            // 
            // Lbl_FechaFin
            // 
            this.Lbl_FechaFin.AutoSize = true;
            this.Lbl_FechaFin.Location = new System.Drawing.Point(465, 102);
            this.Lbl_FechaFin.Name = "Lbl_FechaFin";
            this.Lbl_FechaFin.Size = new System.Drawing.Size(57, 13);
            this.Lbl_FechaFin.TabIndex = 4;
            this.Lbl_FechaFin.Text = "Fecha Fin:";
            // 
            // Cbo_Codigo
            // 
            this.Cbo_Codigo.FormattingEnabled = true;
            this.Cbo_Codigo.Location = new System.Drawing.Point(34, 130);
            this.Cbo_Codigo.Name = "Cbo_Codigo";
            this.Cbo_Codigo.Size = new System.Drawing.Size(71, 21);
            this.Cbo_Codigo.TabIndex = 5;
            // 
            // Cbo_Producto
            // 
            this.Cbo_Producto.FormattingEnabled = true;
            this.Cbo_Producto.Location = new System.Drawing.Point(148, 130);
            this.Cbo_Producto.Name = "Cbo_Producto";
            this.Cbo_Producto.Size = new System.Drawing.Size(126, 21);
            this.Cbo_Producto.TabIndex = 6;
            // 
            // Dtp_FechaInicio
            // 
            this.Dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaInicio.Location = new System.Drawing.Point(319, 130);
            this.Dtp_FechaInicio.Name = "Dtp_FechaInicio";
            this.Dtp_FechaInicio.Size = new System.Drawing.Size(100, 20);
            this.Dtp_FechaInicio.TabIndex = 7;
            // 
            // Dtp_FechaFin
            // 
            this.Dtp_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaFin.Location = new System.Drawing.Point(468, 131);
            this.Dtp_FechaFin.Name = "Dtp_FechaFin";
            this.Dtp_FechaFin.Size = new System.Drawing.Size(101, 20);
            this.Dtp_FechaFin.TabIndex = 8;
            // 
            // Lbl_Totales
            // 
            this.Lbl_Totales.AutoSize = true;
            this.Lbl_Totales.Location = new System.Drawing.Point(29, 436);
            this.Lbl_Totales.Name = "Lbl_Totales";
            this.Lbl_Totales.Size = new System.Drawing.Size(45, 13);
            this.Lbl_Totales.TabIndex = 9;
            this.Lbl_Totales.Text = "Totales:";
            // 
            // Txt_CM
            // 
            this.Txt_CM.Enabled = false;
            this.Txt_CM.Location = new System.Drawing.Point(161, 429);
            this.Txt_CM.Name = "Txt_CM";
            this.Txt_CM.Size = new System.Drawing.Size(158, 20);
            this.Txt_CM.TabIndex = 10;
            this.Txt_CM.Text = "Q.";
            // 
            // Txt_CF
            // 
            this.Txt_CF.Enabled = false;
            this.Txt_CF.Location = new System.Drawing.Point(483, 429);
            this.Txt_CF.Name = "Txt_CF";
            this.Txt_CF.Size = new System.Drawing.Size(150, 20);
            this.Txt_CF.TabIndex = 11;
            this.Txt_CF.Text = "Q.";
            // 
            // Lbl_Integracion
            // 
            this.Lbl_Integracion.AutoSize = true;
            this.Lbl_Integracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Integracion.Location = new System.Drawing.Point(79, 23);
            this.Lbl_Integracion.Name = "Lbl_Integracion";
            this.Lbl_Integracion.Size = new System.Drawing.Size(490, 31);
            this.Lbl_Integracion.TabIndex = 12;
            this.Lbl_Integracion.Text = "Integración de Saldos de Inventarios";
            // 
            // Frm_IntegracionSaldosInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(660, 508);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_IntegracionSaldosInventario";
            this.Text = "IntegracionSaldosInventario";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.panel1.ResumeLayout(false);
            this.Pnl_Integracion.ResumeLayout(false);
            this.Pnl_Integracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Integracion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Pnl_Integracion;
        private System.Windows.Forms.DateTimePicker Dtp_FechaFin;
        private System.Windows.Forms.DateTimePicker Dtp_FechaInicio;
        private System.Windows.Forms.ComboBox Cbo_Producto;
        private System.Windows.Forms.ComboBox Cbo_Codigo;
        private System.Windows.Forms.Label Lbl_FechaFin;
        private System.Windows.Forms.Label Lbl_FechaInicio;
        private System.Windows.Forms.Label Lbl_Producto;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.DataGridView Dgv_Integracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Fin;
        private System.Windows.Forms.TextBox Txt_CF;
        private System.Windows.Forms.TextBox Txt_CM;
        private System.Windows.Forms.Label Lbl_Totales;
        private System.Windows.Forms.Label Lbl_Integracion;
    }
}