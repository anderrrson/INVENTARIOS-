using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControl.Control;
using CapaDatos.Conexion;
using CapaDatos.Entity;


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
                total += Convert.ToDouble(row.Cells["Cantidad_Movimiento"].Value);
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

        private void llenarDgv()
        {
            int fila = 0;
            IntegracionControl integracion = new IntegracionControl();
            Dgv_Integracion.Rows.Clear();
            foreach (Integracion IntegracionTmp in integracion.obtenerAllIntegracion())
            {
                Dgv_Integracion.Rows.Add();
                Dgv_Integracion.Rows[fila].Cells[0].Value = IntegracionTmp.NOMBRECOMPROBANTE;
                Dgv_Integracion.Rows[fila].Cells[1].Value = IntegracionTmp.CANTIDAD_MOVIMIENTODETALLE;
                Dgv_Integracion.Rows[fila].Cells[2].Value = IntegracionTmp.CANTIDADMAXIMA;
                Dgv_Integracion.Rows[fila].Cells[3].Value = IntegracionTmp.CANTIDADMINIMA;
                fila++;
            }
        }

        public void llenarCmbCodigo()
        {
            ProductoControl CodigoControl = new ProductoControl();
            List<Producto> codigoList = CodigoControl.obtenerAllProducto();

            Cmb_Codigo.ValueMember = "PRODUCTO";
            Cmb_Codigo.DisplayMember = "CODIGO";
            Cmb_Codigo.DataSource = codigoList;
        }

        public void llenarCmbProducto()
        {
            ProductoControl productoControl = new ProductoControl();
            List<Producto> productoList = productoControl.obtenerAllProducto();

            Cmb_Producto.ValueMember = "PRODUCTO";
            Cmb_Producto.DisplayMember = "NOMBRE";
            Cmb_Producto.DataSource = productoList;
        }
        
        private void Cmb_Codigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCmbCodigo();
        }

        private void Cmb_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCmbProducto();
        }
    }
}
