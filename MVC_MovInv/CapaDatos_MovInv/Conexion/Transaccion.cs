﻿using System.Windows.Forms;
using System.Data.Odbc;

namespace CapaDatos_MovInv.Conexion
{
    public class Transaccion
    {
        public void insertarDatos(params string[] sSentencia)
        {
            Conexion conexion = new Conexion();
            var resultado = conexion.iniciarConexion();
            OdbcCommand comando = resultado.Item1.CreateCommand();
            OdbcTransaction transaccion = resultado.Item2;
            comando.Transaction = transaccion;

            try
            {
                foreach (string sentencia in sSentencia)
                {
                    comando.CommandText = sentencia;
                    comando.ExecuteNonQuery();
                }

                transaccion.Commit();
            }
            catch (OdbcException ex)
            {
                transaccion.Rollback();
                MessageBox.Show(ex.Message, "Error en sentencia");
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public OdbcDataReader ConsultarDatos(string sParametro)
        {
            Conexion conexion = new Conexion();
            var resultado = conexion.iniciarConexion();
            OdbcCommand comando = resultado.Item1.CreateCommand();
            OdbcTransaction transaction = resultado.Item2;
            OdbcDataReader reader;
            try
            {
                comando.Transaction = transaction;
                comando.CommandText = sParametro;
                reader = comando.ExecuteReader();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Se dio un error al procesar la peticion: " + ex.Message, "Error en " +
                    "consulta de datos.");
                return null;
            }
            return reader;
        }
    }
}
