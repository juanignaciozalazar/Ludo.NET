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
        public int IdJugador { get; }
        public int IdArea { get; set; }
        public int PosArea { get; set; } 

        // Constructores
        public Ficha(int IdJugador) 
        {
            this.IdJugador = IdJugador;
            this.IdArea = IdJugador;
            this.PosArea = -1;
        }

        // Métodos

        public void Mover(int NuevaPosicion)
        {
            PosArea = NuevaPosicion;
        }
    }
}
