using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace ProyectoClases
{
    public enum TipoGenero {Masculino = 0, Femenino = 1}
    public enum Paises { España, Francia, Alemania, Andorra, Colombia }
    
    public class Persona
    {
        #region Propiedades
        private string _DescripcionThis;

        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set
            {
                Random random = new Random();
                int dato = random.Next(1, 20);
                this._DescripcionThis = "Descripción " + dato;
            }
        }

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        public TipoGenero _Genero;
        public TipoGenero Genero {
            get { 
                return this._Genero;
            } 
            set {
                if (value != TipoGenero.Femenino && value != TipoGenero.Masculino) 
                {
                    throw new Exception("Error");
                }
                else
                {
                    this._Genero = value;
                }
            } }
        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellidos {  get; set; }
        private int _Edad;
        public int Edad {
            get
            {
                return this._Edad;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }
        #endregion
        #region Constructores
        public Persona()
        {
            Debug.WriteLine("Constructor PERSONA vacío");
        }

        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor PERSONA con dos parámetros");
        }
        #endregion
        #region Metodos
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(bool orden)
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(int num1)
        {
            return this.Apellidos + " " + this.Nombre;
        }

        public string GetNombreCompleto(int num1, int num2)
        {
            return (this.Nombre + " " + this.Apellidos).ToUpper();
        }

        public string GetNombreCompleto(string dato)
        {
            return this.GetNombreCompleto().ToLower();
        }
        #endregion
    }
}