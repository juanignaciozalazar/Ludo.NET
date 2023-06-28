using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LudoTPI
{

    enum ColorById
    {
        G,
        R,
        B,
        Y,
    }
    internal class Tablero
    {
        public AreaTablero[] AreasTablero { get;  }      //Contiene las 4 areas del tablero
        private int numeroSacado;
        public ContenedorFichas contenedorFinal;

        public bool ContieneFicha(int idArea, int posicion)
        {
            return AreasTablero[idArea].ContieneFicha(posicion) ? true : false;
        }

        public bool PuedeIniciarFicha(Jugador jugador)
        {
            if (
                (numeroSacado == 1 || numeroSacado == 6)
                && !ContieneFicha(jugador.ID, Constantes.POS_INICIO)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
