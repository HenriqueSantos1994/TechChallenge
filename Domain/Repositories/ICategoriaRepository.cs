using Domain.Entities;

namespace Domain.Repositories
{
    public interface ICategoriaRepository
    {
        Task<IList<Categoria>> GetAll();
        Task<Categoria> GetByName(string nome);
    }
}
