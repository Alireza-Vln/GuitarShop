using Microsoft.AspNetCore.Mvc;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Controllers
{
    [ApiController]
    [Route("ElectricGuitar")]
    public class ElectricGuitarController : Controller
    {
     private readonly IElectricGuitarService _service;
        public ElectricGuitarController(IElectricGuitarService electricGuitarService)
        {
            _service = electricGuitarService;
        }

        [HttpPost("Add-ElectricGuitar")]
        public void AddElectericGuitar([FromBody] AddElecetricGuitarDto dto)
        {
            _service.AddElectric(dto);
        }
        [HttpGet("Get-AllElectricGuitar")]

        public List<ElectircGuitar> GetElectircGuitars()
        {
            return _service.GetElectircGuitars();
        }

        [HttpDelete("Delete-ElectricGuitar")]
        public List<ElectircGuitar> DeleteElecrticGuiatr([FromQuery]DeleteElectricGuitarDto dto)
        {
            return _service.DeleteElectircGuitars(dto);
        }

        [HttpPatch("Update-ElectricguitarPrice")]
        public void UpdateElectricGuitarPrice([FromQuery] UpdateElectricGuitarDto dto)
        {
            _service.UpdateElectircGuitar(dto);
        }

    }
}
