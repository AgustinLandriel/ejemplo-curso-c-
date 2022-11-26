using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    abstract class Persona
    {
        public string Nombre { get;}
        private string apellido;
        public Direccion Direccion { get; set; }

        private string provincia;
        public string Pais { get; set; }
        public string Apellido
        {
            get{ return apellido; }
            set{ apellido = value; }
        }

        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public virtual void saludar()
        {
            Console.WriteLine("Hola soy " + Nombre);
        }
  
    }
}
