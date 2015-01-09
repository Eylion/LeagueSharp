using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploTrabajadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entra el nombre del trabajador 1");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("Su nombre es {0}", nombre1);
            Console.WriteLine("Entra su salario");
            double sal1 = double.Parse(Console.ReadLine());         
            Console.WriteLine("Su salario es {0}", sal1);

            Console.WriteLine("Entra el nombre del trabajador 2");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("Su nombre es {0}", nombre2);
            Console.WriteLine("Entra su salario");
            double sal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Su salario es {0}", sal2);

            Console.WriteLine("Entra el nombre del trabajador 3");
            string nombre3 = Console.ReadLine();
            Console.WriteLine("Su nombre es {0}", nombre3);
            Console.WriteLine("Entra su salario");
            double sal3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Su salario es {0}", sal3);

            double media = (sal1 + sal2 + sal3) / 3;
            Console.WriteLine("La media del salario de entre los 3 es: " + Math.Round(media, 2));
            Console.ReadKey();
        }
    }
}
