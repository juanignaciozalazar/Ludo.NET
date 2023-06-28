namespace LudoTPI
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_Jugar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.l_cantJugadores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_Jugar
            // 
            this.b_Jugar.Location = new System.Drawing.Point(326, 232);
            this.b_Jugar.Margin = new System.Windows.Forms.Padding(2);
            this.b_Jugar.Name = "b_Jugar";
            this.b_Jugar.Size = new System.Drawing.Size(128, 95);
            this.b_Jugar.TabIndex = 0;
            this.b_Jugar.Text = "Jugar!";
            this.b_Jugar.UseVisualStyleBackColor = true;
            this.b_Jugar.Click += new System.EventHandler(this.b_Jugar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(326, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // l_cantJugadores
            // 
            this.l_cantJugadores.AutoSize = true;
            this.l_cantJugadores.Location = new System.Drawing.Point(351, 133);
            this.l_cantJugadores.Name = "l_cantJugadores";
            this.l_cantJugadores.Size = new System.Drawing.Size(83, 13);
            this.l_cantJugadores.TabIndex = 2;
            this.l_cantJugadores.Text = "N° de jugadores";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_cantJugadores);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.b_Jugar);
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Jugar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label l_cantJugadores;
    }
}

