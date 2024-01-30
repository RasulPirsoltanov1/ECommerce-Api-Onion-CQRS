using E_Commerce_Api.Application.Bases;

namespace E_Commerce_Api.Application.Features.Auth.Exceptions
{
    public class EmailAddressShouldBeValidException : BaseExceptions
    {
        public EmailAddressShouldBeValidException():base("Invalid email address!")
        {
            
        }
        public EmailAddressShouldBeValidException(string message):base(message)
        {
            
        }
    }
}
