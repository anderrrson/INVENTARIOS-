using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaDatos_MovInv.Entity;
using CapaDatos_MovInv.Conexion;
using System.Data.Odbc;

namespace CapaControl_MovInv.Control
{
    public class ProveedorControl
    {
        private Transaccion transaccion = new Transaccion();

        public Proveedor defProveedor()
        {
            Proveedor proveedor = new Proveedor();
            proveedor.PROVEEDOR = 0;
            proveedor.NOMBRE = "null";
            proveedor.ESTADO = 1;
            return proveedor;
        }
        public Proveedor obrenerProveedorById(int id)
        {
                        Proveedor proveedor = new Proveedor();

            String sComando = String.Format("Select KidProveedor, nombre,  estado from Tbl_proveedor " +
               " where KidProveedor = {0} and estado <> 0; ", id);
            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        proveedor.PROVEEDOR = reader.GetInt32(0);
                        proveedor.NOMBRE = reader.GetString(1);
                        proveedor.ESTADO = reader.GetInt32(2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }

            return proveedor;
        }

        public List<Proveedor> obrenerAllProveedor()
        {
            List<Proveedor> proveedorList = new List<Proveedor>();

            String sComando = String.Format("Select KidProveedor, nombre,  estado from Tbl_proveedor " +
               " where estado <> 0; ");
            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Proveedor proveedor = new Proveedor();
                        proveedor.PROVEEDOR = reader.GetInt32(0);
                        proveedor.NOMBRE = reader.GetString(1);
                        proveedor.ESTADO = reader.GetInt32(2);
                        proveedorList.Add(proveedor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }

            return proveedorList;
        }
    }
}
