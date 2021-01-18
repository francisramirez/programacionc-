using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Interfaces
{
    public interface IBaseEntity<TEntity> where TEntity : class
    {
        void Guardar(TEntity entity);
        void Actualizar(TEntity entity);
        void Eliminar(TEntity entity);
        TEntity ObtenerEntity(int Id);
        List<TEntity> ObtenerRegistros();

    }
}
