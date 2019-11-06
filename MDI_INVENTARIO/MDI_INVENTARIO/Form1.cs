using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno_MovInv.Movimientos;

namespace MDI_INVENTARIO
{
    public partial class MDI_INVETARIO : Form
    {
        private int childFormNumber = 0;
        string sIdUsuario="admin";
        public MDI_INVETARIO()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_productosInventario nuevo = new frm_productosInventario(sIdUsuario);
            //nuevo.MdiParent = this;
            nuevo.Show();

        }

        private void tipoProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tipoproducto tipo = new frm_tipoproducto(sIdUsuario);
            tipo.Show();

        }

        private void MovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MovimientosInventarios mov = new Frm_MovimientosInventarios();
            mov.TopLevel = false;
            mov.Parent = this;
            mov.Show();

        }
    }
}
