using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaDatos_MovInv.Conexion;
using CapaDatos_MovInv.Entity;

namespace CapaControl_MovInv.Control
{
    public class MovimientoDetalleControl
    {
        private Transaccion transaccion = new Transaccion();


        public void incertarMovimientoDetalle (MovimientoDetalle movimientoDetalle)
        {
            ExistenciaControl existencia = new ExistenciaControl();
            String sComando = String.Format("Insert into Tbl_MovimientoDetalle " +
                " values ( {0} , {1} , {2} , {3}, {4});", movimientoDetalle.MOVIMIENTO_DETALLE,  
                movimientoDetalle.CANTIDAD, movimientoDetalle.PRODUCTO.PRODUCTO, 
                movimientoDetalle.MOVIMIENTO_ENCABEZADO.MOVIMIENTO_ENCABEZADO, movimientoDetalle.ESTADO);

            try
            {
                transaccion.insertarDatos(sComando);
                existencia.actualizarExistencias(movimientoDetalle.PRODUCTO.PRODUCTO, movimientoDetalle.CANTIDAD,
                    movimientoDetalle.MOVIMIENTO_ENCABEZADO.TIPO.TIPO_MOVIMIENTO);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al insertar");
                throw new Exception("No se pudo insertar.");
            }
        }

        public List<MovimientoDetalle> obtenerAllMovDetalleByEncab(int encabezado)
        {
            List<MovimientoDetalle> movimientoDetalleList = new List<MovimientoDetalle>();
            MovimientoEncabezadoControl movimientoEncabezadoControl = new MovimientoEncabezadoControl();
            ProductoControl productoControl = new ProductoControl();

            String sComando = String.Format("Select KidMovimientoDetalle, cantidad_movimientodetalle, KidProducto, KidMovimientoEncabezado, estado" +
                " from Tbl_MovimientoDetalle " +
               " where KidMovimientoEncabezado = {0} and estado <> 0; ", encabezado);
            try
            {
                OdbcDataReader reader = transaccion.ConsultarDatos(sComando);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MovimientoDetalle movimientoDetalle = new MovimientoDetalle();
                        movimientoDetalle.MOVIMIENTO_DETALLE = reader.GetInt32(0);
                        movimientoDetalle.CANTIDAD = reader.GetInt32(1);
                        movimientoDetalle.PRODUCTO = productoControl.obtenerProductoById(reader.GetInt32(2));
                        movimientoDetalle.MOVIMIENTO_ENCABEZADO = movimientoEncabezadoControl.obtenerMovimientoEncabezadoById(encabezado);
                        movimientoDetalle.ESTADO = reader.GetInt32(2);
                        movimientoDetalleList.Add(movimientoDetalle);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el dato: " + ex, "Error en consulta a Base de Datos");
                return null;
            }

            return movimientoDetalleList;
        }
    }
}
