using OverTimeMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverTimeMVC.Domain.Interfaces
{
    public interface IEmployee
    {
        void DeleteEmployee(int id);
        int AddEmployee(Employee employee);

    }
}
