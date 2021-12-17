using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Animals;
using UppgiftKennel.Data;

namespace UppgiftKennel.Services
{
    class Cleaning : ICleaning
    {
        public IDatabaseWithLists Db { get; set; }
        public IListAnimals ListAnimals { get; set; }
        public string Name { get; set; }
        public decimal ServicePrice { get; set; }
        public Cleaning(IDatabaseWithLists databaseWithLists, IListAnimals listAnimals)
        {
            Db = databaseWithLists;
            ListAnimals = listAnimals;
            Name = "Cleaning";
            ServicePrice = 100;
        }

        public void DoService()
        {
            Console.Clear();
            // listar djur
            Console.WriteLine($"Listing all animals available for Cleaning");
            ListAnimals.ListAllDroppedOffAnimals();
            // väljer djur
            Console.WriteLine("Please enter the number next to your animal");
            bool UserInputIsANumber = int.TryParse(Console.ReadLine(), out int UserInput);
            if (UserInputIsANumber == false)
            {
                Console.WriteLine("Input is not a number");
            }
            else
            {
                if (UserInput > Db.DroppedOffAnimals.Count || UserInput < 1)
                {
                    Console.WriteLine("Input is not an animal in our list");
                }
                else
                {
                    var selectedAnimal = Db.DroppedOffAnimals[UserInput-1];
                    // Lägg till ServicePrice på selesctedAnimal.Price
                    selectedAnimal.Price = ServicePrice + selectedAnimal.Price;
                    // lägger till den här servicen i det valda djurets UsedServices
                    selectedAnimal.UsedServices.Add(this);

                    Console.WriteLine("Press enter to go back to Main Menu");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
