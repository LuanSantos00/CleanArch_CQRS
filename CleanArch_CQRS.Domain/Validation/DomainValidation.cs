namespace CleanArch_CQRS.Domain.Validation
{
    public class DomainValidation : Exception
    {
        public DomainValidation(string error) : base(error) { }

        public static void When(bool hasError, string errror)
        {
            if(hasError) 
                throw new DomainValidation(errror);
        }
    }
}
