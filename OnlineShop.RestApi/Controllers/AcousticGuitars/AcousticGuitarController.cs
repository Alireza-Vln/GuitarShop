using Microsoft.AspNetCore.Mvc;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Controllers
{
    [ApiController]
    [Route("Api/AcousticGuitar")]
    public class AcousticGuitarController : Controller
    {
        private readonly AcousticGuitarService _service;
        public AcousticGuitarController(AcousticGuitarService service)
        {
            _service = service;
        }
        [HttpPost("Add-AcoutsicGuitar")]
        public async Task AddAcoustic([FromBody]AddAcousticGuitarDto dto)
        {
            await _service.AddAcoustic(dto);
        }
        [HttpGet("GetAllAcousticGuitar")]
        public async  Task<List<AcousticGuitar>> GetAcousticGuitars()
        {
            return await _service.GetAllAcousticGuitars();
        }
        [HttpDelete("Delet-AcousticGuitar")]
        public async Task<List<AcousticGuitar>> DeleteAcoustic([FromQuery]DeleteAcousticGuitarDto dto)
        {
            return await _service.DeleteAcoustic(dto);
        }
        [HttpPatch]
        public async Task UpdateAcoustic([FromQuery]UpdateAcousticGuitarDto dto)
        {
            await _service.UpdateAcousticGuitar(dto);
        }
    }
}
