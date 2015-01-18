using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Empleado
    {
        private string nombre;
        private int nivel;
        private int years;
        private bool lider;
        public Empleado(string nombre, int nivel, int years, bool lider)
        {
            this.nombre = nombre;
            this.nivel = nivel;
            this.years = years;
            this.lider = lider;
        }
        public double salario()
        {
            double salario = 245;
            if (nivel == 2)
                salario += 100;
            if (lider == true)
                salario += (245 * 15) / 100;
            return salario;
        }

        public bool haTrabajado(int cantidadMe)
        {
            bool result;

            if (years * 11 > cantidadMe)
            {
                result = true;
            }
            else
	        {
                result = false;
        	}
            return result;
        }
    }
}
