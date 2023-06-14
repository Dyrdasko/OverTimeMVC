using OverTimeMVC.Domain.Interfaces;
using OverTimeMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverTimeMVC.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployee
    {
        private readonly WorkTimeDbContext _workTimeDbContext;
        public EmployeeRepository(WorkTimeDbContext workTimeDbContext)
        {
            _workTimeDbContext = workTimeDbContext;
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = _workTimeDbContext.Employees.Find(employeeId);
            if (employee != null)
            {
                _workTimeDbContext.Employees.Remove(employee);
                _workTimeDbContext.SaveChanges();
            }
        }

        public int AddEmployee(Employee employee)
        {
            _workTimeDbContext.Employees.Add(employee);
            _workTimeDbContext.SaveChanges();
            return employee.Id;
        }

    }
}
