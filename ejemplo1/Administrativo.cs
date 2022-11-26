using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Administrativo:Persona,ISalario
    {

        public string salario ()
        {
            return "Soy administrativo mi salario es de $100.000";
        }
    }
}
