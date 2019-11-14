using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaDatos_MovInv.Conexion;
using CapaDatos_MovInv.Entity;

namespace CapaControl_MovInv.Control
{
    public class ExistenciaControl
    {
        private Transaccion transaccion = new Transaccion();

        public void actualizarExistencias(int prod, int cantidad, int tipoMov)
        {
            int res = obtenerCantidadByProd(prod);
            if (tipoMov == 1)
            {
                res = obtenerCantidadByProd(prod) - cantidad;
            }
            else
            {
                res = obtenerCantidadByProd(prod) + cantidad;
            }

            String sComando = String.Format("Update cantidad = {0} from Tbl_Existencia where kidproducto = {1};", res, prod);

            try
            {
                transaccion.insertarDatos(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al actualizar");
                throw new Exception("No se pudo Actualizar.");
            }
        }
        
        private int obtenerCantidadByProd(int prod)
        {
            int cant = 0;
            String sComando = String.Format("Select cantidad from Tbl_Existencia where kidproducto = {0};", prod);

            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cant = reader.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return 0;
            }

            return cant;
        }
    }
}
