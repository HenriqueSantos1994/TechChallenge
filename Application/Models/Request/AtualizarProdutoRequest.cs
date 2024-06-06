﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Application.Models.Request
{
    public class AtualizarProdutoRequest
    {
        [Required(ErrorMessage = "É obrigatório informar o id.")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o Nome.")]
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a Descricao.")]
        [JsonPropertyName("Descricao")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o Valor.")]
        [JsonPropertyName("Valor")]
        public double Valor { get; set; }//{ get => String.Format("{0:0.00}", _valor); set => _valor = Convert.ToDouble(value); }

        [Required(ErrorMessage = "É obrigatório informar o nome da Categoria.")]
        [JsonPropertyName("nome_categoria")]
        public string NomeCategoria { get; set; }
    }
}
