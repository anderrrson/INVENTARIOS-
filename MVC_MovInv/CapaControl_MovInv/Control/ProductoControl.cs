using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaDatos_MovInv.Entity;
using CapaDatos_MovInv.Conexion;
using System.Data.Odbc;


namespace CapaControl_MovInv.Control
{
    public class ProductoControl
    {
        private Transaccion transaccion = new Transaccion();

        public List<Producto> obtenerAllProducto()
        {
            List<Producto> productoList = new List<Producto>();

            String sComando = String.Format("Select KidProducto, nombre_producto, estado from Tbl_Producto " +
               " where estado <> 0; ");
            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto producto = new Producto();
                        producto.PRODUCTO = reader.GetInt32(0);
                        producto.NOMBRE = reader.GetString(1);
                        producto.ESTADO = reader.GetInt32(2);
                        productoList.Add(producto);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }

            return productoList;
        }
    }
}
