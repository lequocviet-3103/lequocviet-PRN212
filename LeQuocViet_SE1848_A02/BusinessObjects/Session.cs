using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public static class Session
    {
        public static Employee CurrentEmployee { get; set; }
        public static Customer CurrentCustomer { get; set; }
    }
}
