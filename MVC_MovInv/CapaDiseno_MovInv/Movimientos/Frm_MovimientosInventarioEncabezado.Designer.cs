namespace CapaDiseno_MovInv.Movimientos
{
    partial class Frm_MovimientosInventarioEncabezado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MovimientosInventarioEncabezado));
            this.Fondo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Dgv_Consulta = new System.Windows.Forms.DataGridView();
            this.Pnl_DataGrid = new System.Windows.Forms.Panel();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Pnl_Nuevo = new System.Windows.Forms.Panel();
            this.Nuevo = new System.Windows.Forms.Label();
            this.Pnl_Modificar = new System.Windows.Forms.Panel();
            this.Modificar = new System.Windows.Forms.Label();
            this.Pnl_Eliminar = new System.Windows.Forms.Panel();
            this.Eliminar = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fondo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consulta)).BeginInit();
            this.Pnl_DataGrid.SuspendLayout();
            this.panel7.SuspendLayout();
            this.Pnl_Nuevo.SuspendLayout();
            this.Pnl_Modificar.SuspendLayout();
            this.Pnl_Eliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fondo
            // 
            this.Fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.Fondo.Controls.Add(this.panel2);
            this.Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fondo.Location = new System.Drawing.Point(0, 0);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(1021, 686);
            this.Fondo.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 662);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.Pnl_DataGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 531);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(997, 82);
            this.panel5.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(230, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(593, 54);
            this.label10.TabIndex = 0;
            this.label10.Text = "Movimientos de Inventario";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(997, 613);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 613);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(997, 49);
            this.panel6.TabIndex = 3;
            // 
            // Dgv_Consulta
            // 
            this.Dgv_Consulta.AllowUserToAddRows = false;
            this.Dgv_Consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Concepto,
            this.Proveedor,
            this.Cliente,
            this.estado});
            this.Dgv_Consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Consulta.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Consulta.Name = "Dgv_Consulta";
            this.Dgv_Consulta.RowHeadersVisible = false;
            this.Dgv_Consulta.Size = new System.Drawing.Size(997, 366);
            this.Dgv_Consulta.TabIndex = 0;
            this.Dgv_Consulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Consulta_CellContentClick);
            // 
            // Pnl_DataGrid
            // 
            this.Pnl_DataGrid.Controls.Add(this.Dgv_Consulta);
            this.Pnl_DataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_DataGrid.Location = new System.Drawing.Point(0, 165);
            this.Pnl_DataGrid.Name = "Pnl_DataGrid";
            this.Pnl_DataGrid.Size = new System.Drawing.Size(997, 366);
            this.Pnl_DataGrid.TabIndex = 1;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Nuevo.BackgroundImage")));
            this.Btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Nuevo.Location = new System.Drawing.Point(13, 14);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(82, 85);
            this.Btn_Nuevo.TabIndex = 1;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Pnl_Eliminar);
            this.panel7.Controls.Add(this.Pnl_Modificar);
            this.panel7.Controls.Add(this.Pnl_Nuevo);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(997, 165);
            this.panel7.TabIndex = 2;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.BackgroundImage")));
            this.Btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Modificar.Location = new System.Drawing.Point(13, 14);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(82, 85);
            this.Btn_Modificar.TabIndex = 2;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.BackgroundImage")));
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Eliminar.Location = new System.Drawing.Point(13, 14);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(82, 85);
            this.Btn_Eliminar.TabIndex = 3;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Pnl_Nuevo
            // 
            this.Pnl_Nuevo.Controls.Add(this.Nuevo);
            this.Pnl_Nuevo.Controls.Add(this.Btn_Nuevo);
            this.Pnl_Nuevo.Location = new System.Drawing.Point(306, 10);
            this.Pnl_Nuevo.Name = "Pnl_Nuevo";
            this.Pnl_Nuevo.Size = new System.Drawing.Size(108, 144);
            this.Pnl_Nuevo.TabIndex = 4;
            // 
            // Nuevo
            // 
            this.Nuevo.AutoSize = true;
            this.Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Nuevo.Location = new System.Drawing.Point(30, 113);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(49, 17);
            this.Nuevo.TabIndex = 2;
            this.Nuevo.Text = "Nuevo";
            // 
            // Pnl_Modificar
            // 
            this.Pnl_Modificar.Controls.Add(this.Modificar);
            this.Pnl_Modificar.Controls.Add(this.Btn_Modificar);
            this.Pnl_Modificar.Location = new System.Drawing.Point(444, 10);
            this.Pnl_Modificar.Name = "Pnl_Modificar";
            this.Pnl_Modificar.Size = new System.Drawing.Size(108, 144);
            this.Pnl_Modificar.TabIndex = 5;
            // 
            // Modificar
            // 
            this.Modificar.AutoSize = true;
            this.Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Modificar.Location = new System.Drawing.Point(22, 113);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(65, 17);
            this.Modificar.TabIndex = 2;
            this.Modificar.Text = "Modificar";
            // 
            // Pnl_Eliminar
            // 
            this.Pnl_Eliminar.Controls.Add(this.Eliminar);
            this.Pnl_Eliminar.Controls.Add(this.Btn_Eliminar);
            this.Pnl_Eliminar.Location = new System.Drawing.Point(582, 10);
            this.Pnl_Eliminar.Name = "Pnl_Eliminar";
            this.Pnl_Eliminar.Size = new System.Drawing.Size(108, 144);
            this.Pnl_Eliminar.TabIndex = 6;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSize = true;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Eliminar.Location = new System.Drawing.Point(25, 113);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(58, 17);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Cod. Movimiento";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // Frm_MovimientosInventarioEncabezado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 686);
            this.Controls.Add(this.Fondo);
            this.Name = "Frm_MovimientosInventarioEncabezado";
            this.Text = "Frm_MovimientosInventarioEncabezado";
            this.Fondo.ResumeLayout(false);
            this.Fondo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Consulta)).EndInit();
            this.Pnl_DataGrid.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.Pnl_Nuevo.ResumeLayout(false);
            this.Pnl_Nuevo.PerformLayout();
            this.Pnl_Modificar.ResumeLayout(false);
            this.Pnl_Modificar.PerformLayout();
            this.Pnl_Eliminar.ResumeLayout(false);
            this.Pnl_Eliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Fondo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel Pnl_Eliminar;
        private System.Windows.Forms.Label Eliminar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Panel Pnl_Modificar;
        private System.Windows.Forms.Label Modificar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Panel Pnl_Nuevo;
        private System.Windows.Forms.Label Nuevo;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Panel Pnl_DataGrid;
        private System.Windows.Forms.DataGridView Dgv_Consulta;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}