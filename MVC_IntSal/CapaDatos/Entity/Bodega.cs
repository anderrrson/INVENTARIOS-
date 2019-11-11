using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entity
{
    public class Bodega
    {
        public Sucursal KIDSUCURSAL { get; set; }
        public int KIDBODEGA { get; set; }
        public String NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public string DIRECCION { get; set; }
        public int MAXSTOCK { get; set; }
        public int MIXSTOCK { get; set; }
        public int estado{ get; set; }
    }
}