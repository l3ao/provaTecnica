using ProvaTecnica.Domain.Validation.v1;

namespace ProvaTecnica.Domain.Entities.v1;

public sealed class Company
{
    public int Id { get; private set; }
    public string? Name { get; private set; }
    public int? Size { get; private set; }
    public IEnumerable<Client>? Clients { get; private set; }

    public Company() { }
    
    public Company(int id, string? name, int? size, IEnumerable<Client>? clients)
    {
        Id = id;
        Name = name;
        Size = size;
        Clients = clients;
    }

    public Company(string name, int size)
    {
        ValidateName(name);
        ValidateSize(size);
    }

    public Company(int id, string name)
    {
        ValidateId(id);
        ValidateName(name);
    }

    public void Update(string name)
    {
        ValidateName(name);
    }
    
    private void ValidateId(int id)
    {
        DomainExceptionValidation.When(id < 0,
            "ID inválido.");
        Id = id;
    }

    private void ValidateName(string name)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name),
            "Nome inválido. Campo obrigátorio");
        DomainExceptionValidation.When(name.Length < 5,
            "Nome inválido. Tamanho mínimo de 5 caracteres");

        Name = name;
    }
    
    private void ValidateSize(int size)
    {
        DomainExceptionValidation.When(size < 0,
            "Tamanho inválido.");

        Size = size;
    }
    
}