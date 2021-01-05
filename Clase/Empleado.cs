
using System;

namespace Clase
{
    public class Empleado : Persona
    {
        public decimal Sueldo { get; set; }

        public override void ImprimirDatos()
        {
            Console.WriteLine("----Datos del Empleado----");

            Console.WriteLine($"Nombre: {this.ObtenerNombreCompleto()}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Sueldo: {Sueldo}");
          
            Console.WriteLine("----------------------------");
        }
    }
}
