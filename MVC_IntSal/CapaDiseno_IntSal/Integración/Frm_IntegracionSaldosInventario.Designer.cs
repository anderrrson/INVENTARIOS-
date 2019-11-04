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
            this.Lbl_Documento = new System.Windows.Forms.Label();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.Lbl_Concepto = new System.Windows.Forms.Label();
            this.Lbl_ClienteProveedor = new System.Windows.Forms.Label();
            this.Lbl_Origen = new System.Windows.Forms.Label();
            this.Lbl_Destino = new System.Windows.Forms.Label();
            this.Txt_Documento = new System.Windows.Forms.TextBox();
            this.Txt_Tipo = new System.Windows.Forms.TextBox();
            this.Txt_Concepto = new System.Windows.Forms.TextBox();
            this.Cbo_ClienteProveedor = new System.Windows.Forms.ComboBox();
            this.Cbo_Origen = new System.Windows.Forms.ComboBox();
            this.Cbo_Destino = new System.Windows.Forms.ComboBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
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
            // Lbl_Documento
            // 
            this.Lbl_Documento.AutoSize = true;
            this.Lbl_Documento.Location = new System.Drawing.Point(72, 210);
            this.Lbl_Documento.Name = "Lbl_Documento";
            this.Lbl_Documento.Size = new System.Drawing.Size(62, 13);
            this.Lbl_Documento.TabIndex = 2;
            this.Lbl_Documento.Text = "Documento";
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.Location = new System.Drawing.Point(490, 220);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(28, 13);
            this.Lbl_Tipo.TabIndex = 3;
            this.Lbl_Tipo.Text = "Tipo";
            // 
            // Lbl_Concepto
            // 
            this.Lbl_Concepto.AutoSize = true;
            this.Lbl_Concepto.Location = new System.Drawing.Point(72, 274);
            this.Lbl_Concepto.Name = "Lbl_Concepto";
            this.Lbl_Concepto.Size = new System.Drawing.Size(117, 13);
            this.Lbl_Concepto.TabIndex = 4;
            this.Lbl_Concepto.Text = "Concepto/Descripción:";
            // 
            // Lbl_ClienteProveedor
            // 
            this.Lbl_ClienteProveedor.AutoSize = true;
            this.Lbl_ClienteProveedor.Location = new System.Drawing.Point(490, 278);
            this.Lbl_ClienteProveedor.Name = "Lbl_ClienteProveedor";
            this.Lbl_ClienteProveedor.Size = new System.Drawing.Size(96, 13);
            this.Lbl_ClienteProveedor.TabIndex = 5;
            this.Lbl_ClienteProveedor.Text = "Cliente/Proveedor:";
            // 
            // Lbl_Origen
            // 
            this.Lbl_Origen.AutoSize = true;
            this.Lbl_Origen.Location = new System.Drawing.Point(72, 346);
            this.Lbl_Origen.Name = "Lbl_Origen";
            this.Lbl_Origen.Size = new System.Drawing.Size(41, 13);
            this.Lbl_Origen.TabIndex = 6;
            this.Lbl_Origen.Text = "Origen:";
            // 
            // Lbl_Destino
            // 
            this.Lbl_Destino.AutoSize = true;
            this.Lbl_Destino.Location = new System.Drawing.Point(490, 335);
            this.Lbl_Destino.Name = "Lbl_Destino";
            this.Lbl_Destino.Size = new System.Drawing.Size(46, 13);
            this.Lbl_Destino.TabIndex = 7;
            this.Lbl_Destino.Text = "Destino:";
            this.Lbl_Destino.Click += new System.EventHandler(this.label6_Click);
            // 
            // Txt_Documento
            // 
            this.Txt_Documento.Location = new System.Drawing.Point(208, 210);
            this.Txt_Documento.Multiline = true;
            this.Txt_Documento.Name = "Txt_Documento";
            this.Txt_Documento.Size = new System.Drawing.Size(170, 20);
            this.Txt_Documento.TabIndex = 8;
            // 
            // Txt_Tipo
            // 
            this.Txt_Tipo.Location = new System.Drawing.Point(614, 210);
            this.Txt_Tipo.Multiline = true;
            this.Txt_Tipo.Name = "Txt_Tipo";
            this.Txt_Tipo.Size = new System.Drawing.Size(166, 20);
            this.Txt_Tipo.TabIndex = 9;
            // 
            // Txt_Concepto
            // 
            this.Txt_Concepto.Location = new System.Drawing.Point(208, 271);
            this.Txt_Concepto.Multiline = true;
            this.Txt_Concepto.Name = "Txt_Concepto";
            this.Txt_Concepto.Size = new System.Drawing.Size(170, 20);
            this.Txt_Concepto.TabIndex = 10;
            // 
            // Cbo_ClienteProveedor
            // 
            this.Cbo_ClienteProveedor.FormattingEnabled = true;
            this.Cbo_ClienteProveedor.Location = new System.Drawing.Point(614, 274);
            this.Cbo_ClienteProveedor.Name = "Cbo_ClienteProveedor";
            this.Cbo_ClienteProveedor.Size = new System.Drawing.Size(166, 21);
            this.Cbo_ClienteProveedor.TabIndex = 11;
            // 
            // Cbo_Origen
            // 
            this.Cbo_Origen.FormattingEnabled = true;
            this.Cbo_Origen.Location = new System.Drawing.Point(208, 338);
            this.Cbo_Origen.Name = "Cbo_Origen";
            this.Cbo_Origen.Size = new System.Drawing.Size(170, 21);
            this.Cbo_Origen.TabIndex = 12;
            // 
            // Cbo_Destino
            // 
            this.Cbo_Destino.FormattingEnabled = true;
            this.Cbo_Destino.Location = new System.Drawing.Point(614, 338);
            this.Cbo_Destino.Name = "Cbo_Destino";
            this.Cbo_Destino.Size = new System.Drawing.Size(166, 21);
            this.Cbo_Destino.TabIndex = 13;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Location = new System.Drawing.Point(853, 335);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Total.TabIndex = 14;
            this.Lbl_Total.Text = "Total:";
            // 
            // Txt_Total
            // 
            this.Txt_Total.Location = new System.Drawing.Point(923, 339);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(166, 20);
            this.Txt_Total.TabIndex = 15;
            // 
            // Frm_IntegracionSaldosInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.Cbo_Destino);
            this.Controls.Add(this.Cbo_Origen);
            this.Controls.Add(this.Cbo_ClienteProveedor);
            this.Controls.Add(this.Txt_Concepto);
            this.Controls.Add(this.Txt_Tipo);
            this.Controls.Add(this.Txt_Documento);
            this.Controls.Add(this.Lbl_Destino);
            this.Controls.Add(this.Lbl_Origen);
            this.Controls.Add(this.Lbl_ClienteProveedor);
            this.Controls.Add(this.Lbl_Concepto);
            this.Controls.Add(this.Lbl_Tipo);
            this.Controls.Add(this.Lbl_Documento);
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
        private System.Windows.Forms.Label Lbl_Documento;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.Label Lbl_Concepto;
        private System.Windows.Forms.Label Lbl_ClienteProveedor;
        private System.Windows.Forms.Label Lbl_Origen;
        private System.Windows.Forms.Label Lbl_Destino;
        private System.Windows.Forms.TextBox Txt_Documento;
        private System.Windows.Forms.TextBox Txt_Tipo;
        private System.Windows.Forms.TextBox Txt_Concepto;
        private System.Windows.Forms.ComboBox Cbo_ClienteProveedor;
        private System.Windows.Forms.ComboBox Cbo_Origen;
        private System.Windows.Forms.ComboBox Cbo_Destino;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.TextBox Txt_Total;
    }
}