using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Data;
using UppgiftKennel.Factory;

namespace UppgiftKennel.Animals
{
    class AnimalManager : IAnimalManager
    {
        public IDatabaseWithLists Db { get; set; }
        public AnimalManager(IDatabaseWithLists databaseWithLists)
        {
            Db = databaseWithLists;
        }
        public void ResgisterAnimal()
        {
            //Kallar på Create funktionen som gör en ny customer.
            IAnimal animal = AnimalFactory.Create();

            Console.Clear();
            Console.WriteLine("Please enter the animals name.");
            animal.Name = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            animal.OwnerLastName = Console.ReadLine();

            Console.WriteLine("Please enter what kind of animal you own.");
            animal.TypeOfAnimal = Console.ReadLine();

            Db.Animals.Add(animal);
            Console.WriteLine($"{animal.Name} added!");
            Console.WriteLine("Press enter to go back to Main Menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
