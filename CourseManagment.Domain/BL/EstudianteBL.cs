using CourseManagment.Domain.Entities;
using CourseManagment.Domain.Interfaces;
using System.Collections.Generic;

namespace CourseManagment.Domain.BL
{
    public class EstudianteBL : IBaseEntity<Estudiante>, IEstudiante
    {
        public void Actualizar(Estudiante entity)
        {
            throw new System.NotImplementedException();
        }

        public void Eliminar(Estudiante entity)
        {
            throw new System.NotImplementedException();
        }

        public void Guardar(Estudiante entity)
        {
            throw new System.NotImplementedException();
        }

        public Estudiante ObtenerEntity(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Estudiante ObtenerEstudiantePorMatricula(string matricula)
        {
            throw new System.NotImplementedException();
        }

        public List<Estudiante> ObtenerProfesoresPorDepartamento(string departamento)
        {
            throw new System.NotImplementedException();
        }

        public List<Estudiante> ObtenerProforesPorCarrera(string carrera)
        {
            throw new System.NotImplementedException();
        }

        public List<Estudiante> ObtenerRegistros()
        {
            throw new System.NotImplementedException();
        }
    }
}
