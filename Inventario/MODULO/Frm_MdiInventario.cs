using System;
using System.Windows.Forms;
using CapaDiseno;

namespace MODULO
{
    public partial class Frm_MdiInventario : Form
    {
        private String usuario = "admin";
        private String aplicacion = "1";
        public Frm_MdiInventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void button15_Click(object sender, EventArgs e)
        {
        }

        private void button16_Click(object sender, EventArgs e)
        {
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bodega frm_Bodega = new Frm_Bodega(usuario, aplicacion);
            frm_Bodega.Show();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sucursal frm_Sucursal = new Frm_Sucursal(usuario, aplicacion);
            frm_Sucursal.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Stock frm_Stock = new Frm_Stock(usuario, aplicacion);
            frm_Stock.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Inventario frm_ProductoBodega = new Frm_Inventario(usuario, aplicacion);
            frm_ProductoBodega.Show();
        }

        private void existenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Existencia frm_Existencia = new Frm_Existencia(usuario, aplicacion);
            frm_Existencia.Show();
        }

        private void tipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TipoProducto tipoProducto = new Frm_TipoProducto(usuario, aplicacion);
            tipoProducto.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Producto frm_Cliente = new Frm_Producto(usuario, aplicacion);
            frm_Cliente.Show();
        }

        private void productoDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProdDetalle frm_ProdDetalle = new Frm_ProdDetalle(usuario, aplicacion);
            frm_ProdDetalle.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Marca frm_Marca = new Frm_Marca(usuario, aplicacion);
            frm_Marca.Show();
        }

        private void productoMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProdMarca frm_ProdMarca = new Frm_ProdMarca(usuario, aplicacion);
            frm_ProdMarca.Show();
        }

        private void ubicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Ubicacion frm_Ubicacion = new Frm_Ubicacion(usuario, aplicacion);
            frm_Ubicacion.Show();
        }

        private void movimientoEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MovInventario frm_MovInventario = new Frm_MovInventario(usuario, aplicacion);
            frm_MovInventario.Show();
        }

        private void movimientoDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HisInventario frm_HisInventario = new Frm_HisInventario(usuario, aplicacion);
            frm_HisInventario.Show();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PolizaInventario frm_Poliza = new Frm_PolizaInventario(usuario, aplicacion);
            frm_Poliza.Show();
        }
    }
}
