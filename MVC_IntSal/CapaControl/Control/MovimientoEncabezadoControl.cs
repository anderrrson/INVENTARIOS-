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
    public class MovimientoEncabezadoControl
    {
        private Transaccion transaccion = new Transaccion();
        private MovimientoDetalleControl MD = new MovimientoDetalleControl();
        private ProductoControl Pro = new ProductoControl();
        private ClienteControl Cli = new ClienteControl();
        private StockControl sto = new StockControl();
        private TipoMovimientoControl TM = new TipoMovimientoControl();

        public void insertarMovimientoEncabezado(MovimientoEncabezado Tipo)
        {
            try
            {
                String sComando = String.Format("INSERT INTO TBL_MOVIMIENTOENCABEZADO VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10});",
                    Tipo.KIDMOVIMIENTOENCABBEBZADO.ToString(), Tipo.FECHA_MOVIMIENTOENCABEZADO.ToString(),
                    Tipo.KIDPROVEEDOR.ToString(), Tipo.KIDTIPOMOVIMIENTO.ToString(), Tipo.KIDCLIENTE.ToString(),
                    Tipo.CONCEPTO_MOVIMIENTOENCABEZADO.ToString(), Tipo.KIDBODEGA_DESTINO.ToString(), Tipo.KIDBODEGA_ORIGEN.ToString(),
                    Tipo.KIDORDENCOMPRAENCABEZADO.ToString(), Tipo.KIDFACTURAENCABEZADO.ToString(), Tipo.ESTADO.ToString());
                
                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al insertar.");
            }
        }

        public void actualizarMovimientoEncabezado(MovimientoEncabezado Tipo)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_MOVIMIENTOENCABEZADO" + "SET ESTADO = {2}",
                    Tipo.KIDMOVIMIENTOENCABBEBZADO.ToString(), Tipo.FECHA_MOVIMIENTOENCABEZADO.ToString(),
                    Tipo.KIDPROVEEDOR.ToString(), Tipo.KIDTIPOMOVIMIENTO.ToString(), Tipo.KIDCLIENTE.ToString(),
                    Tipo.CONCEPTO_MOVIMIENTOENCABEZADO.ToString(), Tipo.KIDBODEGA_DESTINO.ToString(), Tipo.KIDBODEGA_ORIGEN.ToString(),
                    Tipo.KIDORDENCOMPRAENCABEZADO.ToString(), Tipo.KIDFACTURAENCABEZADO.ToString(), Tipo.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al actualizar.");
            }
        }

        public void eliminarMovimientoEncabezado(int app, int modulo)
        {
            try
            {
                String sComando = String.Format("DELETE FROM TBL_MOVIMIENTOENCABEZADO",
                    app.ToString(), modulo.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al eliminar.");
            }
        }

        public MovimientoEncabezado obtenerMovimientoEncabezado(int app, int modulo)
        {
            MovimientoEncabezado tipoTmp = new MovimientoEncabezado();
            try
            {
                String sComando = String.Format("SELECT KIDMOVIMIENTOENCABBEBZADO, FECHA_MOVIMIENTOENCABBEBZADO, " +
                    "KIDPROVEEDOR, KIDTIPOMOVIMIENTO, KIDCLIENTE, CONCEPTO_MOVIMIENTOENCABBEBZADO, KIDBODEGA_DESTINO, " +
                    "KIDBODEGA_ORIGEN, KIDORDENCOMPRAENCABEZADO, KIDFACTURAENCABEZADO, ESTADO " +
                    "FROM TBL_MOVIMIENTOENCABEZADO WHERE ESTADO <> 0; ",
                    app.ToString(), modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tipoTmp.KIDMOVIMIENTOENCABBEBZADO = reader.GetInt32(0);
                        tipoTmp.FECHA_MOVIMIENTOENCABEZADO = reader.GetDateTime(0);
                        tipoTmp.CONCEPTO_MOVIMIENTOENCABEZADO = reader.GetString(0);
                        tipoTmp.KIDBODEGA_DESTINO = reader.GetInt32(0);
                        tipoTmp.KIDBODEGA_ORIGEN = reader.GetInt32(0);
                        tipoTmp.KIDORDENCOMPRAENCABEZADO = reader.GetInt32(0);
                        tipoTmp.KIDFACTURAENCABEZADO = reader.GetInt32(0);
                        tipoTmp.ESTADO = reader.GetInt32(3);
                        tipoTmp.KIDTIPOMOVIMIENTO = TM.obtenerTipoMovimiento(reader.GetInt32(1), reader.GetInt32(2));
                        tipoTmp.KIDCLIENTE = Cli.obtenerCliente(reader.GetInt32(1), reader.GetInt32(2));
                    }
                }
            }
            catch (OdbcException ex)
            {
                throw new Exception("No se obtuvieron registros." + ex.ToString());
            }

            return tipoTmp;
        }

        public List<MovimientoEncabezado> obtenerAllMovimientoEncabezado(int modulo)
        {
            List<MovimientoEncabezado> TipoList = new List<MovimientoEncabezado>();
            try
            {
                String sComando = String.Format("SELECT KIDMOVIMIENTOENCABBEBZADO, FECHA_MOVIMIENTOENCABBEBZADO, " +
                    "KIDPROVEEDOR, KIDTIPOMOVIMIENTO, KIDCLIENTE, CONCEPTO_MOVIMIENTOENCABBEBZADO, KIDBODEGA_DESTINO, " +
                    "KIDBODEGA_ORIGEN, KIDORDENCOMPRAENCABEZADO, KIDFACTURAENCABEZADO, ESTADO " +
                    "FROM TBL_MOVIMIENTOENCABEZADO WHERE ESTADO <> 0; ",
                    modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MovimientoEncabezado tipoTmp = new MovimientoEncabezado();
                        tipoTmp.KIDMOVIMIENTOENCABBEBZADO = reader.GetInt32(0);
                        tipoTmp.FECHA_MOVIMIENTOENCABEZADO = reader.GetDateTime(0);
                        tipoTmp.CONCEPTO_MOVIMIENTOENCABEZADO = reader.GetString(0);
                        tipoTmp.KIDBODEGA_DESTINO = reader.GetInt32(0);
                        tipoTmp.KIDBODEGA_ORIGEN = reader.GetInt32(0);
                        tipoTmp.KIDORDENCOMPRAENCABEZADO = reader.GetInt32(0);
                        tipoTmp.KIDFACTURAENCABEZADO = reader.GetInt32(0);
                        tipoTmp.ESTADO = reader.GetInt32(3);
                        TipoList.Add(tipoTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error.");
                return null;
            }

            return TipoList;
        }
        public List<MovimientoEncabezado> obtenerAllMovimientoEncabezado()
        {
            List<MovimientoEncabezado> tipoList = new List<MovimientoEncabezado>();

            try
            {
                String sComando = String.Format("KIDMOVIMIENTOENCABBEBZADO, FECHA_MOVIMIENTOENCABBEBZADO, " +
                    "KIDPROVEEDOR, KIDTIPOMOVIMIENTO, KIDCLIENTE, CONCEPTO_MOVIMIENTOENCABBEBZADO, KIDBODEGA_DESTINO, " +
                    "KIDBODEGA_ORIGEN, KIDORDENCOMPRAENCABEZADO, KIDFACTURAENCABEZADO, ESTADO " +
                    "FROM TBL_MOVIMIENTOENCABEZADO WHERE ESTADO <> 0; ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MovimientoEncabezado tipoTmp = new MovimientoEncabezado();
                        tipoTmp.KIDMOVIMIENTOENCABBEBZADO = reader.GetInt32(0);
                        tipoTmp.FECHA_MOVIMIENTOENCABEZADO = reader.GetDateTime(0);
                        tipoTmp.CONCEPTO_MOVIMIENTOENCABEZADO = reader.GetString(0);
                        tipoTmp.KIDBODEGA_DESTINO = reader.GetInt32(0);
                        tipoTmp.KIDBODEGA_ORIGEN = reader.GetInt32(0);
                        tipoTmp.KIDORDENCOMPRAENCABEZADO = reader.GetInt32(0);
                        tipoTmp.KIDFACTURAENCABEZADO = reader.GetInt32(0);
                        tipoTmp.ESTADO = reader.GetInt32(3);
                        tipoList.Add(tipoTmp);
                    }
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error.");
                return null;
            }

            return tipoList;
        }
    }
}