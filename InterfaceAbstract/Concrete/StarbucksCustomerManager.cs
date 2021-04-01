using InterfaceAbstract.Abstract;
using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace InterfaceAbstract.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private Abstract.ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(Abstract.ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
       
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
                base.Save(customer);
            else throw new Exception("Not a valid person");
        }
    }
}
