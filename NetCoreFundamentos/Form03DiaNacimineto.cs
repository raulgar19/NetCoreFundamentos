using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimineto : Form
    {
        public Form03DiaNacimineto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int ano = int.Parse(txtAno.Text);

            if (mes == 1)
            {
                mes = 13;
                ano-= 1;
            }else if (mes == 2)
            {
                mes = 14;
                ano-= 1;
            }

            int op1 = ((mes + 1) * 3) / 5;
            int op2 = ano / 4;
            int op3 = ano / 100;
            int op4 = ano / 400;
            int op5 = dia + (mes * 2) + ano + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int resultado = op5 - (op6 * 7);

            string diaSemana = "";

            if (resultado == 0)
            {
                diaSemana = "Sábado";
            } 
            else if (resultado == 1)
            {
                diaSemana = "Domingo";
            } 
            else if (resultado == 2)
            {
                diaSemana = "Lunes";
            } 
            else if (resultado == 3)
            {
                diaSemana = "Martes";
            } 
            else if (resultado == 4)
            {
                diaSemana = "Miércoles";
            } 
            else if (resultado == 5)
            {
                diaSemana = "Viernes";
            }
            else
            {
                diaSemana = "Error Lógico";
            }
            
            lblMostrar.Text = "El día de la semana es " + diaSemana;
        }
    }
}