namespace FIAP.TechChallenge.ByteMeBurguer.Application.Models.Response
{
    public class ProdutoResponse
    {
        private double _valor;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Valor { get => string.Format("{0:0.00}", _valor); set => _valor = Convert.ToDouble(value); }
        public string NomeCategoria { get; set; }
    }
}
