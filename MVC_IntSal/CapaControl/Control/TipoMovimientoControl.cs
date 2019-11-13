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
    public class TipoMovimientoControl
    {
        private Transaccion transaccion = new Transaccion();

        public void insertarTipoMovimiento(TipoMovimiento Tipo)
        {
            try
            {
                String sComando = String.Format("INSERT INTO TBL_TIPOMOVIMIENTO VALUES ({0}, {1}, {2}, {3}); ",
                    Tipo.KIDTIPOMOVIMIENTO.ToString(), Tipo.NOMBRE.ToString(),
                    Tipo.DESCRIPCION.ToString(), Tipo.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al insertar.");
            }
        }

        public void actualizarTipoMovimiento(TipoMovimiento tipo)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_TIPOMOVIMIENTO " +
                    "SET ESTADO = {3} ",
                    tipo.KIDTIPOMOVIMIENTO.ToString(), tipo.NOMBRE.ToString(),
                    tipo.DESCRIPCION.ToString(), tipo.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al actualizar.");
            }
        }

        public void eliminarTipoMovimiento(int app, int modulo)
        {
            try
            {
                String sComando = String.Format("DELETE FROM TBL_TIPOMOVIMIENTO ",
                    app.ToString(), modulo.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al eliminar.");
            }
        }

        public TipoMovimiento obtenerTipoMovimiento(int app, int modulo)
        {
            TipoMovimiento tipoTmp = new TipoMovimiento();
            try
            {
                String sComando = String.Format("SELECT KIDTIPOSCOMPROBANTES, NOMBRECOMPROBANTE, DETALLE, ESTADO " +
                    "FROM TBL_TIPOMOVIMIENTO " + "WHERE ESTADO <> 0; ",
                    app.ToString(), modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tipoTmp.KIDTIPOMOVIMIENTO = reader.GetInt32(0);
                        tipoTmp.NOMBRE = reader.GetString(45);
                        tipoTmp.DESCRIPCION = reader.GetString(45);
                        tipoTmp.ESTADO = reader.GetInt32(3);
                    }
                }
            }
            catch (OdbcException ex)
            {
                throw new Exception("No se obtuvieron registros." + ex.ToString());
            }

            return tipoTmp;
        }

        public List<TipoMovimiento> obtenerAllTipoMovimiento(int modulo)
        {
            List<TipoMovimiento> TipoList = new List<TipoMovimiento>();
            try
            {
                String sComando = String.Format("SELECT KIDTIPOSCOMPROBANTES, NOMBRECOMPROBANTE, DETALLE, ESTADO " +
                    "FROM TBL_TIPOMOVIMIENTO" + "WHERE ESTADO <> 0; ",
                    modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TipoMovimiento TipoTmp = new TipoMovimiento();
                        TipoTmp.KIDTIPOMOVIMIENTO = reader.GetInt32(0);
                        TipoTmp.NOMBRE = reader.GetString(45);
                        TipoTmp.DESCRIPCION = reader.GetString(45);
                        TipoTmp.ESTADO = reader.GetInt32(3);
                        TipoList.Add(TipoTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte aplicacion.");
                return null;
            }

            return TipoList;
        }
        public List<TipoMovimiento> obtenerAllTipoMovimiento()
        {
            List<TipoMovimiento> tipoList = new List<TipoMovimiento>();

            try
            {
                String sComando = String.Format("SELECT ID_REPORTE, ID_APLICACION, ID_MODULO, ESTADO " +
                    "FROM TBL_TIPOMOVIMIENTO " +
                    "WHERE ESTADO <> 0; ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TipoMovimiento TipoTmp = new TipoMovimiento();
                        TipoTmp.KIDTIPOMOVIMIENTO = reader.GetInt32(0);
                        TipoTmp.NOMBRE = reader.GetString(45);
                        TipoTmp.DESCRIPCION = reader.GetString(45);
                        TipoTmp.ESTADO = reader.GetInt32(3);
                        tipoList.Add(TipoTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al obtener reporte aplicacion.");
                return null;
            }

            return tipoList;
        }
    }
}
