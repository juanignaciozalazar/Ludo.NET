using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LudoTPI
{
    internal class Juego
    {
        
        // Atributos
        private Tablero tablero;
        public int NumeroSacado { get; set; }
        public DadoClass Dado { get; set; }
        public Jugador[] Jugadores { get; set; }

        public Jugador ProximoJugador;

        //Constructores
        public Juego(int CantJugadores) {
            this.Dado = new DadoClass();
            for (int i = 0; i < CantJugadores; i++)
            {
                Jugadores[i] = new Jugador(i);
            }
        }

        public void TirarDado()
        {
            NumeroSacado = Dado.Tirar();
        }

        public int CalcularProxMovimiento(Ficha ficha, int numeroSacado, out int idArea)
        {
            idArea = ficha.IdArea;
            int proxPos = ficha.PosArea + numeroSacado;
            if (ficha.IdArea == ficha.IdJugador)
            {
                if (ficha.PosArea <= Constantes.POS_SALTO_FINAL)    // Si la ficha ya esta en el tramo final
                {
                    if (proxPos > Constantes.POS_SALTO_FINAL)       // Si la proxima posición daría en el camino ya recorrido, se le suma 6 para que entre al tramo final.
                        proxPos += Constantes.POS_SALTO_FINAL;
                    return proxPos;
                }
                if (proxPos < Constantes.POS_CAMBIO_AREA)
                {
                    return proxPos;
                }
                else
                {
                    idArea = (idArea + 1) % 4;
                    return proxPos;
                }
            }
            return proxPos;
        }

        public void MoverFicha(Ficha ficha)
        {
            int proxIdArea;
            int proxPosArea = CalcularProxMovimiento(ficha, NumeroSacado, out proxIdArea);
            if (PuedeComer(ficha, NumeroSacado) == true)
            {
                ficha.IdArea = proxIdArea;
                ficha.PosArea = proxPosArea;
            }
        }

        public bool PuedeComer(Ficha ficha, int numeroSacado)
        {
            int idArea;
            int proxMovimiento = CalcularProxMovimiento(ficha, numeroSacado, out idArea);
            Ficha fichaDestino = this.tablero.AreasTablero[idArea].ArrayFichas[proxMovimiento];

            return (fichaDestino == null) ? false : true;
        }
    }
}
