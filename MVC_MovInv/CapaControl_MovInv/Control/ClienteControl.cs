using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaDatos_MovInv.Entity;
using CapaDatos_MovInv.Conexion;
using System.Data.Odbc;

namespace CapaControl_MovInv.Control
{
    public class ClienteControl
    {
        private Transaccion transaccion = new Transaccion();

        public Cliente defCliente()
        {
            Cliente cliente = new Cliente();
            cliente.CLIENTE = 0;
            cliente.NOMBRE = "null";
            cliente.APELLIDO = "null";
            cliente.ESTADO = 1;
            return cliente;
        }
        public Cliente seleccionarClienteById(int id)
        {
            Cliente cliente = new Cliente();

            String sComando = String.Format("Select KidCliente, nombres_cliente, apellidos_cliente, estado from Tbl_Clientes " +
                " where KidCliente = {0} and estado <> 0; ", id);
            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cliente.CLIENTE = reader.GetInt32(0);
                        cliente.NOMBRE = reader.GetString(1);
                        cliente.APELLIDO = reader.GetString(2);
                        cliente.ESTADO = reader.GetInt32(3);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }
            return cliente;
        }

        public List<Cliente> seleccionarAllClientes()
        {
            List<Cliente> clienteList = new List<Cliente>();

            String sComando = String.Format("Select KidCliente, nombres_cliente, apellidos_cliente, estado from Tbl_Clientes " +
                " where estado <> 0; ");
            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.CLIENTE = reader.GetInt32(0);
                        cliente.NOMBRE = reader.GetString(1);
                        cliente.APELLIDO = reader.GetString(2);
                        cliente.ESTADO = reader.GetInt32(3);
                        clienteList.Add(cliente);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }
            return clienteList;
        }

    }
}
