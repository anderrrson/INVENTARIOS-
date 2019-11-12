using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entity
{
    public class MovimientoEncabezado
    {
        public int KIDMOVIMIENTOENCABBEBZADO { get; set; }
        public DateTime FECHA_MOVIMIENTOENCABBEBZADO { get; set; }
        public Proveedor KIDPROVEEDOR { get; set; }
        public TipoMovimiento KIDTIPOMOVIMIENTO { get; set; }
        public Cliente KIDCLIENTE { get; set; }
        public string CONCEPTO_MOVIMIENTOENCABBEBZADO { get; set; }
        public int KIDBODEGA_DESTINO { get; set; }
        public int KIDBODEGA_ORIGEN { get; set; }
        public int KIDORDENCOMPRAENCABEZADO { get; set; }
        public int KIDFACTURAENCABEZADO { get; set; }
        public int ESTADO { get; set; } 
    }
}