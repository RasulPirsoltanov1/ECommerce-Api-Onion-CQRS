using AutoMapper;
using E_Commerce_Api.Application.DTO_s;
using E_Commerce_Api.Application.Features.Auth.Command.Register;
using E_Commerce_Api.Application.Features.Products.Queries.GetAllProducts;
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
            CreateMap<AppUser, RegisterCommandRequest>().ReverseMap();
            CreateMap<Brand, BrandDto>().ReverseMap();
        }
    }
}
