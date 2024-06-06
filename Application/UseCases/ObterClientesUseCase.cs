using Application.Models.Response;
using Application.UseCases.Interfaces;
using AutoMapper;
using Domain.Repositories;

namespace Application.UseCases
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