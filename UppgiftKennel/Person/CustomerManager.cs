using System;
using UppgiftKennel.Data;
using UppgiftKennel.Factory;

namespace UppgiftKennel.Person
{
    internal class CustomerManager : ICustomerManager
    {
        public IDatabaseWithLists Db { get; set; }
        public CustomerManager(IDatabaseWithLists databaseWithLists)
        {
            Db = databaseWithLists;
        }
        public void ResgisterCustomer()
        {
            //Kallar på Create funktionen som gör en ny customer.
            ICustomer customer = CustomerFactory.Create();

            Console.Clear();
            Console.WriteLine("Please enter your first name.");
            customer.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            customer.LastName = Console.ReadLine();

            Console.WriteLine("Please enter your phone number with 10 digits.");
            customer.PhoneNumber = Console.ReadLine();

            Db.Customers.Add(customer);
            Console.WriteLine($"{customer.FirstName} {customer.LastName} added!");
            Console.WriteLine("Press enter to go back to Main Menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}