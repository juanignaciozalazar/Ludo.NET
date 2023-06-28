using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoTPI
{
    internal class EstadoJuego
    {

        public Jugador JugadorActual { get; set; }
        public int EstadoActual { get; set; } // ESTADO_SACADADO -- ESTADO_MOVERFICHA
        public int NumeroSacado { get; set; }
        public int CantJugadores { get; set; }


        public EstadoJuego()
        {
            this.EstadoActual = Constantes.ESTADO_SACADADO;
        }
    }
}
