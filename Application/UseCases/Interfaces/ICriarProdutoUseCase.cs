using Application.Models.Request;

namespace Application.UseCases.Interfaces
{
    public interface ICriarProdutoUseCase : IUseCase<CriarProdutoRequest, bool>
    {
    }
}
