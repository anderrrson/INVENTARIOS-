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
    public class IntegracionControl
    {
        private Transaccion transaccion = new Transaccion();
        private MovimientoDetalleControl MD = new MovimientoDetalleControl();
        private ProductoControl Pro = new ProductoControl();
        private StockControl sto = new StockControl();
        private TipoMovimientoControl TM = new TipoMovimientoControl();

        public void insertarIntegracion(Integracion reporteApp)
        {
            try
            {
                String sComando = String.Format("INSERT INTO TBL_INTEGRACION VALUES ({0}, {1}, {2}, {3}); ",
                    reporteApp.NOMBRECOMPROBANTE.ToString(), reporteApp.CANTIDAD_MOVIMIENTODETALLE.ToString(),
                    reporteApp.CANTIDADMAXIMA.ToString(), reporteApp.CANTIDADMINIMA.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al insertar.");
            }
        }

        public void actualizarIntegracion(Integracion reporteApp)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_INTEGRACION ",
                    reporteApp.NOMBRECOMPROBANTE.ToString(), reporteApp.CANTIDAD_MOVIMIENTODETALLE.ToString(),
                    reporteApp.CANTIDADMAXIMA.ToString(), reporteApp.CANTIDADMINIMA.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al actualizar.");
            }
        }

        public void eliminarIntegracion(int app, int modulo)
        {
            try
            {
                String sComando = String.Format("DELETE FROM TBL_INTEGRACION ",
                    app.ToString(), modulo.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al eliminar.");
            }
        }

        public Integracion obtenerIntegracion(int app, int modulo)
        {
            Integracion reporteAppTmp = new Integracion();
            try
            {
                String sComando = String.Format("SELECT NOMBRECOMPROBANTE, CANTIDAD_MOVIMIENTODETALLE, " +
                    "CANTIDADMAXIMA, CANTIDADMINIMA " + "FROM TBL_INTEGRACION ", app.ToString(), modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        reporteAppTmp.NOMBRECOMPROBANTE = TM.obtenerTipoMovimiento(reader.GetInt32(0), reader.GetInt32(1));
                        reporteAppTmp.CANTIDAD_MOVIMIENTODETALLE = MD.obtenerMovimientoDetalle(reader.GetInt32(2), reader.GetInt32(3));
                        reporteAppTmp.CANTIDADMAXIMA = sto.obtenerStock(reader.GetInt32(4), reader.GetInt32(5));
                        reporteAppTmp.CANTIDADMINIMA = sto.obtenerStock(reader.GetInt32(6), reader.GetInt32(7));
                    }
                }
            }
            catch (OdbcException ex)
            {
                throw new Exception("No se obtuvieron registros." + ex.ToString());
            }

            return reporteAppTmp;
        }

        public List<Integracion> obtenerAllIntegracion(int modulo)
        {
            List<Integracion> reporteAppList = new List<Integracion>();
            try
            {
                String sComando = String.Format("SELECT NOMBRECOMPROBANTE, CANTIDAD_MOVIMIENTODETALLE, " +
                    "CANTIDADMAXIMA, CANTIDADMINIMA " + "FROM TBL_INTEGRACION", modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Integracion reporteAppTmp = new Integracion();
                        reporteAppTmp.NOMBRECOMPROBANTE = TM.obtenerTipoMovimiento(reader.GetInt32(0), reader.GetInt32(1));
                        reporteAppTmp.CANTIDAD_MOVIMIENTODETALLE = MD.obtenerMovimientoDetalle(reader.GetInt32(2), reader.GetInt32(3));
                        reporteAppTmp.CANTIDADMAXIMA = sto.obtenerStock(reader.GetInt32(4), reader.GetInt32(5));
                        reporteAppTmp.CANTIDADMINIMA = sto.obtenerStock(reader.GetInt32(6), reader.GetInt32(7));
                        reporteAppList.Add(reporteAppTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error.");
                return null;
            }

            return reporteAppList;
        }
        public List<Integracion> obtenerAllIntegracion()
        {
            List<Integracion> reporteAppList = new List<Integracion>();
            MovimientoDetalleControl MD = new MovimientoDetalleControl();
            ProductoControl Pro = new ProductoControl();
            StockControl sto = new StockControl();
            TipoMovimientoControl TM = new TipoMovimientoControl();

            try
            {
                String sComando = String.Format("SELECT ID_REPORTE, ID_APLICACION, ID_MODULO, ESTADO " +
                    "FROM TBL_INTEGRACION ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Integracion reporteAppTmp = new Integracion();
                        reporteAppTmp.NOMBRECOMPROBANTE = TM.obtenerTipoMovimiento(reader.GetInt32(0), reader.GetInt32(1));
                        reporteAppTmp.CANTIDAD_MOVIMIENTODETALLE = MD.obtenerMovimientoDetalle(reader.GetInt32(2), reader.GetInt32(3));
                        reporteAppTmp.CANTIDADMAXIMA = sto.obtenerStock(reader.GetInt32(4), reader.GetInt32(5));
                        reporteAppTmp.CANTIDADMINIMA = sto.obtenerStock(reader.GetInt32(6), reader.GetInt32(7));
                        reporteAppList.Add(reporteAppTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error.");
                return null;
            }

            return reporteAppList;
        }
    }
}
