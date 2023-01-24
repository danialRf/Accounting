using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepositories
    {
        List<Customers> GetAllCustomers();
        IEnumerable<Customers> GetCustomersByFilter (string parameter);

        Customers GetCustomersById(int customerID);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);

        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerID);
        void save();
    }
}
