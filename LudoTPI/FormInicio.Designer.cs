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
            this.SuspendLayout();
            // 
            // b_Jugar
            // 
            this.b_Jugar.Location = new System.Drawing.Point(434, 286);
            this.b_Jugar.Name = "b_Jugar";
            this.b_Jugar.Size = new System.Drawing.Size(170, 117);
            this.b_Jugar.TabIndex = 0;
            this.b_Jugar.Text = "Jugar!";
            this.b_Jugar.UseVisualStyleBackColor = true;
            this.b_Jugar.Click += new System.EventHandler(this.b_Jugar_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.b_Jugar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Jugar;
    }
}

