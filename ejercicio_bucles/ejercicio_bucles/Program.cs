﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*REALICE UN PROGRAMA QUE LEA 5 NÚMEROS INGRESADOS POR EL TECLADO,
 * CALCULE EL FACTORIAL DE CADA NÚMERO Y LO MUESTRE EN PANTALLA, ADEMÁS DEBE MOSTRAR LA SUMA DE LOS FACTORIALES DE LOS 5 NÚMEROS INGRESADOS*/
namespace ejercicio_bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumatoria = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Introduce un número");
                int numero = int.Parse(Console.ReadLine());
                int factorial = 1;
                for (int j = 1; j <= numero; j++)
                {
                    factorial = factorial * j;
                }
                sumatoria = sumatoria + factorial;
                Console.WriteLine("El valor del numero {0} y su factorial es {1}", numero, factorial);
            }
            Console.WriteLine("El valor de la suma de todos los factoriales es {0}", sumatoria);
            Console.ReadKey();
        }
    }
}
