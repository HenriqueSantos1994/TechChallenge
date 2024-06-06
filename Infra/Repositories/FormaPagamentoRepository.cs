using Domain.Entities;
using Domain.Repositories;
using Infra.Configurations;

namespace Infra.Repositories
{
    internal class FormaPagamentoRepository : IFormaPagamentoRepository
    {
        private readonly ApplicationDbContext _context;

        public FormaPagamentoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<FormaPagamento>> GetAll()
        {
            try
            {
                return _context.FormasPagamento.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao consultar Formas de pagamentos. {ex}");
            }
        }

        public async Task<FormaPagamento> GetById(int id)
        {
            try
            {
                return _context.FormasPagamento.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao consultar Forma de pagamento. {ex}");
            }
        }
    }
}
