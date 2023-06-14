using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverTimeMVC.Domain.Model
{
    public class WorkTime
    {
        public int Id { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime EndWork { get; set; }
        public bool IsHoliday { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
