using System;
using System.Windows.Forms;
using CapaDiseno;

namespace MODULO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Producto frm_Cliente = new Frm_Producto();
            frm_Cliente.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_TipoProducto tipoProducto = new Frm_TipoProducto();
            tipoProducto.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Bodega frm_Bodega = new Frm_Bodega();
            frm_Bodega.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Sucursal frm_Sucursal = new Frm_Sucursal();
            frm_Sucursal.Show();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Inventario frm_ProductoBodega = new Frm_Inventario();
            frm_ProductoBodega.Show();
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            Frm_PolizaInventario frm_Poliza = new Frm_PolizaInventario();
            frm_Poliza.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Stock frm_Stock = new Frm_Stock();
            frm_Stock.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Frm_Existencia frm_Existencia = new Frm_Existencia();
            frm_Existencia.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Frm_Marca frm_Marca = new Frm_Marca();
            frm_Marca.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Frm_ProdDetalle frm_ProdDetalle = new Frm_ProdDetalle();
            frm_ProdDetalle.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Frm_Ubicacion frm_Ubicacion = new Frm_Ubicacion();
            frm_Ubicacion.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Frm_ProdMarca frm_ProdMarca = new Frm_ProdMarca();
            frm_ProdMarca.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Frm_MovInventario frm_MovInventario = new Frm_MovInventario();
            frm_MovInventario.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Frm_HisInventario frm_HisInventario = new Frm_HisInventario();
            frm_HisInventario.Show();
        }
    }
}
