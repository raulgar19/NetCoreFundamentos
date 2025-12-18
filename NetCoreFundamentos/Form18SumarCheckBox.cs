using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form18SumarCheckBox : Form
    {
        List<CheckBox> checkboxs;

        public Form18SumarCheckBox()
        {
            InitializeComponent();
            this.checkboxs = new List<CheckBox>();

            foreach (Control control in this.panel1.Controls)
            {
                if (control is CheckBox check)
                {
                    this.checkboxs.Add(check);
                    check.CheckedChanged += SumarNumeros;
                }
            }
        }

        private void SumarNumeros(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            
            if (check.Checked)
            {
                this.Sumar(check);
            }
            else
            {
                this.Restar(check);
            }
        }

        private void Sumar(CheckBox checkBox)
        {
            int num = int.Parse(checkBox.Text);
            int suma = int.Parse(this.txtSuma.Text);
            suma += num;
            this.txtSuma.Text = suma.ToString();
        }

        private void Restar(CheckBox checkBox)
        {
            int num = int.Parse(checkBox.Text);
            int suma = int.Parse(this.txtSuma.Text);
            suma -= num;
            this.txtSuma.Text = suma.ToString();
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            foreach (CheckBox check in this.checkboxs)
            {
                int alert = random.Next(1, 50);
                check.Text = alert.ToString();
                check.Checked = false;
            }
        }
    }
}
