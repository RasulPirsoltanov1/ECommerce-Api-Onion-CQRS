using E_Commerce_Api.Application.Features.Products.Rules;
using E_Commerce_Api.Application.Interfaces.UnitOfWorks;
using E_Commerce_Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        ProductRules _productRules;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork, ProductRules productRules)
        {
            _unitOfWork = unitOfWork;
            _productRules = productRules;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {

            IList<Product> products = await _unitOfWork.GetReadRepository<Product>().GetAllAsync();
            await _productRules.ProductTitleMustNotBeSame(request.Title, products);

            var product = new Product
            {
                BrandId = request.BrandId,
                Discount = request.Discount,
                Description = request.Description,
                Price = request.Price,
                Title = request.Title
            };

            await _unitOfWork.GetWriteRepository<Product>().AddAsync(product);
            var result = await _unitOfWork.SaveAsync();
            if (result > 0)
            {
                foreach (var categoryId in request.CategoryIds)
                {
                    await _unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new ProductCategory
                    {
                        CategoryId = categoryId,
                        ProductId = product.Id,
                    });
                    await _unitOfWork.SaveAsync();
                }
            }
            return new CreateProductCommandResponse();
        }
    }
}
