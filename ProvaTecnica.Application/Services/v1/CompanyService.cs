using AutoMapper;
using MediatR;
using TechnicalTest.Application.Companies.Commands.v1;
using TechnicalTest.Application.Companies.Queries.v1;
using TechnicalTest.Application.Dtos.v1;
using TechnicalTest.Application.Interfaces;

namespace TechnicalTest.Application.Services.v1;

public sealed class CompanyService : ICompanyService
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public CompanyService(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    public async Task<IEnumerable<CompanyDto>> GetAllAsync()
    {
        var companiesQuery = new GetAllCompaniesQuery();

        if (companiesQuery == null)
            throw new ApplicationException("Entidade não pôde ser carregada.");

        var result = await _mediator.Send(companiesQuery);
        return _mapper.Map<IEnumerable<CompanyDto>>(result);
    }

    public async Task<CompanyDto?> GetByIdAsync(int id)
    {
        var companyByIdQuery = new GetCompanyByIdQuery(id);

        if (companyByIdQuery == null)
            throw new ApplicationException("Entidade não pôde ser carregada.");

        var result = await _mediator.Send(companyByIdQuery);
        return _mapper.Map<CompanyDto>(result);
    }

    public async Task<CompanyDto> CreateAsync(CompanyCreateDto companyDto)
    {
        var companyCreateCommand = _mapper.Map<CompanyCreateCommand>(companyDto);
        var result = await _mediator.Send(companyCreateCommand);
        return _mapper.Map<CompanyDto>(result);
    }

    public async Task UpdateAsync(int id, CompanyUpdateDto companyDto)
    {
        companyDto.Id = id;
        var companyUpdateCommand = _mapper.Map<CompanyUpdateCommand>(companyDto);
        await _mediator.Send(companyUpdateCommand);
    }

    public async Task RemoveAsync(int id)
    {
        var companyRemoveCommand = new CompanyRemoveCommand(id);
        if (companyRemoveCommand == null)
            throw new ApplicationException("Entidade não pode ser carregada.");

        await _mediator.Send(companyRemoveCommand);
    }
}