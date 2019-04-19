using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Calculadora
    {
        //Funcion min
        int Min(int n, int maximo)
        {
            if (n > maximo)
            {
                return maximo;
            }

            else
            {
                return n;
            }
        }
       
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
            //Sumar 5
            if (opcion == 1)
            {
                int resultado = calculadoras[0].Calcular(numero);
                numero = resultado;
            }

            //Fibonacci
            else if (opcion == 2)
            {
                int resultado = calculadoras[1].Calcular(Min(numero,46));
                numero = resultado;
            }

            //Fcatorial
            else if (opcion == 3)
            {
                int resultado = calculadoras[2].Calcular(Min(numero,13));
                numero = resultado;
            }

            //Cubo
            else if (opcion == 4)
            {
                int resultado = calculadoras[3].Calcular(numero);
                numero = resultado;
            }

            //Cuadrado
            else if (opcion == 5)
            {
                int resultado = calculadoras[4].Calcular(numero);
                numero = resultado;
            }
        }
    }
}
