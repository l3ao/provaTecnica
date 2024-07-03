using ProvaTecnica.Domain.Entities.v1;

namespace ProvaTecnica.Domain.Interfaces.v1;

public interface IClientRepository
{
    Task<IEnumerable<Client>> GetAllAsync();
    Task<Client?> GetByIdAsync(int id);
    Task<Client> CreateAsync(Client client);
    Task<Client> UpdateAsync(Client client);
    Task RemoveAsync(Client client);
}