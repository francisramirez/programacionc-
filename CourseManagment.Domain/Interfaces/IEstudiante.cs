using CourseManagment.Domain.Entities;

namespace CourseManagment.Domain.Interfaces
{
    public interface IEstudiante : IBusquedaDepartamentoCarrera<Estudiante>
    {
        Estudiante ObtenerEstudiantePorMatricula(string matricula);
    }
}
