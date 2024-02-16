using OnlineShopGuitar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services.Factors.Cantracts.Dtos
{
     public class AddFactorDto
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreateAt { get; set; }
        public int UserId { get; set; }

       // public User User { get; set; }
      //  public BassGuitar Guitar { get; set; }

    }
}
