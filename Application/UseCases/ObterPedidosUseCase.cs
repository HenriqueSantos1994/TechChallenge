using Application.Models.Response;
using Application.UseCases.Interfaces;
using AutoMapper;
using Domain.Repositories;

namespace Application.UseCases
{
    public class ObterPedidosUseCase : IObterPedidosUseCase
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;

        public ObterPedidosUseCase(
            IPedidoRepository pedidoRepository, IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;
            _mapper = mapper;
        }

        public async Task<IList<PedidoResponse>> Execute()
        {
            var result = await _pedidoRepository.GetAll();

            return _mapper.Map<IList<PedidoResponse>>(result);
        }
    }
}