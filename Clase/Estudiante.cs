﻿

using System;

namespace Clase
{
    public class Estudiante : Persona
    {
        public string Carrera { get; set; }
        public string Matricula { get; set; }

        public override void ImprimirDatos()
        {
            Console.WriteLine("----Datos del Estudiante----");

            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Nombre: {this.ObtenerNombreCompleto()}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Carrera: {Carrera}");
        

            Console.WriteLine("----------------------------");
        }

    }
}