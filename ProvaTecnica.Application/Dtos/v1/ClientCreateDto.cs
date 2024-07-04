using System.Text.Json.Serialization;
using AutoMapper.Configuration.Annotations;

namespace TechnicalTest.Application.Dtos.v1;

public sealed class ClientCreateDto : ClientDto
{
    [JsonIgnore]
    public int Id { get; set; }
    
    [JsonIgnore]
    public CompanyDto? Company { get; init; }
}