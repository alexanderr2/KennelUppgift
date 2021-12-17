using UppgiftKennel.Person;

namespace UppgiftKennel.Menu.Interfaces
{
    interface IMainMenu : IMenu
    {
        ICustomerManager CustomerManager { get; set; }

        void GetInput();
    }
}