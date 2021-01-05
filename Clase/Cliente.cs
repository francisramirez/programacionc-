

using System;

namespace Clase
{
    public class Cliente : Persona
    {
        public string Cuenta { get; set; }
        public override void ImprimirDatos()
        {
            Console.WriteLine("----Datos del Cliente----");

            Console.WriteLine($"Nombre: {this.ObtenerNombreCompleto()}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Sueldo: {Cuenta}");

            Console.WriteLine("----------------------------");
        }
    }
}
