using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDisenoInventario
{
    public partial class Frm_Inventario : Form
    {
        private String usuario;
        private String aplicacion;

        public Frm_Inventario(String usuario, String aplicacion)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.usuario = usuario;
            this.aplicacion = aplicacion;
            inicio();
        }

        private void inicio()
        {
            navegador1.asignarTabla("Tbl_Inventario");
            String[] alias = { "Código", "Producto", "Bodega", "Stock", "Existencia", "Fecha", "Cantidad", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#C05640"));
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Inventario");
            //Asociaciones
            navegador1.asignarComboConTabla("Tbl_Producto", "nombre_producto", 1);
            navegador1.asignarComboConTabla("Tbl_Bodega", "nombre", 1);
            navegador1.asignarComboConTabla("Tbl_Stock", "Kidstock", 0);
            navegador1.asignarComboConTabla("Tbl_Existencia", "cantidad", 1);

        }

        private void Frm_ProductoBodega_Load(object sender, EventArgs e)
        {
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.ObtenerIdAplicacion(aplicacion);
            navegador1.botonesYPermisosInicial(usuario, aplicacion);
        }
    }
}
