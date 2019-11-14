using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_MovInv.Entity
{
    public class Cliente
    {
        public int CLIENTE { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string TELEFONO { get; set; }
        public string DIRECCION { get; set; }
        public int DPI { get; set; }
        public string NIT { get; set; }
        public string CONTACTO { get; set; }
        public string TELEFONO_CONTACTO { get; set; }
        public TipoCliente TIPO { get; set; }
        public int ESTADO { get; set; }
    }
}
