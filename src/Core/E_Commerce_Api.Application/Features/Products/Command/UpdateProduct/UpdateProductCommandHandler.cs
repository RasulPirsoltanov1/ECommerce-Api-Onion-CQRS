using AutoMapper;
using E_Commerce_Api.Application.Interfaces.UnitOfWorks;
using E_Commerce_Api.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        async Task<UpdateProductCommandResponse> IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>.Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var productDb = await _unitOfWork.GetReadRepository<Product>().GetAsync(expression: x => x.Id == request.Id && !x.IsDeleted, include: x => x.Include(y => y.ProductCategories), enableTracking: true);
            if (productDb == null)
            {
                return new()
                {
                    IsSuccessfull = false,
                    Message = "Can not find this product in Database!"
                };
            }
            var productCategories = await _unitOfWork.GetReadRepository<ProductCategory>().GetAllAsync(expression: x => x.ProductId == productDb.Id, enableTracking: true);
            await _unitOfWork.GetWriteRepository<ProductCategory>().HardDeleteRangeAsync(productCategories);
            await _unitOfWork.SaveAsync();
            foreach (var item in request.CategoryIds)
            {
                await _unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new ProductCategory
                {
                    CategoryId = item,
                    ProductId = productDb.Id
                });
            }
            productDb.Title = request.Title;
            productDb.Description = request.Description;
            productDb.Price = request.Price;
            productDb.BrandId = request.BrandId;
            productDb.Discount = request.Discount;
            await _unitOfWork.GetWriteRepository<Product>().UpdateAsync(productDb);
            await _unitOfWork.SaveAsync();
            return new()
            {
                IsSuccessfull = true,
                Message = "Successfully updated."
            };
        }
    }
}
