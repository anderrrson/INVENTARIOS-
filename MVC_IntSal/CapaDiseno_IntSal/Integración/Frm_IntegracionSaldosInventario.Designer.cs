namespace CapaDiseno_IntSal.Integración
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
            this.navegador1 = new CapaDeDiseno.Navegador();
            this.navegador2 = new CapaDeDiseno.Navegador();
            this.Lbl_FechaInicio = new System.Windows.Forms.Label();
            this.Lbl_FechaFin = new System.Windows.Forms.Label();
            this.Dtp_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.Cbo_CodigoProducto = new System.Windows.Forms.ComboBox();
            this.Lbl_CodigoProducto = new System.Windows.Forms.Label();
            this.Lbl_Documento = new System.Windows.Forms.Label();
            this.Lbl_Proveedor = new System.Windows.Forms.Label();
            this.Cbo_Proveedor = new System.Windows.Forms.ComboBox();
            this.Cbo_Documento = new System.Windows.Forms.ComboBox();
            this.Lbl_Destino = new System.Windows.Forms.Label();
            this.Lbl_Origen = new System.Windows.Forms.Label();
            this.Cbo_Origen = new System.Windows.Forms.ComboBox();
            this.Cbo_Destino = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.White;
            this.navegador1.Location = new System.Drawing.Point(80, 602);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1178, 657);
            this.navegador1.TabIndex = 0;
            // 
            // navegador2
            // 
            this.navegador2.BackColor = System.Drawing.Color.White;
            this.navegador2.Location = new System.Drawing.Point(0, 0);
            this.navegador2.Name = "navegador2";
            this.navegador2.Size = new System.Drawing.Size(1178, 657);
            this.navegador2.TabIndex = 1;
            this.navegador2.Load += new System.EventHandler(this.navegador2_Load);
            // 
            // Lbl_FechaInicio
            // 
            this.Lbl_FechaInicio.AutoSize = true;
            this.Lbl_FechaInicio.Location = new System.Drawing.Point(733, 211);
            this.Lbl_FechaInicio.Name = "Lbl_FechaInicio";
            this.Lbl_FechaInicio.Size = new System.Drawing.Size(68, 13);
            this.Lbl_FechaInicio.TabIndex = 2;
            this.Lbl_FechaInicio.Text = "Fecha Inicio:";
            this.Lbl_FechaInicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_FechaFin
            // 
            this.Lbl_FechaFin.AutoSize = true;
            this.Lbl_FechaFin.Location = new System.Drawing.Point(1030, 211);
            this.Lbl_FechaFin.Name = "Lbl_FechaFin";
            this.Lbl_FechaFin.Size = new System.Drawing.Size(57, 13);
            this.Lbl_FechaFin.TabIndex = 3;
            this.Lbl_FechaFin.Text = "Fecha Fin:";
            // 
            // Dtp_FechaInicio
            // 
            this.Dtp_FechaInicio.Location = new System.Drawing.Point(670, 245);
            this.Dtp_FechaInicio.Name = "Dtp_FechaInicio";
            this.Dtp_FechaInicio.Size = new System.Drawing.Size(200, 20);
            this.Dtp_FechaInicio.TabIndex = 4;
            // 
            // Dtp_FechaFin
            // 
            this.Dtp_FechaFin.Location = new System.Drawing.Point(961, 245);
            this.Dtp_FechaFin.Name = "Dtp_FechaFin";
            this.Dtp_FechaFin.Size = new System.Drawing.Size(200, 20);
            this.Dtp_FechaFin.TabIndex = 5;
            // 
            // Cbo_CodigoProducto
            // 
            this.Cbo_CodigoProducto.FormattingEnabled = true;
            this.Cbo_CodigoProducto.Location = new System.Drawing.Point(451, 248);
            this.Cbo_CodigoProducto.Name = "Cbo_CodigoProducto";
            this.Cbo_CodigoProducto.Size = new System.Drawing.Size(121, 21);
            this.Cbo_CodigoProducto.TabIndex = 6;
            // 
            // Lbl_CodigoProducto
            // 
            this.Lbl_CodigoProducto.AutoSize = true;
            this.Lbl_CodigoProducto.Location = new System.Drawing.Point(468, 211);
            this.Lbl_CodigoProducto.Name = "Lbl_CodigoProducto";
            this.Lbl_CodigoProducto.Size = new System.Drawing.Size(78, 13);
            this.Lbl_CodigoProducto.TabIndex = 7;
            this.Lbl_CodigoProducto.Text = "Cod - Producto";
            // 
            // Lbl_Documento
            // 
            this.Lbl_Documento.AutoSize = true;
            this.Lbl_Documento.Location = new System.Drawing.Point(90, 211);
            this.Lbl_Documento.Name = "Lbl_Documento";
            this.Lbl_Documento.Size = new System.Drawing.Size(65, 13);
            this.Lbl_Documento.TabIndex = 8;
            this.Lbl_Documento.Text = "Documento:";
            // 
            // Lbl_Proveedor
            // 
            this.Lbl_Proveedor.AutoSize = true;
            this.Lbl_Proveedor.Location = new System.Drawing.Point(288, 212);
            this.Lbl_Proveedor.Name = "Lbl_Proveedor";
            this.Lbl_Proveedor.Size = new System.Drawing.Size(59, 13);
            this.Lbl_Proveedor.TabIndex = 9;
            this.Lbl_Proveedor.Text = "Proveedor:";
            // 
            // Cbo_Proveedor
            // 
            this.Cbo_Proveedor.FormattingEnabled = true;
            this.Cbo_Proveedor.Location = new System.Drawing.Point(262, 248);
            this.Cbo_Proveedor.Name = "Cbo_Proveedor";
            this.Cbo_Proveedor.Size = new System.Drawing.Size(121, 21);
            this.Cbo_Proveedor.TabIndex = 10;
            // 
            // Cbo_Documento
            // 
            this.Cbo_Documento.FormattingEnabled = true;
            this.Cbo_Documento.Location = new System.Drawing.Point(69, 245);
            this.Cbo_Documento.Name = "Cbo_Documento";
            this.Cbo_Documento.Size = new System.Drawing.Size(121, 21);
            this.Cbo_Documento.TabIndex = 11;
            // 
            // Lbl_Destino
            // 
            this.Lbl_Destino.AutoSize = true;
            this.Lbl_Destino.Location = new System.Drawing.Point(301, 321);
            this.Lbl_Destino.Name = "Lbl_Destino";
            this.Lbl_Destino.Size = new System.Drawing.Size(46, 13);
            this.Lbl_Destino.TabIndex = 12;
            this.Lbl_Destino.Text = "Destino:";
            // 
            // Lbl_Origen
            // 
            this.Lbl_Origen.AutoSize = true;
            this.Lbl_Origen.Location = new System.Drawing.Point(117, 323);
            this.Lbl_Origen.Name = "Lbl_Origen";
            this.Lbl_Origen.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Origen.TabIndex = 13;
            this.Lbl_Origen.Text = "Origen";
            // 
            // Cbo_Origen
            // 
            this.Cbo_Origen.FormattingEnabled = true;
            this.Cbo_Origen.Location = new System.Drawing.Point(69, 348);
            this.Cbo_Origen.Name = "Cbo_Origen";
            this.Cbo_Origen.Size = new System.Drawing.Size(121, 21);
            this.Cbo_Origen.TabIndex = 14;
            // 
            // Cbo_Destino
            // 
            this.Cbo_Destino.FormattingEnabled = true;
            this.Cbo_Destino.Location = new System.Drawing.Point(262, 348);
            this.Cbo_Destino.Name = "Cbo_Destino";
            this.Cbo_Destino.Size = new System.Drawing.Size(121, 21);
            this.Cbo_Destino.TabIndex = 15;
            // 
            // Frm_IntegracionSaldosInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Cbo_Destino);
            this.Controls.Add(this.Cbo_Origen);
            this.Controls.Add(this.Lbl_Origen);
            this.Controls.Add(this.Lbl_Destino);
            this.Controls.Add(this.Cbo_Documento);
            this.Controls.Add(this.Cbo_Proveedor);
            this.Controls.Add(this.Lbl_Proveedor);
            this.Controls.Add(this.Lbl_Documento);
            this.Controls.Add(this.Lbl_CodigoProducto);
            this.Controls.Add(this.Cbo_CodigoProducto);
            this.Controls.Add(this.Dtp_FechaFin);
            this.Controls.Add(this.Dtp_FechaInicio);
            this.Controls.Add(this.Lbl_FechaFin);
            this.Controls.Add(this.Lbl_FechaInicio);
            this.Controls.Add(this.navegador2);
            this.Controls.Add(this.navegador1);
            this.Name = "Frm_IntegracionSaldosInventario";
            this.Text = "IntegracionSaldosInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaDeDiseno.Navegador navegador1;
        private CapaDeDiseno.Navegador navegador2;
        private System.Windows.Forms.Label Lbl_FechaInicio;
        private System.Windows.Forms.Label Lbl_FechaFin;
        private System.Windows.Forms.DateTimePicker Dtp_FechaInicio;
        private System.Windows.Forms.DateTimePicker Dtp_FechaFin;
        private System.Windows.Forms.ComboBox Cbo_CodigoProducto;
        private System.Windows.Forms.Label Lbl_CodigoProducto;
        private System.Windows.Forms.Label Lbl_Documento;
        private System.Windows.Forms.Label Lbl_Proveedor;
        private System.Windows.Forms.ComboBox Cbo_Proveedor;
        private System.Windows.Forms.ComboBox Cbo_Documento;
        private System.Windows.Forms.Label Lbl_Destino;
        private System.Windows.Forms.Label Lbl_Origen;
        private System.Windows.Forms.ComboBox Cbo_Origen;
        private System.Windows.Forms.ComboBox Cbo_Destino;
    }
}