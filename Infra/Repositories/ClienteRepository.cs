using Domain.Entities;
using Domain.Repositories;
using Infra.Configurations;

namespace Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Cliente>> GetAll()
        {
            try
            {
                return _context.Clientes.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao consultar clientes. {ex}");
            }
        }

        public async Task<Cliente> GetByCpf(string cpf)
        {
            try
            {
                return _context.Clientes.FirstOrDefault(x => x.CPF == cpf);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao consultar cliente. {ex}");
            }
        }

        public async Task<Cliente> GetById(int id)
        {
            try
            {
                return _context.Clientes.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao consultar cliente. {ex}");
            }
        }

        public async Task<int> Post(Cliente cliente)
        {
            try
            {
                _context.Clientes.Add(cliente);
                await _context.SaveChangesAsync();
                return 123;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao cadastrar cliente. {ex}");
            }
        }
    }
}
