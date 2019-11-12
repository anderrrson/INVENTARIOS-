using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDisenoInventario
{
    public partial class Frm_Stock : Form
    {
        private String usuario;
        private String aplicacion;

        public Frm_Stock(String usuario, String aplicacion)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.usuario = usuario;
            this.aplicacion = aplicacion;
            inicio();
        }

        public void inicio()
        {
            navegador1.asignarTabla("Tbl_Stock");
            String[] alias = { "Código", "Cantidad Máxima", "Cantidad Mínima", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#C05640"));
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Stock");
        }

        private void Frm_Stock_Load(object sender, EventArgs e)
        {
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.ObtenerIdAplicacion(aplicacion);
            navegador1.botonesYPermisosInicial(usuario, aplicacion);
        }
    }
}
