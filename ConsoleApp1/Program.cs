using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accounting_DBEntities db = new Accounting_DBEntities();
            ICustomerRepositories customer = new CustomersRepository(db);

            var list = customer.GetAllCustomers();



        }
    }
}
