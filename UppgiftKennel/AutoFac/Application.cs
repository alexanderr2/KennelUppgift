using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Data;
using UppgiftKennel.Menu;
using UppgiftKennel.Menu.Interfaces;
using UppgiftKennel.Services;

namespace UppgiftKennel.AutoFac
{
    class Application : IApplication
    {
        //Injectar props för AutoFac
        public IDatabaseWithLists Db { get; set; }
        public IService ClawClipping { get; set; }
        public IService Cleaning { get; set; }
        public IMainMenu MainMenu { get; set; }

        public Application(IMainMenu mainMenu, IDatabaseWithLists databaseWithLists, IClawclipping clawClipping, ICleaning cleaning)
        {
            Db = databaseWithLists;
            MainMenu = mainMenu;
            ClawClipping = clawClipping;
            Cleaning = cleaning;
        }
        public void Run()
        {
            Init();

            while (true)
            {
                MainMenu.ShowMenu();
                MainMenu.GetInput();
            }
        }

        private void Init()
        {
            Db.AvailableServices.Add(ClawClipping);
            Db.AvailableServices.Add(Cleaning);
        }
    }
}
