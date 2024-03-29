﻿using Cantracts;
using OnlineShop.Entities;
using OnlineShop.Services.Factors.Cantracts;
using OnlineShop.Services.Factors.Cantracts.Dtos;
using OnlineShopGuitar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services.Factors
{
    public class FactorAppService : FactorService
    {
        private readonly FactorRepository _repository;
        private readonly UnitOfWork _unitOfWork;
        public FactorAppService(FactorRepository repository, UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task AddFactor(int userId, string brand, string model)
        {
            if (_repository.IsExistUser(userId) == null)
            {
                throw new Exception("not found");

            }
            if (_repository.IsExistGuitar(brand, model) == null)
            {
                throw new Exception("not Found");
            }
            var factor = new Factor
            {
                Name = _repository.IsExistUser(userId).FirstName +
                 " " + _repository.IsExistUser(userId).LastName,
                Brand = brand,
                Model = model,
                CreateAt = DateTime.Now,
                UserId = userId,
                Price=_repository.IsExistGuitar(brand,model).Price,

            };
            _repository.AddFactor(factor);
            await _unitOfWork.Complete();

        }


    }
}
