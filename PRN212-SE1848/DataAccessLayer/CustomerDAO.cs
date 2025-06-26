using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        static List<Customer> customers = new List<Customer>();
        
        public void GenerateSampleDataSet()
        {
            customers.Add(new Customer() { Id = 1, Name = "Obama", Phone = "0321245", Email = "obama@gmail.com" });
            customers.Add(new Customer() { Id = 2, Name = "Putin", Phone = "0333333333", Email = "putin@gmail.com" });
            customers.Add(new Customer() { Id = 3, Name = "Kim", Phone = "034444444", Email = "kim@gmail.com" });
            customers.Add(new Customer() { Id = 4, Name = "Trump", Phone = "035555555", Email = "trump@gmail.com" });
            customers.Add(new Customer() { Id = 5, Name = "Jong", Phone = "0366666", Email = "jong@gmail.com" });


        }
        public List<Customer> GetCustomers()
        {

            return customers;
        }

    }
}
