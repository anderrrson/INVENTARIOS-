using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class Frm_HisInventario : Form
    {
        private String usuario;
        private String aplicacion;

        public Frm_HisInventario(String usuario, String aplicacion)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.aplicacion = aplicacion;
            inicio();
        }

        public void inicio()
        {
            navegador1.asignarTabla("Tbl_Historia_Inventario");
            String[] alias = { "Producto", "Cód. Movimiento", "Bodega", "Sucursal", "Fecha", "Cantidad", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#C05640"));
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Historial Inventario");
            //Asociaciones
            navegador1.asignarComboConTabla("Tbl_Producto", "nombre_producto", 1);
            navegador1.asignarComboConTabla("Tbl_Moviemiento_Inventario", "nombre", 1);
            navegador1.asignarComboConTabla("Tbl_Bodega", "nombre", 1);
            navegador1.asignarComboConTabla("Tbl_sucursal", "nombre", 1);
        }

        private void Frm_HisInventario_Load(object sender, EventArgs e)
        {
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.ObtenerIdAplicacion(aplicacion);
            navegador1.botonesYPermisosInicial(usuario, aplicacion);
        }
    }
}
