using System.Collections.Generic;
using System.Data;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class InventoryDemolitionService : IInventoryDemolitionService
    {
        public List<InventoryDemolition> GetAllInventoryDemolitions()
        {
            using (var db = new WMSContext())
            {
                return db.InventoryDemolitions.ToList();
            }
        }

        public List<InventoryDemolition> SearchInventoryDemolitions()
        {
            using (var db = new WMSContext())
            {
                return db.InventoryDemolitions.ToList();
            }
        }

        public InventoryDemolition SaveInventoryDemolition(InventoryDemolition entity)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.InventoryDemolitions.Find(entity.DemolitionID);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).CurrentValues.SetValues(entity);
                }
                else
                {
                    db.InventoryDemolitions.Add(entity);
                }
                db.SaveChanges();
                return entity;
            }
        }

        public bool DeleteInventoryDemolition(int entityId)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.InventoryDemolitions.Find(entityId);
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