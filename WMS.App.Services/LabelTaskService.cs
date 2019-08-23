using System.Collections.Generic;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class LabelTaskService : ILabelTaskService
    {
        public List<LabelTask> GetAllLocalLabelTasks(string address)
        {
            using (var db = new WMSContext())
            {
                var stockOutTasks = db.LabelTasks
                    .Where(p => p.LabelAddress == address
                                && (p.TaskStatus == null || p.TaskStatus == 0))
                    .GroupBy(p => p.StockOutNo)
                    .FirstOrDefault();
                if (null != stockOutTasks)
                {
                    var waitingTasks = from t in stockOutTasks
                        group t by t.LabelCode
                        into g
                        select g.FirstOrDefault();
                    return waitingTasks.ToList();
                }
                return new List<LabelTask>();
            }
        }
        public List<LabelTask> GetAllLabelTasks()
        {
            using (var db = new WMSContext())
            {
                var stockOutTasks = db.LabelTasks
                    .Where(p => p.TaskStatus == null || p.TaskStatus == 0)
                    .GroupBy(p => p.StockOutNo)
                    .FirstOrDefault();
                if (null != stockOutTasks)
                {
                    var waitingTasks = from t in stockOutTasks
                        group t by t.LabelCode
                        into g
                        select g.FirstOrDefault();
                    return waitingTasks.ToList();
                }
                return new List<LabelTask>();
            }
        }

        public void UpdateLabelTask(LabelTask task)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.LabelTasks.Find(task.TaskId);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).CurrentValues.SetValues(task);
                }
                db.SaveChanges();
            }
        }
    }
}