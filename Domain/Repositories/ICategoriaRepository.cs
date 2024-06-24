using FIAP.TechChallenge.ByteMeBurguer.Domain.Entities;

namespace FIAP.TechChallenge.ByteMeBurguer.Domain.Repositories
{
    public interface ICategoriaRepository
    {
        Task<IList<Categoria>> GetAll();
        Task<Categoria> GetByName(string nome);
    }
}
