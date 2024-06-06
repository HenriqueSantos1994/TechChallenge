using Application.Models.Response;

namespace Application.UseCases.Interfaces
{
    public interface IObterPedidoPorIdUseCase : IUseCase<int, PedidoResponse>
    {
    }
}
