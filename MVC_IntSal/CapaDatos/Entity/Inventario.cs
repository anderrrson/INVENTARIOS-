using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entity
{
    public class Inventario
    {
        public int KidInventarios { get; set; }
        public Producto KidProducto { get; set; } 
        public Bodega KidBodega { get; set; }
        public Stock Kidstock { get; set; }
        public Existencia Kidexistencias { get; set; }
        public DateTime fecha_inventario { get; set; }
        public int cantidad_inventario { get; set; }
        public int estado { get; set; }
    }
}
