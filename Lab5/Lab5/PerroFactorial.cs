using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class PerroFactorial : ICalcular
    {
        public int Calcular(int n)
        {
            int r = 1;
            for (int i=n; i>1; i--)
            {
                r *= i;
            }
            return r;
        }
    }
}
