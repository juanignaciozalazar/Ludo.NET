using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoTPI
{
    internal class ContenedorFichas
    {
        public List<Ficha> Fichas { get; set; }

        private ContenedorFichas(int CantFichas)
        {

        }

        public ContenedorFichas CreateContenedorFichasJugador(int IdJugador)
        {
            return new ContenedorFichas(IdJugador);
        }

    }
}
