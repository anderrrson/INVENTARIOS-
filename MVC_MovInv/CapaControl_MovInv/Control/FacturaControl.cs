using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaDatos_MovInv.Conexion;
using CapaDatos_MovInv.Entity;
using System.Data.Odbc;

namespace CapaControl_MovInv.Control
{
    public class FacturaControl
    {
        private Transaccion transaccion = new Transaccion();

        public Factura defFactura()
        {
            Factura factura = new Factura();
            ClienteControl clienteControl = new ClienteControl();

            factura.FACTURA = 0;
            factura.CLIENTE = clienteControl.defCliente();
            factura.ESTADO = 1;

            return factura;
        }
        public Factura seleccionarFacturaById(int id)
        {
            ClienteControl clienteControl = new ClienteControl();
            Factura factura = new Factura();

            String sComando = String.Format("Select KidFacturaEncabezado, KidCliente, estado from Tbl_FacturaEncabezado " +
                " where KidFacturaEncabezado = {0} and estado <> 0; ", id);
            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        factura.FACTURA = reader.GetInt32(0);
                        factura.CLIENTE = clienteControl.seleccionarClienteById(reader.GetInt32(1));
                        factura.ESTADO = reader.GetInt32(2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }
            return factura;
        }

        public List<Factura> seleccionarAllByClientes(Cliente cliente)
        {
            List<Factura> facturaList = new List<Factura>();

            String sComando = String.Format("Select KidFacturaEncabezado, KidCliente, estado from Tbl_FacturaEncabezado " +
                " where KidCliente = {0} and estado <> 0; ", cliente.CLIENTE);
            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Factura factura = new Factura();
                        factura.FACTURA = reader.GetInt32(0);
                        factura.CLIENTE = cliente;
                        factura.ESTADO = reader.GetInt32(2);
                        facturaList.Add(factura);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }
            return facturaList;
        }
    }
}
