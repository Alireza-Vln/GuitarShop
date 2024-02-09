using Microsoft.AspNetCore.Mvc;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Services;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Controllers
{
    [ApiController]
    [Route("ClassicGuitar")]
    public class ClassicGuitarController : Controller
    {
    private readonly IClassicGuitarService _service;
        public ClassicGuitarController(IClassicGuitarService service)
        {
            _service = service;
        }
        [HttpPost("Add-ClassiceGuitar")]

        public void AddClassic([FromBody]AddClassicGuitarDto dto)
        {
            _service.AddClassic(dto);
        }
    }
}
