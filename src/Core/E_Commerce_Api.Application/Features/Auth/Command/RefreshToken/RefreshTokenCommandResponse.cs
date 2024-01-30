using FluentValidation;

namespace E_Commerce_Api.Application.Features.Auth.Command.RefreshToken
{
    public class RefreshTokenCommandResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }

    public class RefreshTokenCommandRequestValidator : AbstractValidator<RefreshTokenCommandRequest>
    {

        public RefreshTokenCommandRequestValidator()
        {
            RuleFor(x => x.AccessToken).NotEmpty().NotNull();
            RuleFor(x => x.RefreshToken).NotEmpty().NotNull();
        }

    }
}
