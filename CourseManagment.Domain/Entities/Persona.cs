using System;
using CourseManagment.Domain.Exceptions;

namespace CourseManagment.Domain.Entities
{
    public abstract class Persona  
    {
        private string _nombre;

        public string Nombre 
        {
            get { return this._nombre; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new PersonaException("el nombre es requerido.");

                if (value.Length > 50)
                    throw new PersonaException("el nombre no debe ser mayor a 50 caracteres...");

                this._nombre = value;

            }
        }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Rut { get; set; }
    }
}
