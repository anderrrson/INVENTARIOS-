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
    public class MovimientoDetalleControl
    {
        private Transaccion transaccion = new Transaccion();
        
        public void insertarMovimientoDetalle(MovimientoDetalle MD)
        {
            try
            {
                String sComando = String.Format("INSERT INTO TBL_MOVIMIENTODETALLE VALUES ({0}, {1}, {2}, {3}, {4}); ",
                    MD.KIDMOVIMIENTODETALLE.ToString(), MD.CANTIDAD_MOVIMIENTODETALLE.ToString(),
                    MD.KIDPRODUCTO.ToString(), MD.KIDMOVIMIENTOENCABEZADO.ToString(), MD.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al insertar.");
            }
        }

        public void actualizarMovimientoDetalle(MovimientoDetalle md)
        {
            try
            {
                String sComando = String.Format("UPDATE TBL_MOVIMIENTODETALLE " +
                    "SET ESTADO = {3} ",
                    md.KIDMOVIMIENTODETALLE.ToString(), md.CANTIDAD_MOVIMIENTODETALLE.ToString(),
                    md.KIDPRODUCTO.ToString(), md.KIDMOVIMIENTOENCABEZADO.ToString(), md.ESTADO.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al actualizar.");
            }
        }

        public void eliminarMovimientoDetalle(int app, int modulo)
        {
            try
            {
                String sComando = String.Format("DELETE FROM TBL_MOVIMIENTODETALLE ",
                    app.ToString(), modulo.ToString());

                this.transaccion.insertarDatos(sComando);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString(), "Error al eliminar.");
            }
        }

        public MovimientoDetalle obtenerMovimientoDetalle(int app, int modulo)
        {
            MovimientoDetalle movTmp = new MovimientoDetalle();
            try
            {
                String sComando = String.Format("SELECT KIDMOVIMIENTODETALLE, CANTIDAD_MOVIMIENTODETALLE, " +
                    "KIDPRODUCTO, KIDMOVIMIENTOENCABEZDO, ESTADO " +
                    "FROM TBL_MOVIMIENTODETALLE " + "WHERE ESTADO <> 0; ",
                    app.ToString(), modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        movTmp.KIDMOVIMIENTODETALLE = reader.GetInt32(0);
                        movTmp.CANTIDAD_MOVIMIENTODETALLE = reader.GetInt32(1);
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

        public List<MovimientoDetalle> obtenerAllMovimientoDetalle(int modulo)
        {
            List<MovimientoDetalle> MovList = new List<MovimientoDetalle>();
            try
            {
                String sComando = String.Format("SELECT KIDMOVIMIENTODETALLE, CANTIDAD_MOVIMIENTODETALLE, " +
                    "KIDPRODUCTO, KIDMOVIMIENTOENCABEZDO, ESTADO " + "FROM TBL_RPT_APP" + "WHERE ESTADO <> 0; ",
                    modulo.ToString());

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MovimientoDetalle movTmp = new MovimientoDetalle();
                        movTmp.KIDMOVIMIENTODETALLE = reader.GetInt32(0);
                        movTmp.CANTIDAD_MOVIMIENTODETALLE = reader.GetInt32(1);
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
        public List<MovimientoDetalle> obtenerAllMovimientoDetalle()
        {
            List<MovimientoDetalle> MovList = new List<MovimientoDetalle>();
            
            try
            {
                String sComando = String.Format("SELECT ID_REPORTE, ID_APLICACION, ID_MODULO, ESTADO " +
                    "FROM TBL_RPT_APP " + "WHERE ESTADO <> 0; ");

                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MovimientoDetalle movTmp = new MovimientoDetalle();
                        movTmp.KIDMOVIMIENTODETALLE = reader.GetInt32(0);
                        movTmp.CANTIDAD_MOVIMIENTODETALLE = reader.GetInt32(1);
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