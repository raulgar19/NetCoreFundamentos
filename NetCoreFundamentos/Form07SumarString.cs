using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form07SumarString : Form
    {
        public Form07SumarString()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtNumeros.Text;
            int suma = 0;

            for (int i = 0; i < textoNumeros.Length; i++)
            {
                char caracter = textoNumeros[i];

                int numero = Convert.ToInt32(caracter.ToString());

                suma += numero;
            }

            this.lblResultado.Text = "La suma de " + textoNumeros + " es " + suma;
        }
    }
}
