using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre el nombre del trabajador");
            string nombre = Console.ReadLine();

            Console.WriteLine("Entre el nivel del trabajador");
            int nivel = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre los años trabajados por parte del trabajador");
            int years = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Es líder? <Si o No>");
            string liderRes = Console.ReadLine();
            bool lider = false;
                if(liderRes=="Si")
                    lider = true;

            Empleado obj = new Empleado(nombre, nivel, years, lider);
            Console.WriteLine(obj.salario().ToString());
            Console.WriteLine("Entre cantidad de meses");
            int meses = int.Parse(Console.ReadLine());
            if(obj.haTrabajado(meses) == true)
                Console.WriteLine("Ha trabajado más tiempo");
            else
            {
                Console.WriteLine("No ha trabajado más de {0} meses", meses);
            }
            Console.ReadKey();
        }
    }
}
