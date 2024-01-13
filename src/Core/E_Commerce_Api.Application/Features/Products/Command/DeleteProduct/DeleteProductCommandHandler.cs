﻿using E_Commerce_Api.Application.Interfaces.UnitOfWorks;
using E_Commerce_Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Features.Products.Command.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, bool>
    {
        IUnitOfWork _unitOfWork;

        public DeleteProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        async Task<bool> IRequestHandler<DeleteProductCommandRequest, bool>.Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var product = await _unitOfWork.GetReadRepository<Product>().GetAsync(expression: x => x.Id == request.Id && !x.IsDeleted, enableTracking: true);
                if (product is null)
                    return false;
                product.IsDeleted = true;
                await _unitOfWork.GetWriteRepository<Product>().UpdateAsync(product);
                await _unitOfWork.SaveAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
