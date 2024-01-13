using E_Commerce_Api.Application.Features.Products.Command.CreateProduct;
using E_Commerce_Api.Application.Features.Products.Command.DeleteProduct;
using E_Commerce_Api.Application.Features.Products.Command.UpdateProduct;
using E_Commerce_Api.Application.Features.Products.Queries.GetAllProducts;
using E_Commerce_Api.Application.Interfaces.UnitOfWorks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace E_Commerce_Api.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var datas = await _mediator.Send(new GetAllProductsQueryRequest());
            return Ok(datas);
        }
        [HttpPost]
        public async Task<IActionResult> Add(CreateProductCommandRequest createProductCommandRequest)
        {
            await _mediator.Send(createProductCommandRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductCommandRequest updateProductCommandRequest)
        {
            var result =await _mediator.Send(updateProductCommandRequest);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteProductCommandRequest deleteProductCommandRequest)
        {
            
            var result = await _mediator.Send(deleteProductCommandRequest);
            return Ok(result);
        }

    }
}
