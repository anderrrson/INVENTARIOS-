using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControl_MovInv.Control;
using CapaDatos_MovInv.Entity;

namespace CapaDiseno_MovInv.Movimientos
{
    public partial class Frm_MovimientosInventarioEncabezado : Form
    {
        public Frm_MovimientosInventarioEncabezado()
        {
            InitializeComponent();
            inicializarDgv();
        }

        private MovimientoEncabezado obtenerEncabezado()
        {
            MovimientoEncabezadoControl encabezadoControl = new MovimientoEncabezadoControl();
            ProveedorControl proveedorControl = new ProveedorControl();

            int fila = Dgv_Consulta.CurrentCell.RowIndex;
            int id = int.Parse(Dgv_Consulta.Rows[fila].Cells[0].Value.ToString());

            MovimientoEncabezado encabezado = encabezadoControl.obtenerMovimientoEncabezadoById(id);


            return encabezado;
        }

        void inicializarDgv()
        {
            MovimientoEncabezadoControl movimientoEncabezadoControl = new MovimientoEncabezadoControl();

            try
            {
                int fila = 0;
                Dgv_Consulta.Rows.Clear();
                foreach (MovimientoEncabezado movimiento in movimientoEncabezadoControl.obtenerAllMovimientoEncabezado())
                {
                    Dgv_Consulta.Rows.Add();
                    Dgv_Consulta.Rows[fila].Cells[0].Value = movimiento.MOVIMIENTO_ENCABEZADO.ToString();
                    Dgv_Consulta.Rows[fila].Cells[1].Value = movimiento.CONCEPTO;
                    Dgv_Consulta.Rows[fila].Cells[2].Value = movimiento.PROVEEDOR.NOMBRE;
                    Dgv_Consulta.Rows[fila].Cells[3].Value = movimiento.CLIENTE.NOMBRE;
                    Dgv_Consulta.Rows[fila].Cells[4].Value = movimiento.ESTADO;
                    fila++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex, "Error al obtener los movimientos");
            }

        }
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {

            Frm_MovimientosInventarioDetalle detalle = new Frm_MovimientosInventarioDetalle();

            detalle.Show();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            MovimientoEncabezado encabezado = obtenerEncabezado();
            Frm_MovimientosInventarioDetalle detalle = new Frm_MovimientosInventarioDetalle(encabezado);

            detalle.Show();
        }

        private void Dgv_Consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int fila = Dgv_Consulta.CurrentCell.RowIndex;
            Dgv_Consulta.Rows[fila].Selected = true;
        }
    }
}
