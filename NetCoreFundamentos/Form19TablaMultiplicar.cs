using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<Button> botones;
        List<TextBox> textBoxs;

        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.textBoxs = new List<TextBox>();

            foreach (Control control in this.Controls)
            {
                if(control is Button)
                {
                    this.botones.Add((Button)control);
                    control.Click += Multiplicar;
                }
                if (control is TextBox)
                {
                    this.textBoxs.Add((TextBox)control);
                }
            }
        }

        private void Multiplicar(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            int contador = 1;

            for (int i = textBoxs.Count - 1; i >= 0; i--)
            {
                int resultado = numero * contador;
                textBoxs[i].Text = resultado.ToString();
                contador++;
            }
        }
    }
}
