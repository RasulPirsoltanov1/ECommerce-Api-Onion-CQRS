using AutoMapper;
using E_Commerce_Api.Application.DTO_s;
using E_Commerce_Api.Application.Features.Products.Command.GetAllProducts;
using E_Commerce_Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.AutoMapperConfigs
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Product, GetAllProductsQueryResponse>().ReverseMap();
            CreateMap<Brand, BrandDto>().ReverseMap();
        }
    }
}
