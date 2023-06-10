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
        Rojo,
        Verde,
        Azul,
        Amarillo
    }
    internal class Tablero
    {
        AreaTablero[] areasTablero = new AreaTablero[4];      //Contiene las 4 areas del tablero
        private int numeroSacado;
        public void MoverFicha(Ficha ficha)
        {
            int proxIdArea;
            int proxPosArea = CalcularProxMovimiento(ficha, numeroSacado, out proxIdArea);
            if (PuedeComer(ficha, numeroSacado) == true)
            {
                ficha.IdArea = proxIdArea;
                ficha.PosArea = proxPosArea;
            }
        }

        public bool PuedeComer(Ficha ficha, int numeroSacado)
        {
            int idArea;
            int proxMovimiento = CalcularProxMovimiento(ficha, numeroSacado, out idArea);
            Ficha fichaDestino = areasTablero[idArea].ArrayFichas[proxMovimiento];

            return (fichaDestino == null) ? false : true;
        }

        private int CalcularProxMovimiento(Ficha ficha, int numeroSacado,out int idArea)
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
                } else
                {
                    idArea = (idArea + 1) % 4;
                    return proxPos;
                }      
            }
            return proxPos;

        }

    }
}
