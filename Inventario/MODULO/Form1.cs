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

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Transporte frm_Transporte = new Frm_Transporte();
            frm_Transporte.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_ProductoBodega frm_ProductoBodega = new Frm_ProductoBodega();
            frm_ProductoBodega.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_TipoMovimiento frm_TipoMovimiento = new Frm_TipoMovimiento();
            frm_TipoMovimiento.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm_PolizaInventario frm_Poliza = new Frm_PolizaInventario();
            frm_Poliza.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Frm_MovEncabezado frm_MovEncabezado = new Frm_MovEncabezado();
            frm_MovEncabezado.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Frm_MovDetalle frm_MovDetalle = new Frm_MovDetalle();
            frm_MovDetalle.Show();
        }
    }
}
