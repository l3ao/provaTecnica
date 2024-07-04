using System.Text.Json.Serialization;

namespace TechnicalTest.Application.Dtos.v1;

public sealed class CompanyUpdateDto : CompanyDto
{
    [JsonIgnore]
    public int Id { get; set; }
}