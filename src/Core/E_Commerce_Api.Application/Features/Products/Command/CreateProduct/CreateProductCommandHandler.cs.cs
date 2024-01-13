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

        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
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
