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
    public class StockControl
    {
        private Transaccion transaccion = new Transaccion();
        
        public List<Stock> ExistenciaList { get; private set; }

        public void insertarStock(Stock existencia)
        {
            try
            {
                String sComando = String.Format("INSERT INTO TBL_STOCK VALUES ({0}, {1}, {2}, {3}); ",
                    existencia.KIDSTOCK.ToString(), existencia.CANTIDADMAXIMA.ToString(),
                    existencia.CANTIDADMINIMA.ToString(), existencia.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al insertar.");
            }
        }

        public void actualizarStock(Stock existencia)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_STOCK " +
                    "SET KIDSTOCK = {0}, ESTADO = {3} " +
                    "WHERE CANTIDADMAXIMA = {1} " +
                    " AND CANTIDADMINIMA = {2}; ",
                    existencia.KIDSTOCK.ToString(), existencia.CANTIDADMAXIMA.ToString(),
                    existencia.CANTIDADMINIMA.ToString(), existencia.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al actualizar.");
            }
        }

        public void eliminarStock(int stock)
        {
            try
            {
                String sComando = String.Format("DELETE FROM TBL_STOCK " +
                    "WHERE KIDSTOCK = {0} ",
                    stock.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al eliminar");
            }
        }

        public Stock obtenerStock(int app, int modulo)
        {
            Stock ExisTmp = new Stock();
            try
            {
                String sComando = String.Format("SELECT ID_REPORTE, ID_APLICACION, ID_MODULO, ESTADO " +
                    "FROM TBL_STOCK " + "WHERE ESTADO <> 0; ",
                    app.ToString(), modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ExisTmp.KIDSTOCK = reader.GetInt32(0);
                        ExisTmp.CANTIDADMAXIMA = reader.GetInt32(100);
                        ExisTmp.CANTIDADMINIMA = reader.GetInt32(100);
                        ExisTmp.ESTADO = reader.GetInt32(3);
                    }
                }
            }
            catch (OdbcException ex)
            {
                throw new Exception("No se obtuvieron registros." + ex.ToString());
            }

            return ExisTmp;
        }

        public List<Stock> obtenerAllStock(int stock)
        {
            List<Stock> ExistenciaList = new List<Stock>();
            try
            {
                String sComando = String.Format("SELECT KIDSTOCK, CANTIDADMAXIMA, CANTIDADMINIMA, ESTADO " +
                    "FROM TBL_STOCK" + "WHERE AND ESTADO <> 0; ",
                    stock.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Stock ExisTmp = new Stock();
                        ExisTmp.KIDSTOCK = reader.GetInt32(0);
                        ExisTmp.CANTIDADMAXIMA = reader.GetInt32(100);
                        ExisTmp.CANTIDADMINIMA = reader.GetInt32(100);
                        ExisTmp.ESTADO = reader.GetInt32(3);
                        ExistenciaList.Add(ExisTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error.");
                return null;
            }

            return ExistenciaList;
        }
        public List<Stock> obtenerAllStock()
        {
            List<Stock> ExistenciaList = new List<Stock>();
            
            try
            {
                String sComando = String.Format("SELECT KIDSTOCK, CANTIDADMAXIMA, CANTIDADMINIMA, ESTADO " +
                    "FROM TBL_STOCK " + "WHERE ESTADO <> 0; ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Stock ExisTmp = new Stock();
                        ExisTmp.KIDSTOCK = reader.GetInt32(0);
                        ExisTmp.CANTIDADMAXIMA = reader.GetInt32(100);
                        ExisTmp.CANTIDADMINIMA = reader.GetInt32(100);
                        ExisTmp.ESTADO = reader.GetInt32(3);
                        ExisTmp.ESTADO = int.Parse(reader.GetString(3));
                        ExistenciaList.Add(ExisTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "ErroR.");
                return null;
            }

            return ExistenciaList;
        }
    }
}
