using InterfaceAbstract.Abstract;
using InterfaceAbstract.Adapters;
using InterfaceAbstract.Concrete;
using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());

            customerManager.Save(new Customer
            {
                DateOfBirth = new System.DateTime(1997, 6, 2),
                FirstName = "Dilek",
                LastName = "Sinanoğlu",
                NationalityId = "22222222222",
            });
            Console.ReadLine();
        }
    }
}
