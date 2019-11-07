using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class Frm_Ubicacion : Form
    {
        private String usuario;
        private String aplicacion;

        public Frm_Ubicacion(String usuario, String aplicacion)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.aplicacion = aplicacion;
            inicio();
        }

        public void inicio()
        {
            navegador1.asignarTabla("Tbl_Ubicacion");
            String[] alias = { "Código", "Nombre", "Dirección", "Capacidad", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#C05640"));
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Ubicación");
        }

        private void Frm_Ubicacion_Load(object sender, EventArgs e)
        {
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.ObtenerIdAplicacion(aplicacion);
            navegador1.botonesYPermisosInicial(usuario, aplicacion);
        }
    }
}
