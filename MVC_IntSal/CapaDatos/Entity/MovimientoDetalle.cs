using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entity
{
    public class MovimientoDetalle
    {
        public int KIDMOVIMIENTODETALLE { get; set; }
        public int CANTIDAD_MOVIMIENTODETALLE { get; set; }
        public Producto KIDPRODUCTO { get; set; }
        public MovimientoEncabezado KIDMOVIMIENTOENCABEZADO { get; set; }
        public int ESTADO { get; set; }
    }
}