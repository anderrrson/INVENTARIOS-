using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaDatos_MovInv.Entity;
using CapaDatos_MovInv.Conexion;
using System.Data.Odbc;

namespace CapaControl_MovInv.Control
{
    public class TipoMovimientoControl
    {
        private Transaccion transaccion = new Transaccion();
        public TipoMovimiento obtenerTipoMovimientoById(int id)
        {
            TipoMovimiento tipoMovimiento = new TipoMovimiento();

            String sComando = String.Format("select KidTipoMovimiento, nombre, estado " +
                "from tbl_tipo_movimiento where KidTipoMovimiento = {0} and estado <> 0;", id);

            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tipoMovimiento.TIPO_MOVIMIENTO = reader.GetInt32(0);
                        tipoMovimiento.NOMBRE = reader.GetString(1);
                        tipoMovimiento.ESTADO = reader.GetInt32(2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }

            return tipoMovimiento;
        }
    }
}
