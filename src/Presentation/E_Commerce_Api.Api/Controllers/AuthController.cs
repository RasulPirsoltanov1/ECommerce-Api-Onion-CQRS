using E_Commerce_Api.Application.Features.Auth.Command.Login;
using E_Commerce_Api.Application.Features.Auth.Command.RefreshToken;
using E_Commerce_Api.Application.Features.Auth.Command.Register;
using E_Commerce_Api.Application.Features.Auth.Command.Revoke;
using E_Commerce_Api.Application.Features.Auth.Command.RevokeAll;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace E_Commerce_Api.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterCommandRequest registerCommandRequest)
        {
            await _mediator.Send(registerCommandRequest);
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginCommandRequest loginCommandRequest)
        {
            var response = await _mediator.Send(loginCommandRequest);
            return StatusCode(statusCode:StatusCodes.Status200OK,response);
        }
        [HttpPost]
        public async Task<IActionResult> RefreshToken(RefreshTokenCommandRequest refreshTokenCommandRequest)
        {
            var response = await _mediator.Send(refreshTokenCommandRequest);
            return StatusCode(statusCode: StatusCodes.Status200OK, response);
        }
        [HttpPost]
        public async Task<IActionResult> Revoke(RevokeCommandRequest revokeCommandRequest)
        {
            var response = await _mediator.Send(revokeCommandRequest);
            return StatusCode(statusCode: StatusCodes.Status200OK);
        }
        [HttpPost]
        public async Task<IActionResult> RevokeAll()
        {
            var response = await _mediator.Send(new RevokeAllCommandRequest());
            return StatusCode(statusCode: StatusCodes.Status200OK);
        }
    }
}
