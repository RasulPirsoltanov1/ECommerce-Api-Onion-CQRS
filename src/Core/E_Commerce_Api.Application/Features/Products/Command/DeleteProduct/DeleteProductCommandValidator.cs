using FluentValidation;

namespace E_Commerce_Api.Application.Features.Products.Command.DeleteProduct
{
    public class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommandRequest>
    {
        public DeleteProductCommandValidator()
        {
            RuleFor(x=>x.Id).NotEmpty().NotNull().GreaterThan(0);
        }
    }
}
