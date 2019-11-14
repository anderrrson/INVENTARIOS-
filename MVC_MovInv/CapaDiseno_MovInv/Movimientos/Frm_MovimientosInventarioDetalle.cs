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
    public partial class Frm_MovimientosInventarioDetalle : Form
    {
        List<MovimientoDetalle> movimientoDetalleList = new List<MovimientoDetalle>();
        MovimientoEncabezadoControl movimientoEncabezadoControl = new MovimientoEncabezadoControl();
        MovimientoEncabezado movimientoEncabezado = new MovimientoEncabezado();
        MovimientoDetalleControl movimientoDetalleControl = new MovimientoDetalleControl();
        MovimientoDetalle movimientoDetalle = new MovimientoDetalle();
        TipoMovimiento tipoMovimiento = new TipoMovimiento();

        int indexDetalle = 0;
        public Frm_MovimientosInventarioDetalle(MovimientoEncabezado encabezado)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            inicializar(encabezado);
            //inicializarValores();
        }
        public Frm_MovimientosInventarioDetalle()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            inicializar(null);
            //inicializarValores();
        }

        private void inicializar(MovimientoEncabezado encabezado)
        {
            if (encabezado != null)
            {
                Txt_Codigo.Text = encabezado.MOVIMIENTO_ENCABEZADO + "";
                Txt_Concepto.Text = encabezado.CONCEPTO;
                if (encabezado.TIPO.TIPO_MOVIMIENTO == 0)
                {
                    Rdb_Salida.Checked = true;
                    llenarComboClienteProveedor();
                    Cmb_Ciente.SelectedItem = encabezado.CLIENTE;
                    Cmb_DoctoCliente.SelectedItem = encabezado.FACTURA;
                }
                else
                {
                    Rdb_Entrada.Checked = true;
                    llenarComboClienteProveedor();
                    Cmb_Proveedor.SelectedItem = encabezado.PROVEEDOR;
                    Cmb_DoctoProveedor.SelectedItem = encabezado.ORDEN_COMPRA;
                }
                GUARDAR.Text = "ACEPTAR";
                llenarDgv(encabezado);
                llenarComboProducto();
            }
            else
            {
                MovimientoEncabezadoControl movimientoEncabezadoControl = new MovimientoEncabezadoControl();
                Txt_Codigo.Text = movimientoEncabezadoControl.obtenerUltimoID() + "";
                Txt_Codigo.Enabled = false;
                Rdb_Entrada.Checked = true;
                llenarComboClienteProveedor();
                llenarComboProducto();
            }
            Pnl_detalle.Visible = false;
        }

        private void llenarDgv(MovimientoEncabezado encabezado)
        {
            movimientoEncabezado = encabezado;
            MovimientoDetalleControl movimientoDetalleControl = new MovimientoDetalleControl();

            try
            {
                int fila = 0;
                Dgv_DetalleMovimiento.Rows.Clear();
                foreach(MovimientoDetalle movimiento in movimientoDetalleControl.obtenerAllMovDetalleByEncab(encabezado.MOVIMIENTO_ENCABEZADO))
                {
                    Dgv_DetalleMovimiento.Rows.Add();
                    Dgv_DetalleMovimiento.Rows[fila].Cells[0].Value = movimiento.PRODUCTO.PRODUCTO.ToString();
                    Dgv_DetalleMovimiento.Rows[fila].Cells[1].Value = movimiento.PRODUCTO.NOMBRE;
                    Dgv_DetalleMovimiento.Rows[fila].Cells[2].Value = movimiento.CANTIDAD.ToString();
                    fila++;
                }
                indexDetalle = Dgv_DetalleMovimiento.RowCount;
                indexDetalle++;
                MessageBox.Show(indexDetalle+"");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex, "Error al obtener los productos");
            }
        }

        private void Btn_ActualizarGuardar_Click(object sender, EventArgs e)
        {
            if (GUARDAR.Text == "ACEPTAR")
            {
                Pnl_detalle.Visible = true;
                Pnl_guardar.Visible = false;
                Pnl_Cancelar.Visible = false;
            }
            else if (GUARDAR.Text == "GUARDAR")
            {
                if (Txt_Codigo.Text != "" && Txt_Concepto.Text != "" && (Rdb_Entrada.Checked || Rdb_Salida.Checked))
                {
                    MovimientoEncabezado movimientoEncabezado = new MovimientoEncabezado();
                    MovimientoEncabezadoControl movimientoEncabezadoControl = new MovimientoEncabezadoControl();
                    TipoMovimientoControl tipoMovimientoControl = new TipoMovimientoControl();

                    movimientoEncabezado.MOVIMIENTO_ENCABEZADO = int.Parse(Txt_Codigo.Text);
                    movimientoEncabezado.CONCEPTO = Txt_Concepto.Text;
                    movimientoEncabezado.ESTADO = 1;

                    if (getIdTipoMov() == 0)
                    {
                        movimientoEncabezado.TIPO = tipoMovimientoControl.obtenerTipoMovimientoById(getIdTipoMov());
                        movimientoEncabezado.CLIENTE = (Cliente)Cmb_Ciente.SelectedItem;
                        movimientoEncabezado.FACTURA = (Factura)Cmb_DoctoCliente.SelectedItem;
                        movimientoEncabezado.PROVEEDOR = null;
                        movimientoEncabezado.ORDEN_COMPRA = null;
                        movimientoEncabezadoControl.insertarMovimientoEncabezadoCliente(movimientoEncabezado);
                    }
                    if (getIdTipoMov() == 1)
                    {
                        movimientoEncabezado.TIPO = tipoMovimientoControl.obtenerTipoMovimientoById(getIdTipoMov());
                        movimientoEncabezado.PROVEEDOR = (Proveedor)Cmb_Proveedor.SelectedItem;
                        movimientoEncabezado.ORDEN_COMPRA = (OrdenCompra)Cmb_DoctoProveedor.SelectedItem;
                        movimientoEncabezado.CLIENTE = null;
                        movimientoEncabezado.FACTURA = null;
                        movimientoEncabezadoControl.insertarMovimientoEncabezadoProveedor(movimientoEncabezado);
                    }
                }

                Pnl_detalle.Visible = true;
                Pnl_guardar.Visible = false;
                Pnl_Cancelar.Visible = false;
            }
        }
        
        private int getIdTipoMov()
        {
            if (Rdb_Entrada.Checked)
            {
                return 1;
            }
            else {
                return 0;
            }
        }

        // ----------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------
        public void inicializarValores()
        {
            Txt_Codigo.Enabled = false;
            eliminarTabs();
            llenarComboProducto();
            colorfondo();
            Rdb_Entrada.Checked = true;
            llenarComboClienteProveedor();
           // llenarDGV();
            //Txt_Codigo.Text = movimientoEncabezado.MOVIMIENTO_ENCABEZADO + "";
        }
        private void llenarDGV( )
        {
            Cliente cliente = null;
            Factura factura = null;
            Proveedor proveedor = null;
            OrdenCompra orden = null;
            if (Rdb_Entrada.Checked)
            {
                proveedor = (Proveedor)Cmb_Proveedor.SelectedItem;
                orden = (OrdenCompra)Cmb_DoctoProveedor.SelectedItem;
                movimientoEncabezado = movimientoEncabezadoControl.obtenerEncabezadoByEntrada(proveedor.PROVEEDOR, orden.ORDEN_COMPRA);
            }
            if (Rdb_Salida.Checked)
            {
                cliente = (Cliente)Cmb_Ciente.SelectedItem;
                factura = (Factura)Cmb_DoctoCliente.SelectedItem;
                movimientoEncabezado = movimientoEncabezadoControl.obtenerEncabezadoBySalida(cliente.CLIENTE, factura.FACTURA);
            }

            iniciarObjetoEncabezado();
            movimientoDetalleList = movimientoDetalleControl.obtenerAllMovDetalleByEncab(this.movimientoEncabezado.MOVIMIENTO_ENCABEZADO);
        }

        private void llenarComboDocProveedor()
        {
            OrdenCompraControl ordenCompraControl = new OrdenCompraControl();
            List<OrdenCompra> ordenCompra = ordenCompraControl.seleccionarAllByProveedors((Proveedor)Cmb_Proveedor.SelectedItem);
            Cmb_DoctoProveedor.ValueMember = "ORDEN_COMPRA";
            Cmb_DoctoProveedor.DisplayMember = "ORDEN_COMPRA";
            Cmb_DoctoProveedor.DataSource = ordenCompra;
        }

        private void llenarComboDocCliente() {
            FacturaControl facturaControl = new FacturaControl();
            List<Factura> factura = facturaControl.seleccionarAllByClientes((Cliente)Cmb_Ciente.SelectedItem);
            Cmb_DoctoCliente.ValueMember = "FACTURA";
            Cmb_DoctoCliente.DisplayMember = "FACTURA";
            Cmb_DoctoCliente.DataSource = factura;
        }

        public void iniciarObjetoEncabezado()
        {
            try{
                movimientoEncabezado.MOVIMIENTO_ENCABEZADO = int.Parse(Txt_Codigo.Text);
                if (Rdb_Entrada.Checked == true)
                {
                    movimientoEncabezado.PROVEEDOR = (Proveedor)Cmb_Proveedor.SelectedItem;
                    movimientoEncabezado.TIPO = tipoMovimiento;
                }
                else if (Rdb_Salida.Checked == true)
                {
                    movimientoEncabezado.CLIENTE = (Cliente)Cmb_Ciente.SelectedItem;
                    movimientoEncabezado.TIPO = tipoMovimiento;
                }
                else
                {
                    MessageBox.Show("Seleccione un tipo de Movimiento");
                }
                movimientoEncabezado.ESTADO = 1;
                movimientoEncabezado.CONCEPTO = Txt_Concepto.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el Movimiento, llenar los dato necesarios: "+ex);
            }

        }
        private void colorfondo()
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#C05640");
            Fondo.BackColor = color;
        }

        void eliminarTabs()
        {
            Tab_ClienteProv.TabPages.Remove(Tbp_Proveedores);
            Tab_ClienteProv.TabPages.Remove(Tbp_Clientes);
        }

        void llenarComboProducto()
        {
            ProductoControl productoControl = new ProductoControl();
            List<Producto> producto = productoControl.obtenerAllProducto();

            Cmb_Producto.ValueMember = "PRODUCTOS";
            Cmb_Producto.DisplayMember = "NOMBRE";
            Cmb_Producto.DataSource = producto;
        }

        void llenarComboClienteProveedor()
        {
            eliminarTabs();
            if (Rdb_Salida.Checked == true)
            {
                Tab_ClienteProv.TabPages.Add(Tbp_Clientes);
                Tab_ClienteProv.TabPages.Remove(Tbp_Proveedores);

                ClienteControl clienteControl = new ClienteControl();
                List<Cliente> clientes = clienteControl.seleccionarAllClientes();

                Cmb_Ciente.ValueMember = "CLIENTE";
                Cmb_Ciente.DisplayMember = "NOMBRE";
                Cmb_Ciente.DataSource = clientes;
            }
            else if (Rdb_Entrada.Checked == true)
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
            try
            {
                int fila = Dgv_DetalleMovimiento.CurrentCell.RowIndex;
                Dgv_DetalleMovimiento.Rows[fila].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Porfavor ingrese un nuevo producto, la lista no puede quedar vacia.", "Error al seleccionar un producto");
            }
        }

        private void Frm_MovimientosInventarios_Load(object sender, EventArgs e)
        {

        }

        private void Rdb_Entrada_CheckedChanged(object sender, EventArgs e)
        {
            llenarComboClienteProveedor();
            llenarComboDocProveedor();
            tipoMovimiento.TIPO_MOVIMIENTO = 1;
            tipoMovimiento.NOMBRE = "Entrada";
            tipoMovimiento.ESTADO = 1;
        }

        private void Rbd_Salida_CheckedChanged(object sender, EventArgs e)
        {
            llenarComboClienteProveedor();
            llenarComboDocCliente();
            tipoMovimiento.TIPO_MOVIMIENTO = 0;
            tipoMovimiento.NOMBRE = "Salida";
            tipoMovimiento.ESTADO = 1;
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
           

        }

        private void Cmb_Documento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            indexDetalle--;

            Dgv_DetalleMovimiento.Rows.Remove(Dgv_DetalleMovimiento.CurrentRow);

        }

        private void Txt_Concepto_TextChanged(object sender, EventArgs e)
        {
            //iniciarObjetoEncabezado();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            MovimientoDetalleControl detalleControl = new MovimientoDetalleControl();
            try
            {
                if (Txt_Codigo.Text != "" && Txt_Concepto.Text != "" && (Rdb_Entrada.Checked || Rdb_Salida.Checked))
                {
                    if (Nud_Cantidad.Value != 0)
                    {
                        movimientoDetalle.PRODUCTO = (Producto)Cmb_Producto.SelectedItem;
                        movimientoDetalle.CANTIDAD = Convert.ToInt32(Nud_Cantidad.Value);
                        movimientoDetalle.MOVIMIENTO_DETALLE = indexDetalle;
                        movimientoDetalle.MOVIMIENTO_ENCABEZADO = movimientoEncabezado;
                        movimientoDetalle.ESTADO = 1;

                        indexDetalle = Dgv_DetalleMovimiento.RowCount;
                        Dgv_DetalleMovimiento.Rows.Add();
                        Dgv_DetalleMovimiento.Rows[indexDetalle].Cells[0].Value = movimientoDetalle.PRODUCTO.PRODUCTO.ToString();
                        Dgv_DetalleMovimiento.Rows[indexDetalle].Cells[1].Value = movimientoDetalle.PRODUCTO.NOMBRE;
                        Dgv_DetalleMovimiento.Rows[indexDetalle].Cells[2].Value = movimientoDetalle.CANTIDAD.ToString();

                        detalleControl.incertarMovimientoDetalle(movimientoDetalle);

                        indexDetalle++;
                    }
                    else
                    {
                        MessageBox.Show("Agregar cantidad de producto ", "Error al agregar el producto");
                    }
                }
                else
                {
                    MessageBox.Show("Llenar todos los datos antes de agregar un producto ", "Error al agregar el producto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al agregar el producto");
            }
        }
    }
}
