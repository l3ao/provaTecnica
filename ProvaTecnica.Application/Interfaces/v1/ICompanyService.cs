using TechnicalTest.Application.Dtos.v1;

namespace TechnicalTest.Application.Interfaces;

public interface ICompanyService
{
    Task<IEnumerable<CompanyDto>> GetAllAsync();
    Task<CompanyDto?> GetByIdAsync(int id);
    Task<CompanyDto> CreateAsync(CompanyDto companyDto);
    Task UpdateAsync(int id, CompanyDto companyDto);
    Task RemoveAsync(int id);
}