using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProject
{
    public class RenterPerson : Person
    {
        public Apartament Apartament { get; set; }
        public RenterPerson(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение арендовщику: " + message);
        }
    }
}
