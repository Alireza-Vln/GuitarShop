using Microsoft.AspNetCore.Mvc;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Services;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Controllers
{
    [ApiController]
    [Route("ClassicGuitar")]
    public class ClassicGuitarController : Controller
    {
    private readonly ClassicGuitarService _service;
        public ClassicGuitarController(ClassicGuitarService service)
        {
            _service = service;
        }
        [HttpPost("Add-ClassiceGuitar")]

        public async Task AddClassic([FromBody]AddClassicGuitarDto dto)
        {
            await _service.AddClassic(dto);
        }

        [HttpGet("GetAllClassicGuitar")]

        public async Task<List<ClassicGuitar>> GetClassic()
        {
            return await _service.GetClassicGuitars();
        }

        [HttpDelete("Delete-classicGuitar")]

        public async Task<List<ClassicGuitar>> DeleteClassic([FromQuery]DeleteClassicGuitarDto dto)
        {
            return await _service.DeleteClassicGuitars(dto);
        }

        [HttpPatch("Upadte-CalassicGuitarPrice")]

        public  async Task UpdateClassicPrice([FromQuery]UpdateClassicGuitarDto dto)
        {
            await _service.UpdateClassicGuitar(dto);
        }
    }
}
