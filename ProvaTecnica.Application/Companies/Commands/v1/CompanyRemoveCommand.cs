using MediatR;
using ProvaTecnica.Domain.Entities.v1;

namespace TechnicalTest.Application.Companies.Commands.v1;

public class CompanyRemoveCommand : IRequest<Company>
{
    public int Id { get; set; }

    public CompanyRemoveCommand(int id)
    {
        Id = id;
    }
}