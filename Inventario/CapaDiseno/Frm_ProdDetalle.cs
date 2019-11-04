using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class Frm_ProdDetalle : Form
    {
        public Frm_ProdDetalle()
        {
            InitializeComponent();
            inicio();
        }

        public void inicio()
        {
            navegador1.asignarTabla("Tbl_Detalle_Producto");
            String[] alias = { "Kiddetalleproducto", "Kidproducto", "nombre", "presentacion", "descripcion", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Producto Detalle");
            navegador1.ObtenerIdAplicacion("1");
            //Asociacion
            navegador1.asignarComboConTabla("Tbl_Producto", "nombre_producto", 1);
        }

        private void Frm_ProdDetalle_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario("MiUsuario");
            navegador1.botonesYPermisosInicial("MiUsuario", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
