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
            this.Smi_Procesos = new System.Windows.Forms.ToolStripMenuItem();
            this.Smi_Reporte = new System.Windows.Forms.ToolStripMenuItem();
            this.Smi_Herramienta = new System.Windows.Forms.ToolStripMenuItem();
            this.Smi_Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoEncabezadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mst_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mst_Menu
            // 
            this.Mst_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Smi_Inicio,
            this.Msi_Mantenimiento,
            this.Smi_Procesos,
            this.Smi_Reporte,
            this.Smi_Herramienta,
            this.Smi_Ayuda});
            this.Mst_Menu.Location = new System.Drawing.Point(0, 0);
            this.Mst_Menu.Name = "Mst_Menu";
            this.Mst_Menu.Size = new System.Drawing.Size(800, 24);
            this.Mst_Menu.TabIndex = 16;
            this.Mst_Menu.Text = "menuStrip1";
            // 
            // Smi_Inicio
            // 
            this.Smi_Inicio.Name = "Smi_Inicio";
            this.Smi_Inicio.Size = new System.Drawing.Size(48, 20);
            this.Smi_Inicio.Text = "Inicio";
            // 
            // Msi_Mantenimiento
            // 
            this.Msi_Mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bodegaToolStripMenuItem,
            this.sucursalToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.existenciaToolStripMenuItem,
            this.tipoProductoToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.productoDetalleToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.productoMarcaToolStripMenuItem,
            this.ubicacionToolStripMenuItem,
            this.movimientoEncabezadoToolStripMenuItem,
            this.movimientoDetalleToolStripMenuItem,
            this.hToolStripMenuItem});
            this.Msi_Mantenimiento.Name = "Msi_Mantenimiento";
            this.Msi_Mantenimiento.Size = new System.Drawing.Size(106, 20);
            this.Msi_Mantenimiento.Text = "Mantenimientos";
            // 
            // Smi_Procesos
            // 
            this.Smi_Procesos.Name = "Smi_Procesos";
            this.Smi_Procesos.Size = new System.Drawing.Size(66, 20);
            this.Smi_Procesos.Text = "Procesos";
            // 
            // Smi_Reporte
            // 
            this.Smi_Reporte.Name = "Smi_Reporte";
            this.Smi_Reporte.Size = new System.Drawing.Size(65, 20);
            this.Smi_Reporte.Text = "Reportes";
            // 
            // Smi_Herramienta
            // 
            this.Smi_Herramienta.Name = "Smi_Herramienta";
            this.Smi_Herramienta.Size = new System.Drawing.Size(90, 20);
            this.Smi_Herramienta.Text = "Herramientas";
            // 
            // Smi_Ayuda
            // 
            this.Smi_Ayuda.Name = "Smi_Ayuda";
            this.Smi_Ayuda.Size = new System.Drawing.Size(58, 20);
            this.Smi_Ayuda.Text = "Ayudas";
            // 
            // bodegaToolStripMenuItem
            // 
            this.bodegaToolStripMenuItem.Name = "bodegaToolStripMenuItem";
            this.bodegaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.bodegaToolStripMenuItem.Text = "Bodega";
            this.bodegaToolStripMenuItem.Click += new System.EventHandler(this.bodegaToolStripMenuItem_Click);
            // 
            // sucursalToolStripMenuItem
            // 
            this.sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            this.sucursalToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.sucursalToolStripMenuItem.Text = "Sucursal";
            this.sucursalToolStripMenuItem.Click += new System.EventHandler(this.sucursalToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // existenciaToolStripMenuItem
            // 
            this.existenciaToolStripMenuItem.Name = "existenciaToolStripMenuItem";
            this.existenciaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.existenciaToolStripMenuItem.Text = "Existencia";
            this.existenciaToolStripMenuItem.Click += new System.EventHandler(this.existenciaToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // productoDetalleToolStripMenuItem
            // 
            this.productoDetalleToolStripMenuItem.Name = "productoDetalleToolStripMenuItem";
            this.productoDetalleToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.productoDetalleToolStripMenuItem.Text = "Producto Detalle";
            this.productoDetalleToolStripMenuItem.Click += new System.EventHandler(this.productoDetalleToolStripMenuItem_Click);
            // 
            // ubicacionToolStripMenuItem
            // 
            this.ubicacionToolStripMenuItem.Name = "ubicacionToolStripMenuItem";
            this.ubicacionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ubicacionToolStripMenuItem.Text = "Ubicacion";
            this.ubicacionToolStripMenuItem.Click += new System.EventHandler(this.ubicacionToolStripMenuItem_Click);
            // 
            // movimientoEncabezadoToolStripMenuItem
            // 
            this.movimientoEncabezadoToolStripMenuItem.Name = "movimientoEncabezadoToolStripMenuItem";
            this.movimientoEncabezadoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.movimientoEncabezadoToolStripMenuItem.Text = "Movimiento Inventario";
            this.movimientoEncabezadoToolStripMenuItem.Click += new System.EventHandler(this.movimientoEncabezadoToolStripMenuItem_Click);
            // 
            // movimientoDetalleToolStripMenuItem
            // 
            this.movimientoDetalleToolStripMenuItem.Name = "movimientoDetalleToolStripMenuItem";
            this.movimientoDetalleToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.movimientoDetalleToolStripMenuItem.Text = "Historial Inventario";
            this.movimientoDetalleToolStripMenuItem.Click += new System.EventHandler(this.movimientoDetalleToolStripMenuItem_Click);
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.hToolStripMenuItem.Text = "Poliza";
            this.hToolStripMenuItem.Click += new System.EventHandler(this.hToolStripMenuItem_Click);
            // 
            // tipoProductoToolStripMenuItem
            // 
            this.tipoProductoToolStripMenuItem.Name = "tipoProductoToolStripMenuItem";
            this.tipoProductoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.tipoProductoToolStripMenuItem.Text = "Tipo Producto";
            this.tipoProductoToolStripMenuItem.Click += new System.EventHandler(this.tipoProductoToolStripMenuItem_Click);
            // 
            // productoMarcaToolStripMenuItem
            // 
            this.productoMarcaToolStripMenuItem.Name = "productoMarcaToolStripMenuItem";
            this.productoMarcaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.productoMarcaToolStripMenuItem.Text = "Producto Marca";
            this.productoMarcaToolStripMenuItem.Click += new System.EventHandler(this.productoMarcaToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem existenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoEncabezadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Smi_Procesos;
        private System.Windows.Forms.ToolStripMenuItem Smi_Reporte;
        private System.Windows.Forms.ToolStripMenuItem Smi_Herramienta;
        private System.Windows.Forms.ToolStripMenuItem Smi_Ayuda;
    }
}

