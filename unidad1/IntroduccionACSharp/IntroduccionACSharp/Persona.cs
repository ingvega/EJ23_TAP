using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionACSharp
{
    internal class Persona
    {
        //Atributo a manejar en el get y set de Edad
        private int edad;
        
        //Propiedad autoimplementada
        public String Nombre { get; set; }
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value < 0 || value > 120)
                    throw new Exception("Edad no válida, debe estar entre 0 y 120");

                edad = value;
            }
            //set(int value)
            //{
            //       edad = value;
            //    }
        }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }


        //private String nombre;
        //public string getNombre() {
        //    return nombre;
        //}
        //public void setNombre(string nombre) {
        //    this.nombre = nombre;
        //}

        public void Mostrar()
        {
            Console.WriteLine("Nombre: " + Nombre +
                "\n Edad: " + Edad);
        }
    }
}
