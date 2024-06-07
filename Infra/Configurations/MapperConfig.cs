using Application.Models.Response;
using AutoMapper;
using Domain.Entities;

namespace Infra.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<ClienteResponse, Cliente>().ReverseMap();
            CreateMap<ProdutoResponse, Produto>().ReverseMap()
                .ForMember(x => x.NomeCategoria, y => y.MapFrom(x => x.CategoriaProduto.Nome));
            CreateMap<FormaPagamentoResponse, FormaPagamento>().ReverseMap();
            CreateMap<PedidoResponse, Pedido>().ReverseMap();
        }
    }
}
