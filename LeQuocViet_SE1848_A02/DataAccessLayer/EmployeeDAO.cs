using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EmployeeDAO
    {
        public Employee GetEmployeeById(int employeeId)
        {
            using var context = new LucySalesDataContext();
            return context.Employees
                .FirstOrDefault(e => e.EmployeeId == employeeId);
        }


        public Employee GetEmployeeByUserName(string username)
        {
            using var context = new LucySalesDataContext();
            return context.Employees.FirstOrDefault(u => u.UserName.Equals(username));
        }

        public void updateEmployee(Employee emp)
        {
            using var context = new LucySalesDataContext(); // Tạo context mới      
            var dbEmp = context.Employees.FirstOrDefault(e => e.EmployeeId == emp.EmployeeId);
            if (dbEmp != null)
            {
                dbEmp.Name = emp.Name;
                dbEmp.UserName = emp.UserName;
                dbEmp.Password = emp.Password;
                dbEmp.JobTitle = emp.JobTitle;
                dbEmp.BirthDate = emp.BirthDate;
                dbEmp.HireDate = emp.HireDate;
                dbEmp.Address = emp.Address;
                context.SaveChanges();
            }
        }




    }
}
