using MediatR;
using ProvaTecnica.Domain.Entities;
using ProvaTecnica.Domain.Entities.v1;

namespace TechnicalTest.Application.Companies.Queries.v1;

public class GetCompanyByIdQuery : IRequest<Company>
{
    public int Id { get; set; }

    public GetCompanyByIdQuery(int id)
    {
        Id = id;
    }
}