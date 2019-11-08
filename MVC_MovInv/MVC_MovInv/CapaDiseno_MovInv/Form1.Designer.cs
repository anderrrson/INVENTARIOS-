namespace CapaDiseno_MovInv
{
    partial class Form1
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Dgv_MovInv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadAMover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_MovInv = new System.Windows.Forms.Label();
            this.Lbl_Folio = new System.Windows.Forms.Label();
            this.Lbl_FechAplic = new System.Windows.Forms.Label();
            this.Lbl_AlmacenOrigen = new System.Windows.Forms.Label();
            this.Lbl_AlmacenDestino = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Dtp_FechaApp = new System.Windows.Forms.DateTimePicker();
            this.Cbm_AlmacenOrigen = new System.Windows.Forms.ComboBox();
            this.Cbm_Folio = new System.Windows.Forms.ComboBox();
            this.Cbm_AlmacenDestino = new System.Windows.Forms.ComboBox();
            this.Cbm_Estado = new System.Windows.Forms.ComboBox();
            this.Lbl_Observaciones = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MovInv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(0, 0);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(764, 151);
            this.textBox6.TabIndex = 15;
            // 
            // Dgv_MovInv
            // 
            this.Dgv_MovInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_MovInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Existencias,
            this.CantidadAMover,
            this.Lote});
            this.Dgv_MovInv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_MovInv.Location = new System.Drawing.Point(0, 152);
            this.Dgv_MovInv.Name = "Dgv_MovInv";
            this.Dgv_MovInv.RowHeadersVisible = false;
            this.Dgv_MovInv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Dgv_MovInv.Size = new System.Drawing.Size(764, 298);
            this.Dgv_MovInv.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cbm_Estado);
            this.panel1.Controls.Add(this.Cbm_AlmacenDestino);
            this.panel1.Controls.Add(this.Cbm_Folio);
            this.panel1.Controls.Add(this.Cbm_AlmacenOrigen);
            this.panel1.Controls.Add(this.Dtp_FechaApp);
            this.panel1.Controls.Add(this.Lbl_Estado);
            this.panel1.Controls.Add(this.Lbl_AlmacenDestino);
            this.panel1.Controls.Add(this.Lbl_AlmacenOrigen);
            this.panel1.Controls.Add(this.Lbl_FechAplic);
            this.panel1.Controls.Add(this.Lbl_Folio);
            this.panel1.Controls.Add(this.Lbl_MovInv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 152);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 194);
            this.panel2.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Existencias
            // 
            this.Existencias.HeaderText = "Extistencias";
            this.Existencias.Name = "Existencias";
            // 
            // CantidadAMover
            // 
            this.CantidadAMover.HeaderText = "CantidadAMover";
            this.CantidadAMover.Name = "CantidadAMover";
            // 
            // Lote
            // 
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            // 
            // Lbl_MovInv
            // 
            this.Lbl_MovInv.AutoSize = true;
            this.Lbl_MovInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Lbl_MovInv.Location = new System.Drawing.Point(181, 9);
            this.Lbl_MovInv.Name = "Lbl_MovInv";
            this.Lbl_MovInv.Size = new System.Drawing.Size(403, 39);
            this.Lbl_MovInv.TabIndex = 7;
            this.Lbl_MovInv.Text = "Movimientos al Inventario";
            // 
            // Lbl_Folio
            // 
            this.Lbl_Folio.AutoSize = true;
            this.Lbl_Folio.Location = new System.Drawing.Point(15, 59);
            this.Lbl_Folio.Name = "Lbl_Folio";
            this.Lbl_Folio.Size = new System.Drawing.Size(32, 13);
            this.Lbl_Folio.TabIndex = 8;
            this.Lbl_Folio.Text = "Folio:";
            // 
            // Lbl_FechAplic
            // 
            this.Lbl_FechAplic.AutoSize = true;
            this.Lbl_FechAplic.Location = new System.Drawing.Point(15, 86);
            this.Lbl_FechAplic.Name = "Lbl_FechAplic";
            this.Lbl_FechAplic.Size = new System.Drawing.Size(107, 13);
            this.Lbl_FechAplic.TabIndex = 9;
            this.Lbl_FechAplic.Text = "Fecha de Aplicacion:";
            // 
            // Lbl_AlmacenOrigen
            // 
            this.Lbl_AlmacenOrigen.AutoSize = true;
            this.Lbl_AlmacenOrigen.Location = new System.Drawing.Point(15, 109);
            this.Lbl_AlmacenOrigen.Name = "Lbl_AlmacenOrigen";
            this.Lbl_AlmacenOrigen.Size = new System.Drawing.Size(100, 13);
            this.Lbl_AlmacenOrigen.TabIndex = 10;
            this.Lbl_AlmacenOrigen.Text = "Almacen de Origen:";
            // 
            // Lbl_AlmacenDestino
            // 
            this.Lbl_AlmacenDestino.AutoSize = true;
            this.Lbl_AlmacenDestino.Location = new System.Drawing.Point(447, 64);
            this.Lbl_AlmacenDestino.Name = "Lbl_AlmacenDestino";
            this.Lbl_AlmacenDestino.Size = new System.Drawing.Size(105, 13);
            this.Lbl_AlmacenDestino.TabIndex = 11;
            this.Lbl_AlmacenDestino.Text = "Almacen de Destino:";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(447, 90);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(43, 13);
            this.Lbl_Estado.TabIndex = 12;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Dtp_FechaApp
            // 
            this.Dtp_FechaApp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaApp.Location = new System.Drawing.Point(128, 80);
            this.Dtp_FechaApp.Name = "Dtp_FechaApp";
            this.Dtp_FechaApp.Size = new System.Drawing.Size(177, 20);
            this.Dtp_FechaApp.TabIndex = 13;
            // 
            // Cbm_AlmacenOrigen
            // 
            this.Cbm_AlmacenOrigen.FormattingEnabled = true;
            this.Cbm_AlmacenOrigen.Location = new System.Drawing.Point(128, 106);
            this.Cbm_AlmacenOrigen.Name = "Cbm_AlmacenOrigen";
            this.Cbm_AlmacenOrigen.Size = new System.Drawing.Size(177, 21);
            this.Cbm_AlmacenOrigen.TabIndex = 14;
            // 
            // Cbm_Folio
            // 
            this.Cbm_Folio.FormattingEnabled = true;
            this.Cbm_Folio.Location = new System.Drawing.Point(128, 56);
            this.Cbm_Folio.Name = "Cbm_Folio";
            this.Cbm_Folio.Size = new System.Drawing.Size(177, 21);
            this.Cbm_Folio.TabIndex = 15;
            // 
            // Cbm_AlmacenDestino
            // 
            this.Cbm_AlmacenDestino.FormattingEnabled = true;
            this.Cbm_AlmacenDestino.Location = new System.Drawing.Point(560, 61);
            this.Cbm_AlmacenDestino.Name = "Cbm_AlmacenDestino";
            this.Cbm_AlmacenDestino.Size = new System.Drawing.Size(177, 21);
            this.Cbm_AlmacenDestino.TabIndex = 16;
            // 
            // Cbm_Estado
            // 
            this.Cbm_Estado.FormattingEnabled = true;
            this.Cbm_Estado.Location = new System.Drawing.Point(560, 87);
            this.Cbm_Estado.Name = "Cbm_Estado";
            this.Cbm_Estado.Size = new System.Drawing.Size(177, 21);
            this.Cbm_Estado.TabIndex = 17;
            // 
            // Lbl_Observaciones
            // 
            this.Lbl_Observaciones.AutoSize = true;
            this.Lbl_Observaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Lbl_Observaciones.Location = new System.Drawing.Point(3, 8);
            this.Lbl_Observaciones.Name = "Lbl_Observaciones";
            this.Lbl_Observaciones.Size = new System.Drawing.Size(150, 25);
            this.Lbl_Observaciones.TabIndex = 13;
            this.Lbl_Observaciones.Text = "Observaciones:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Lbl_Observaciones);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 43);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(764, 151);
            this.panel4.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Dgv_MovInv);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MovInv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView Dgv_MovInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadAMover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Cbm_Estado;
        private System.Windows.Forms.ComboBox Cbm_AlmacenDestino;
        private System.Windows.Forms.ComboBox Cbm_Folio;
        private System.Windows.Forms.ComboBox Cbm_AlmacenOrigen;
        private System.Windows.Forms.DateTimePicker Dtp_FechaApp;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_AlmacenDestino;
        private System.Windows.Forms.Label Lbl_AlmacenOrigen;
        private System.Windows.Forms.Label Lbl_FechAplic;
        private System.Windows.Forms.Label Lbl_Folio;
        private System.Windows.Forms.Label Lbl_MovInv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lbl_Observaciones;
    }
}