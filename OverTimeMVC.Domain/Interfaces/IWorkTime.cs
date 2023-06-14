using OverTimeMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverTimeMVC.Domain.Interfaces
{
    public interface IWorkTime
    {
        void DeleteWorkTime(int  workTimeid);
        int AddWorkTime(WorkTime workTime);
        IQueryable<WorkTime> GetWorkTimeByDay(DateTime date);
    }
}
