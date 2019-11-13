using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using CapaDatos.Conexion;
using CapaDatos.Entity;

namespace CapaControl.Control
{
    class ClienteControl
    {
        private Transaccion transaccion = new Transaccion();

        public void insertarCliente(Cliente MD)
        {
            try
            {
                String sComando = String.Format("INSERT INTO TBL_CLIENTE VALUES ({0}, {1}, {2}, {3}, {4}); ",
                    MD.KIDCLIENTE.ToString(), MD.NOMBRES_CLIENTE.ToString(), MD.APELLIDOS_CLIENTE.ToString(),
                    MD.TELEFONO_CLIENTE.ToString(), MD.DIRECCION_CLIENTE.ToString(), MD.DPI_CLIENTE.ToString(),
                    MD.NIT_CLIENTE.ToString(), MD.CONTACTO_CLIENTE.ToString(), MD.TELEFONO_CONTACTO.ToString(),
                    MD.KIDTIPOCLIENTE.ToString(), MD.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al insertar.");
            }
        }

        public void actualizarCliente(Cliente md)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_CLIENTE " + "SET ESTADO = {3} ",
                    md.KIDCLIENTE.ToString(), md.NOMBRES_CLIENTE.ToString(), md.APELLIDOS_CLIENTE.ToString(),
                    md.TELEFONO_CLIENTE.ToString(), md.DIRECCION_CLIENTE.ToString(), md.DPI_CLIENTE.ToString(),
                    md.NIT_CLIENTE.ToString(), md.CONTACTO_CLIENTE.ToString(), md.TELEFONO_CONTACTO.ToString(),
                    md.KIDTIPOCLIENTE.ToString(), md.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al actualizar.");
            }
        }

        public void eliminarCliente(int app, int modulo)
        {
            try
            {
                String sComando = String.Format("DELETE FROM TBL_CLIENTE",
                    app.ToString(), modulo.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al eliminar.");
            }
        }

        public Cliente obtenerCliente(int app, int modulo)
        {
            Cliente movTmp = new Cliente();
            try
            {
                String sComando = String.Format("SELECT KIDCLIENTE, NOMBRE_CLIENTE, APELLIDOS_CLIENTE," +
                    "TELEFONO_CLIENTE, DIRECCION_CLIENTE, DPI_CLIENTE, NIT_CLIENTE, CONTACTO_CLIENTE, " +
                    "TELEFONO_CONTACTO, ESTADO " + "FROM TBL_CLIENTE " + "WHERE ESTADO <> 0; ",
                    app.ToString(), modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        movTmp.KIDCLIENTE = reader.GetInt32(0);
                        movTmp.NOMBRES_CLIENTE = reader.GetString(45);
                        movTmp.APELLIDOS_CLIENTE = reader.GetString(45);
                        movTmp.TELEFONO_CLIENTE = reader.GetString(45);
                        movTmp.DIRECCION_CLIENTE = reader.GetString(45);
                        movTmp.DPI_CLIENTE = reader.GetInt32(0);
                        movTmp.NIT_CLIENTE = reader.GetString(45);
                        movTmp.CONTACTO_CLIENTE = reader.GetString(45);
                        movTmp.TELEFONO_CONTACTO = reader.GetString(45);
                        movTmp.ESTADO = reader.GetInt32(3);
                    }
                }
            }
            catch (OdbcException ex)
            {
                throw new Exception("No se obtuvieron registros." + ex.ToString());
            }

            return movTmp;
        }

        public List<Cliente> obtenerAllCliente(int modulo)
        {
            List<Cliente> MovList = new List<Cliente>();
            try
            {
                String sComando = String.Format("SELECT KIDCLIENTE, NOMBRE_CLIENTE, APELLIDOS_CLIENTE," +
                    "TELEFONO_CLIENTE, DIRECCION_CLIENTE, DPI_CLIENTE, NIT_CLIENTE, CONTACTO_CLIENTE, " +
                    "TELEFONO_CONTACTO, ESTADO " + "FROM TBL_CLIENTE" + "WHERE ESTADO <> 0; ",
                    modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente movTmp = new Cliente();
                        movTmp.KIDCLIENTE = reader.GetInt32(0);
                        movTmp.NOMBRES_CLIENTE = reader.GetString(45);
                        movTmp.APELLIDOS_CLIENTE = reader.GetString(45);
                        movTmp.TELEFONO_CLIENTE = reader.GetString(45);
                        movTmp.DIRECCION_CLIENTE = reader.GetString(45);
                        movTmp.DPI_CLIENTE = reader.GetInt32(0);
                        movTmp.NIT_CLIENTE = reader.GetString(45);
                        movTmp.CONTACTO_CLIENTE = reader.GetString(45);
                        movTmp.TELEFONO_CONTACTO = reader.GetString(45);
                        movTmp.ESTADO = reader.GetInt32(3);
                        MovList.Add(movTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error.");
                return null;
            }

            return MovList;
        }
        public List<Cliente> obtenerAllCliente()
        {
            List<Cliente> MovList = new List<Cliente>();

            try
            {
                String sComando = String.Format("SELECT * FROM TBL_CLIENTE " + "WHERE ESTADO <> 0; ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente movTmp = new Cliente();
                        movTmp.KIDCLIENTE = reader.GetInt32(0);
                        movTmp.NOMBRES_CLIENTE = reader.GetString(45);
                        movTmp.APELLIDOS_CLIENTE = reader.GetString(45);
                        movTmp.TELEFONO_CLIENTE = reader.GetString(45);
                        movTmp.DIRECCION_CLIENTE = reader.GetString(45);
                        movTmp.DPI_CLIENTE = reader.GetInt32(0);
                        movTmp.NIT_CLIENTE = reader.GetString(45);
                        movTmp.CONTACTO_CLIENTE = reader.GetString(45);
                        movTmp.TELEFONO_CONTACTO = reader.GetString(45);
                        movTmp.ESTADO = reader.GetInt32(3);
                        MovList.Add(movTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error.");
                return null;
            }

            return MovList;
        }
    }
}
