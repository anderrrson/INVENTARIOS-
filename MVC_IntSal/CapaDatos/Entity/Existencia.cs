using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entity
{
    public class Existencia
    {
        public int KIDEXISTENCIA { get; set; }
        public int KIDPRODUCTO { get; set; }
        public int KIDBODEGA { get; set; }
        public int EXISTENCIA { get; set; }
        public int ESTADO { get; set; }
    }
}
