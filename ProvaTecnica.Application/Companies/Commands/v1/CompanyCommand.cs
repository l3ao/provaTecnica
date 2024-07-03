using MediatR;
using ProvaTecnica.Domain.Entities;
using ProvaTecnica.Domain.Entities.v1;

namespace TechnicalTest.Application.Companies.Commands.v1;

public abstract class CompanyCommand : IRequest<Company>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Size { get; set; }
}