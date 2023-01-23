using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Accounting.DataLayer.Context
{
    public class UnitOfWork:IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();

        private ICustomerRepositories _customerRepositories;

        public ICustomerRepositories CustomerRepository {
            get 
            {
                if (_customerRepositories == null)
                {
                    _customerRepositories = new CustomersRepository (db);

                }
               return _customerRepositories;
            } 
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
