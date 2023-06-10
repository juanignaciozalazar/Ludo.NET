using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoTPI
{
    internal class Casillero
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int IdArea { get; set; }

        public Casillero() 
        {
            PosX = -1;
            PosX = -1;
            IdArea = -1;
        }

        public Casillero(int posX, int posY, int idArea)
        {
            PosX = posX;
            PosY = posY;
            IdArea = idArea;
        }
    }
}
