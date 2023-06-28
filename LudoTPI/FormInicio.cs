using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudoTPI
{
    public partial class FormInicio : Form
    {
        private FormLudo _form_ludo;


        public FormInicio()
        {
            InitializeComponent();
            comboBox1.Text = "2";
        }

        private void b_Jugar_Click(object sender, EventArgs e)
        {
            //this.FormJuegoInstance = FormJuego.GetInstance();
            //this.FormJuegoInstance.Show();
            _form_ludo = new FormLudo(getCantidadJugadores());
            _form_ludo.Show();
        }

        private int getCantidadJugadores()
        {
            return Convert.ToInt32(comboBox1.GetItemText(this.comboBox1.SelectedItem));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
