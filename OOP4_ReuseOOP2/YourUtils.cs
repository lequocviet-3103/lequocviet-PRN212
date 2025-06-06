using Microsoft.VisualBasic;
using OOP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_ReuseOOP2
{
    public static class YourUtils
    {
        public static int Tuoi(this Employee emp)
        {
            return DateTime.Now.Year - emp.Birthday.Year;

        }

        public static bool SinhNhatThangNay(this Employee emp)
        {
            if(DateTime.Now.Month == emp.Birthday.Month)
            {
                return true;
            }
            return false;
        }
    }
}
