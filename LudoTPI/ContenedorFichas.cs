using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoTPI
{
    internal class ContenedorFichas
    {
        public Ficha[] Fichas { get; set; }

        public ContenedorFichas(int CantFichas, int IdJugador)
        {
            this.Fichas = new Ficha[4];
            for (int i = 0; i < CantFichas; i++)
            {
                Fichas[i] = new Ficha(IdJugador);
            }
        }        
    }
}
