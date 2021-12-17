using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Services;

namespace UppgiftKennel.Animals
{
    class Animal : IAnimal
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string OwnerLastName { get; set; }
        public string TypeOfAnimal { get; set; }
        public decimal Price { get; set; }
        public List<IService> UsedServices { get; set; }

        public Animal()
        {
            ID = Guid.NewGuid();
            Price = 150;
            UsedServices = new List<IService>();
        }
    }
}
