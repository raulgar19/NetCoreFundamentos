using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases
{
    public interface IFactura
    {
        int PrecioBase { get; set; }
        int PrecioTotal { get; set; }
        void CalcularIVA();
        void OdioHacienda(int mucho);
    }
}