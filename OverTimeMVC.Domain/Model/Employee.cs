using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverTimeMVC.Domain.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Codename { get; set; }
        public string Shift { get; set; }
        public string Login { get; set; }
        public ICollection<WorkTime>? WorkTime { get; set; }
    }
}
