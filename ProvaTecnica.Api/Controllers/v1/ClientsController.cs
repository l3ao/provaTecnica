using Microsoft.AspNetCore.Mvc;
using TechnicalTest.Application.Dtos.v1;
using TechnicalTest.Application.Interfaces;

namespace ProvaTecnica.Api.Controllers.v1;

[Route("api/v1/clients")]
[ApiController]
public class ClientsController : ControllerBase
{
    private readonly IClientService _clientService;

    public ClientsController(IClientService clientService)
    {
        _clientService = clientService;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ClientDto>>> GetAllClientsAsync()
    {
        var clients = await _clientService.GetAllAsync();
        if (!clients.Any())
            return NotFound(new { errorMessage = "Clientes não encontrados." });

        return Ok(clients);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ClientDto>> GetClientByIdAsync(int id)
    {
        var client = await _clientService.GetByIdAsync(id);
        if (client == null)
            return NotFound(new { errorMessage = "Cliente não encontrado." });

        return Ok(client);
    }
    
    [HttpPost]
    public async Task<ActionResult<ClientDto>> CreateClientAsync([FromBody] ClientCreateDto clientDto)
    {
        if (clientDto == null)
            return BadRequest(new { errorMessage = "Dados inválidos." });
        
        var client = await _clientService.CreateAsync(clientDto);
        
        return StatusCode(StatusCodes.Status201Created,
            new { successMessage = "Sucesso ao criar o cliente.", client = client });
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ClientDto>> UpdateClientAsync(int id, [FromBody] ClientUpdateDto clientDto)
    {
        if (clientDto == null)
            return BadRequest(new { errorMessage = "Dados inválidos." });

        await _clientService.UpdateAsync(id, clientDto);
        return Ok(clientDto);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ClientDto>> RemoveClientAsync(int id)
    {
        var company = await _clientService.GetByIdAsync(id);
        if (company == null)
            return NotFound(new { errorMessage = "Empresa não encontrada." });

        await _clientService.RemoveAsync(id);
        return Ok(new { successMessage = "Sucesso ao excluir o cliente." });
    }
}