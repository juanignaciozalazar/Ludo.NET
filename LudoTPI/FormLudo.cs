using LudoTPI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LudoTPI
{

    public partial class FormLudo : Form
    {
        private Juego juego;
        private int cantJugadores;
        private EstadoJuego estadoJuego;
        private PictureBox ultPictureBox;
        public FormLudo(int cantJugadores)
        {
            InitializeComponent();
            this.cantJugadores = cantJugadores;
            this.juego = new Juego(estadoJuego, cantJugadores) ;
            this.estadoJuego = new EstadoJuego();
            iniciarContenedoresJugadores();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb_sender = sender as PictureBox;
            if (pb_sender == null)
                return;

            eliminarFichaFantasma(ultPictureBox);
            ultPictureBox = pb_sender;

            if (pb_sender.Image != null)
            {
                seleccionarFicha(pb_sender);
            } else
            {
                return;
            }
        }

        private void seleccionarFicha(PictureBox pb_sender)
        {
            if (estadoJuego.EstadoActual == Constantes.ESTADO_JUEGAFICHA)
            {
                string tipoPB = nameof(pb_sender).Split('_')[1];

                if (tipoPB.Length > 1 && tipoPB[0] == juego.GetColorJugadorActual() && tipoPB[1] == 'C' )
                {
                    string pb_fantasma_name = "pb_" + tipoPB[0] + "_" + Constantes.POS_INICIO;
                    int idJugador = tipoPB[0];
                    crearFichaFantasma(idJugador, pb_fantasma_name);
                }

            }
        }

        private void crearFichaFantasma(int idJugador, string pb_name)
        {
            PictureBox pb = (PictureBox) this.GetType().GetProperty(pb_name).GetValue(this,null);
            string pb_color = Enum.GetName(typeof(Color), idJugador);
            string image_name = $"Resources.Ficha_{pb_color}F";
            pb.Image = (Image) this.GetType().GetProperty(image_name).GetValue(this);
        }

        private void crearFichaFantasma(PictureBox pb)
        {
            string areaName = getAreaName(pb);
        }

        private void eliminarFichaFantasma(PictureBox pb)
        {
            if (nameof(pb.Image).Split('_')[0] == "FichaFantasma")
            {
                pb.Image = null;
            }
        }

        private PictureBox getProxMovimiento(PictureBox pb_sender)
        {
            int idArea = getAreaId(pb_sender);
            int pos = getPos(pb_sender);
            int proxIdArea = -1;
            Ficha ficha = this.juego.GetFicha(idArea, pos);
            int proxPos = this.juego.CalcularProxMovimiento(ficha, out proxIdArea);
            string string_proxMov = "pb_" + getAreaName(pb_sender) + "_" + getPos(pb_sender);

            PictureBox proxMov = (PictureBox) this.GetType().GetProperty(string_proxMov).GetValue(this, null);

            return proxMov;

        }

        private string getAreaName(PictureBox pb)
        {
            string string_area = nameof(pb).Split('_')[2];
            return string_area;
        }

        private int getAreaId(PictureBox pb) 
        {
            string string_area = nameof(pb).Split('_')[1];
            int idArea = (int)Enum.Parse(typeof(ColorById), string_area);
            return idArea;
        }

        private int getPos(PictureBox pb)
        {
            string string_pos = nameof(pb).Split('_')[2];
            int pos = Convert.ToInt32(string_pos);
            return pos;
        }

        private void button_SacaDado_Click(object sender, EventArgs e)
        {
            if (estadoJuego.EstadoActual == Constantes.ESTADO_SACADADO)
            {
                this.juego.TirarDado();
                this.pb_Dado.BackgroundImage = (Image) Resources.ResourceManager.GetObject("Dado_" + this.juego.NumeroSacado);
                this.estadoJuego.EstadoActual = Constantes.ESTADO_JUEGAFICHA;
            }
        }

        private void iniciarContenedoresJugadores()
        {
            string[] colores = { "G", "R", "B", "Y" };
            foreach(string color in colores)
            {
                for (int i = 0; i < 4; i++)
                {
                    string pb_name = $"pb_{color}_{i}";
                    PictureBox pb = (PictureBox) this.GetType().GetProperty(pb_name).GetValue(this);
                    pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"Ficha_{color}");
                }
            }
            
        }

        private void pb_SacarFicha(object sender, EventArgs e)
        {
            if ( puedeSacarFicha() )
            {
                PictureBox pb_sender = (PictureBox) sender;
                string colorJugador = nameof(pb_sender).Split('_')[1];
                int idJugador = Convert.ToInt32( Enum.Parse(typeof(ColorById), colorJugador ));
                string pb_fantasma_name = $"pb_{colorJugador}_{Constantes.POS_INICIO}";

                crearFichaFantasma(idJugador, pb_fantasma_name);
            }
        }

        private bool puedeSacarFicha()
        {
            if (
                estadoJuego.EstadoActual == Constantes.ESTADO_JUEGAFICHA
                && (juego.NumeroSacado == 1 || juego.NumeroSacado == 6)
            )
            {
                return true;
            } else
            {
                return false;
            }
        }

        private bool puedeJugarFicha()
        {
            return false;
        }
    }
}
