namespace MDI_INVENTARIO
{
    partial class MDI_INVETARIO
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moviemientosInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integracionDeSaldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviemientosInventarioToolStripMenuItem,
            this.integracionDeSaldosToolStripMenuItem,
            this.polizasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.mantenimientosToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moviemientosInventarioToolStripMenuItem
            // 
            this.moviemientosInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientoToolStripMenuItem});
            this.moviemientosInventarioToolStripMenuItem.Name = "moviemientosInventarioToolStripMenuItem";
            this.moviemientosInventarioToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.moviemientosInventarioToolStripMenuItem.Text = "Moviemientos de Inventario";
            // 
            // integracionDeSaldosToolStripMenuItem
            // 
            this.integracionDeSaldosToolStripMenuItem.Name = "integracionDeSaldosToolStripMenuItem";
            this.integracionDeSaldosToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.integracionDeSaldosToolStripMenuItem.Text = "Integracion de Saldos ";
            // 
            // polizasToolStripMenuItem
            // 
            this.polizasToolStripMenuItem.Name = "polizasToolStripMenuItem";
            this.polizasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.polizasToolStripMenuItem.Text = "Polizas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.mantenimientosToolStripMenuItem.Text = "Traslados";
            // 
            // mantenimientosToolStripMenuItem1
            // 
            this.mantenimientosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.vehiculosToolStripMenuItem,
            this.tipoProductosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem1.Name = "mantenimientosToolStripMenuItem1";
            this.mantenimientosToolStripMenuItem1.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem1.Text = "Mantenimientos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            // 
            // tipoProductosToolStripMenuItem
            // 
            this.tipoProductosToolStripMenuItem.Name = "tipoProductosToolStripMenuItem";
            this.tipoProductosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoProductosToolStripMenuItem.Text = "Tipo Productos";
            this.tipoProductosToolStripMenuItem.Click += new System.EventHandler(this.tipoProductosToolStripMenuItem_Click);
            // 
            // movimientoToolStripMenuItem
            // 
            this.movimientoToolStripMenuItem.Name = "movimientoToolStripMenuItem";
            this.movimientoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.movimientoToolStripMenuItem.Text = "Movimiento";
            this.movimientoToolStripMenuItem.Click += new System.EventHandler(this.MovimientoToolStripMenuItem_Click);
            // 
            // MDI_INVETARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(882, 496);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI_INVETARIO";
            this.Text = "MDI_INVETARIO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moviemientosInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integracionDeSaldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoToolStripMenuItem;
    }
}

