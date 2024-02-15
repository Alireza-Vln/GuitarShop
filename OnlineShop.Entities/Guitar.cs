using OnlineShopGuitar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Entities
{
    public class Guitar
    {
        public int Id { get; set; }
        public string GuitarName { get; set; }
        public HashSet<BassGuitar> BassGuitars { get; set; }
        public HashSet<ClassicGuitar> ClassicGuitars { get; set; }
        public HashSet<AcousticGuitar> AcousticGuitars  { get; set; }
        public HashSet<ElectricGuitar> ElectricGuitars{ get; set; }
    }
}
