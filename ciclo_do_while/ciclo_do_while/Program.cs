using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclo_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string usu;
            string pass;
            do
            {
                Console.WriteLine("Introduce usuario");
                usu = Console.ReadLine();
                if (usu != "Administrador")
                {
                    Console.WriteLine("Usuario incorrecto");
                }
                Console.WriteLine("Introduce contraseña");
                pass = Console.ReadLine();
                if (pass != "admin")
                {
                    Console.WriteLine("Pass incorrecta");
                }
                
            } while (usu != "Administrador" || pass != "admin");
            Console.WriteLine("Login correcto");
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
        }
    }
}
