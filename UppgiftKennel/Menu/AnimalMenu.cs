using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Animals;
using UppgiftKennel.Menu.Interfaces;

namespace UppgiftKennel.Menu
{
    class AnimalMenu : IAnimalMenu
    {
        public IAnimalManager AnimalManager { get; set; }
        public IListAnimals ListAnimals { get; set; }
        public AnimalMenu(IAnimalManager animalManager, IListAnimals listAnimals)
        {
            AnimalManager = animalManager;
            ListAnimals = listAnimals;
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Register Animal");
            Console.WriteLine("2) List Animals");
            GetInput();
        }

        private void GetInput()
        {
            var userInput = Console.ReadKey(true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    AnimalManager.ResgisterAnimal();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    ListAnimals.ListAllAnimals();
                    break;
                default:
                    Console.WriteLine("Wrong Input, please try again!");
                    break;
            }
        }

    }
}
