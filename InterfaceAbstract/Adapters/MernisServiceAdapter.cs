using InterfaceAbstract.Abstract;
using InterfaceAbstract.Entities;
using InterfaceAbstract.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        //Mernis TC Dogrulama
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(
                Convert.ToInt64(customer.NationalityId), 
                customer.FirstName.ToUpper(), 
                customer.LastName.ToUpper(),
                customer.DateOfBirth.Year);
        }
    }
}
