using ProvaTecnica.Domain.Entities;
using ProvaTecnica.Domain.Entities.v1;

namespace ProvaTecnica.Domain.Interfaces.v1;

public interface ICompanyRepository
{
    Task<IEnumerable<Company>> GetAllAsync();
    Task<Company?> GetByIdAsync(int id);
    Task<Company> CreateAsync(Company company);
    Task<Company> UpdateAsync(Company company);
    Task<Company> RemoveAsync(Company company);
}