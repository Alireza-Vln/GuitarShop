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

        [HttpGet("GetAllClassicGuitar")]

        public List<ClassicGuitar> GetClassic()
        {
            return _service.GetClassicGuitars();
        }

        [HttpDelete("Delete-classicGuitar")]

        public List<ClassicGuitar> DeleteClassic([FromQuery]DeleteClassicGuitarDto dto)
        {
            return _service.DeleteClassicGuitars(dto);
        }

        [HttpPatch("Upadte-CalassicGuitarPrice")]

        public  void UpdateClassicPrice([FromQuery]UpdateClassicGuitarDto dto)
        {
            _service.UpdateClassicGuitar(dto);
        }
    }
}
