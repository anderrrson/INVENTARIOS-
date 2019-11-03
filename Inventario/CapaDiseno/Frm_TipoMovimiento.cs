using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class Frm_TipoMovimiento : Form
    {
        public Frm_TipoMovimiento()
        {
            InitializeComponent();
            inicio();
        }

        private void inicio()
        {
            navegador1.asignarTabla("Tbl_TipoMovimiento");
            String[] alias = { "Codigo", "Nombre", "Estado"  };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Tipo Movimiento");
            navegador1.ObtenerIdAplicacion("1");
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario("MiUsuario");
            navegador1.botonesYPermisosInicial("MiUsuario", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
