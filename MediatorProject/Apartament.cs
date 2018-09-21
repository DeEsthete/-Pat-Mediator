using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProject
{
    public class Apartament
    {
        public string Address { get; set; }
        public int Price { get; set; }
        public LandlordPerson Owner { get; set; }
        public RenterPerson Renter { get; set; }
    }
}
