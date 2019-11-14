using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_MovInv.Entity
{
    public class Poliza
    {
        public int POLIZA { get; set; }
        public string CUENTA { get; set; }
        public double DEBE { get; set; }
        public double HABER { get; set; }
    }
}
