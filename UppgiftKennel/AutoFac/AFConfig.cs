using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Data;
using UppgiftKennel.Person;
using UppgiftKennel.Animals;
using UppgiftKennel.Menu;
using System.Reflection;
using UppgiftKennel.Menu.Interfaces;
using UppgiftKennel.Services;

namespace UppgiftKennel.AutoFac
{
    class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();


            // Register one by one    builder.RegisterType<CLASS>().As<INTERFACE>();
            // Register Main Application
            builder.RegisterType<Application>().As<IApplication>();

            //Data
            builder.RegisterType<DatabaseWithLists>().As<IDatabaseWithLists>().SingleInstance();

            //Menu
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .Where(i => i.Namespace.Contains("Menu"))
            //    .As(i => i.GetInterfaces()
            //    .FirstOrDefault(n => n.Name == "I" + i.Name));
            builder.RegisterType<MainMenu>().As<IMainMenu>();
            builder.RegisterType<AnimalMenu>().As<IAnimalMenu>();
            builder.RegisterType<PersonMenu>().As<IPersonMenu>();
            builder.RegisterType<ServiceMenu>().As<IServiceMenu>();

            //Animal
            builder.RegisterType<Animal>().As<IAnimal>();
            builder.RegisterType<AnimalManager>().As<IAnimalManager>();
            builder.RegisterType<AnimalHandler>().As<IAnimalHandler>();
            builder.RegisterType<ListAnimals>().As<IListAnimals>();


            //Person
            builder.RegisterType<Customer>().As<ICustomer>();
            builder.RegisterType<CustomerManager>().As<ICustomerManager>();
            builder.RegisterType<ListPersons>().As<IListPersons>();

            // Services
            builder.RegisterType<Clawclipping>().As<IClawclipping>();
            builder.RegisterType<Cleaning>().As<ICleaning>();

            return builder.Build();
        }
    }
}
