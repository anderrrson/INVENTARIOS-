using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_MovInv.Entity
{
    public class Factura
    {
        public int FACTURA { get; set; }
        public Cliente CLIENTE { get; set; }
        public int ESTADO { get; set; }
    }
}
