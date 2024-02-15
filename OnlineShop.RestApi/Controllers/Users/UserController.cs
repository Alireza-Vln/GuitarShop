using Microsoft.AspNetCore.Mvc;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Controllers
{
    [ApiController]
    [Route("Api/User")]
    public class UserController : Controller
    {
        private readonly UserService _service;
        public UserController(UserService service)
        {
            _service = service;
        }

        [HttpPost("Add-User")]

        public async Task AddUser([FromBody]AddUserDto dto)
        {
            await _service.AddUser(dto);
        }

    }
}
