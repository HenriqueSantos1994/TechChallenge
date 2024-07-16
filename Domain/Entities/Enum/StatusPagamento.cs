using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Enum
{
    public enum StatusPagamento
    {
        [Description("Pendente")]
        Recebido = 0,

        [Description("Aprovado")]
        EmPreparacao = 2,

        [Description("Recusado")]
        Pronto = 3
    }
}
