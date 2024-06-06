namespace Application.Models.Response
{
    public class PedidoResponse
    {
        public int Id { get; set; }
        public ClienteResponse Cliente { get; set; }
        public IList<ProdutoResponse> Produtos { get; set; }
        public FormaPagamentoResponse FormaPagamento { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataPreparacao { get; set; }
        public DateTime? DataPronto { get; set; }
        public DateTime? DataEncerrado { get; set; }
        public int StatusPedido { get; set; }
    }
}
