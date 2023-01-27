using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionACSharp
{
    //extends equivalente a :
    internal class Cliente : Persona
    {
        public Cliente(string nombre, int edad, string telefono): base(nombre, edad)
        {
            Telefono= telefono;
            Nombre = nombre.ToLower();
        }

        public String Telefono { get; set; }


        
        public void Mostrar() {
            base.Mostrar();
            Console.WriteLine("Telefono: " + Telefono);
        }
    }
}
