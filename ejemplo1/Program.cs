using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Profesor profesor01 = new Profesor();

            Administrativo adm01 = new Administrativo();

            profesor01.salario();
            
            Console.WriteLine(adm01.salario());
            Console.WriteLine(profesor01.salario());

            Estudiante estudiante01 = new Estudiante();
          
            profesor01.saludar();
            estudiante01.saludar();


            List<string> listaNombres = new List<string>() {"Agustin","Matias","Valentin","Federico","Agustin" };

            HashSet<string> hashNombres = new HashSet<string>() { "Florencia", "Mariel","Florencia" };

            Dictionary<int, string> diccionario = new Dictionary<int, string>() {
                [0] = "Independiente",
                [1] = "River"
            };

            diccionario.Add(4, "ChuchoRojo");

            foreach (KeyValuePair<int,string> item in diccionario)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            listaNombres.Add("Kevin");
            listaNombres.Remove("Agustin");

            foreach (string item in listaNombres)
            {
                Console.WriteLine(item);
            }

            foreach (string item in hashNombres)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
