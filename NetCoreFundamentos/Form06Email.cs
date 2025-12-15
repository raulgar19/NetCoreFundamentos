using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            // Verificar que exista @
            if (!email.Contains("@"))
            {
                lblResultado.Text = "El email debe contener @";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            // Verificar que @ no esté al inicio ni al final
            if (email.StartsWith("@") || email.EndsWith("@"))
            {
                lblResultado.Text = "El email no puede comenzar ni terminar con @";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            // Verificar que no exista más de una @
            int contadorArroba = 0;
            int posicionArroba = -1;
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@')
                {
                    contadorArroba++;
                    posicionArroba = i;
                }
            }

            if (contadorArroba != 1)
            {
                lblResultado.Text = "El email debe contener exactamente una @";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            // Verificar que existe un punto
            if (!email.Contains("."))
            {
                lblResultado.Text = "El email debe contener un punto";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            // Verificar que existe un punto después de la @
            string partePostArroba = email.Substring(posicionArroba + 1);
            if (!partePostArroba.Contains("."))
            {
                lblResultado.Text = "Debe existir un punto después de la @";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            // Verificar que el dominio tenga de 2 a 3 caracteres
            int ultimoPunto = email.LastIndexOf(".");
            string dominio = email.Substring(ultimoPunto + 1);

            if (dominio.Length < 2 || dominio.Length > 3)
            {
                lblResultado.Text = "El dominio debe tener entre 2 y 3 caracteres";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            lblResultado.Text = "El email es válido";
            lblResultado.ForeColor = Color.Green;
        }
    }
}
