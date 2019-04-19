using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class PersonaQueSuma5 : ICalcular
    {
        public int Calcular(int n)
        {
            int r= n + 5;
            return r;
        }
    }
}
