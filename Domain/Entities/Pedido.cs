namespace FIAP.TechChallenge.ByteMeBurguer.Domain.Entities
{
    public class Pedido : EntityBase
    {
        public Guid IdGuid { get; set; }
        public Cliente Cliente { get; set; }
        public IList<PedidoProduto> PedidoProdutos { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataPreparacao { get; set; }
        public DateTime? DataPronto { get; set; }
        public DateTime? DataEncerrado { get; set; }
        public int StatusPedido { get; set; }
    }
}
