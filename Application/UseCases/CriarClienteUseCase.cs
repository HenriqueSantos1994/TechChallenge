using Application.Models.Request;
using Application.UseCases.Interfaces;
using Domain.Entities;
using Domain.Repositories;

namespace Application.UseCases
{
    public class CriarClienteUseCase : ICriarClienteUseCase
    {
        private readonly IClienteRepository _clienteRepository;

        public CriarClienteUseCase(
            IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<bool> Execute(CriarClienteRequest request)
        {
            var cliente = new Cliente()
            {
                CPF = request.CPF,
                Nome = request.Nome,
                Email = request.Email
            };
            await _clienteRepository.Post(cliente);

            return true;
        }
    }
}
