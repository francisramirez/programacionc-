using System.Collections.Generic;
using CourseManagment.Domain.Entities;

namespace CourseManagment.Domain.BL
{
    public class BaseBL<TEntity>  where TEntity : class
    {
        private List<TEntity> entities;

        public BaseBL()
        {
            this.entities = new List<TEntity>();
        }

        public List<TEntity> Entities { get { return this.entities; } }

        public virtual void Guardar(TEntity entity) 
        {
            this.entities.Add(entity);
        }
        public virtual void Eliminar(TEntity entity) 
        {
            this.entities.Remove(entity);
        }
        public virtual List<TEntity> ObtenerRegistros() 
        {
            return this.entities;
        }
    }
}
