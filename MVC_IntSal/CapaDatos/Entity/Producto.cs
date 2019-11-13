using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entity
{
    public class Producto
    {
        public string KIDPRODUCTO { get; set; }
        public TipoProducto KIDIPOPRODUCTO { get; set; }
        public string NOMBRE_PRODUCTO { get; set; }
        public string DESCRIPCION_PRODUCTO { get; set; }
        public int ESTADO { get; set; }
    }
}
