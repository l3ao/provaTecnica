using MediatR;
using ProvaTecnica.Domain.Entities.v1;

namespace TechnicalTest.Application.Clients.Commands.v1;

public abstract class ClientCommand : IRequest<Client>
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string? Document { get; init; }
    public string? Address { get; init; }
    public string? PhoneNumber { get; init; }
    public int? CompanyId { get; init; }
}