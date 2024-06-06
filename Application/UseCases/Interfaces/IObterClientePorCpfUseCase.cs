using Application.Models.Response;

namespace Application.UseCases.Interfaces
{
    public interface IObterClientePorCpfUseCase : IUseCase<string, ClienteResponse>
    {
    }
}
