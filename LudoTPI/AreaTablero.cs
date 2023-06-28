using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoTPI
{
    internal class AreaTablero
    {
        public int ID { get; set; }
        public Ficha[] ArrayFichas { get; set; }
        

        public AreaTablero()
        {
            ArrayFichas = new Ficha[18];
        } 

        public bool ContieneFicha(int posicion)
        {
            if (ArrayFichas[posicion] == null)
            {
                return false;
            } else
            {
                return true;
            }
        }

            
    }
}
