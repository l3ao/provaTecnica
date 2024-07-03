using Microsoft.EntityFrameworkCore;
using ProvaTecnica.Domain.Entities.v1;
using ProvaTecnica.Domain.Interfaces.v1;
using ProvaTecnica.InfraData.Context.v1;

namespace ProvaTecnica.InfraData.Repositories.v1;

public sealed class CompanyRepository : ICompanyRepository
{
    private ApplicationDbContext _db;

    public CompanyRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Company>> GetAllAsync()
    {
        return await _db.Companies.ToListAsync();
    }

    public async Task<Company?> GetByIdAsync(int id)
    {
        return await _db.Companies.FirstOrDefaultAsync(company => company.Id == id);
    }

    public async Task<Company> CreateAsync(Company company)
    {
        await _db.Companies.AddAsync(company);
        await _db.SaveChangesAsync();
        return company;
    }

    public async Task<Company> UpdateAsync(Company company)
    {
        _db.Companies.Update(company);
        await _db.SaveChangesAsync();
        return company;
    }

    public async Task<Company> RemoveAsync(Company company)
    {
        _db.Remove(company);
        await _db.SaveChangesAsync();
        return company;
    }
}