using Domain.Entities;

namespace Domain.Repositories
{
    public interface IClienteRepository
    {
        Task<IList<Cliente>> GetAll();
        Task<Cliente> GetByCpf(string cpf);
        Task<Cliente> GetById(int id);
        Task<int> Post(Cliente cliente);
    }
}
