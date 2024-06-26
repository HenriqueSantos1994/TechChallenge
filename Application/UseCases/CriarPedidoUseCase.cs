﻿using FIAP.TechChallenge.ByteMeBurguer.Domain.Entities;
using FIAP.TechChallenge.ByteMeBurguer.Application.Models.Request;
using FIAP.TechChallenge.ByteMeBurguer.Application.UseCases.Interfaces;
using FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Enum;
using FIAP.TechChallenge.ByteMeBurguer.Domain.Repositories;

namespace FIAP.TechChallenge.ByteMeBurguer.Application.UseCases
{
    public class CriarPedidoUseCase : ICriarPedidoUseCase
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IFormaPagamentoRepository _formaPagamentoRepository;
        private readonly IProdutoRepository _produtoRepository;

        public CriarPedidoUseCase(
            IPedidoRepository petoRepository,
            IClienteRepository clienteRepository,
            IFormaPagamentoRepository formaPagamentoRepository,
            IProdutoRepository produtoRepository)
        {
            _pedidoRepository = petoRepository;
            _clienteRepository = clienteRepository;
            _formaPagamentoRepository = formaPagamentoRepository;
            _produtoRepository = produtoRepository;
        }

        public async Task<string> Execute(CriarPedidoRequest request)
        {
            Cliente cliente = null;

            if (!string.IsNullOrEmpty(request.CpfCliente))
                cliente = _clienteRepository.GetByCpf(request.CpfCliente);

            var pagamento = _formaPagamentoRepository.GetById(request.IdFormaPagamento);


            var produtos = new List<Produto>();

            request.IdsProdutos.ForEach(x =>
            {
                produtos.Add(_produtoRepository.GetById(x));
            });

            var pedido = new Pedido()
            {
                Cliente = cliente,
                FormaPagamento = pagamento,
                Produtos = produtos,
                DataCriacao = DateTime.Now,
                StatusPedido = (int)StatusPedidoEnum.Recebido
            };

            var idPedido = await _pedidoRepository.Post(pedido);

            return $"Seu pedido foi criado! Número do seu pedido {idPedido}";
        }
    }
}
