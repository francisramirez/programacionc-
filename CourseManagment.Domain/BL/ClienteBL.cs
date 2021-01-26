
using CourseManagment.Domain.Entities;
using CourseManagment.Domain.Interfaces;
using System.Linq;
namespace CourseManagment.Domain.BL
{
    public class ClienteBL : BaseBL<Cliente>, ICliente
    {
        public Cliente ObtenerClientePorCuenta(string cuenta)
        {
            return base.Entities.SingleOrDefault(cliente => cliente.Cuenta == cuenta);
        }
        public Cliente ObtenerEntity(int Id)
        {
            return base.Entities.Find(cliente => cliente.ClienteId == Id);
        }
        public override void Guardar(Cliente entity)
        {
            entity.ClienteId = base.Entities.Count == 0 ? 1 : base.Entities.Max(cliente => cliente.ClienteId) + 1;
            base.Guardar(entity);
        }
       
    }
}
