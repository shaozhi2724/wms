using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class LabelStructureService : ILabelStructureService
    {
        public List<LabelStructure> GetAllLabelStructures()
        {
            using (var db = new WMSContext())
            {
                return db.LabelStructures.ToList();
            }
        }

        public List<LabelStructure> SearchElectronicLabels()
        {
            using (var db = new WMSContext())
            {
                return db.LabelStructures.ToList();
            }
        }

        public LabelStructure SaveLabelStructure(LabelStructure entity)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.LabelStructures.FirstOrDefault(p => p.StructureID == entity.StructureID);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).CurrentValues.SetValues(entity);
                }
                else
                {
                    db.LabelStructures.Add(entity);
                }
                db.SaveChanges();
                return entity;
            }
        }
        public void SaveLabelStructures(List<LabelStructure> entities)
        {
            using (var db = new WMSContext())
            {
                foreach (var entity in entities)
                {
                    var trackedEntity =
                        db.LabelStructures.FirstOrDefault(
                            p => p.StructureID == entity.StructureID);
                    if (trackedEntity != null)
                    {
                        db.LabelStructures.Remove(trackedEntity);

                        entity.CreateDate = DateTime.Now;
                        db.LabelStructures.Add(entity);
                        //db.Entry(trackedEntity).CurrentValues.SetValues(entity);
                    }
                    else
                    {
                        entity.CreateDate = DateTime.Now;
                        db.LabelStructures.Add(entity);
                    }
                }

                db.SaveChanges();
            }
        }

        public bool DeleteLabelStructure(LabelStructure entity)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.LabelStructures.FirstOrDefault(p => p.LabelID == entity.LabelID && p.StructureID == entity.StructureID);
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