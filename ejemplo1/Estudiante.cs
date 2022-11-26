using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Estudiante:Persona
    {
        public Carrera Carrera { get; set; }

        public override void saludar()
        {
            Console.WriteLine("Hola soy un estudiante");
        }
    }
}
