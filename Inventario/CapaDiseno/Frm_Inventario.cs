using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class Frm_Inventario : Form
    {
        public Frm_Inventario()
        {
            InitializeComponent();
            inicio();
        }

        private void inicio()
        {
            navegador1.asignarTabla("Tbl_Inventario");
            String[] alias = { "Código", "Producto", "Bodega", "Stock", "Existencia", "Fecha", "Cantidad", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Bodega Producto");
            navegador1.ObtenerIdAplicacion("1");
            //Asociaciones
            navegador1.asignarComboConTabla("Tbl_Producto", "nombre_producto", 1);
            navegador1.asignarComboConTabla("Tbl_Bodega", "nombre", 1);
            navegador1.asignarComboConTabla("Tbl_Stock", "cantidad", 1);
            navegador1.asignarComboConTabla("Tbl_Existencia", "cantidad", 1);

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
