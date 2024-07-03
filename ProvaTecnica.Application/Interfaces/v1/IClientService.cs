using TechnicalTest.Application.Dtos.v1;

namespace TechnicalTest.Application.Interfaces;

public interface IClientService
{
    Task<IEnumerable<ClientDto>> GetAllAsync();
    Task<ClientDto?> GetByIdAsync(int id);
    Task<ClientDto> CreateAsync(ClientDto clientDto);
    Task<ClientDto> UpdateAsync(int id, ClientDto clientDto);
    Task RemoveAsync(int id);
}