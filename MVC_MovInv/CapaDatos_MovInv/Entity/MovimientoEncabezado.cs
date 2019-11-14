using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_MovInv.Entity
{
    public class MovimientoEncabezado
    {
        public int MOVIMIENTO_ENCABEZADO { get; set; }
        public DateTime FECHA { get; set; }
        public string CONCEPTO { get; set; }
        public TipoMovimiento TIPO { get; set; }
        public Bodega BODEGA_ORIGEN { get; set; }
        public Bodega BODEGA_DESTINO { get; set; }
        public Proveedor PROVEEDOR { get; set; }
        public Cliente CLIENTE { get; set; }
        public OrdenCompra ORDEN_COMPRA { get; set; }
        public Factura FACTURA { get; set; }
        public int ESTADO { get; set; }
    }
}
