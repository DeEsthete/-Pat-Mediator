using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProject
{
    public class LandlordPerson : Person
    {
        public Apartament Apartament { get; set; }
        public LandlordPerson(Mediator mediator, Apartament apartament) : base(mediator)
        {
            Apartament = apartament;
        }

        public void ToRent(RenterPerson renter)
        {
            mediator.ToRent(this, renter);
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение арендатору: " + message);
        }
    }
}
