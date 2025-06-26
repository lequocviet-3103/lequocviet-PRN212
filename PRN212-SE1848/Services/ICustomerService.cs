using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICustomerService
    {
        public void GenerateSampleDataSet();
        public List<Customer> GetCustomers();
    }
}
