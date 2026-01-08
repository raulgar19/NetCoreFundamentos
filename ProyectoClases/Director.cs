using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director()
        {
            this.SalarioMinimo += 200;
            Debug.WriteLine("Constructor DIRECTOR");
        }

        public override int GetDiasVacaciones()
        {
            Debug.WriteLine("GetDiasVacaciones() DIRECTOR");
            return 30;
        }
    }
}