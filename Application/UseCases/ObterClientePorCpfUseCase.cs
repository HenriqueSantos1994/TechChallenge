using Application.Models.Response;
using Application.UseCases.Interfaces;
using AutoMapper;
using Domain.Repositories;

namespace Application.UseCases
{
    public class ObterClientePorCpfUseCase : IObterClientePorCpfUseCase
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ObterClientePorCpfUseCase(
            IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<ClienteResponse> Execute(string cpf)
        {
            var result = await _clienteRepository.GetByCpf(cpf);

            return _mapper.Map<ClienteResponse>(result);
        }
    }
}