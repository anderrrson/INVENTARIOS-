using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class Frm_ProductoBodega : Form
    {
        public Frm_ProductoBodega()
        {
            InitializeComponent();
            inicio();
        }

        private void inicio()
        {
            navegador1.asignarTabla("Tbl_Producto_Tbl_Bodega");
            String[] alias = { "Producto", "Bodega", "Stock Min", "Stock Max", "Sucursal", "Transporte", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Bodega Producto");
            navegador1.ObtenerIdAplicacion("1");
            //asociaciones
            navegador1.asignarComboConTabla("Tbl_Producto", "nombre_producto", 1);
            navegador1.asignarComboConTabla("Tbl_Bodega", "nombre_bodega", 1);
            navegador1.asignarComboConTabla("Tbl_Sucursal", "nombre_sucursal", 1);
            navegador1.asignarComboConTabla("Tbl_Transporte", "placa_transporte", 1);

        }

        private void Frm_ProductoBodega_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario("MiUsuario");
            navegador1.botonesYPermisosInicial("MiUsuario", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
