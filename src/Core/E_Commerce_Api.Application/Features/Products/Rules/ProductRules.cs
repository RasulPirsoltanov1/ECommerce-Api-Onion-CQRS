using E_Commerce_Api.Application.Bases;
using E_Commerce_Api.Application.Features.Products.Exceptions;
using E_Commerce_Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Features.Products.Rules
{
    public class ProductRules : BaseRules
    {
        public Task ProductTitleMustNotBeSame(string requestTitle, IList<Product> products)
        {
            if (products.Any(x => x.Title == requestTitle))
            {
                throw new ProductTitleMustNotBeSameException();
            }
            return Task.CompletedTask;
        }
    }
}
