using Domain.Entities;

namespace Domain.Repositories
{
    public interface IProdutoRepository
    {
        Task<Produto> GetById(int Id);
        Task Delete(Produto produto);
        Task<Produto> Post(Produto produto);
        Task<Produto> Update(Produto produto);
        Task<IList<Produto>> GetAll();
        Task<IList<Produto>> GetByCategoria(int IdCategoria);
    }
}
