using Microsoft.AspNetCore.Mvc;
using OnlineShop.Services.Factors.Cantracts;
using OnlineShop.Services.Factors.Cantracts.Dtos;

namespace OnlineShop.RestApi.Controllers.Factors
{
    [ApiController]
    [Route("api/Factor")]
    public class FactorController : Controller
    {
    readonly FactorService _Service;
        public FactorController(FactorService service)
        {
            _Service = service;
        }
        [HttpPost]
        public async Task AddFactor([FromQuery] int userId,
                                     [FromQuery] string brand,
                                     [FromQuery] string model)
                                   
        {

           await _Service.AddFactor(userId,brand,model);
        }
    }
}
