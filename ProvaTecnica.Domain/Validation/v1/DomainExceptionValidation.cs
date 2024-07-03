namespace ProvaTecnica.Domain.Validation.v1;

public class DomainExceptionValidation : Exception
{
    private DomainExceptionValidation(string error) : base(error) { }

    public static void When(bool hasError, string error)
    {
        if (hasError)
            throw new DomainExceptionValidation(error);
    }
}