using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entity
{
    public class Cliente
    {
        public int KIDCLIENTE { get; set; }
        public string NOMBRES_CLIENTE { get; set; }
        public string APELLIDOS_CLIENTE { get; set; }
        public string TELEFONO_CLIENTE { get; set; }
        public string DIRECCION_CLIENTE { get; set; }
        public int DPI_CLIENTE { get; set; }
        public string NIT_CLIENTE { get; set; }
        public string CONTACTO_CLIENTE { get; set; }
        public string TELEFONO_CONTACTO { get; set; }
        public TipoCliente KIDTIPOCLIENTE { get; set; }
        public int ESTADO { get; set; }
    }
}