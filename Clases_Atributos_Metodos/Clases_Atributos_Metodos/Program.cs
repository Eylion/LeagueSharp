using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Atributos_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona obPersona = new Persona("Juan", 26, 15.2);
            Console.WriteLine("Entre el nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Entre el edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre el peso");
            double peso = double.Parse(Console.ReadLine());
            Persona ob2Persona = new Persona(nombre, edad, peso);

            Console.WriteLine(ob2Persona.nombre);
            Console.ReadKey();


          /*  double valor = int.Parse(Console.ReadLine());
            obPersona.limpiarNotas();
            bool rendimiento = obPersona.rendimiento(valor);
            Console.WriteLine("El promedio de las notas es: {0}", obPersona.promedioNotas());
            if (rendimiento == true)
            {
                Console.WriteLine("La persona es de buen rendimiento");
            }
            else
            {
                Console.WriteLine("La persona NO es de buen rendimiento");
            }
            Console.ReadKey();*/
        }
    }
}
