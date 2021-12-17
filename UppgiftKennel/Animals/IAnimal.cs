using System;
using System.Collections.Generic;
using UppgiftKennel.Services;

namespace UppgiftKennel.Animals
{
    interface IAnimal
    {
        Guid ID { get; set; }
        string Name { get; set; }
        string Notes { get; set; }
        public decimal Price { get; set; }
        string OwnerLastName { get; set; }
        public string TypeOfAnimal { get; set; }
        List<IService> UsedServices { get; set; }
    }
}