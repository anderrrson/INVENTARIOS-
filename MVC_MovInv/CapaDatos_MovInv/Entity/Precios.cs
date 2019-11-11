using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_MovInv.Entity
{
    public class Precios
    {
        public int CODIGO  { get; set; }
        public float PRECIO { get; set; }
        public string DESCRIPCION { get; set; }
        public Producto PRODUCTO { get; set; }
    }
}
