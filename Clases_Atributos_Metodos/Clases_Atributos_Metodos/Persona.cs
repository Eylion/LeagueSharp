using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Atributos_Metodos
{
    public class Persona
    {
        public string nombre; //se podrá acceder desde cualquier sitio
        public int edad; //Sólo dentro de la clase
        public double peso; //Sólo dentro de su clase o clases heredadas de esta clase
        int[] notas = { 5, 6, 7, 9, 7, 5, 4, 5 }; //Se puede utilizar desde cualquier parte del ensamblado propio
        public Persona(string nombre, int edad, double peso)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
        }
        public double promedioNotas()
        {
            double suma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }
            double promedio = suma / notas.Length;
            return promedio;
        }
       public void limpiarNotas()
        {
            Array.Clear(notas, 0, notas.Length);
        }
        public bool rendimiento(double valorEntrado)
       {
           double promedio = promedioNotas();
           if (promedio >= valorEntrado)
           {
               return true;
           }
           else
           {
               return false;
           }
       }
    }
}
