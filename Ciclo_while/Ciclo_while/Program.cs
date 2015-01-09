using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclo_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el usuario");
            string usu = Console.ReadLine();
            while(usu != "Administrador")
            {
                Console.WriteLine("Usuario incorrecto");
                Console.WriteLine("Vuelve a introducir el usuario");
                usu = Console.ReadLine();
            }
            Console.WriteLine("Bienvenido Administrador");
            Console.WriteLine("¿Cómo va la mañana fiera?");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
    }
}
