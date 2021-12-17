using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Menu.Interfaces;
using UppgiftKennel.Person;

namespace UppgiftKennel.Menu
{
    class PersonMenu : IPersonMenu
    {
        public ICustomerManager CustomerManager { get; set; }
        public IListPersons ListPersons { get; set; }
        public PersonMenu(ICustomerManager customerManager, IListPersons listPersons)
        {
            CustomerManager = customerManager;
            ListPersons = listPersons;
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Register Person");
            Console.WriteLine("2) List Persons");
            GetInput();
        }
        private void GetInput()
        {
            var userInput = Console.ReadKey(true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    CustomerManager.ResgisterCustomer();
            break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    ListPersons.ListAllPersons();
                    break;
                default:
                    Console.WriteLine("Wrong Input, please try again!");
            break;
            }
        }
    }
}
