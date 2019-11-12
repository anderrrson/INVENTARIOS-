using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entity
{
    public class TipoMovimiento
    {
        public int KIDTIPOSCOMPROBANTES { get; set; }
        public string NOMBRECOMPROBANTE { get; set; }
        public string DETALLE { get; set; }
        public int ESTADO { get; set; }
    }
}
