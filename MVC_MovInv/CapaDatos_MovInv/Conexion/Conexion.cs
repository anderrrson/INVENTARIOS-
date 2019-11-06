using System;
using System.Data.Odbc;

namespace CapaDatos_MovInv.Conexion
{
    public class Conexion
    {
        OdbcConnection conexion;

        public Tuple<OdbcConnection, OdbcTransaction> iniciarConexion()
        {
            conexion = new OdbcConnection("Dsn=HSC");
            conexion.Open();

            OdbcTransaction transaccion = conexion.BeginTransaction();

            return Tuple.Create(conexion, transaccion);
        }
        
        public void cerrarConexion()
        {
            conexion.Close();
        }
    }
}
