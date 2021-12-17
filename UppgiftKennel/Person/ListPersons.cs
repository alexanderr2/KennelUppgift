using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Data;

namespace UppgiftKennel.Person
{
    class ListPersons : IListPersons
    {
        public IDatabaseWithLists Db { get; set; }
        public ListPersons(IDatabaseWithLists databaseWithLists)
        {
            Db = databaseWithLists;
        }
        public void ListAllPersons()
        {
            Console.Clear();
            Console.WriteLine("Listing all persons");
            foreach (var person in Db.Customers)
            {
                Console.WriteLine($"Person first name: { person.FirstName}");
                Console.WriteLine($"Person last name: {person.LastName}");
                Console.WriteLine($"Person phone number: {person.PhoneNumber}");
                Console.WriteLine("----------------------");
            }
            Console.ReadLine();
            Console.WriteLine("Press enter to go back to Main Menu");
            Console.Clear();

        }
    }
}
