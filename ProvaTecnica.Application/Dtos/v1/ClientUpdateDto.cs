using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TechnicalTest.Application.Dtos.v1;

public sealed class ClientUpdateDto : ClientDto
{
    [JsonIgnore]
    public int Id { get; set; }
    
    public int? CompanyId { get; init; }
    
    [JsonIgnore]
    public CompanyDto? Company { get; init; }
}