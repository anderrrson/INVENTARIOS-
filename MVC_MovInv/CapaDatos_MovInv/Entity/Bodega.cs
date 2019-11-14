using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_MovInv.Entity
{
    public class Bodega
    {
        public int BODEGA { get; set; }
        public int SUCURSAL { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public string DIRECCION { get; set; }
        public int MINSTOCK { get; set; }
        public int MAXSTOCK { get; set; }
        public string STATUS { get; set; }
        public int ESTADO { get; set; }
    }
}
