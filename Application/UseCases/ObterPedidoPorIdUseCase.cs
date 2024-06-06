using Application.Models.Response;
using Application.UseCases.Interfaces;
using AutoMapper;
using Domain.Repositories;

namespace Application.UseCases
{
    public class ObterPedidoPorIdUseCase : IObterPedidoPorIdUseCase
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;

        public ObterPedidoPorIdUseCase(
            IPedidoRepository pedidoRepository,
            IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;
            _mapper = mapper;
    }

        public async Task<PedidoResponse> Execute(int Id)
        {
            var result = await _pedidoRepository.GetById(Id);

            return  _mapper.Map<PedidoResponse>(result);
        }
    }
}