using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruccion_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entra el nombre de ususario");
            string usu = Console.ReadLine();
            switch (usu)
            {
                case "Administrador":
                    {
                        Console.WriteLine("Bienvenido Administrador") ;
                        Console.ReadKey();
                        break;
                    }
                case "Invitado":
                    {
                        Console.WriteLine("Bienvenido Invitado") ;
                        goto case "Permisos Invitado";  //Muestra el caso de abajo después de ejecutar el caso de Invitado            
                    }
                case "Permisos Invitado":
                    {
                        Console.WriteLine("No disponemos de apenas ningún permiso menda");
                        break; //Termina la instrucción
                    }
                default:
                    {
                        Console.WriteLine("Mis cojones");
                            break;
                    }
            }
            Console.WriteLine("Gracias por usar el programa");
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
