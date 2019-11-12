using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entity
{
    public class Integracion
    {
        public TipoMovimiento NOMBRECOMPROBANTE { get; set; }
        public MovimientoDetalle CANTIDAD_MOVIMIENTODETALLE { get; set; }
        public Stock CANTIDADMAXIMA { get; set; }
        public Stock CANTIDADMINIMA { get; set; }
    }
}
