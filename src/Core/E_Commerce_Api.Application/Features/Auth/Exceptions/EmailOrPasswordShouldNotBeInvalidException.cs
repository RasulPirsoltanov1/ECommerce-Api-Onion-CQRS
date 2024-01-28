using E_Commerce_Api.Application.Bases;
using System.Runtime.Serialization;

namespace E_Commerce_Api.Application.Features.Auth.Rules
{
    [Serializable]
    internal class EmailOrPasswordShouldNotBeInvalidException : BaseExceptions
    {
        public EmailOrPasswordShouldNotBeInvalidException():base("invalid username or password.")
        {
        }

        public EmailOrPasswordShouldNotBeInvalidException(string? message) : base(message)
        {
        }
    }
}