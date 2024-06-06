using Application.Models.Response;

namespace Application.UseCases.Interfaces
{
    public interface IObterProdutoPorCategoriaUseCase : IUseCase<string, IList<ProdutoResponse>>
    {
    }
}
