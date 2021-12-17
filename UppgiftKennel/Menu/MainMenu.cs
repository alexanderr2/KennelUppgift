using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Animals;
using UppgiftKennel.Menu.Interfaces;
using UppgiftKennel.Person;

namespace UppgiftKennel.Menu
{
    class MainMenu : IMainMenu
    {
        public ICustomerManager CustomerManager { get; set; }
        public IPersonMenu PersonMenu { get; set; }
        public IAnimalMenu AnimalMenu { get; set; }
        public IServiceMenu ServiceMenu { get; set; }
        public IAnimalHandler AnimalHandler { get; set; }
        public MainMenu(ICustomerManager customerManager, IPersonMenu personMenu, IAnimalMenu animalMenu, IServiceMenu serviceMenu, IAnimalHandler animalHandler)
        {
            CustomerManager = customerManager;
            PersonMenu = personMenu;
            AnimalMenu = animalMenu;
            ServiceMenu = serviceMenu;
            AnimalHandler = animalHandler;
        }
        public void ShowMenu()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("This is the best Kennel in the world!");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Please choose an option below!");
            Console.WriteLine("1) Person");
            Console.WriteLine("2) Animal");
            Console.WriteLine("3) Drop off");
            Console.WriteLine("4) Pick up");
            Console.WriteLine("5) Our services");
        }

        public void GetInput()
        {
            var userInput = Console.ReadKey(true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    PersonMenu.ShowMenu();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    AnimalMenu.ShowMenu();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    AnimalHandler.DropOff();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    AnimalHandler.PickUp();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    ServiceMenu.ShowMenu();
                    break;
                default:
                    Console.WriteLine("Wrong Input, please try again!");
                    break;
            }
        }

    }
}
