using AutoMapper;
using E_Commerce_Api.Application.Interfaces.UnitOfWorks;
using E_Commerce_Api.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Api.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        async Task<IList<GetAllProductsQueryResponse>> IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>.Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await _unitOfWork.GetReadRepository<Product>().GetAllAsync(include: x => x.Include(y => y.Brand));
            var response = _mapper.Map<IList<Product>, IList<GetAllProductsQueryResponse>>(products);
            foreach (var res in response)
            {
                res.Price -= res.Price * res.Discount / 100;
            }
            //throw new ValidationException("global error"); //for test global exception handler.
            return response;
        }
    }
}
