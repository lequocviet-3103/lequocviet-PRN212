﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepository
    {
        public void GenerateSampleDataSet();
        public List<Customer> GetCustomers();
    }
}
