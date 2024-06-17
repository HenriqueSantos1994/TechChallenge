using FIAP.TechChallenge.ByteMeBurguer.Domain.Entities;

namespace FIAP.TechChallenge.ByteMeBurguer.Domain.Repositories
{
    public interface IFormaPagamentoRepository
    {
        Task<IList<FormaPagamento>> GetAll();
        Task<FormaPagamento> GetById(int id);
    }
}
