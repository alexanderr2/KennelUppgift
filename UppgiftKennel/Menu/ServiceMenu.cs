using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Data;
using UppgiftKennel.Menu.Interfaces;
using UppgiftKennel.Services;

namespace UppgiftKennel.Menu
{
    class ServiceMenu : IServiceMenu
    {
        public IDatabaseWithLists Db { get; set; }
        public IClawclipping Clawclipping { get; set; }
        public ICleaning Cleaning { get; set; }
        //public ICleaning Cleaning { get; set; }
        public ServiceMenu(IDatabaseWithLists databaseWithLists, IClawclipping clawClipping, ICleaning cleaning)
        {
            Db = databaseWithLists;
            Clawclipping = clawClipping;
            Cleaning = cleaning;
        }
        public void ShowMenu()
        {
            Console.Clear();
            for (int i = 0; i < Db.AvailableServices.Count; i++)
            {
                Console.WriteLine($"{i+1}: {Db.AvailableServices[i].Name}");
            }
                GetInput();
        }
            private void GetInput()
            {
                var userInput = Console.ReadKey(true).Key;
                switch (userInput)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Clawclipping.DoService();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Cleaning.DoService();
                        break;
                    default:
                            Console.WriteLine("Wrong Input, please try again!");
                            break;
                }
            }
    }
}
