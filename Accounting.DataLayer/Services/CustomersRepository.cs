using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;

namespace Accounting.DataLayer.Services
{
    public class CustomersRepository : ICustomerRepositories
    {
        Accounting_DBEntities db = new Accounting_DBEntities();
        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
                return true;

            }
            catch
            { return false; }
        }

        public bool DeleteCustomer(int customerID)
        {
            try
            {
                var customer = GetCustomersById(customerID);
                DeleteCustomer(customer);
                return true;

            }
            catch
            { return false; }
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customers GetCustomersById(int customerID)
        {
            return db.Customers.Find(customerID);
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                return true;

            }
            catch
            { return false; }


        }

        public void save()
        {
            db.SaveChanges();
        }


    }
}
