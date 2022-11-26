using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Profesor:Persona,ISalario
    {

        public string salario ()
        {
            return "Soy profesor y mi salario es de 130.000";
        }

        public override void saludar()
        {
            Console.WriteLine("Hola soy el profesor");
        }
    }
}
