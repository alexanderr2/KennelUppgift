using System.Collections.Generic;
using UppgiftKennel.Animals;
using UppgiftKennel.Person;
using UppgiftKennel.Services;

namespace UppgiftKennel.Data
{
    interface IDatabaseWithLists
    {
        List<ICustomer> Customers { get; set; }
        List<IAnimal> Animals { get; set; }
        List<IAnimal> DroppedOffAnimals { get; set; }
        List<IService> AvailableServices { get; set; }
    }
}