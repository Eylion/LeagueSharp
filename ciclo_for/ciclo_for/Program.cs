using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclo_for
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            bool aut = false;
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine("Entre su usuario");
                usuario = Console.ReadLine();
                if (usuario == "Administrador")
                {
                    Console.WriteLine("Usuario correcto");
                    aut = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Usuario incorrecto");
                }
            }
            if (aut == true)
            {
                Console.WriteLine("Bienvenido Administrador");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Eres un impostor de mierda");
                Console.ReadKey();
            }

        }
    }
}
