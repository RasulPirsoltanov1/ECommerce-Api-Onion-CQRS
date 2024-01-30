using E_Commerce_Api.Application.Bases;

namespace E_Commerce_Api.Application.Features.Auth.Exceptions
{
    public class RefreshTokenShouldNotBeExpiredException: BaseExceptions
    {
        public RefreshTokenShouldNotBeExpiredException() : base("Refresh token expired.")
        {
        }

        public RefreshTokenShouldNotBeExpiredException(string? message) : base(message)
        {
        }
    }
}
