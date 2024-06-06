using Domain.Entities;
using Domain.Repositories;
using Infra.Configurations;

namespace Infra.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoriaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IList<Categoria>> GetAll()
        {
            try
            {
                return _context.Categorias.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao consultar categorias. {ex}");
            }
        }

        public async Task<Categoria> GetByName(string nome)
        {
            try
            {
                return _context.Categorias.First(x => x.Nome == nome);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao consultar categoria. {ex}");
            }
        }
    }
}
