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
        readonly IBassGuitarService _service;
        public BassGuitarController(IBassGuitarService service)
        {
            _service = service;
        }



        [HttpPost("Add-BassGuitar")]
        public void AddBass([FromBody] AddGuitarBassDto dto)
        {
            _service.AddBass(dto);
        }


        [HttpGet("Get-AllBassGuitar")]
        public List<BassGuitar> GetAllBassGuitars()
        {
            return _service.GetAllBassGuitars();
        }


        [HttpDelete("Delete-BassGuitar")]
        public List<BassGuitar> DeleteBassGuitar([FromQuery] DeleteBassGuitarDto dto)
        {
            return _service.DeleteBassGuitar(dto);
        }

        [HttpPatch("Update-BassGuitarPrice")]
        public void UpdateBassGuitarPrice([FromQuery] UpdateBassGuitarPriceDto dto)
        {
            _service.UpdateBassGuitar(dto);
        }
    }
}
