using FIAP.TechChallenge.ByteMeBurguer.Application.Models.Request;
using FIAP.TechChallenge.ByteMeBurguer.Application.Models.Response;
using FIAP.TechChallenge.ByteMeBurguer.Application.UseCases.Interfaces;
using FIAP.TechChallenge.ByteMeBurguer.Domain.Entities;
using FIAP.TechChallenge.ByteMeBurguer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.TechChallenge.ByteMeBurguer.Application.UseCases
{
    public class AtualizarStatusPedidoUseCase : IAtualizarStatusPedidoUseCase
    {
        private readonly IPedidoRepository _pedidoRepository;
        public AtualizarStatusPedidoUseCase(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        async Task<bool> IUseCaseAsync<AtualizarStatusPedidoRequest, bool>.Execute(AtualizarStatusPedidoRequest request)
        {
            Pedido pedido = _pedidoRepository.GetById(request.Id);
            if (pedido != null)
            {
                pedido.StatusPedido = request.StatusPedido;
                await _pedidoRepository.Update(pedido, pedido.Id);
                return true;
            } else
            {
                return false;
            }
            
        }
    }
}
