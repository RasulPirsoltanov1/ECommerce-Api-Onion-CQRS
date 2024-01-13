using FluentValidation;

namespace E_Commerce_Api.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommandRequest>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(x => x.Title).NotEmpty().NotNull().MinimumLength(3).MaximumLength(200);
            RuleFor(x => x.Description).NotEmpty().NotNull().MinimumLength(10).MaximumLength(5000);
            RuleFor(x => x.Discount).GreaterThanOrEqualTo(0).LessThan(100);
            RuleFor(x => x.Price).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(x => x.BrandId).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(x => x.CategoryIds).NotEmpty().NotNull();
        }
    }
}
