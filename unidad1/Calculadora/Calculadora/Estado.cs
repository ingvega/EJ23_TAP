using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Estado
    {
        public int Clave { get; set; }
        public String Nombre { get; set; }

        public override string ToString() {
            return Nombre;
        }
    }
}
