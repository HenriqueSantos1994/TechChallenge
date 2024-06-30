using FIAP.TechChallenge.ByteMeBurguer.Domain.Entities;
using FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Enum;

namespace FIAP.TechChallenge.ByteMeBurguer.Domain.Repositories
{
    public interface IPedidoRepository
    {
        Task<int> Post(Pedido pedido);
        Task Update(Pedido pedido, int Id);
        Pedido GetById(int Id);
        IList<Pedido> GetAll();
        IList<Pedido> GetByStatus(StatusPedidoEnum status);
    }
}
