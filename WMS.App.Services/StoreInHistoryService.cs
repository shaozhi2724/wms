using System.Collections.Generic;
using System.Data;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class StoreInHistoryService : IStoreInHistoryService
    {
        public List<StoreInHistory> GetAllStoreInHistories()
        {
            using (var db = new WMSContext())
            {
                return db.StoreInHistories.ToList();
            }
        }

        public List<StoreInHistory> SearchStoreInHistories()
        {
            using (var db = new WMSContext())
            {
                return db.StoreInHistories.ToList();
            }
        }

        public StoreInHistory SaveStoreInHistory(StoreInHistory entity)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.StoreInHistories.Find(entity.StoreInHistoryID);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).CurrentValues.SetValues(entity);
                }
                else
                {
                    db.StoreInHistories.Add(entity);
                }
                db.SaveChanges();
                return entity;
            }
        }

        public bool DeleteStoreInHistory(int entityId)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.StoreInHistories.Find(entityId);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).State = EntityState.Deleted;
                    var rowEffected = db.SaveChanges();
                    return rowEffected > 0;
                }
                return false;
            }
        }
    }
}