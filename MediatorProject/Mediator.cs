using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProject
{
    public abstract class Mediator
    {
        public abstract void Send(string msg, Person person);
        public abstract void ToRent(LandlordPerson landlord, RenterPerson renter);
    }
}