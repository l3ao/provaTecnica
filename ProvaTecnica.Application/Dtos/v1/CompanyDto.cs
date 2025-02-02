using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TechnicalTest.Application.Dtos.v1;

public class CompanyDto
{
    public int Id { get; set; }
    
    [Required]
    [MinLength(5)]
    [MaxLength(100)]
    [JsonPropertyName("nome")]
    public string Name { get; set; }
    
    [Required]
    [JsonPropertyName("porte")]
    public int Size { get; set; }
}