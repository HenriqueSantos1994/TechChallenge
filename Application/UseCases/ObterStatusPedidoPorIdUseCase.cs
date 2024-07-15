using AutoMapper;
using FIAP.TechChallenge.ByteMeBurguer.Application.Models.Response;
using FIAP.TechChallenge.ByteMeBurguer.Application.UseCases.Interfaces;
using FIAP.TechChallenge.ByteMeBurguer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.TechChallenge.ByteMeBurguer.Application.UseCases
{
    public class ObterStatusPedidoPorIdUseCase : IObterStatusPedidoPorIdUseCase
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;

        public ObterStatusPedidoPorIdUseCase(
            IPedidoRepository pedidoRepository, IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;
            _mapper = mapper;
        }

        public StatusPedidoResponse Execute(int id)
        {
            var result = _pedidoRepository.GetById(id);

            return _mapper.Map<StatusPedidoResponse>(result);
        }
    }
}
