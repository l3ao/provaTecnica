namespace TechnicalTest.Application.Clients.Commands.v1;

public sealed class ClientCreateCommand : ClientCommand
{
    public new int CompanyId { get; init; }
}