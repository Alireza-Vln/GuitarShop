using Microsoft.AspNetCore.Mvc;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Controllers
{
    [ApiController]
    [Route("Api/BassGuitar")]
    public class BassGuitarController : Controller
    {
        readonly BassGuitarService _service;
        public BassGuitarController(BassGuitarService service)
        {
            _service = service;
        }



        [HttpPost("Add-BassGuitar")]
        public async Task AddBass([FromBody] AddGuitarBassDto dto)
        {
           await _service.AddBass(dto);
        }


        [HttpGet("Get-AllBassGuitar")]
        public async Task<List<BassGuitar>> GetAllBassGuitars()
        {
             return await _service.GetAllBassGuitars();
        }


        [HttpDelete("Delete-BassGuitar")]
        public async Task <List<BassGuitar>> DeleteBassGuitar([FromQuery] DeleteBassGuitarDto dto)
        {
            return await _service.DeleteBassGuitar(dto);
        }

        [HttpPatch("Update-BassGuitarPrice")]
        public async Task UpdateBassGuitarPrice([FromQuery] UpdateBassGuitarPriceDto dto)
        {
            await _service.UpdateBassGuitar(dto);
        }
    }
}
