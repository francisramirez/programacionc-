using CourseManagment.Domain.Interfaces;
using CourseManagment.Domain.Entities;
using System.Collections.Generic;

namespace CourseManagment.Domain.BL
{
    public class ProfesorBL : IBaseEntity<Profesor>, IProfesor
    {
        private List<Profesor> profesors;
        public ProfesorBL()
        {
            this.profesors = new List<Profesor>();
        }
        public void Actualizar(Profesor entity)
        {
            throw new System.NotImplementedException();
        }

        public void Eliminar(Profesor entity)
        {
            var profesor = this.ObtenerEntity(entity.ProfesorId);
            this.profesors.Remove(profesor);
        }

        public void Guardar(Profesor entity)
        {
            this.profesors.Add(entity);
        }

        public Profesor ObtenerEntity(int Id)
        {
            return this.profesors.Find(profesor => profesor.ProfesorId == Id);
        }

        public List<Profesor> ObtenerProfesoresPorDepartamento(string departamento)
        {
            return this.profesors.FindAll(profesor => profesor.Departamento == departamento);
        }

        public Profesor ObtenerProfesorPorCodigo(string codigo)
        {
            return this.profesors.Find(profesor => profesor.Codigo == codigo);
        }

        public List<Profesor> ObtenerProforesPorCarrera(string carrera)
        {
            return this.profesors.FindAll(profesor => profesor.Carrera == carrera);
        }

        public List<Profesor> ObtenerRegistros()
        {
            return this.profesors;
        }
    }
}
