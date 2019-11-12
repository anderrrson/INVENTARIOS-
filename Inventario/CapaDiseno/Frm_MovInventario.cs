using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDisenoInventario
{
    public partial class Frm_MovInventario : Form
    {
        private String usuario;
        private String aplicacion;

        public Frm_MovInventario(String usuario, String aplicacion)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.usuario = usuario;
            this.aplicacion = aplicacion;
            inicio();
        }

        public void inicio()
        {
            navegador1.asignarTabla("Tbl_Moviemiento_Inventario");
            String[] alias = { "Kidmoviemientoinventario", "nombre", "naturaleza", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#C05640"));
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Movimientos Inventario");
        }

        private void Frm_MovInventario_Load(object sender, EventArgs e)
        {
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.ObtenerIdAplicacion(aplicacion);
            navegador1.botonesYPermisosInicial(usuario, aplicacion);
        }
    }
}
