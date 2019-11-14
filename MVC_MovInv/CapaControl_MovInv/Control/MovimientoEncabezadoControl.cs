using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaDatos_MovInv.Conexion;
using CapaDatos_MovInv.Entity;

namespace CapaControl_MovInv.Control
{
    public class MovimientoEncabezadoControl
    {
        private Transaccion transaccion = new Transaccion();

        public void insertarMovimientoEncabezadoProveedor(MovimientoEncabezado encabezado)
        {
            try
            {
                String sComando = String.Format("insert into Tbl_MovimientoEncabezado values(" +
                    "{0}, null, '{1}', {2}, null, null, {3}, null, {4}, null, 1); ",
                    encabezado.MOVIMIENTO_ENCABEZADO, encabezado.CONCEPTO, encabezado.TIPO.TIPO_MOVIMIENTO,
                    encabezado.PROVEEDOR.PROVEEDOR, encabezado.ORDEN_COMPRA.ORDEN_COMPRA);

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al crear movimiento.");
            }
        }

        public void insertarMovimientoEncabezadoCliente(MovimientoEncabezado encabezado)
        {
            try
            {
                String sComando = String.Format("insert into Tbl_MovimientoEncabezado values(" +
                    "{0}, null, '{1}', {2}, null, null, null, {3}, null, {4}, 1); ",
                    encabezado.MOVIMIENTO_ENCABEZADO, encabezado.CONCEPTO, encabezado.TIPO.TIPO_MOVIMIENTO,
                    encabezado.CLIENTE.CLIENTE, encabezado.FACTURA.FACTURA);

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al crear movimiento.");
            }
        }

        public MovimientoEncabezado obtenerMovimientoEncabezadoById( int id)
        {
            MovimientoEncabezado movimientoEncabezado = new MovimientoEncabezado();
            TipoMovimientoControl tipoMovimientoControl = new TipoMovimientoControl();
            OrdenCompraControl ordenCompraControl = new OrdenCompraControl();
            ProveedorControl proveedorControl = new ProveedorControl();
            FacturaControl facturaControl = new FacturaControl();
            ClienteControl clienteControl = new ClienteControl();

            String sComando = String.Format("Select KidMovimientoEncabezado, concepto_movimientoencabezado, " +
                "KidTipoMovimiento, KidProveedor, KidOrdenCompraEncabezado, KidClientes, KidFacturaEncabezado, " +
                "estado from Tbl_MovimientoEncabezado where KidMovimientoEncabezado = {0};", id);

            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        movimientoEncabezado.MOVIMIENTO_ENCABEZADO = reader.GetInt32(0);
                        movimientoEncabezado.CONCEPTO = reader.IsDBNull(1) ? "null" : reader.GetString(1);
                        movimientoEncabezado.TIPO = tipoMovimientoControl.obtenerTipoMovimientoById(reader.GetInt32(2));
                        movimientoEncabezado.PROVEEDOR = reader.IsDBNull(3) ? proveedorControl.defProveedor() : proveedorControl.obrenerProveedorById(reader.GetInt32(3));
                        movimientoEncabezado.ORDEN_COMPRA = reader.IsDBNull(4) ? ordenCompraControl.defOrdenCompra() : ordenCompraControl.seleccionarOrdenCompraById(reader.GetInt32(4));
                        movimientoEncabezado.CLIENTE = reader.IsDBNull(5) ? clienteControl.defCliente() : clienteControl.seleccionarClienteById(reader.GetInt32(5));
                        movimientoEncabezado.FACTURA = reader.IsDBNull(6) ? facturaControl.defFactura() : facturaControl.seleccionarFacturaById(reader.GetInt32(6));
                        movimientoEncabezado.ESTADO = reader.GetInt32(7);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }

            return movimientoEncabezado;
        }

        public List<MovimientoEncabezado> obtenerAllMovimientoEncabezado()
        {
            List<MovimientoEncabezado> movimientoEncabezadoList = new List<MovimientoEncabezado>();
            TipoMovimientoControl tipoMovimientoControl = new TipoMovimientoControl();
            OrdenCompraControl ordenCompraControl = new OrdenCompraControl();
            ProveedorControl proveedorControl = new ProveedorControl();
            FacturaControl facturaControl = new FacturaControl();
            ClienteControl clienteControl = new ClienteControl();

            String sComando = String.Format("Select KidMovimientoEncabezado, concepto_movimientoencabezado, " +
                "KidTipoMovimiento, KidProveedor, KidOrdenCompraEncabezado, KidClientes, KidFacturaEncabezado, " +
                "estado from Tbl_MovimientoEncabezado;");

            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MovimientoEncabezado movimientoEncabezado = new MovimientoEncabezado();
                        movimientoEncabezado.MOVIMIENTO_ENCABEZADO = reader.GetInt32(0);
                        movimientoEncabezado.CONCEPTO = reader.IsDBNull(1) ? "null" : reader.GetString(1);
                        movimientoEncabezado.TIPO = tipoMovimientoControl.obtenerTipoMovimientoById(reader.GetInt32(2));
                        movimientoEncabezado.PROVEEDOR = reader.IsDBNull(3) ? proveedorControl.defProveedor() : proveedorControl.obrenerProveedorById(reader.GetInt32(3));
                        movimientoEncabezado.ORDEN_COMPRA = reader.IsDBNull(4) ? ordenCompraControl.defOrdenCompra() : ordenCompraControl.seleccionarOrdenCompraById(reader.GetInt32(4));
                        movimientoEncabezado.CLIENTE = reader.IsDBNull(5) ? clienteControl.defCliente() : clienteControl.seleccionarClienteById(reader.GetInt32(5));
                        movimientoEncabezado.FACTURA = reader.IsDBNull(6) ? facturaControl.defFactura() :facturaControl.seleccionarFacturaById(reader.GetInt32(6));
                        movimientoEncabezado.ESTADO = reader.GetInt32(7);
                        movimientoEncabezadoList.Add(movimientoEncabezado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }

            return movimientoEncabezadoList;
        }

        public int obtenerUltimoID()
        {
            int id = 0;
            String sComando = String.Format("Select KidMovimientoEncabezado from Tbl_MovimientoEncabezado");
            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (id < reader.GetInt32(0))
                        {
                            id = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return 0;
            }
            id++;
            return id;
        }

        public MovimientoEncabezado obtenerEncabezadoByEntrada(int proveedor, int ordenCompra)
        {
            MovimientoEncabezado movimientoEncabezado = new MovimientoEncabezado();
            TipoMovimientoControl tipoMovimientoControl = new TipoMovimientoControl();
            OrdenCompraControl ordenCompraControl = new OrdenCompraControl();
            ProveedorControl proveedorControl = new ProveedorControl();

            String sComando = String.Format("select KidMovimientoEncabezado, concepto_movimientoencabezado, " +
                "KidTipoMovimiento, KidProveedor, KidOrdenCompraEncabezado from Tbl_MovimientoEncabezado " +
                "from c where KidProveedor = {0} and " +
                "KidOrdenCompraEncabezado = {1} and estado <> 0;", proveedor, ordenCompra);
            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        movimientoEncabezado.MOVIMIENTO_ENCABEZADO = reader.GetInt32(0);
                        movimientoEncabezado.CONCEPTO = reader.GetString(1);
                        movimientoEncabezado.TIPO = tipoMovimientoControl.obtenerTipoMovimientoById(reader.GetInt32(2));
                        movimientoEncabezado.PROVEEDOR = proveedorControl.obrenerProveedorById(reader.GetInt32(3));
                        movimientoEncabezado.ORDEN_COMPRA = ordenCompraControl.seleccionarOrdenCompraById(reader.GetInt32(4));
                        movimientoEncabezado.ESTADO = reader.GetInt32(5);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }

            return movimientoEncabezado;
        }

        public MovimientoEncabezado obtenerEncabezadoBySalida(int cliente, int factura)
        {
            MovimientoEncabezado movimientoEncabezado = new MovimientoEncabezado();
            TipoMovimientoControl tipoMovimientoControl = new TipoMovimientoControl();
            FacturaControl facturaControl = new FacturaControl();
            ClienteControl clienteControl = new ClienteControl();

            String sComando = String.Format("select KidMovimientoEncabezado, concepto_movimientoencabezado, KidTipoMovimiento, " +
                "KidClientes, KidFacturaEncabezado, estado" +
                " from Tbl_MovimientoEncabezado" +
                " where KidClientes = {0} and KidFacturaEncabezado = {1} and estado <> 0;", cliente, factura);
            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        movimientoEncabezado.MOVIMIENTO_ENCABEZADO = reader.GetInt32(0);
                        movimientoEncabezado.CONCEPTO = reader.GetString(1);
                        movimientoEncabezado.TIPO = tipoMovimientoControl.obtenerTipoMovimientoById(reader.GetInt32(2));
                        movimientoEncabezado.CLIENTE = clienteControl.seleccionarClienteById(reader.GetInt32(3));
                        movimientoEncabezado.FACTURA = facturaControl.seleccionarFacturaById(reader.GetInt32(4));
                        movimientoEncabezado.ESTADO = reader.GetInt32(5);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }

            return movimientoEncabezado;
        }
    }
}
