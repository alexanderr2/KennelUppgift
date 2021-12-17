using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKennel.Person;

namespace UppgiftKennel.Factory
{
    static class CustomerFactory
    {
        //Fabrik som skapar en ny Customer!
        public static ICustomer Create()
        {
            return new Customer();
        }
    }
}
