using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerDAO customerDAO = new CustomerDAO();
        public Customer GetCustomerById(int customerId)
        {
            return customerDAO.GetCustomerById(customerId);
        }

        public Customer GetCustomerByPhone(string phone)
        {
            return customerDAO.GetCustomerByPhone(phone);
        }

        public void AddCustomer(Customer customer)
        {
            customerDAO.AddCustomer(customer);
        }

        public void DeleteCustomer(int customerId)
        {
            customerDAO.DeleteCustomer(customerId);
        }

        public void DeleteCustomer(Customer customer)
        {
            customerDAO.DeleteCustomer(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return customerDAO.GetAllCustomers();
        }       

        

        public void UpdateCustomer(Customer customer)
        {
            customerDAO.UpdateCustomer(customer);
        }

        public List<Customer> GetCustomersByContactName(string contactName)
        {
            return customerDAO.GetCustomersByContactName(contactName);
        }
    }
}
