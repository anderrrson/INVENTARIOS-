using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class Frm_MovInventario : Form
    {
        public Frm_MovInventario()
        {
            InitializeComponent();
            inicio();
        }

        public void inicio()
        {
            navegador1.asignarTabla("Tbl_Moviemiento_Inventario");
            String[] alias = { "Kidmoviemientoinventario", "nombre", "naturaleza", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Movimientos Inventario");
            navegador1.ObtenerIdAplicacion("1");
        }

        private void Frm_MovInventario_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario("MiUsuario");
            navegador1.botonesYPermisosInicial("MiUsuario", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
