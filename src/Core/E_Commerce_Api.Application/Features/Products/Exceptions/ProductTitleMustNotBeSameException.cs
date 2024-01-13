using E_Commerce_Api.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Features.Products.Exceptions
{
    public class ProductTitleMustNotBeSameException : BaseExceptions
    {
        public ProductTitleMustNotBeSameException() : base("product name already exists")
        {

        }
    }
}
