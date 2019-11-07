using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class Frm_Bodega : Form
    {
        private String usuario;
        private String aplicacion;

        public Frm_Bodega(String usuario, String aplicacion)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.aplicacion = aplicacion;
            inicio();
        }

        private void inicio()
        {
            navegador1.asignarTabla("tbl_bodega");
            String[] alias = { "Código", "Sucursal", "Nombre", "Descripción", "Dirección", "Stock Máximo", "Stock Mínimo", "Status", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#C05640"));
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Bodega");
            //Asociaciones
            //navegador1.asignarComboConTabla("Tbl_sucursal", "nombre", 1);
        }

        private void Frm_Bodega_Load(object sender, EventArgs e)
        {
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.ObtenerIdAplicacion(aplicacion);
            navegador1.botonesYPermisosInicial(usuario, aplicacion);
        }
    }
}
