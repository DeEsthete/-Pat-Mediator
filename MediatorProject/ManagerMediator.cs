using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProject
{
    public class ManagerMediator : Mediator
    {
        public LandlordPerson LandlordPerson { get; set; }
        public RenterPerson RenterPerson { get; set; }
        public override void Send(string msg, Person person)
        {
            if (LandlordPerson == person)
            {
                RenterPerson.Notify(msg);
            }
            else if (RenterPerson == person)
            {
                LandlordPerson.Notify(msg);
            }
        }
        public override void ToRent(LandlordPerson landlord, RenterPerson renter)
        {
            landlord.Apartament.Renter = renter;
            renter.Apartament = landlord.Apartament;
            Console.WriteLine("Сделка успешно удалась!");
        }
    }
}