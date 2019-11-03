using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class Frm_Bodega : Form
    {
        public Frm_Bodega()
        {
            InitializeComponent();
            inicio();

        }

        private void inicio()
        {
            navegador1.asignarTabla("tbl_bodega");
            String[] alias = { "Codigo", "Nombre", "Direccion", "Descripcion", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Bodega");
            navegador1.ObtenerIdAplicacion("1");
        }

        private void Frm_Bodega_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario("MiUsuario");
            navegador1.botonesYPermisosInicial("MiUsuario", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
