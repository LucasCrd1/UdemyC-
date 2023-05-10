using Ex_Resolvido.Entities.Exceptions;

namespace Ex_Resolvido.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
