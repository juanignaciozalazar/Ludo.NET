using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudoTPI
{
    // PATRON SINGLETON
    public partial class FormJuego : Form
    {
        private static FormJuego _instance;
        private FormJuego()
        {
            InitializeComponent();
            
            this.panel1.BackgroundImage = Properties.Resources.LudoBackgroundImage;
            this.panel1.BackgroundImageLayout = ImageLayout.Stretch;
            this.Show();

        }

        public static FormJuego GetInstance()
        {
            if (_instance == null )
            {
                _instance = new FormJuego();
            }
            return _instance;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
