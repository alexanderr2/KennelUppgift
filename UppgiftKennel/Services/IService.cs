using UppgiftKennel.Animals;
using UppgiftKennel.Data;

namespace UppgiftKennel.Services
{
    interface IService
    {
        IDatabaseWithLists Db { get; set; }
        IListAnimals ListAnimals { get; set; }
        string Name { get; set; }
        decimal ServicePrice { get; set; }
        void DoService();
    }
}