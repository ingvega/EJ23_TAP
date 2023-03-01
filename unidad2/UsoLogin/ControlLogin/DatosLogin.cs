using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLogin
{
    public class DatosLogin:EventArgs
    {
        public String Usuario { get; set; }
        public String Contrasenia { get; set; }
    }
}
