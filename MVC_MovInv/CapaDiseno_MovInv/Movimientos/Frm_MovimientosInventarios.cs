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
    public partial class Frm_MovimientosInventarios : Form
    {
        public Frm_MovimientosInventarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            iniciarValor1DGV();
            colorfondo();
            llenarCombo();
            eliminarTabs();
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

        void eliminarTabs()
        {
            Tab_ClienteProv.TabPages.Remove(Tbp_Proveedores);
            Tab_ClienteProv.TabPages.Remove(Tbp_Clientes);
        }

        void llenarCombo()
        {
            ProductoControl productoControl = new ProductoControl();
            List<Producto> producto = productoControl.obtenerAllProducto();

            Cmb_Producto.ValueMember = "PRODUCTOS";
            Cmb_Producto.DisplayMember = "NOMBRE";
            Cmb_Producto.DataSource = producto;
        }

        void ComboClienteProveedor()
        {
            eliminarTabs();
            if (Rdb_Entrada.Checked == true)
            {
                Tab_ClienteProv.TabPages.Add(Tbp_Clientes);
                Tab_ClienteProv.TabPages.Remove(Tbp_Proveedores);

                ClienteControl clienteControl = new ClienteControl();
                List<Cliente> clientes = clienteControl.seleccionarAllClientes();

                Cmb_Ciente.ValueMember = "CLIENTE";
                Cmb_Ciente.DisplayMember = "NOMBRE";
                Cmb_Ciente.DataSource = clientes;
            }
            else if (Rdb_Salida.Checked == true)
            {
                Tab_ClienteProv.TabPages.Add(Tbp_Proveedores);
                Tab_ClienteProv.TabPages.Remove(Tbp_Clientes);

                ProveedorControl proveedorControl = new ProveedorControl();
                List<Proveedor> proveedor = proveedorControl.obrenerAllProveedor();

                Cmb_Proveedor.ValueMember = "PROVEEDOR";
                Cmb_Proveedor.DisplayMember = "NOMBRE";
                Cmb_Proveedor.DataSource = proveedor;
            }

        }

        private void Dgv_DetalleMovimiento_SelectionChanged(object sender, EventArgs e)
        {
            int fila = Dgv_DetalleMovimiento.CurrentCell.RowIndex;
            Dgv_DetalleMovimiento.Rows[fila].Selected = true;
        }

        private void Frm_MovimientosInventarios_Load(object sender, EventArgs e)
        {

        }

        private void Rdb_Entrada_CheckedChanged(object sender, EventArgs e)
        {
            ComboClienteProveedor();
        }

        private void Rbd_Salida_CheckedChanged(object sender, EventArgs e)
        {
            ComboClienteProveedor();
        }
    }
}
