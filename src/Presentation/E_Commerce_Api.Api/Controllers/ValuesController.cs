using E_Commerce_Api.Application.Features.Products.Queries.GetAllProducts;
using E_Commerce_Api.Application.Interfaces.UnitOfWorks;
using E_Commerce_Api.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Api.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IUnitOfWork _unitOfWork;
        IMediator _mediator;

        public ValuesController(IUnitOfWork unitOfWork, IMediator mediator)
        {
            this._unitOfWork = unitOfWork;
            this._mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var datas = await _mediator.Send(new GetAllProductsQueryRequest());
            return Ok(datas);

        }
    }
}
