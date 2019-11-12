namespace MODULO
{
    partial class Frm_MdiInventario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mst_Menu = new System.Windows.Forms.MenuStrip();
            this.Smi_Inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.Msi_Mantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Smi_Procesos = new System.Windows.Forms.ToolStripMenuItem();
            this.Smi_Reporte = new System.Windows.Forms.ToolStripMenuItem();
            this.Smi_Herramienta = new System.Windows.Forms.ToolStripMenuItem();
            this.Smi_Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.polizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasladoDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestreoAuditorioaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mst_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mst_Menu
            // 
            this.Mst_Menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Mst_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Smi_Inicio,
            this.Msi_Mantenimiento,
            this.Smi_Procesos,
            this.Smi_Reporte,
            this.Smi_Herramienta,
            this.Smi_Ayuda});
            this.Mst_Menu.Location = new System.Drawing.Point(0, 0);
            this.Mst_Menu.Name = "Mst_Menu";
            this.Mst_Menu.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.Mst_Menu.Size = new System.Drawing.Size(800, 24);
            this.Mst_Menu.TabIndex = 16;
            this.Mst_Menu.Text = "menuStrip1";
            // 
            // Smi_Inicio
            // 
            this.Smi_Inicio.Name = "Smi_Inicio";
            this.Smi_Inicio.Size = new System.Drawing.Size(48, 22);
            this.Smi_Inicio.Text = "Inicio";
            // 
            // Msi_Mantenimiento
            // 
            this.Msi_Mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bodegaToolStripMenuItem,
            this.sucursalToolStripMenuItem,
            this.ubicacionToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.tipoProductoToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.productoMarcaToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.Msi_Mantenimiento.Name = "Msi_Mantenimiento";
            this.Msi_Mantenimiento.Size = new System.Drawing.Size(106, 22);
            this.Msi_Mantenimiento.Text = "Mantenimientos";
            // 
            // bodegaToolStripMenuItem
            // 
            this.bodegaToolStripMenuItem.Name = "bodegaToolStripMenuItem";
            this.bodegaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bodegaToolStripMenuItem.Text = "Bodega";
            this.bodegaToolStripMenuItem.Click += new System.EventHandler(this.bodegaToolStripMenuItem_Click);
            // 
            // sucursalToolStripMenuItem
            // 
            this.sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            this.sucursalToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.sucursalToolStripMenuItem.Text = "Sucursal";
            this.sucursalToolStripMenuItem.Click += new System.EventHandler(this.sucursalToolStripMenuItem_Click);
            // 
            // ubicacionToolStripMenuItem
            // 
            this.ubicacionToolStripMenuItem.Name = "ubicacionToolStripMenuItem";
            this.ubicacionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ubicacionToolStripMenuItem.Text = "Ubicacion";
            this.ubicacionToolStripMenuItem.Click += new System.EventHandler(this.ubicacionToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // tipoProductoToolStripMenuItem
            // 
            this.tipoProductoToolStripMenuItem.Name = "tipoProductoToolStripMenuItem";
            this.tipoProductoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tipoProductoToolStripMenuItem.Text = "Tipo Producto";
            this.tipoProductoToolStripMenuItem.Click += new System.EventHandler(this.tipoProductoToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // productoMarcaToolStripMenuItem
            // 
            this.productoMarcaToolStripMenuItem.Name = "productoMarcaToolStripMenuItem";
            this.productoMarcaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.productoMarcaToolStripMenuItem.Text = "Producto Marca";
            this.productoMarcaToolStripMenuItem.Click += new System.EventHandler(this.productoMarcaToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // Smi_Procesos
            // 
            this.Smi_Procesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polizaToolStripMenuItem,
            this.trasladoDeProductoToolStripMenuItem,
            this.saldosToolStripMenuItem});
            this.Smi_Procesos.Name = "Smi_Procesos";
            this.Smi_Procesos.Size = new System.Drawing.Size(66, 22);
            this.Smi_Procesos.Text = "Procesos";
            // 
            // Smi_Reporte
            // 
            this.Smi_Reporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muestreoAuditorioaToolStripMenuItem});
            this.Smi_Reporte.Name = "Smi_Reporte";
            this.Smi_Reporte.Size = new System.Drawing.Size(65, 22);
            this.Smi_Reporte.Text = "Reportes";
            // 
            // Smi_Herramienta
            // 
            this.Smi_Herramienta.Name = "Smi_Herramienta";
            this.Smi_Herramienta.Size = new System.Drawing.Size(90, 22);
            this.Smi_Herramienta.Text = "Herramientas";
            // 
            // Smi_Ayuda
            // 
            this.Smi_Ayuda.Name = "Smi_Ayuda";
            this.Smi_Ayuda.Size = new System.Drawing.Size(58, 22);
            this.Smi_Ayuda.Text = "Ayudas";
            // 
            // polizaToolStripMenuItem
            // 
            this.polizaToolStripMenuItem.Name = "polizaToolStripMenuItem";
            this.polizaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.polizaToolStripMenuItem.Text = "Poliza";
            this.polizaToolStripMenuItem.Click += new System.EventHandler(this.polizaToolStripMenuItem_Click);
            // 
            // trasladoDeProductoToolStripMenuItem
            // 
            this.trasladoDeProductoToolStripMenuItem.Name = "trasladoDeProductoToolStripMenuItem";
            this.trasladoDeProductoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.trasladoDeProductoToolStripMenuItem.Text = "Traslado de Producto";
            this.trasladoDeProductoToolStripMenuItem.Click += new System.EventHandler(this.trasladoDeProductoToolStripMenuItem_Click);
            // 
            // saldosToolStripMenuItem
            // 
            this.saldosToolStripMenuItem.Name = "saldosToolStripMenuItem";
            this.saldosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saldosToolStripMenuItem.Text = "Saldos";
            this.saldosToolStripMenuItem.Click += new System.EventHandler(this.saldosToolStripMenuItem_Click);
            // 
            // muestreoAuditorioaToolStripMenuItem
            // 
            this.muestreoAuditorioaToolStripMenuItem.Name = "muestreoAuditorioaToolStripMenuItem";
            this.muestreoAuditorioaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.muestreoAuditorioaToolStripMenuItem.Text = "Muestreo Auditoria";
            this.muestreoAuditorioaToolStripMenuItem.Click += new System.EventHandler(this.muestreoAuditorioaToolStripMenuItem_Click);
            // 
            // Frm_MdiInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mst_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.Mst_Menu;
            this.Name = "Frm_MdiInventario";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_MdiInventario_Load);
            this.Mst_Menu.ResumeLayout(false);
            this.Mst_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Mst_Menu;
        private System.Windows.Forms.ToolStripMenuItem Smi_Inicio;
        private System.Windows.Forms.ToolStripMenuItem Msi_Mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem bodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Smi_Procesos;
        private System.Windows.Forms.ToolStripMenuItem Smi_Reporte;
        private System.Windows.Forms.ToolStripMenuItem Smi_Herramienta;
        private System.Windows.Forms.ToolStripMenuItem Smi_Ayuda;
        private System.Windows.Forms.ToolStripMenuItem polizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasladoDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestreoAuditorioaToolStripMenuItem;
    }
}

