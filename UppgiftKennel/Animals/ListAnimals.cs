using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Data;

namespace UppgiftKennel.Animals
{
    class ListAnimals : IListAnimals
    {
        public IDatabaseWithLists Db { get; set; }
        public ListAnimals(IDatabaseWithLists databaseWithLists)
        {
            Db = databaseWithLists;
        }
        public void ListAllAnimals()
        {
            Console.Clear();
            Console.WriteLine("Listing all animals and thier owners");
            foreach (var animal in Db.Animals)
            {
                Console.WriteLine($"Animal name: { animal.Name}");
                Console.WriteLine($"Owner last name: {animal.OwnerLastName}");
                Console.WriteLine("----------------------");
            }
            Console.ReadLine();
            Console.WriteLine("Press enter to go back to Main Menu");
            Console.Clear();
            
        }

        public void ListAllDroppedOffAnimals()
        {
            for (int i = 0; i < Db.DroppedOffAnimals.Count; i++)
            {
                Console.WriteLine($"{i+1}  Animal name: {Db.DroppedOffAnimals[i].Name}");
                Console.WriteLine("----------------------");
            }
        }
    }
}
