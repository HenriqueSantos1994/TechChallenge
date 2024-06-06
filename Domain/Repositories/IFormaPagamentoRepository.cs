using Domain.Entities;

namespace Domain.Repositories
{
    public interface IFormaPagamentoRepository
    {
        Task<IList<FormaPagamento>> GetAll();
        Task<FormaPagamento> GetById(int id);
    }
}
