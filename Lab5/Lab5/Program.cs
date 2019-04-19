using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonaQueSuma5 pqs5 = new PersonaQueSuma5();
            RobotFibonacci rf = new RobotFibonacci();
            PerroFactorial pf = new PerroFactorial();
            Cubo cubo = new Cubo();
            Cuadrado cuadrado = new Cuadrado();

            Console.WriteLine("Ingrese numero");
            int numero = int.Parse(Console.ReadLine());
            Calculadora cal = new Calculadora(numero);
            cal.calculadoras.Add(pqs5);
            cal.calculadoras.Add(rf);
            cal.calculadoras.Add(pf);
            cal.calculadoras.Add(cubo);
            cal.calculadoras.Add(cuadrado);

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("Cuantos calculos desea?");
            int numcalculos = int.Parse(Console.ReadLine());

            for (int i =0; i<numcalculos; i++)
            {
                Console.WriteLine("Que calculo quiere hacer?");
                Console.WriteLine("[1] Sumar 5");
                Console.WriteLine("[2] Fibonacci del numero");
                Console.WriteLine("[3] Factorial del numero");
                Console.WriteLine("[4] Numero al cubo");
                Console.WriteLine("[5] Numero al cuadrado");
                int opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (opcion == 1)
                {
                    cal.Calcular(opcion);
                    Console.WriteLine(cal.GetNumero());
                }

                else if (opcion == 2)
                {
                    cal.Calcular(opcion);
                    Console.WriteLine(cal.GetNumero());
                }

                else if (opcion == 3)
                {
                    cal.Calcular(opcion);
                    Console.WriteLine(cal.GetNumero());
                }

                else if (opcion == 4)
                {
                    cal.Calcular(opcion);
                    Console.WriteLine(cal.GetNumero());
                }

                else if (opcion == 5)
                {
                    cal.Calcular(opcion);
                    Console.WriteLine(cal.GetNumero());
                }

            }

            Console.ReadLine();

        }
    }
}
