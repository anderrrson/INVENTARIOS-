using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class Frm_MovEncabezado : Form
    {
        public Frm_MovEncabezado()
        {
            InitializeComponent();
            inicio();
        }

        private void inicio()
        {
            navegador1.asignarTabla("Tbl_MovimientoEncabezado");
            String[] alias = { "Codigo", "Destino", "Origen", "Fecha", "Proveedor", "Tipo Movimiento", "Poliza", "Cliente", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Movimiento Encabezado");
            navegador1.ObtenerIdAplicacion("1");
            //Asociaciones
            navegador1.asignarComboConTabla("Tbl_Proveedor", "nombre_proveedor", 1);
            navegador1.asignarComboConTabla("Tbl_TipoMovimiento", "nombre_tipomovimiento", 1);
            navegador1.asignarComboConTabla("Tbl_Polizas", "nombre_polizas", 1);
            navegador1.asignarComboConTabla("Tbl_Clientes", "KidClientes", 1);
        }

        private void Frm_MovEncabezado_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario("MiUsuario");
            navegador1.botonesYPermisosInicial("MiUsuario", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
