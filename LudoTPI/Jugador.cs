using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoTPI
{
    internal class Jugador
    {
        public int ID { get; set; }
        public ContenedorFichas contenedorFichas { get; set; }   
        public Jugador(int ID)
        {
            this.ID = ID;
            this.contenedorFichas = CrearContenedorFichas();
        }

        private ContenedorFichas CrearContenedorFichas()
        {
            return new ContenedorFichas(4, this.ID);
        }
    }
}
