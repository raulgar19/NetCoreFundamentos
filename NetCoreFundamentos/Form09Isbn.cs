using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = textBox1.Text;

            // Calcular la suma de las multiplicaciones
            int suma = 0;
            for (int i = 0; i < isbn.Length; i++)
            {
                int digito = int.Parse(isbn[i].ToString());
                int posicion = i + 1;
                suma += digito * posicion;
            }

            // Verificar si el resto de dividir entre 11 es 0
            if (suma % 11 == 0)
            {
                lblResultado.Text = "El ISBN es válido";
                lblResultado.ForeColor = Color.Green;
            }
            else
            {
                lblResultado.Text = "El ISBN no es válido";
                lblResultado.ForeColor = Color.Red;
            }
        }
    }
}
