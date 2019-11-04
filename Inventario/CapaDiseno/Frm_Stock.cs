using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class Frm_Stock : Form
    {
        public Frm_Stock()
        {
            InitializeComponent();
            inicio();
        }

        public void inicio()
        {
            navegador1.asignarTabla("Tbl_Stock");
            String[] alias = { "Código", "Cantidad Máxima", "Cantidad Mínima", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarAyuda("1");
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarNombreForm("Stock");
            navegador1.ObtenerIdAplicacion("1");
        }

        private void Frm_Stock_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario("MiUsuario");
            navegador1.botonesYPermisosInicial("MiUsuario", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
