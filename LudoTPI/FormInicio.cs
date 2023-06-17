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
    public partial class FormInicio : Form
    {
        private FormJuego FormJuegoInstance;
        public FormInicio()
        {
            InitializeComponent();
        }

        private void b_Jugar_Click(object sender, EventArgs e)
        {
            this.FormJuegoInstance = FormJuego.GetInstance();
            this.FormJuegoInstance.Show();
        }
    }
}
