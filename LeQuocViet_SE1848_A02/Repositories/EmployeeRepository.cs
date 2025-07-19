using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeDAO employeeDAO = new EmployeeDAO();

        

        public Employee GetEmployeeById(int employeeId)
        {
            return employeeDAO.GetEmployeeById(employeeId);
        }

        public Employee GetEmployeeByUserName(string username)
        {
            return employeeDAO.GetEmployeeByUserName(username);
        }
        public void updateEmployee(Employee employee)
        {
            employeeDAO.updateEmployee(employee);
        }


    }
}
