using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class RobotFibonacci : ICalcular
    {
        public int Calcular(int n)
        {
            int x0 = 0;
            int x1 = 1;
            int x2 = 0; 

            for(int i = 0; i<n-1; i++)
            {
                x2 = x1 + x0;
                x0 = x1;
                x1 = x2;
            }


            return x2;
        }
    }
}
