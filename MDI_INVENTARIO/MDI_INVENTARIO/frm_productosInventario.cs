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
    public partial class frm_productosInventario : Form
    {
        public frm_productosInventario()
        {
            InitializeComponent();
        }
        //string usuario = "";
        public frm_productosInventario(string user)
        {
            InitializeComponent();
            //usuario = user;
            string[] alias = { "Codigo", "TipoProducto", "Nombre", "Descripcion","Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.Aqua);
            navegador1.asignarColorFuente(Color.BlueViolet);
            navegador1.asignarAyuda("1");
            navegador1.asignarComboConTabla("tbl_tipoproducto", "tipo_tipoproducto", 1);
            navegador1.asignarTabla("tbl_producto");
            navegador1.asignarNombreForm("Producto");
        }

        private void frm_productosInventario_Load(object sender, EventArgs e)
        {
            string aplicacionactiva = "1";
            navegador1.ObtenerIdUsuario("admin");
            navegador1.botonesYPermisosInicial("admin", aplicacionactiva);
            navegador1.ObtenerIdAplicacion(aplicacionactiva);
        }
    }
}
