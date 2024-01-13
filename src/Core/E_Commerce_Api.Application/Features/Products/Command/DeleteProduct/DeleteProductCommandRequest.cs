using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Features.Products.Command.DeleteProduct
{
    public class DeleteProductCommandRequest:IRequest<bool>
    {
        public int Id { get; set; }
    }
}
