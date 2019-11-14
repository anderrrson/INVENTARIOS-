namespace CapaDiseno_MovInv.Movimientos
{
    partial class Frm_MovimientosInventarioDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MovimientosInventarioDetalle));
            this.Fondo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Tab_ClienteProv = new System.Windows.Forms.TabControl();
            this.Tbp_Clientes = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Cmb_Ciente = new System.Windows.Forms.ComboBox();
            this.Cmb_DoctoCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbp_Proveedores = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Cmb_Proveedor = new System.Windows.Forms.ComboBox();
            this.Cmb_DoctoProveedor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rdb_Salida = new System.Windows.Forms.RadioButton();
            this.Rdb_Entrada = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Concepto = new System.Windows.Forms.TextBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Pnl_detalle = new System.Windows.Forms.Panel();
            this.Pnl_guardar = new System.Windows.Forms.Panel();
            this.GUARDAR = new System.Windows.Forms.Label();
            this.Pnl_Cancelar = new System.Windows.Forms.Panel();
            this.CANCELAR = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_Remover = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.Cmb_Producto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dgv_DetalleMovimiento = new System.Windows.Forms.DataGridView();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fondo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Tab_ClienteProv.SuspendLayout();
            this.Tbp_Clientes.SuspendLayout();
            this.panel8.SuspendLayout();
            this.Tbp_Proveedores.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Pnl_detalle.SuspendLayout();
            this.Pnl_guardar.SuspendLayout();
            this.Pnl_Cancelar.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cantidad)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleMovimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // Fondo
            // 
            this.Fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(86)))), ((int)(((byte)(64)))));
            this.Fondo.Controls.Add(this.panel2);
            this.Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fondo.Location = new System.Drawing.Point(0, 0);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(1076, 753);
            this.Fondo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.Pnl_detalle);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 729);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Pnl_Cancelar);
            this.panel1.Controls.Add(this.Pnl_guardar);
            this.panel1.Controls.Add(this.Tab_ClienteProv);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_Concepto);
            this.panel1.Controls.Add(this.Txt_Codigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 182);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.BackgroundImage")));
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Cancelar.Location = new System.Drawing.Point(4, 9);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(64, 64);
            this.Btn_Cancelar.TabIndex = 20;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.BackgroundImage")));
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Guardar.Location = new System.Drawing.Point(4, 9);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(64, 64);
            this.Btn_Guardar.TabIndex = 19;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_ActualizarGuardar_Click);
            // 
            // Tab_ClienteProv
            // 
            this.Tab_ClienteProv.Controls.Add(this.Tbp_Clientes);
            this.Tab_ClienteProv.Controls.Add(this.Tbp_Proveedores);
            this.Tab_ClienteProv.Location = new System.Drawing.Point(180, 52);
            this.Tab_ClienteProv.Name = "Tab_ClienteProv";
            this.Tab_ClienteProv.SelectedIndex = 0;
            this.Tab_ClienteProv.Size = new System.Drawing.Size(643, 112);
            this.Tab_ClienteProv.TabIndex = 18;
            // 
            // Tbp_Clientes
            // 
            this.Tbp_Clientes.Controls.Add(this.panel8);
            this.Tbp_Clientes.Location = new System.Drawing.Point(4, 22);
            this.Tbp_Clientes.Name = "Tbp_Clientes";
            this.Tbp_Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Clientes.Size = new System.Drawing.Size(635, 86);
            this.Tbp_Clientes.TabIndex = 0;
            this.Tbp_Clientes.Text = "Cliente";
            this.Tbp_Clientes.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Cmb_Ciente);
            this.panel8.Controls.Add(this.Cmb_DoctoCliente);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(629, 80);
            this.panel8.TabIndex = 0;
            // 
            // Cmb_Ciente
            // 
            this.Cmb_Ciente.FormattingEnabled = true;
            this.Cmb_Ciente.Location = new System.Drawing.Point(170, 8);
            this.Cmb_Ciente.Name = "Cmb_Ciente";
            this.Cmb_Ciente.Size = new System.Drawing.Size(456, 21);
            this.Cmb_Ciente.TabIndex = 26;
            // 
            // Cmb_DoctoCliente
            // 
            this.Cmb_DoctoCliente.FormattingEnabled = true;
            this.Cmb_DoctoCliente.Location = new System.Drawing.Point(170, 45);
            this.Cmb_DoctoCliente.Name = "Cmb_DoctoCliente";
            this.Cmb_DoctoCliente.Size = new System.Drawing.Size(456, 21);
            this.Cmb_DoctoCliente.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cliente / Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Documento Asociado:";
            // 
            // Tbp_Proveedores
            // 
            this.Tbp_Proveedores.Controls.Add(this.panel9);
            this.Tbp_Proveedores.Location = new System.Drawing.Point(4, 22);
            this.Tbp_Proveedores.Name = "Tbp_Proveedores";
            this.Tbp_Proveedores.Padding = new System.Windows.Forms.Padding(3);
            this.Tbp_Proveedores.Size = new System.Drawing.Size(635, 86);
            this.Tbp_Proveedores.TabIndex = 1;
            this.Tbp_Proveedores.Text = "Poveedor";
            this.Tbp_Proveedores.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.Cmb_Proveedor);
            this.panel9.Controls.Add(this.Cmb_DoctoProveedor);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(629, 80);
            this.panel9.TabIndex = 0;
            // 
            // Cmb_Proveedor
            // 
            this.Cmb_Proveedor.FormattingEnabled = true;
            this.Cmb_Proveedor.Location = new System.Drawing.Point(168, 13);
            this.Cmb_Proveedor.Name = "Cmb_Proveedor";
            this.Cmb_Proveedor.Size = new System.Drawing.Size(456, 21);
            this.Cmb_Proveedor.TabIndex = 26;
            // 
            // Cmb_DoctoProveedor
            // 
            this.Cmb_DoctoProveedor.FormattingEnabled = true;
            this.Cmb_DoctoProveedor.Location = new System.Drawing.Point(168, 46);
            this.Cmb_DoctoProveedor.Name = "Cmb_DoctoProveedor";
            this.Cmb_DoctoProveedor.Size = new System.Drawing.Size(456, 21);
            this.Cmb_DoctoProveedor.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(4, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cliente / Proveedor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(4, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Documento Asociado:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Rdb_Salida);
            this.groupBox1.Controls.Add(this.Rdb_Entrada);
            this.groupBox1.Location = new System.Drawing.Point(32, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 88);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Movimiento";
            // 
            // Rdb_Salida
            // 
            this.Rdb_Salida.AutoSize = true;
            this.Rdb_Salida.Location = new System.Drawing.Point(40, 52);
            this.Rdb_Salida.Name = "Rdb_Salida";
            this.Rdb_Salida.Size = new System.Drawing.Size(54, 17);
            this.Rdb_Salida.TabIndex = 1;
            this.Rdb_Salida.TabStop = true;
            this.Rdb_Salida.Text = "Salida";
            this.Rdb_Salida.UseVisualStyleBackColor = true;
            this.Rdb_Salida.CheckedChanged += new System.EventHandler(this.Rbd_Salida_CheckedChanged);
            // 
            // Rdb_Entrada
            // 
            this.Rdb_Entrada.AutoSize = true;
            this.Rdb_Entrada.Location = new System.Drawing.Point(40, 19);
            this.Rdb_Entrada.Name = "Rdb_Entrada";
            this.Rdb_Entrada.Size = new System.Drawing.Size(62, 17);
            this.Rdb_Entrada.TabIndex = 0;
            this.Rdb_Entrada.TabStop = true;
            this.Rdb_Entrada.Text = "Entrada";
            this.Rdb_Entrada.UseVisualStyleBackColor = true;
            this.Rdb_Entrada.CheckedChanged += new System.EventHandler(this.Rdb_Entrada_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(382, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Concepto:";
            // 
            // Txt_Concepto
            // 
            this.Txt_Concepto.Location = new System.Drawing.Point(524, 25);
            this.Txt_Concepto.Name = "Txt_Concepto";
            this.Txt_Concepto.Size = new System.Drawing.Size(292, 20);
            this.Txt_Concepto.TabIndex = 17;
            this.Txt_Concepto.TextChanged += new System.EventHandler(this.Txt_Concepto_TextChanged);
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(171, 26);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(168, 20);
            this.Txt_Codigo.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1052, 88);
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 692);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1052, 37);
            this.panel6.TabIndex = 3;
            // 
            // Pnl_detalle
            // 
            this.Pnl_detalle.BackColor = System.Drawing.Color.White;
            this.Pnl_detalle.Controls.Add(this.panel4);
            this.Pnl_detalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_detalle.Location = new System.Drawing.Point(0, 270);
            this.Pnl_detalle.Name = "Pnl_detalle";
            this.Pnl_detalle.Size = new System.Drawing.Size(1052, 422);
            this.Pnl_detalle.TabIndex = 4;
            // 
            // Pnl_guardar
            // 
            this.Pnl_guardar.Controls.Add(this.GUARDAR);
            this.Pnl_guardar.Controls.Add(this.Btn_Guardar);
            this.Pnl_guardar.Location = new System.Drawing.Point(866, 7);
            this.Pnl_guardar.Name = "Pnl_guardar";
            this.Pnl_guardar.Size = new System.Drawing.Size(144, 83);
            this.Pnl_guardar.TabIndex = 21;
            // 
            // GUARDAR
            // 
            this.GUARDAR.AutoSize = true;
            this.GUARDAR.Location = new System.Drawing.Point(74, 35);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(61, 13);
            this.GUARDAR.TabIndex = 20;
            this.GUARDAR.Text = "GUARDAR";
            // 
            // Pnl_Cancelar
            // 
            this.Pnl_Cancelar.Controls.Add(this.CANCELAR);
            this.Pnl_Cancelar.Controls.Add(this.Btn_Cancelar);
            this.Pnl_Cancelar.Location = new System.Drawing.Point(866, 96);
            this.Pnl_Cancelar.Name = "Pnl_Cancelar";
            this.Pnl_Cancelar.Size = new System.Drawing.Size(144, 83);
            this.Pnl_Cancelar.TabIndex = 22;
            // 
            // CANCELAR
            // 
            this.CANCELAR.AutoSize = true;
            this.CANCELAR.Location = new System.Drawing.Point(74, 35);
            this.CANCELAR.Name = "CANCELAR";
            this.CANCELAR.Size = new System.Drawing.Size(64, 13);
            this.CANCELAR.TabIndex = 20;
            this.CANCELAR.Text = "CANCELAR";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.Btn_Remover);
            this.panel4.Controls.Add(this.Btn_Agregar);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.Nud_Cantidad);
            this.panel4.Controls.Add(this.Cmb_Producto);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(13, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1027, 422);
            this.panel4.TabIndex = 6;
            // 
            // Btn_Remover
            // 
            this.Btn_Remover.BackColor = System.Drawing.Color.LightSalmon;
            this.Btn_Remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Remover.Location = new System.Drawing.Point(938, 3);
            this.Btn_Remover.Name = "Btn_Remover";
            this.Btn_Remover.Size = new System.Drawing.Size(47, 41);
            this.Btn_Remover.TabIndex = 24;
            this.Btn_Remover.Text = "x";
            this.Btn_Remover.UseVisualStyleBackColor = false;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(885, 3);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(47, 41);
            this.Btn_Agregar.TabIndex = 23;
            this.Btn_Agregar.Text = "✓";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(598, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cantidad:";
            // 
            // Nud_Cantidad
            // 
            this.Nud_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Nud_Cantidad.Location = new System.Drawing.Point(740, 14);
            this.Nud_Cantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Nud_Cantidad.Name = "Nud_Cantidad";
            this.Nud_Cantidad.Size = new System.Drawing.Size(120, 23);
            this.Nud_Cantidad.TabIndex = 21;
            // 
            // Cmb_Producto
            // 
            this.Cmb_Producto.FormattingEnabled = true;
            this.Cmb_Producto.Location = new System.Drawing.Point(152, 20);
            this.Cmb_Producto.Name = "Cmb_Producto";
            this.Cmb_Producto.Size = new System.Drawing.Size(407, 21);
            this.Cmb_Producto.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(16, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Producto:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.Dgv_DetalleMovimiento);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1027, 364);
            this.panel3.TabIndex = 0;
            // 
            // Dgv_DetalleMovimiento
            // 
            this.Dgv_DetalleMovimiento.AllowUserToAddRows = false;
            this.Dgv_DetalleMovimiento.AllowUserToDeleteRows = false;
            this.Dgv_DetalleMovimiento.AllowUserToOrderColumns = true;
            this.Dgv_DetalleMovimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_DetalleMovimiento.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_DetalleMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DetalleMovimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProducto,
            this.Producto,
            this.Cantidad});
            this.Dgv_DetalleMovimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_DetalleMovimiento.Location = new System.Drawing.Point(0, 0);
            this.Dgv_DetalleMovimiento.Name = "Dgv_DetalleMovimiento";
            this.Dgv_DetalleMovimiento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_DetalleMovimiento.RowHeadersVisible = false;
            this.Dgv_DetalleMovimiento.Size = new System.Drawing.Size(1027, 364);
            this.Dgv_DetalleMovimiento.TabIndex = 0;
            // 
            // CodProducto
            // 
            this.CodProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CodProducto.HeaderText = "Codigo Producto";
            this.CodProducto.Name = "CodProducto";
            this.CodProducto.ReadOnly = true;
            this.CodProducto.Width = 102;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidad.Width = 74;
            // 
            // Frm_MovimientosInventarioDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 753);
            this.Controls.Add(this.Fondo);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_MovimientosInventarioDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movimientos de Inventarios";
            this.Load += new System.EventHandler(this.Frm_MovimientosInventarios_Load);
            this.Fondo.ResumeLayout(false);
            this.Fondo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Tab_ClienteProv.ResumeLayout(false);
            this.Tbp_Clientes.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.Tbp_Proveedores.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.Pnl_detalle.ResumeLayout(false);
            this.Pnl_guardar.ResumeLayout(false);
            this.Pnl_guardar.PerformLayout();
            this.Pnl_Cancelar.ResumeLayout(false);
            this.Pnl_Cancelar.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cantidad)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleMovimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Fondo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Concepto;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rdb_Salida;
        private System.Windows.Forms.RadioButton Rdb_Entrada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TabControl Tab_ClienteProv;
        private System.Windows.Forms.TabPage Tbp_Clientes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox Cmb_Ciente;
        private System.Windows.Forms.ComboBox Cmb_DoctoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Tbp_Proveedores;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox Cmb_Proveedor;
        private System.Windows.Forms.ComboBox Cmb_DoctoProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel Pnl_detalle;
        private System.Windows.Forms.Panel Pnl_Cancelar;
        private System.Windows.Forms.Label CANCELAR;
        private System.Windows.Forms.Panel Pnl_guardar;
        private System.Windows.Forms.Label GUARDAR;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_Remover;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Nud_Cantidad;
        private System.Windows.Forms.ComboBox Cmb_Producto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Dgv_DetalleMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}