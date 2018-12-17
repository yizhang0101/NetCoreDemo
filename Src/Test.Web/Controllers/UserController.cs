using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.UserApp;
using Test.Application.UserApp.Dto;

namespace Test.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly IUserAppService _service;

        public UserController(IUserAppService service)
        {
            _service = service;
        }

        // POST api/values
        [HttpPost]
        public void Post(UserDto dto)
        {
            _service.InsertUser(dto);
        }
    }
}