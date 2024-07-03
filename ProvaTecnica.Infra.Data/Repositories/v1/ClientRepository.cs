using Microsoft.EntityFrameworkCore;
using ProvaTecnica.Domain.Entities.v1;
using ProvaTecnica.Domain.Interfaces.v1;
using ProvaTecnica.InfraData.Context.v1;

namespace ProvaTecnica.InfraData.Repositories.v1;

public sealed class ClientRepository : IClientRepository 
{
    private ApplicationDbContext _db;
    
    public ClientRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public async Task<IEnumerable<Client>> GetAllAsync()
    {
        return await _db.Clients
            .Include(client => client.Company)
            .ToListAsync();
    }

    public async Task<Client?> GetByIdAsync(int id)
    {
        return await _db.Clients
            .Include(client => client.Company)
            .FirstOrDefaultAsync(client => client.Id == id);
    }

    public async Task<Client> CreateAsync(Client client)
    {
        await _db.Clients.AddAsync(client);
        await _db.SaveChangesAsync();
        return client;
    }

    public async Task<Client> UpdateAsync(Client client)
    {
        _db.Clients.Update(client);
        await _db.SaveChangesAsync();
        return client;
    }

    public async Task RemoveAsync(Client client)
    {
        _db.Clients.Remove(client);
        await _db.SaveChangesAsync();
    }
}