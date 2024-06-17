using AutoMapper;
using FIAP.TechChallenge.ByteMeBurguer.Application.Models.Response;
using FIAP.TechChallenge.ByteMeBurguer.Application.UseCases.Interfaces;
using FIAP.TechChallenge.ByteMeBurguer.Domain.Repositories;

namespace FIAP.TechChallenge.ByteMeBurguer.Application.UseCases
{
    public class ObterClientesUseCase : IObterClientesUseCase
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ObterClientesUseCase(
            IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<IList<ClienteResponse>> Execute()
        {
            var result = await _clienteRepository.GetAll();

            return _mapper.Map<IList<ClienteResponse>>(result);
        }
    }
}