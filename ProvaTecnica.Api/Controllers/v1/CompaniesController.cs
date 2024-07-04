using Microsoft.AspNetCore.Mvc;
using TechnicalTest.Application.Dtos.v1;
using TechnicalTest.Application.Interfaces;

namespace ProvaTecnica.Api.Controllers.v1;

[Route("api/v1/companies")]
[ApiController]
public class CompaniesController : ControllerBase
{
    private readonly ICompanyService _companyService;

    public CompaniesController(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CompanyDto>>> GetAllCompaniesAsync()
    {
        var companies = await _companyService.GetAllAsync();
        if (!companies.Any())
            return NotFound(new { errorMessage = "Empresas não encontradas." });

        return Ok(companies);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CompanyDto>> GetCompanyByIdAsync(int id)
    {
        var company = await _companyService.GetByIdAsync(id);
        if (company == null)
            return NotFound(new { errorMessage = "Empresa não encontrada." });

        return Ok(company);
    }

    [HttpPost]
    public async Task<ActionResult> CreateCompanyAsync([FromBody] CompanyCreateDto? companyCreateDto)
    {
        if (companyCreateDto == null)
            return BadRequest(new { errorMessage = "Dados inválidos." });

        var company = await _companyService.CreateAsync(companyCreateDto);
        
        return StatusCode(StatusCodes.Status201Created,
            new { successMessage = "Sucesso ao criar empresa.", company = company });
    }

    [HttpPut]
    public async Task<ActionResult> UpdateCompanyAsync(int id, [FromBody] CompanyUpdateDto? companyCreateDto)
    {
        if (companyCreateDto == null)
            return BadRequest(new { errorMessage = "Dados inválidos." });

        await _companyService.UpdateAsync(id, companyCreateDto);
        return Ok(companyCreateDto);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<CompanyDto>> RemoveCompanyAsync(int id)
    {
        var company = await _companyService.GetByIdAsync(id);
        if (company == null)
            return NotFound(new { errorMessage = "Empresa não encontrada." });

        await _companyService.RemoveAsync(id);
        return Ok(company);
    }
}