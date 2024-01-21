using AutoMapper;
using E_Commerce_Api.Application.Interfaces.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Bases
{
    public class BaseHandler
    {
        protected IMapper _mapper;
        protected IUnitOfWork _unitOfWork;
        protected IHttpContextAccessor _httpContextAccessor;
        protected string _userId;
        public BaseHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _userId = _httpContextAccessor?.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
