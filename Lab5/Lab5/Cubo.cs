using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Cubo : ICalcular
    {
        public int Calcular(int n)
        {
            double r = Math.Pow(n, 3);
            return (int)r;
        }
    }
}
