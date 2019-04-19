using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Calculadora
    {
        public List<ICalcular> calculadoras = new List<ICalcular>();


        private int numero;

        public Calculadora(int numero)
        {
            this.numero = numero;
        }


        public int GetNumero()
        {
            return numero;
        }


        public void Calcular(int opcion)
        {
            if (opcion == 1)
            {
                int resultado = calculadoras[0].Calcular(numero);
                numero = resultado;
            }

            else if (opcion == 2)
            {
                int resultado = calculadoras[1].Calcular(numero);
                numero = resultado;
            }

            else if (opcion == 3)
            {
                int resultado = calculadoras[2].Calcular(numero);
                numero = resultado;
            }

            else if (opcion == 4)
            {
                int resultado = calculadoras[3].Calcular(numero);
                numero = resultado;
            }

            else if (opcion == 5)
            {
                int resultado = calculadoras[4].Calcular(numero);
                numero = resultado;
            }
        }
    }
}
