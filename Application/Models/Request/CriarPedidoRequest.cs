using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Application.Models.Request
{
    public class CriarPedidoRequest
    {
        [JsonPropertyName("cpf")]
        public string CpfCliente { get; set; }

        [Required(ErrorMessage = "É obrigatório informar ao menos 1 PRODUTO para finalizar o pedido.")]
        [JsonPropertyName("produtos")]
        public List<int> IdsProdutos { get; set; }

        [Required(ErrorMessage = "É obrigatório informar uma FORMA DE PAGAMENTO para finalizar o pedido.")]
        [JsonPropertyName("idFormaPagamento")]
        public int IdFormaPagamento { get; set; }

        [JsonPropertyName("valorTotal")]
        public double ValorTotal { get; set; }
    }

}
