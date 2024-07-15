using FIAP.TechChallenge.ByteMeBurguer.Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.TechChallenge.ByteMeBurguer.Application.Models.Response
{
    public class StatusPedidoResponse
    {
        public int Id { get; set; }
        public DateTime? DataCriacao { get; set; }
        public string StatusPedido { get; set; }
    }
}
