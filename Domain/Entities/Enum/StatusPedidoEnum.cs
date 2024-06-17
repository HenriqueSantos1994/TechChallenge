using System.ComponentModel;

namespace FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Enum
{
    public enum StatusPedidoEnum
    {
        [Description("Recebido")]
        Recebido,

        [Description("Em Preparação")]
        EmPreparacao,

        [Description("Pronto")]
        Pronto,

        [Description("Finalizado")]
        Finalizado
    }
}
