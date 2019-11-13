using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_MovInv.Entity
{
    public class OrdenCompra
    {
        public int ORDEN_COMPRA { get; set; }
        public Proveedor PROVEEDOR { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public int ESTADO { get; set; }

    }
}
