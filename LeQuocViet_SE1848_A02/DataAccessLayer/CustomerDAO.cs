using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        public Customer GetCustomerByPhone(string phone)
        {
            using var context = new LucySalesDataContext();
            return context.Customers
                .FirstOrDefault(c => c.Phone.Equals(phone));
        }
        public Customer GetCustomerById(int customerId)
        {
            using var context = new LucySalesDataContext();
            return context.Customers
                .FirstOrDefault(c => c.CustomerId == customerId);
        }

        public void AddCustomer(Customer customer)
        {
            using var context = new LucySalesDataContext();
            context.Customers.Add(customer);
            context.SaveChanges();
        }
        public void UpdateCustomer(Customer customer)
        {
            using var context = new LucySalesDataContext();
            context.Customers.Update(customer);
            context.SaveChanges();
        }

        public void DeleteCustomer(int customerId)
        {
            using var context = new LucySalesDataContext();
            var customer = context.Customers.Find(customerId);
            if (customer != null)
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }
        public void DeleteCustomer(Customer customer)
        {
            using var context = new LucySalesDataContext();
            var cus = context.Customers
                .Include(o => o.Orders)
                .ThenInclude(o => o.OrderDetails)
                .FirstOrDefault(c => c.CustomerId == customer.CustomerId);
            if (cus != null)
            {
                foreach (var order in cus.Orders)
                {
                    context.OrderDetails.RemoveRange(order.OrderDetails);
                }
                context.Orders.RemoveRange(cus.Orders);
                context.Customers.Remove(cus);
                context.SaveChanges();
            }
        }

        public List<Customer> GetAllCustomers()
        {
            using var context = new LucySalesDataContext();
            return context.Customers.ToList();
        }

        public List<Customer> GetCustomersByContactName(string contactName)
        {
            using var context = new LucySalesDataContext();
            return context.Customers
        .Where(c => c.ContactName != null &&
               c.ContactName.ToLower().Contains(contactName.ToLower()))
        .ToList();
        }
    }
}
