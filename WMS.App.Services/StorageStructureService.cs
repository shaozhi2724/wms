using System.Collections.Generic;
using System.Data;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class StorageStructureService : IStorageStructureService
    {
        public List<StorageStructure> GetAllStorageStructures()
        {
            using (var db = new WMSContext())
            {
                return db.StorageStructures.ToList();
            }
        }
        public List<StorageStructure> GetAllELabelControledStorageStructures()
        {
            using (var db = new WMSContext())
            {
                return db.StorageStructures.Where(p => p.StructureStyle == 1).ToList();
            }
        }

        public List<StorageStructure> SearchStorageStructures()
        {
            using (var db = new WMSContext())
            {
                return db.StorageStructures.ToList();
            }
        }

        public StorageStructure SaveStorageStructure(StorageStructure entity)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.StorageStructures.Find(entity.StructureID);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).CurrentValues.SetValues(entity);
                }
                else
                {
                    db.StorageStructures.Add(entity);
                }
                db.SaveChanges();
                return entity;
            }
        }

        public bool DeleteStorageStructure(int entityId)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.StorageStructures.Find(entityId);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).State = EntityState.Deleted;
                    var rowEffected = db.SaveChanges();
                    return rowEffected > 0;
                }
                return false;
            }
        }
        public bool DeleteStorageStructureGraph(int entityId, string structureCode)
        {
            using (var db = new WMSContext())
            {
                var trackedEntities = db.StorageStructures.Where(p => p.StructureID == entityId || p.ParentStructureCode == structureCode).ToList();
                if (trackedEntities.Any())
                {
                    foreach (var storageStructure in trackedEntities)
                    {
                        var trackedSubEntities = db.StorageStructures.Where(p => p.ParentStructureCode == storageStructure.StructureCode).ToList();
                        foreach (var trackedSubEntity in trackedSubEntities)
                        {
                            var subEntities = db.StorageStructures.Where(p => p.ParentStructureCode == trackedSubEntity.StructureCode).ToList();
                            foreach (var subEntity in subEntities)
                            {
                                DeleteLabelStructure(subEntity.StructureID);
                                db.StorageStructures.Remove(subEntity);
                            }

                            DeleteLabelStructure(trackedSubEntity.StructureID);
                            db.StorageStructures.Remove(trackedSubEntity);
                        }

                        DeleteLabelStructure(storageStructure.StructureID);
                        db.StorageStructures.Remove(storageStructure);
                    }

                    var rowEffected = db.SaveChanges();
                    return rowEffected > 0;
                }
                return false;
            }
        }

        public StorageStructure GetStorageStructure(int entityId)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.StorageStructures.Find(entityId);
                return trackedEntity;
            }
        }


        private bool DeleteLabelStructure(int structureID)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.LabelStructures.FirstOrDefault(p => p.StructureID == structureID);
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