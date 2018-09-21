using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerMediator managerMediator = new ManagerMediator();

            LandlordPerson landlord = new LandlordPerson(managerMediator, new Apartament { Address = "Московская 3", Price=12000});
            landlord.Apartament.Owner = landlord;
            RenterPerson renter = new RenterPerson(managerMediator);

            managerMediator.LandlordPerson = landlord;
            managerMediator.RenterPerson = renter;

            landlord.Send("Сдаю в аренду квартиру " + "| Address: " + landlord.Apartament.Address);
            renter.Send("Готов арендовать квартиру!");
            landlord.ToRent(renter);

            Console.ReadLine();
        }
    }
}
