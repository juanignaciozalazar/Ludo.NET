using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LudoTPI
{
    internal class Ficha
    {
        // Atributos
        public bool EnJuego;
        public int IdJugador;
        public int IdArea;
        public int PosArea;
        public Ficha(int idJugador)
        {
            IdArea = idJugador;
            PosArea = Constantes.POS_ENTRADA;
        }

        public void Mover()
        {

        }

        public bool EnJuego
        {
            get
            {
                return enJuego;
            }
            set
            {
                enJuego = value;
            }
        }
    }
}
