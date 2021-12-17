using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Animals;
using UppgiftKennel.Person;
using UppgiftKennel.Services;

namespace UppgiftKennel.Data
{
    class DatabaseWithLists : IDatabaseWithLists
    {
        // TODO: Allt som handlar om Room måste göras om till relevans med KENNEL, frågan är om det ens behövs, tex om man lägger in Animals och Customers direkt i en lista?
        public List<ICustomer> Customers { get; set; }
        public List<IAnimal> Animals { get; set; }
        public List<IAnimal> DroppedOffAnimals { get; set; }
        public List<IService> AvailableServices { get; set; }

        public DatabaseWithLists()
        {
            Customers = new List<ICustomer>();
            Animals = new List<IAnimal>();
            DroppedOffAnimals = new ();
            AvailableServices = new List<IService>();
        }   
    }
}
