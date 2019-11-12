using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDisenoInventario
{
    public partial class Frm_PolizaInventario : Form
    {
        private String usuario;
        private String aplicacion;

        public Frm_PolizaInventario(String usuario, String aplicacion)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.usuario = usuario;
            this.aplicacion = aplicacion;
            inicio();
        }

        private void inicio()
        {
            navegador1.asignarTabla("Tbl_Poliza");
            String[] alias = { "Código", "Factura Det", "Descripción", "Fecha", "Monto", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(ColorTranslator.FromHtml("#C05640"));
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Póliza Inventario");
            //Asociaciones
            navegador1.asignarComboConTabla("Tbl_FacturaDetalle", "cantidad_facturadetalle", 1);
        }

        private void Frm_PolizaInventario_Load(object sender, EventArgs e)
        {
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.ObtenerIdAplicacion(aplicacion);
            navegador1.botonesYPermisosInicial(usuario, aplicacion);
        }
    }
}
