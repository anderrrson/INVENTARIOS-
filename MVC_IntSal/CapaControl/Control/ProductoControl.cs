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
    public class ProductoControl
    {
        private Transaccion transaccion = new Transaccion();
        
        public void insertarProducto(Producto prod)
        {
            try
            {
                String sComando = String.Format("INSERT INTO TBL_PRODUCTO VALUES ({0}, {1}, {2}, {3}, {4}); ",
                    prod.KIDPRODUCTO.ToString(), prod.KIDIPOPRODUCTO.ToString(),
                    prod.NOMBRE_PRODUCTO.ToString(), prod.DESCRIPCION_PRODUCTO.ToString(), prod.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al insertar producto.");
            }
        }

        public void actualizarProducto(Producto Pro)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_PRODUCTO " +
                    "SET ESTADO = {3} ",
                    Pro.KIDPRODUCTO.ToString(), Pro.KIDIPOPRODUCTO.ToString(),
                    Pro.NOMBRE_PRODUCTO.ToString(), Pro.DESCRIPCION_PRODUCTO.ToString(), Pro.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al actualizar producto.");
            }
        }

        public void eliminarProducto(int app, int modulo)
        {
            try
            {
                String sComando = String.Format("DELETE FROM TBL_PRODUCTO ",
                    app.ToString(), modulo.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al eliminar producto.");
            }
        }

        public Producto obtenerProducto(int app, int modulo)
        {
            Producto productoTmp = new Producto();
            try
            {
                String sComando = String.Format("SELECT KIDPRO, ID_APLICACION, ID_MODULO, ESTADO " +
                    "FROM TBL_PRODUCTO " +
                    "WHERE ESTADO <> 0; ",
                    app.ToString(), modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        productoTmp.KIDPRODUCTO = reader.GetString(45);
                        productoTmp.NOMBRE_PRODUCTO = reader.GetString(45);
                        productoTmp.DESCRIPCION_PRODUCTO = reader.GetString(45);
                        productoTmp.ESTADO = reader.GetInt32(3);
                    }
                }
            }
            catch (OdbcException ex)
            {
                throw new Exception("No se obtuvieron registros." + ex.ToString());
            }

            return productoTmp;
        }

        public List<Producto> obtenerAllProducto(int modulo)
        {
            List<Producto> ProductoList = new List<Producto>();
            try
            {
                String sComando = String.Format("SELECT ID_REPORTE, ID_APLICACION, ID_MODULO, ESTADO " +
                    "FROM TBL_PRODUCTO" +
                    "WHERE ESTADO <> 0; ",
                    modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto ProductoTmp = new Producto();
                        ProductoTmp.KIDPRODUCTO = reader.GetString(45);
                        ProductoTmp.NOMBRE_PRODUCTO = reader.GetString(45);
                        ProductoTmp.DESCRIPCION_PRODUCTO = reader.GetString(45);
                        ProductoTmp.ESTADO = reader.GetInt32(3);
                        ProductoList.Add(ProductoTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener producto.");
                return null;
            }

            return ProductoList;
        }
        public List<Producto> obtenerAllProducto()
        {
            List<Producto> productoList = new List<Producto>();
            
            try
            {
                String sComando = String.Format("SELECT ID_REPORTE, ID_APLICACION, ID_MODULO, ESTADO " +
                    "FROM TBL_PRODUCTO " + "WHERE ESTADO <> 0; ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto productoTmp = new Producto();
                        Producto ProductoTmp = new Producto();
                        ProductoTmp.KIDPRODUCTO = reader.GetString(45);
                        ProductoTmp.NOMBRE_PRODUCTO = reader.GetString(45);
                        ProductoTmp.DESCRIPCION_PRODUCTO = reader.GetString(45);
                        ProductoTmp.ESTADO = reader.GetInt32(3);
                        productoList.Add(ProductoTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte aplicacion.");
                return null;
            }

            return productoList;
        }

    }
}
