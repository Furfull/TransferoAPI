using TransferoAPI.Models;
using TransferoAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace TransferoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClientesService _clientesService;

        public ClientesController(ILogger<ClientesController> logger, IClientesService clientesService)
        {
            _clientesService = clientesService;
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            var result = await _clientesService.GetClientes();
            return Ok(result);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> Get(string name)
        {
            var result = await _clientesService.GetClientesPorNome(name);
            return Ok(result);
        }

        [HttpPost()]
        public async Task<IActionResult> Add(Clientes cliente)
        {
            await _clientesService.AddClientes(cliente);
            return Ok();
        }
    }
}