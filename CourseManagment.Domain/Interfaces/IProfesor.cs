using System.Collections.Generic;
using CourseManagment.Domain.Entities;
namespace CourseManagment.Domain.Interfaces
{
    public interface IProfesor : IBusquedaDepartamentoCarrera<Profesor>
    {
        Profesor ObtenerProfesorPorCodigo(string codigo);
      
    }
}
