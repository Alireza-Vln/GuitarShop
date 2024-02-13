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
     private readonly ElectricGuitarService _service;
        public ElectricGuitarController(ElectricGuitarService electricGuitarService)
        {
            _service = electricGuitarService;
        }

        [HttpPost("Add-ElectricGuitar")]
        public async Task AddElectericGuitar([FromBody] AddElecetricGuitarDto dto)
        {
            await _service.AddElectric(dto);
        }
        [HttpGet("Get-AllElectricGuitar")]

        public async Task<List<ElectircGuitar>> GetElectircGuitars()
        {
            return await _service.GetElectircGuitars();
        }

        [HttpDelete("Delete-ElectricGuitar")]
        public async Task<List<ElectircGuitar>> DeleteElecrticGuiatr([FromQuery]DeleteElectricGuitarDto dto)
        {
            return await _service.DeleteElectircGuitars(dto);
        }

        [HttpPatch("Update-ElectricguitarPrice")]
        public async Task UpdateElectricGuitarPrice([FromQuery] UpdateElectricGuitarDto dto)
        {
            await _service.UpdateElectircGuitar(dto);
        }

    }
}
