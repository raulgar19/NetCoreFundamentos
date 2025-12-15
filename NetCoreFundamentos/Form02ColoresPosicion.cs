using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnCambiarPosicion_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.txtX.Text);
            int y = int.Parse(this.txtY.Text);

            this.btnCambiarPosicion.Location = new Point(x, y);
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);

            if((rojo>= 0 && rojo <= 255) && (azul >= 0 && azul <= 255) && (verde >= 0 && verde <= 255))
            {
                this.BackColor = Color.FromArgb(rojo, verde, azul);
            }
            else
            {
                MessageBox.Show("Valores incorrectos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
