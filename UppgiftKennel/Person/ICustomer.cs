using System;

namespace UppgiftKennel.Person
{
    interface ICustomer
    {
        string FirstName { get; set; }
        Guid ID { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
    }
}