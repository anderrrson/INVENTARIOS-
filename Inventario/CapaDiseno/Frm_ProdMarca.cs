using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class Frm_ProdMarca : Form
    {
        public Frm_ProdMarca()
        {
            InitializeComponent();
            inicio();
        }

        public void inicio()
        {
            navegador1.asignarTabla("Tbl_Producto_Marca");
            String[] alias = { "Producto", "Marca", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Producto Marca");
            navegador1.ObtenerIdAplicacion("1");
            //Asociacion
            navegador1.asignarComboConTabla("Tbl_Producto", "nombre_producto", 1);
            navegador1.asignarComboConTabla("Tbl_Marca", "nombre", 1);
        }

        private void Frm_ProdMarca_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario("MiUsuario");
            navegador1.botonesYPermisosInicial("MiUsuario", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
