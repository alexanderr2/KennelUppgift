using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Animals;

namespace UppgiftKennel.Factory
{
    class AnimalFactory
    {
        //Fabrik som skapar en ny Animal!
        public static IAnimal Create()
        {
            return new Animal();
        }
    }
}
