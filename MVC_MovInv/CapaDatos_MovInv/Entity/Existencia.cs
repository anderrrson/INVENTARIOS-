using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_MovInv.Entity
{
    public class Existencia
    {
        public int EXISTENCIA { get; set; }
        public Producto PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public int ESTADO { get; set; }

    }
}
