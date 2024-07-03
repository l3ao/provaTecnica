using System.Data;

namespace ProvaTecnica.Domain.Entities.v1;

public sealed class Client
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string? Document { get; private set; }
    public string? Address { get; private set; }
    public string? PhoneNumber { get; private set; }
    public int? CompanyId { get; private set; }
    public Company? Company { get; private set; }

    public Client() { }

    public Client(int id, string name, string? document, string? address, string? phoneNumber,
        int companyId, Company? company)
    {
        Id = id;
        Name = name;
        Document = document;
        Address = address;
        PhoneNumber = phoneNumber;
        CompanyId = companyId;
        Company = company;
    }
    
    public Client(string name, string? document, string? address, string? phoneNumber,
        int companyId, Company? company)
    {
        Name = name;
        Document = document;
        Address = address;
        PhoneNumber = phoneNumber;
        CompanyId = companyId;
        Company = company;
    }

    public void Update(string name, string? document, string? address, string? phoneNumber,
        int companyId, Company? company)
    {
        Name = name;
        Document = document;
        Address = address;
        PhoneNumber = phoneNumber;
        CompanyId = companyId;
        Company = company;
    }
}