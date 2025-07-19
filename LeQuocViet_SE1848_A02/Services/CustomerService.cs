using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository iCustomerRepository;
        public CustomerService()
        {
            iCustomerRepository = new CustomerRepository();
        }

        public Customer GetCustomerById(int customerId)
        {
            return iCustomerRepository.GetCustomerById(customerId);
        }

        public Customer GetCustomerByPhone(string phone)
        {
           return iCustomerRepository.GetCustomerByPhone(phone);
        }

        public void AddCustomer(Customer customer)
        {
            iCustomerRepository.AddCustomer(customer);
        }

        public void DeleteCustomer(int customerId)
        {
            iCustomerRepository.DeleteCustomer(customerId);
        }

        public void DeleteCustomer(Customer customer)
        {
            iCustomerRepository.DeleteCustomer(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return iCustomerRepository.GetAllCustomers();
        }

       

        public void UpdateCustomer(Customer customer)
        {
            iCustomerRepository.UpdateCustomer(customer);
        }

        public List<Customer> GetCustomersByContactName(string contactName)
        {
            return iCustomerRepository.GetCustomersByContactName(contactName);
        }

    }
}
