using MediatR;
using ProvaTecnica.Domain.Entities;
using ProvaTecnica.Domain.Entities.v1;
using ProvaTecnica.Domain.Interfaces.v1;
using TechnicalTest.Application.Companies.Queries.v1;

namespace TechnicalTest.Application.Companies.Handlers.v1;

public sealed class GetCompanyByIdQueryHandler : IRequestHandler<GetCompanyByIdQuery, Company>
{
    private readonly ICompanyRepository _repository;

    public GetCompanyByIdQueryHandler(ICompanyRepository repository)
    {
        _repository = repository;
    }

    public async Task<Company> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetByIdAsync(request.Id);
        return result!;
    }
}