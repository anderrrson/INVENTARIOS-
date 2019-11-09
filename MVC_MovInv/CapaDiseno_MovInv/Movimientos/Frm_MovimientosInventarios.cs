using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseno_MovInv.Movimientos
{
    public partial class Frm_MovimientosInventarios : Form
    {
        public Frm_MovimientosInventarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            iniciarValor1DGV();
            colorfondo();
        }

        private void colorfondo()
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#C05640");
            Fondo.BackColor = color;
        }

        private void iniciarValor1DGV()
        {
            Dgv_DetalleMovimiento.Rows.Add();
            Dgv_DetalleMovimiento.Rows[0].Cells[0].Value = 1;
            Dgv_DetalleMovimiento.Rows[0].Cells[1].Value = "Producto";
            Dgv_DetalleMovimiento.Rows[0].Cells[2].Value = 12;
            Dgv_DetalleMovimiento.Rows[0].Cells[3].Value = 34.4;
            DataGridViewButtonCell buttonCell = 
                (DataGridViewButtonCell)Dgv_DetalleMovimiento.Rows[0].Cells[4];
            buttonCell.FlatStyle = FlatStyle.Flat;
            buttonCell.Style.BackColor = Color.LightSalmon;
            Dgv_DetalleMovimiento.Rows[0].Cells[4].Value = "X";



            Dgv_DetalleMovimiento.Rows.Add();
            Dgv_DetalleMovimiento.Rows[1].Cells[0].Value = 1;
            Dgv_DetalleMovimiento.Rows[1].Cells[1].Value = "Producto";
            Dgv_DetalleMovimiento.Rows[1].Cells[2].Value = 12;
            Dgv_DetalleMovimiento.Rows[1].Cells[3].Value = 34.4;
            buttonCell =
                (DataGridViewButtonCell)Dgv_DetalleMovimiento.Rows[1].Cells[4];
            buttonCell.FlatStyle = FlatStyle.Flat;
            buttonCell.Style.BackColor = Color.LightSalmon;
            Dgv_DetalleMovimiento.Rows[1].Cells[4].Value = "X";

        }

        void llenarCombo()
        {

        }

        void ComboClienteProveedor()
        {


        }

        private void Dgv_DetalleMovimiento_SelectionChanged(object sender, EventArgs e)
        {
            int fila = Dgv_DetalleMovimiento.CurrentCell.RowIndex;
            Dgv_DetalleMovimiento.Rows[fila].Selected = true;
        }

        private void Frm_MovimientosInventarios_Load(object sender, EventArgs e)
        {

        }
    }
}
