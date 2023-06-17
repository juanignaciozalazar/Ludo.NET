using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoTPI
{
    internal class DadoClass
    {
        Random r;
        public const int MIN_VALUE = 1;
        public const int MAX_VALUE = 7;
        public DadoClass()
        {
            r = new Random();
        }

        public int Tirar()
        {
            return r.Next(MIN_VALUE, MAX_VALUE);
        }
    }
}
