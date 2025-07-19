using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepository
    {
        public Customer GetCustomerByPhone(string phone);
        public Customer GetCustomerById(int customerId);

        public void AddCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);

        public void DeleteCustomer(int customerId);
        public void DeleteCustomer(Customer customer);

        public List<Customer> GetAllCustomers();
        public List<Customer> GetCustomersByContactName(string contactName);
    }
}
