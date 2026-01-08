using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Reyes";
            persona.Edad = 25;

            persona[0] = "Vamos 1";
            persona[1] = "Vamos 2";
            persona.Genero = TipoGenero.Femenino;

            this.lstClases.Items.Add("Genero: " + persona.Genero);
            persona.Nacionalidad = Paises.Andorra;

            this.lstClases.Items.Add("Nombre: " + persona.Nombre
                + ", Apellidos: " + persona.Apellidos
                + ", Edad: " + persona.Edad);

            this.lstClases.Items.Add(
                persona.GetNombreCompleto(true)
                );

            persona.Domicilio = new Direccion("Avenida Enero", "Madrid");
            persona.Domicilio.CodigoPostal = 28003;
            this.lstClases.Items.Add("Direccion: "
                + persona.Domicilio.Calle + ", "
                + persona.Domicilio.Ciudad + ", "
                + persona.Domicilio.CodigoPostal);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            //Empleado emp = new Empleado("Nombre", "Apellidos");
            Empleado emp = new Empleado();

            emp.Nombre = "Becario";
            emp.Apellidos = "Bacario";
            this.lstClases.Items.Add("Vacas Empelado: " + emp.GetDiasVacaciones());
            this.lstClases.Items.Add("Empleado: " + emp.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + emp.GetSalarioMinimo() + "€");

            Director director = new Director();

            director.Nombre = "Director";
            director.Apellidos = "Director";
            this.lstClases.Items.Add("Vacas Director: " + director.GetDiasVacaciones());
            this.lstClases.Items.Add("Director: " + director.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + director.GetSalarioMinimo() + "€");
        }
    }
}