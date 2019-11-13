using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_INVENTARIO
{
    public partial class frm_tipoproducto : Form
    {
        //string usuario = "admin";
        public frm_tipoproducto(string user)
        {
            InitializeComponent();
            //usuario = user;
            string[] alias = { "Codigo", "TipoProducto", "Descripcion","Estado"};
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.Aqua);
            navegador1.asignarColorFuente(Color.BlueViolet);
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("tbl_tipoproducto");
            navegador1.asignarNombreForm("TipoProducto");
        }

        private void frm_tipoproducto_Load(object sender, EventArgs e)
        {
            string aplicacionactiva = "1";
            navegador1.ObtenerIdUsuario("admin");
            navegador1.botonesYPermisosInicial("admin", aplicacionactiva);
            navegador1.ObtenerIdAplicacion(aplicacionactiva);
        }
    }
}
