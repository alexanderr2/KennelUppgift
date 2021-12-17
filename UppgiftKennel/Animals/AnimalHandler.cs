using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Data;
using UppgiftKennel.Factory;
using UppgiftKennel.Services;

namespace UppgiftKennel.Animals
{
    class AnimalHandler : IAnimalHandler
    {
        public IDatabaseWithLists Db { get; set; }
        public IListAnimals ListAnimals { get; set; }
        public IService ClawClipping { get; set; }
        public IAnimal Animal { get; set; }
        public AnimalHandler(IDatabaseWithLists databaseWithLists, IListAnimals listAnimals, IAnimal animal, IClawclipping clawClipping)
        {
            Db = databaseWithLists;
            ListAnimals = listAnimals;
            Animal = animal;
            ClawClipping = clawClipping;
        }
        public void DropOff()
        {
            Console.WriteLine("Please enter the name of your animal");
            string animalName = Console.ReadLine();
            var selectedAnimal = Db.Animals.Where(s => s.Name.ToLower() == animalName.ToLower()).FirstOrDefault();
            Db.DroppedOffAnimals.Add(selectedAnimal);

        }

        public void PickUp()
        {
            Console.Clear();
            Console.WriteLine("Listing all animals");
            ListAnimals.ListAllDroppedOffAnimals();
            Console.WriteLine("Enter the number next to your animal to pick up for Kennel");
            int RemoveAnimal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Reciet");
            Console.WriteLine("Kennel daily cost: 150");
            RemoveAnimal = RemoveAnimal - 1;
            if (Db.DroppedOffAnimals[RemoveAnimal].Price == 150)
            {
                Console.WriteLine("Total cost is 150");
            }
            else
            {
                for (int i = 0; i < Db.Animals[RemoveAnimal].UsedServices.Count; i++)
                {
                    Console.WriteLine($"Service name: {Db.Animals[RemoveAnimal].UsedServices[i].Name}");
                    Console.WriteLine($"Service price: {Db.Animals[RemoveAnimal].UsedServices[i].ServicePrice}");
                }
                Console.WriteLine($"Total cost for your animal: {Db.Animals[RemoveAnimal].Price}");
                Console.ReadLine();
            }
            Db.Animals[RemoveAnimal].Price = 150;
            Db.Animals[RemoveAnimal].UsedServices.Clear();
            
            Db.DroppedOffAnimals.RemoveAt(RemoveAnimal);
            

            Console.WriteLine("Press enter to go back to Main Menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
