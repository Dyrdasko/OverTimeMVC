using OverTimeMVC.Domain.Interfaces;
using OverTimeMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverTimeMVC.Infrastructure.Repositories
{
    public class WorkTimeRepository : IWorkTime
    {
        private readonly WorkTimeDbContext _workTimeDbContext;
        public WorkTimeRepository(WorkTimeDbContext workTimeDbContext)
        {
            _workTimeDbContext = workTimeDbContext;
        }

        public void DeleteWorkTime(int  workTimeId) 
        {
            var work = _workTimeDbContext.WorkTimes.Find(workTimeId);
            if (work != null) 
            {
                _workTimeDbContext.Remove(work);
                _workTimeDbContext.SaveChanges();
            }
        }

        public int AddWorkTime(WorkTime workTime)
        {
            _workTimeDbContext.WorkTimes.Add(workTime);
            _workTimeDbContext.SaveChanges();
            return workTime.Id;
        }

        public IQueryable<WorkTime> GetWorkTimeByDay(DateTime dateOnly)
        {
            var day = _workTimeDbContext.WorkTimes.Where(d => d.StartWork == dateOnly);
            return day;
        }
    }
}
