using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudoTPI
{
    public partial class FormNombres : Form
    {
        private int cantBots = 0;
        public FormNombres()
        {
            InitializeComponent();
        }

        private void button_J_Click(object sender, EventArgs e)
        {
            Button b_sender = sender as Button;
            string sender_name = b_sender.Name;
            string sender_row = "";
            try
            {
                sender_row = sender_name.Split('_')[1].Split('J')[1];
            } catch (FormatException fe)
            {
                Debug.WriteLine("Ocurrió un error");
                Debug.WriteLine(fe.StackTrace);
            }

            TextBox tb = (TextBox)this.GetType().GetProperty("textBox_J" + sender_row).GetValue(this, null);

            if (tb.ReadOnly == true)
            {
                tb.ReadOnly = false;
                this.cantBots--;
            } else
            {
                tb.ReadOnly = true;
                this.cantBots++;
            }
            tb.Text = "Bot " + sender_row;

        }
    }
}
