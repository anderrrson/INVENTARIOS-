using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDisenoInventario
{
    public partial class Frm_Marca : Form
    {
        private String usuario;
        private String aplicacion;

        public Frm_Marca(String usuario, String aplicacion)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.usuario = usuario;
            this.aplicacion = aplicacion;
            inicio();
        }

        private void inicio()
        {
            navegador1.asignarTabla("Tbl_Marca");
            String[] alias = { "Código", "Nombre", "País Origen", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("11");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#C05640"));
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Marca");
        }

        private void Frm_Marca_Load(object sender, EventArgs e)
        {
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.ObtenerIdAplicacion(aplicacion);
            navegador1.botonesYPermisosInicial(usuario, aplicacion);
        }
    }
}
