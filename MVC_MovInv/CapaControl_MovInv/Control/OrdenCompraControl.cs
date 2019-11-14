using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaDatos_MovInv.Conexion;
using CapaDatos_MovInv.Entity;

namespace CapaControl_MovInv.Control
{
    public class OrdenCompraControl
    {
        private Transaccion transaccion = new Transaccion();

        public OrdenCompra defOrdenCompra()
        {
            OrdenCompra ordenCompra = new OrdenCompra();
            ProveedorControl proveedorControl = new ProveedorControl();

            ordenCompra.ORDEN_COMPRA = 0;
            ordenCompra.PROVEEDOR = proveedorControl.defProveedor();
            ordenCompra.ESTADO = 1;
            return ordenCompra;
        }
        public OrdenCompra seleccionarOrdenCompraById(int id)
        {
            OrdenCompra ordenCompra = new OrdenCompra();
            ProveedorControl proveedorControl = new ProveedorControl();

            String sComando = String.Format("Select KidOrdenCompraEncabezado, KidProveedor, estado from Tbl_orden_compra_encabezado " +
                " where KidOrdenCompraEncabezado = {0} and estado <> 0; ", id);
            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ordenCompra.ORDEN_COMPRA = reader.GetInt32(0);
                        ordenCompra.PROVEEDOR = proveedorControl.obrenerProveedorById(reader.GetInt32(1));
                        ordenCompra.ESTADO = reader.GetInt32(2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }
            return ordenCompra;
        }

        public List<OrdenCompra> seleccionarAllByProveedors(Proveedor proveedor)
        {
            List<OrdenCompra> ordenCompraList = new List<OrdenCompra>();

            String sComando = String.Format("Select KidOrdenCompraEncabezado, KidProveedor, estado from Tbl_orden_compra_encabezado " +
                " where KidProveedor = {0} and estado <> 0; ", proveedor.PROVEEDOR);
            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OrdenCompra ordenCompra = new OrdenCompra();
                        ordenCompra.ORDEN_COMPRA = reader.GetInt32(0);
                        ordenCompra.PROVEEDOR = proveedor;
                        ordenCompra.ESTADO = reader.GetInt32(2);
                        ordenCompraList.Add(ordenCompra);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }
            return ordenCompraList;
        }

    }
}
