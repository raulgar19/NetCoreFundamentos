using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                int num = random.Next(1, 100);
                lstNumeros.Items.Add(num);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int sumaPares = 0;
            int sumaImpares = 0;
            int sumaTotal = 0;

            foreach (object item in lstNumeros.Items)
            {
                int num = int.Parse(item.ToString());
                sumaTotal += num;

                if (num % 2 == 0)
                {
                    sumaPares += num;
                }
                else
                {
                    sumaImpares += num;
                }
            }

            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();
            this.txtSuma.Text = sumaTotal.ToString();
        }
    }
}
