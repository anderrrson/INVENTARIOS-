using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDisenoInventario
{
    public partial class Frm_Producto : Form
    {
        private String usuario;
        private String aplicacion;

        public Frm_Producto(String usuario, String aplicacion)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.usuario = usuario;
            this.aplicacion = aplicacion;
            inicio();
        }

        private void inicio()
        {
            navegador1.asignarTabla("tbl_producto");
            String[] alias = { "Código", "Tipo Producto", "Nombre", "Descripción", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#C05640"));
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Producto");
            //Asociaciones
            navegador1.asignarComboConTabla("Tbl_TipoProducto", "tipo_tipoproducto", 1);
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.ObtenerIdAplicacion(aplicacion);
            navegador1.botonesYPermisosInicial(usuario, aplicacion);
        }
    }
}
