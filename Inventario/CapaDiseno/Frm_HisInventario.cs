using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class Frm_HisInventario : Form
    {
        public Frm_HisInventario()
        {
            InitializeComponent();
            inicio();
        }

        public void inicio()
        {
            navegador1.asignarTabla("Tbl_Historia_Inventario");
            String[] alias = { "Producto", "Cód. Movimiento", "Bodega", "Sucursal", "Fecha", "Cantidad", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Historial Inventario");
            navegador1.ObtenerIdAplicacion("1");
            //Asociaciones
            navegador1.asignarComboConTabla("Tbl_Producto", "nombre_producto", 1);
            navegador1.asignarComboConTabla("Tbl_Moviemiento_Inventario", "nombre", 1);
            navegador1.asignarComboConTabla("Tbl_Bodega", "nombre", 1);
            navegador1.asignarComboConTabla("Tbl_sucursal", "nombre", 1);
        }

        private void Frm_HisInventario_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario("MiUsuario");
            navegador1.botonesYPermisosInicial("MiUsuario", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
