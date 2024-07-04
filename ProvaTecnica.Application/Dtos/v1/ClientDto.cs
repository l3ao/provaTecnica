using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TechnicalTest.Application.Dtos.v1;

public class ClientDto
{
    public int Id { get; set; }
    
    [Required]
    [MinLength(5)]
    [MaxLength(100)]
    [JsonPropertyName("nome")]
    public string Name { get; init; }
    
    [MinLength(1)]
    [MaxLength(50)]
    [JsonPropertyName("documento")]
    public string? Document { get; init; }
    
    [MinLength(1)]
    [MaxLength(250)]
    [JsonPropertyName("endereco")]
    public string? Address { get; init; }
    
    [MinLength(1)]
    [MaxLength(20)]
    [JsonPropertyName("numeroTelefone")]
    public string? PhoneNumber { get; init; }
    
    [Required]
    [JsonPropertyName("empresaId")]
    public int? CompanyId { get; init; }
    
    [JsonPropertyName("empresa")]
    public CompanyDto? Company { get; init; }
}