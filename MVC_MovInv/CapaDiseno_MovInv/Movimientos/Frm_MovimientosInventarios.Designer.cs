namespace CapaDiseno_MovInv.Movimientos
{
    partial class Frm_MovimientosInventarios
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
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Cuenta = new System.Windows.Forms.Label();
            this.Lbl_Documento = new System.Windows.Forms.Label();
            this.Gpb_Tipo = new System.Windows.Forms.GroupBox();
            this.Rdb_Entrada = new System.Windows.Forms.RadioButton();
            this.Rdb_Salida = new System.Windows.Forms.RadioButton();
            this.Chk_GeneraCosto = new System.Windows.Forms.CheckBox();
            this.Chk_InvierteCostoVenta = new System.Windows.Forms.CheckBox();
            this.Gpb_EnRelacionA = new System.Windows.Forms.GroupBox();
            this.Rdb_Clientes = new System.Windows.Forms.RadioButton();
            this.Rdb_Proveedores = new System.Windows.Forms.RadioButton();
            this.Rdb_Ninguno = new System.Windows.Forms.RadioButton();
            this.Gpb_Estatus = new System.Windows.Forms.GroupBox();
            this.Rdb_Habilitado = new System.Windows.Forms.RadioButton();
            this.Rdb_Deshabilitado = new System.Windows.Forms.RadioButton();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Cuenta = new System.Windows.Forms.TextBox();
            this.Txt_Documento = new System.Windows.Forms.TextBox();
            this.Gpb_Tipo.SuspendLayout();
            this.Gpb_EnRelacionA.SuspendLayout();
            this.Gpb_Estatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.White;
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1178, 657);
            this.navegador1.TabIndex = 0;
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Location = new System.Drawing.Point(38, 183);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(43, 13);
            this.Lbl_Codigo.TabIndex = 1;
            this.Lbl_Codigo.Text = "Código:";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(38, 216);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(47, 13);
            this.Lbl_Nombre.TabIndex = 2;
            this.Lbl_Nombre.Text = "Nombre:";
            // 
            // Lbl_Cuenta
            // 
            this.Lbl_Cuenta.AutoSize = true;
            this.Lbl_Cuenta.Location = new System.Drawing.Point(41, 253);
            this.Lbl_Cuenta.Name = "Lbl_Cuenta";
            this.Lbl_Cuenta.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Cuenta.TabIndex = 3;
            this.Lbl_Cuenta.Text = "Cuenta:";
            // 
            // Lbl_Documento
            // 
            this.Lbl_Documento.AutoSize = true;
            this.Lbl_Documento.Location = new System.Drawing.Point(386, 253);
            this.Lbl_Documento.Name = "Lbl_Documento";
            this.Lbl_Documento.Size = new System.Drawing.Size(65, 13);
            this.Lbl_Documento.TabIndex = 4;
            this.Lbl_Documento.Text = "Documento:";
            // 
            // Gpb_Tipo
            // 
            this.Gpb_Tipo.Controls.Add(this.Rdb_Salida);
            this.Gpb_Tipo.Controls.Add(this.Rdb_Entrada);
            this.Gpb_Tipo.Location = new System.Drawing.Point(44, 292);
            this.Gpb_Tipo.Name = "Gpb_Tipo";
            this.Gpb_Tipo.Size = new System.Drawing.Size(288, 56);
            this.Gpb_Tipo.TabIndex = 5;
            this.Gpb_Tipo.TabStop = false;
            this.Gpb_Tipo.Text = "Tipo";
            // 
            // Rdb_Entrada
            // 
            this.Rdb_Entrada.AutoSize = true;
            this.Rdb_Entrada.Location = new System.Drawing.Point(48, 27);
            this.Rdb_Entrada.Name = "Rdb_Entrada";
            this.Rdb_Entrada.Size = new System.Drawing.Size(62, 17);
            this.Rdb_Entrada.TabIndex = 0;
            this.Rdb_Entrada.TabStop = true;
            this.Rdb_Entrada.Text = "Entrada";
            this.Rdb_Entrada.UseVisualStyleBackColor = true;
            // 
            // Rdb_Salida
            // 
            this.Rdb_Salida.AutoSize = true;
            this.Rdb_Salida.Location = new System.Drawing.Point(180, 27);
            this.Rdb_Salida.Name = "Rdb_Salida";
            this.Rdb_Salida.Size = new System.Drawing.Size(54, 17);
            this.Rdb_Salida.TabIndex = 1;
            this.Rdb_Salida.TabStop = true;
            this.Rdb_Salida.Text = "Salida";
            this.Rdb_Salida.UseVisualStyleBackColor = true;
            // 
            // Chk_GeneraCosto
            // 
            this.Chk_GeneraCosto.AutoSize = true;
            this.Chk_GeneraCosto.Location = new System.Drawing.Point(389, 292);
            this.Chk_GeneraCosto.Name = "Chk_GeneraCosto";
            this.Chk_GeneraCosto.Size = new System.Drawing.Size(91, 17);
            this.Chk_GeneraCosto.TabIndex = 6;
            this.Chk_GeneraCosto.Text = "Genera Costo";
            this.Chk_GeneraCosto.UseVisualStyleBackColor = true;
            // 
            // Chk_InvierteCostoVenta
            // 
            this.Chk_InvierteCostoVenta.AutoSize = true;
            this.Chk_InvierteCostoVenta.Location = new System.Drawing.Point(389, 331);
            this.Chk_InvierteCostoVenta.Name = "Chk_InvierteCostoVenta";
            this.Chk_InvierteCostoVenta.Size = new System.Drawing.Size(122, 17);
            this.Chk_InvierteCostoVenta.TabIndex = 7;
            this.Chk_InvierteCostoVenta.Text = "Invierte Costo Venta";
            this.Chk_InvierteCostoVenta.UseVisualStyleBackColor = true;
            // 
            // Gpb_EnRelacionA
            // 
            this.Gpb_EnRelacionA.Controls.Add(this.Rdb_Ninguno);
            this.Gpb_EnRelacionA.Controls.Add(this.Rdb_Proveedores);
            this.Gpb_EnRelacionA.Controls.Add(this.Rdb_Clientes);
            this.Gpb_EnRelacionA.Location = new System.Drawing.Point(579, 292);
            this.Gpb_EnRelacionA.Name = "Gpb_EnRelacionA";
            this.Gpb_EnRelacionA.Size = new System.Drawing.Size(282, 56);
            this.Gpb_EnRelacionA.TabIndex = 8;
            this.Gpb_EnRelacionA.TabStop = false;
            this.Gpb_EnRelacionA.Text = "En Relación a";
            // 
            // Rdb_Clientes
            // 
            this.Rdb_Clientes.AutoSize = true;
            this.Rdb_Clientes.Location = new System.Drawing.Point(15, 27);
            this.Rdb_Clientes.Name = "Rdb_Clientes";
            this.Rdb_Clientes.Size = new System.Drawing.Size(62, 17);
            this.Rdb_Clientes.TabIndex = 0;
            this.Rdb_Clientes.TabStop = true;
            this.Rdb_Clientes.Text = "Clientes";
            this.Rdb_Clientes.UseVisualStyleBackColor = true;
            this.Rdb_Clientes.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Rdb_Proveedores
            // 
            this.Rdb_Proveedores.AutoSize = true;
            this.Rdb_Proveedores.Location = new System.Drawing.Point(100, 27);
            this.Rdb_Proveedores.Name = "Rdb_Proveedores";
            this.Rdb_Proveedores.Size = new System.Drawing.Size(85, 17);
            this.Rdb_Proveedores.TabIndex = 1;
            this.Rdb_Proveedores.TabStop = true;
            this.Rdb_Proveedores.Text = "Proveedores";
            this.Rdb_Proveedores.UseVisualStyleBackColor = true;
            // 
            // Rdb_Ninguno
            // 
            this.Rdb_Ninguno.AutoSize = true;
            this.Rdb_Ninguno.Location = new System.Drawing.Point(208, 27);
            this.Rdb_Ninguno.Name = "Rdb_Ninguno";
            this.Rdb_Ninguno.Size = new System.Drawing.Size(65, 17);
            this.Rdb_Ninguno.TabIndex = 2;
            this.Rdb_Ninguno.TabStop = true;
            this.Rdb_Ninguno.Text = "Ninguno";
            this.Rdb_Ninguno.UseVisualStyleBackColor = true;
            // 
            // Gpb_Estatus
            // 
            this.Gpb_Estatus.Controls.Add(this.Rdb_Deshabilitado);
            this.Gpb_Estatus.Controls.Add(this.Rdb_Habilitado);
            this.Gpb_Estatus.Location = new System.Drawing.Point(906, 292);
            this.Gpb_Estatus.Name = "Gpb_Estatus";
            this.Gpb_Estatus.Size = new System.Drawing.Size(222, 56);
            this.Gpb_Estatus.TabIndex = 9;
            this.Gpb_Estatus.TabStop = false;
            this.Gpb_Estatus.Text = "Estatus";
            // 
            // Rdb_Habilitado
            // 
            this.Rdb_Habilitado.AutoSize = true;
            this.Rdb_Habilitado.Location = new System.Drawing.Point(15, 27);
            this.Rdb_Habilitado.Name = "Rdb_Habilitado";
            this.Rdb_Habilitado.Size = new System.Drawing.Size(72, 17);
            this.Rdb_Habilitado.TabIndex = 0;
            this.Rdb_Habilitado.TabStop = true;
            this.Rdb_Habilitado.Text = "Habilitado";
            this.Rdb_Habilitado.UseVisualStyleBackColor = true;
            // 
            // Rdb_Deshabilitado
            // 
            this.Rdb_Deshabilitado.AutoSize = true;
            this.Rdb_Deshabilitado.Location = new System.Drawing.Point(115, 27);
            this.Rdb_Deshabilitado.Name = "Rdb_Deshabilitado";
            this.Rdb_Deshabilitado.Size = new System.Drawing.Size(89, 17);
            this.Rdb_Deshabilitado.TabIndex = 1;
            this.Rdb_Deshabilitado.TabStop = true;
            this.Rdb_Deshabilitado.Text = "Deshabilitado";
            this.Rdb_Deshabilitado.UseVisualStyleBackColor = true;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(113, 180);
            this.Txt_Codigo.Multiline = true;
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(186, 20);
            this.Txt_Codigo.TabIndex = 10;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(113, 213);
            this.Txt_Nombre.Multiline = true;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(543, 20);
            this.Txt_Nombre.TabIndex = 11;
            // 
            // Txt_Cuenta
            // 
            this.Txt_Cuenta.Location = new System.Drawing.Point(113, 250);
            this.Txt_Cuenta.Name = "Txt_Cuenta";
            this.Txt_Cuenta.Size = new System.Drawing.Size(186, 20);
            this.Txt_Cuenta.TabIndex = 12;
            // 
            // Txt_Documento
            // 
            this.Txt_Documento.Location = new System.Drawing.Point(470, 246);
            this.Txt_Documento.Name = "Txt_Documento";
            this.Txt_Documento.Size = new System.Drawing.Size(186, 20);
            this.Txt_Documento.TabIndex = 13;
            // 
            // Frm_MovimientosInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Txt_Documento);
            this.Controls.Add(this.Txt_Cuenta);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(this.Gpb_Estatus);
            this.Controls.Add(this.Gpb_EnRelacionA);
            this.Controls.Add(this.Chk_InvierteCostoVenta);
            this.Controls.Add(this.Chk_GeneraCosto);
            this.Controls.Add(this.Gpb_Tipo);
            this.Controls.Add(this.Lbl_Documento);
            this.Controls.Add(this.Lbl_Cuenta);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Lbl_Codigo);
            this.Controls.Add(this.navegador1);
            this.Name = "Frm_MovimientosInventarios";
            this.Text = "Frm_MovimientosInventarios";
            this.Gpb_Tipo.ResumeLayout(false);
            this.Gpb_Tipo.PerformLayout();
            this.Gpb_EnRelacionA.ResumeLayout(false);
            this.Gpb_EnRelacionA.PerformLayout();
            this.Gpb_Estatus.ResumeLayout(false);
            this.Gpb_Estatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaDeDiseno.Navegador navegador1;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Cuenta;
        private System.Windows.Forms.Label Lbl_Documento;
        private System.Windows.Forms.GroupBox Gpb_Tipo;
        private System.Windows.Forms.RadioButton Rdb_Salida;
        private System.Windows.Forms.RadioButton Rdb_Entrada;
        private System.Windows.Forms.CheckBox Chk_GeneraCosto;
        private System.Windows.Forms.CheckBox Chk_InvierteCostoVenta;
        private System.Windows.Forms.GroupBox Gpb_EnRelacionA;
        private System.Windows.Forms.RadioButton Rdb_Clientes;
        private System.Windows.Forms.RadioButton Rdb_Ninguno;
        private System.Windows.Forms.RadioButton Rdb_Proveedores;
        private System.Windows.Forms.GroupBox Gpb_Estatus;
        private System.Windows.Forms.RadioButton Rdb_Deshabilitado;
        private System.Windows.Forms.RadioButton Rdb_Habilitado;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Cuenta;
        private System.Windows.Forms.TextBox Txt_Documento;
    }
}