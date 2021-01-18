using System.Collections.Generic;
using CourseManagment.Domain.Entities;
namespace CourseManagment.Domain.Interfaces
{
    public interface IProfesor
    {
        Profesor ObtenerProfesorPorCodigo(string codigo);
        List<Profesor> ObtenerProfesoresPorDepartamento(string departamento);
        List<Profesor> ObtenerProforesPorCarrera(string carrera);
    }
}
