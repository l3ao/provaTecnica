using TechnicalTest.Application.Dtos.v1;

namespace TechnicalTest.Application.Interfaces;

public interface IClientService
{
    Task<IEnumerable<ClientDto>> GetAllAsync();
    Task<ClientDto?> GetByIdAsync(int id);
    Task<ClientDto> CreateAsync(ClientCreateDto clientDto);
    Task<ClientDto> UpdateAsync(int id, ClientUpdateDto clientDto);
    Task RemoveAsync(int id);
}