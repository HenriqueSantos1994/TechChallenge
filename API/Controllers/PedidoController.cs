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
        private readonly IObterPedidosFiltradosUseCase _obterPedidosFiltrados;
        private readonly IObterPedidoPorIdUseCase _obterPedidoPorId;
        private readonly ICriarPedidoUseCase _criarPedido;
        //private readonly IObterStatusPagamentoPedidoUseCase _obterStatusPagamentoPedido;
        private readonly IAtualizarStatusPedidoUseCase _atualizarStatusPedido;

        public PedidoController(
            IObterPedidosUseCase obterPedidos,
            IObterPedidosFiltradosUseCase obterPedidosFiltrados,
            IObterPedidoPorIdUseCase obterPedidoPorId,
            ICriarPedidoUseCase criarPedido,
            IAtualizarStatusPedidoUseCase atualizarStatusPedido)
        {
            _obterPedidos = obterPedidos;
            _obterPedidosFiltrados = obterPedidosFiltrados;
            _obterPedidoPorId = obterPedidoPorId;
            _criarPedido = criarPedido;
            _atualizarStatusPedido = atualizarStatusPedido;
        }

        [HttpPost]
        public async Task<IActionResult> CriarPedido(CriarPedidoRequest request)
        {
            try
            {
                //TODO: Erro ao cadastrar pedido
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
        [HttpGet("Filtrados")]
        public IActionResult ObterPedidosFiltrados()
        {
            try
            {
                var result = _obterPedidosFiltrados.Execute();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("StatusPedido")]
        public IActionResult AtualizarStatusPedido([FromBody] AtualizarStatusPedidoRequest request)
        {
            try
            {
                _atualizarStatusPedido.Execute(request);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
