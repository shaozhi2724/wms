using System.Collections.Generic;
using System.Data;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class ProductStructureService : IProductStructureService
    {
        public List<ProductStructure> GetAllProductStructures()
        {
            using (var db = new WMSContext())
            {
                return db.ProductStructures.ToList();
            }
        }

        public List<ProductStructure> SearchProductStructures()
        {
            using (var db = new WMSContext())
            {
                return db.ProductStructures.ToList();
            }
        }

        public ProductStructure SaveProductStructure(ProductStructure entity)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.ProductStructures.Find(entity.ProductID);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).CurrentValues.SetValues(entity);
                }
                else
                {
                    db.ProductStructures.Add(entity);
                }
                db.SaveChanges();
                return entity;
            }
        }

        public bool DeleteProductStructure(int entityId)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.ProductStructures.Find(entityId);
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