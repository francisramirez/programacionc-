using System.Collections.Generic;
using System;
using CourseManagment.Domain.Exceptions;

namespace CourseManagment.Domain.Entities
{
    public class Estudiante : Persona
    {
        private List<Estudiante> estudiantes;
        public Estudiante()
        {
            this.estudiantes = new List<Estudiante>();
        }

        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public string Departamento { get; set; }

        public void AgregarEstudiante(Estudiante estudiante)
        {
           
            try
            {
                this.estudiantes.Add(estudiante);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarEstudiante(string matricula) 
        {
            var estudiante = this.estudiantes.Find(est => est.Matricula == matricula);
            this.estudiantes.Remove(estudiante);
        }

        public Estudiante ObtenerEstudiante(string matricula) 
        {
            return this.estudiantes.Find(est => est.Matricula == matricula);
        }
        public List<Estudiante> ObtenerEstudiantes(string depto)
        {
            return this.estudiantes.FindAll(est => est.Departamento == depto);
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            return this.estudiantes;
        }
    }
}
