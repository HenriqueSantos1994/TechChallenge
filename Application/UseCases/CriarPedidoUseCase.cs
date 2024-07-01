using FIAP.TechChallenge.ByteMeBurguer.Domain.Entities;
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
            if (cliente == null)
            {
                throw new Exception("Cliente não encontrado.");
            }
                
            var formaPagamento = _formaPagamentoRepository.GetById(request.IdFormaPagamento) ?? throw new Exception("Forma de pagamento não encontrada.");
            var pedidoProdutos = new List<PedidoProduto>();

            foreach (var item in request.ProdutosQuantidade)    
            {
                var produto = _produtoRepository.GetById(item.IdProduto) ?? throw new Exception($"Produto com ID {item.IdProduto} não encontrado.");
                pedidoProdutos.Add(new PedidoProduto { Produto = produto, Quantidade = item.Quantidade });
            }

            var pedido = new Pedido()
            {
                Cliente = cliente,
                FormaPagamento = formaPagamento,
                PedidoProdutos = pedidoProdutos,
                DataCriacao = DateTime.Now,
                StatusPedido = (int)StatusPedidoEnum.Recebido
            };

            var idPedido = await _pedidoRepository.Post(pedido);

            return $"Seu pedido foi criado! Número do seu pedido {idPedido}";
        }
    }
}
