using FIAP.TechChallenge.ByteMeBurguer.Domain.Entities;
using FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Enum;

namespace FIAP.TechChallenge.ByteMeBurguer.Domain.Repositories
{
    public interface IPedidoRepository
    {
        Task<int> Post(Pedido pedido);
        Task Update(Pedido pedido, int Id);
        Task<Pedido> GetById(int Id);
        Task<IList<Pedido>> GetAll();
        Task<IList<Pedido>> GetByStatus(StatusPedidoEnum status);
    }
}
