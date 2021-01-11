
using System;

namespace Clase
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Rut { get; set; }
        public string ObtenerNombreCompleto()
        {
            return string.Concat(this.Nombre, " ",this.Apellido);
        }
        public abstract void ImprimirDatos();

        public abstract void AgregarPersona(Persona persona, out int personaId);


    }
}
