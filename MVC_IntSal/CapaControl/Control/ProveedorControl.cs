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
    class ProveedorControl
    {
        private Transaccion transaccion = new Transaccion();

        public void insertarProveedor(Proveedor MD)
        {
            try
            {
                String sComando = String.Format("INSERT INTO TBL_PROVEEDOR VALUES ({0}, {1}, {2}, {3}, {4}); ",
                    MD.KIDPROVEEDOR.ToString(), MD.NOMBRE.ToString(), MD.TELEFONO.ToString(),
                    MD.DIRECCION.ToString(), MD.PAGINA.ToString(), MD.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al insertar.");
            }
        }

        public void actualizarProveedor(Proveedor md)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_PROVEEDOR " + "SET ESTADO = {3} ",
                    md.KIDPROVEEDOR.ToString(), md.NOMBRE.ToString(), md.TELEFONO.ToString(),
                    md.DIRECCION.ToString(), md.PAGINA.ToString(), md.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al actualizar.");
            }
        }

        public void eliminarProveedor(int app, int modulo)
        {
            try
            {
                String sComando = String.Format("DELETE FROM TBL_PROVEEDOR ",
                    app.ToString(), modulo.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al eliminar.");
            }
        }

        public Proveedor obtenerProveedor(int app, int modulo)
        {
            Proveedor movTmp = new Proveedor();
            try
            {
                String sComando = String.Format("SELECT KIDCLIENTE, NOMBRE_CLIENTE, APELLIDOS_CLIENTE," +
                    "TELEFONO_CLIENTE, DIRECCION_CLIENTE, DPI_CLIENTE, NIT_CLIENTE, CONTACTO_CLIENTE, " +
                    "TELEFONO_CONTACTO, ESTADO " + "FROM TBL_PROVEEDOR " + "WHERE ESTADO <> 0; ",
                    app.ToString(), modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        movTmp.KIDPROVEEDOR = reader.GetInt32(0);
                        movTmp.NOMBRE = reader.GetString(45);
                        movTmp.TELEFONO = reader.GetString(45);
                        movTmp.PAGINA = reader.GetString(45);
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

        public List<Proveedor> obtenerAllProveedor(int modulo)
        {
            List<Proveedor> MovList = new List<Proveedor>();
            try
            {
                String sComando = String.Format("SELECT * FROM TBL_PROVEEDOR WHERE ESTADO <> 0; ",
                    modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Proveedor movTmp = new Proveedor();
                        movTmp.KIDPROVEEDOR = reader.GetInt32(0);
                        movTmp.NOMBRE = reader.GetString(45);
                        movTmp.TELEFONO = reader.GetString(45);
                        movTmp.DIRECCION = reader.GetString(45);
                        movTmp.PAGINA = reader.GetString(45);
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
        public List<Proveedor> obtenerAllProveedor()
        {
            List<Proveedor> MovList = new List<Proveedor>();

            try
            {
                String sComando = String.Format("SELECT * FROM TBL_PROVEEDOR WHERE ESTADO <> 0; ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Proveedor movTmp = new Proveedor();
                        movTmp.KIDPROVEEDOR = reader.GetInt32(0);
                        movTmp.NOMBRE = reader.GetString(45);
                        movTmp.TELEFONO = reader.GetString(45);
                        movTmp.DIRECCION = reader.GetString(45);
                        movTmp.PAGINA = reader.GetString(45);
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
