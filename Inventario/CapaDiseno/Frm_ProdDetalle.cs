using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class Frm_ProdDetalle : Form
    {
        private String usuario;
        private String aplicacion;

        public Frm_ProdDetalle(String usuario, String aplicacion)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.aplicacion = aplicacion;
            inicio();
        }

        public void inicio()
        {
            navegador1.asignarTabla("Tbl_Detalle_Producto");
            String[] alias = { "Kiddetalleproducto", "Kidproducto", "nombre", "presentacion", "descripcion", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#C05640"));
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Producto Detalle");
            //Asociacion
            navegador1.asignarComboConTabla("Tbl_Producto", "nombre_producto", 1);
        }

        private void Frm_ProdDetalle_Load(object sender, EventArgs e)
        {
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.ObtenerIdAplicacion(aplicacion);
            navegador1.botonesYPermisosInicial(usuario, aplicacion);
        }
    }
}
