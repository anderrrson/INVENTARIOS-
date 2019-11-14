using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_MovInv.Entity
{
    public class MovimientoDetalle
    {
        public int MOVIMIENTO_DETALLE { get; set; }
        public MovimientoEncabezado MOVIMIENTO_ENCABEZADO { get; set; }
        public int CANTIDAD { get; set; }
        public Producto PRODUCTO { get; set; }
        public int ESTADO { get; set; }
    }
}
