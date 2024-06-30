using FIAP.TechChallenge.ByteMeBurguer.Application.Models.Request;
using FIAP.TechChallenge.ByteMeBurguer.Application.UseCases.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FIAP.TechChallenge.ByteMeBurguer.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : Controller
    {
        private readonly IObterPedidosUseCase _obterPedidos;
        private readonly IObterPedidoPorIdUseCase _obterPedidoPorId;
        private readonly ICriarPedidoUseCase _criarPedido;

        public PedidoController(
            IObterPedidosUseCase obterPedidos,
            IObterPedidoPorIdUseCase obterPedidoPorId,
            ICriarPedidoUseCase criarPedido)
        {
            _obterPedidos = obterPedidos;
            _obterPedidoPorId = obterPedidoPorId;
            _criarPedido = criarPedido;
        }

        [HttpPost]
        public async Task<IActionResult> CriarPedido(CriarPedidoRequest request)
        {
            try
            {
                var result = await _criarPedido.Execute(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{Id}")]
        public IActionResult ObterPedidoPorId(int Id)
        {
            try
            {
                var result = _obterPedidoPorId.Execute(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult ObterPedidos()
        {
            try
            {
                var result = _obterPedidos.Execute();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
