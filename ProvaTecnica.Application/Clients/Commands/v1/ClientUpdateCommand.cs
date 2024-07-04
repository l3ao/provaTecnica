using System.Text.Json.Serialization;

namespace TechnicalTest.Application.Clients.Commands.v1;

public sealed class ClientUpdateCommand : ClientCommand
{
    [JsonIgnore]
    public new int Id { get; init; }
}