using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public static class Session
    {
        public static Customers CurrentCustomer { get; set; }
        public static Employees CurrentEmployee { get; set; }
    }
}
