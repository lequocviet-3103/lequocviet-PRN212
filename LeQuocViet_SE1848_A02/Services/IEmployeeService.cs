using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IEmployeeService
    {
        public Employee GetEmployeeById(int employeeId);


        public Employee GetEmployeeByUserName(string username);

        public void updateEmployee(Employee employee);
    }
}
