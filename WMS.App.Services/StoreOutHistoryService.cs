using System.Collections.Generic;
using System.Data;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class StoreOutHistoryService : IStoreOutHistoryService
    {
        public List<StoreOutHistory> GetAllStoreOutHistories()
        {
            using (var db = new WMSContext())
            {
                return db.StoreOutHistories.ToList();
            }
        }

        public List<StoreOutHistory> SearchStoreOutHistories()
        {
            using (var db = new WMSContext())
            {
                return db.StoreOutHistories.ToList();
            }
        }

        public StoreOutHistory SaveStoreOutHistory(StoreOutHistory entity)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.StoreOutHistories.Find(entity.StoreOutHistoryID);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).CurrentValues.SetValues(entity);
                }
                else
                {
                    db.StoreOutHistories.Add(entity);
                }
                db.SaveChanges();
                return entity;
            }
        }

        public bool DeleteStoreOutHistory(int entityId)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.StoreOutHistories.Find(entityId);
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