using BusinessObject;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        CustomerDAO customerDAO = new CustomerDAO();
        public void GenerateSampleDataSet()
        {
            customerDAO.GenerateSampleDataSet();
        }

        public List<Customer> GetCustomers()
        {
            return customerDAO.GetCustomers();
        }
    }
}
