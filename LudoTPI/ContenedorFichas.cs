using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoTPI
{
    internal abstract class ContenedorFichas
    {
        private int CantFichas;

        public Ficha[] Fichas
        {
            get { return fichas; }
            set { fichas = value; }
        }

    }
}
