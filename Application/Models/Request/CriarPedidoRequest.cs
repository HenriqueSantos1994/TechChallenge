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
        [JsonPropertyName("id_forma_pagamento")]
        public int IdFormaPagamento { get; set; }

        [JsonPropertyName("valor_total")]
        public double ValorTotal { get; set; }
    }

}
