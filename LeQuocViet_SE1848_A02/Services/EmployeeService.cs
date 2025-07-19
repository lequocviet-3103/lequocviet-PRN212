using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository iEmployeeRepository;
        public EmployeeService()
        {
            iEmployeeRepository = new EmployeeRepository();
        }

       

        public Employee GetEmployeeById(int employeeId)
        {
            return iEmployeeRepository.GetEmployeeById(employeeId);
        }

        public Employee GetEmployeeByUserName(string username)
        {
            return iEmployeeRepository.GetEmployeeByUserName(username);
        }


        public void updateEmployee(Employee employee)
        {
            iEmployeeRepository.updateEmployee(employee);
        }
    }
}
