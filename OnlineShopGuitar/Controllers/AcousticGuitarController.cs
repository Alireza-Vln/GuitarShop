﻿using Microsoft.AspNetCore.Mvc;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Controllers
{
    [ApiController]
    [Route("Api/AcousticGuitar")]
    public class AcousticGuitarController : Controller
    {
        private readonly IAcousticGuitarService _service;
        public AcousticGuitarController(IAcousticGuitarService service)
        {
            _service = service;
        }
        [HttpPost("Add-AcoutsicGuitar")]
        public void AddAcoustic([FromBody]AddAcousticGuitarDto dto)
        {
            _service.AddAcoustic(dto);
        }
        [HttpGet("GetAllAcousticGuitar")]
        public List<AcousticGuitar> GetAcousticGuitars()
        {
            return _service.GetAllAcousticGuitars();
        }
    }
}