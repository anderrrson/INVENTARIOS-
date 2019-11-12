using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseno.Integraciones
{
    public partial class Frm_IntegracionInventarios : Form
    {
        public Frm_IntegracionInventarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            double total = 0;

            foreach (DataGridViewRow row in Dgv_Integracion.Rows)
            {
                total += Convert.ToDouble(row.Cells["Cantidad_Fin"].Value);
            }

            Lbl_CM.Text = string.Format("{0:C}", total);
            Lbl_CM.Text = total.ToString("C");
        }

        private void Lbl_CF_Click(object sender, EventArgs e)
        {
            double suma = 0;

            foreach (DataGridViewRow row in Dgv_Integracion.Rows)
            {
                suma += Convert.ToDouble(row.Cells["Cantidad_Fin"].Value);
            }

            Lbl_CF.Text = string.Format("{0:C}", suma);
            Lbl_CF.Text = suma.ToString("C");
        }
    }
}
