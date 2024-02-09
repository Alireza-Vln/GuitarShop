﻿using Microsoft.AspNetCore.Mvc;
using OnlineShopGuitar.DTO;
using OnlineShopGuitar.Entities;
using OnlineShopGuitar.Services.Contracts;

namespace OnlineShopGuitar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BassGuitarController : Controller
    {
        readonly IBassGuitarService _service;
        public BassGuitarController(IBassGuitarService service)
        {
                _service = service;
        }

        [HttpPost("Add-BassGuitar")]

        public void AddBass([FromBody]AddGuitarBassDto dto)
        {
          _service.AddBass(dto);
        }



    }
}