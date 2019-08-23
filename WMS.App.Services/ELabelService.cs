using System.Collections.Generic;
using System.Data;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class ELabelService : IELabelService
    {
        public List<ElectronicLabel> GetAllElectronicLabels()
        {
            using (var db = new WMSContext())
            {
                return db.ElectronicLabels.ToList();
            }
        }

        public List<ElectronicLabel> SearchElectronicLabels()
        {
            using (var db = new WMSContext())
            {
                return db.ElectronicLabels.ToList();
            }
        }

        public List<ElectronicLabel> GetControlledLabelsByAddress(string address)
        {
            using (var db = new WMSContext())
            {
                return db.ElectronicLabels.Where(p => p.LabelAddress == address && p.ParentLabelID != null).ToList();
            }
        }
        public List<ElectronicLabel> GetControlledChannelsByAddress(string address)
        {
            using (var db = new WMSContext())
            {
                return db.ElectronicLabels.Where(p => p.LabelAddress == address && p.ParentLabelID == null).ToList();
            }
        }

        public ElectronicLabel SaveElectronicLabel(ElectronicLabel entity)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.ElectronicLabels.Find(entity.LabelID);
                if (trackedEntity != null)
                {
                    db.Entry(trackedEntity).CurrentValues.SetValues(entity);
                }
                else
                {
                    db.ElectronicLabels.Add(entity);
                }
                db.SaveChanges();
                return entity;
            }
        }

        public bool DeleteElectronicLabel(int entityId)
        {
            using (var db = new WMSContext())
            {
                var trackedEntity = db.ElectronicLabels.Find(entityId);
                if (trackedEntity != null)
                {
                    var labelStructures = db.LabelStructures.Where(p => p.LabelID == entityId).ToList();
                    foreach (var labelStructure in labelStructures)
                    {
                        db.LabelStructures.Remove(labelStructure);
                    }
                    db.Entry(trackedEntity).State = EntityState.Deleted;

                    var rowEffected = db.SaveChanges();
                    return rowEffected > 0;
                }
                return false;
            }
        }

        public bool DeleteElectronicLabelGraph(int entityId)
        {
            using (var db = new WMSContext())
            {
                var trackedEntities = db.ElectronicLabels.Where(p => p.LabelID == entityId || p.ParentLabelID == entityId).ToList();
                if (trackedEntities.Any())
                {
                    foreach (var elabel in trackedEntities)
                    {
                        var labelStructures = db.LabelStructures.Where(p => p.LabelID == elabel.LabelID).ToList();
                        foreach (var labelStructure in labelStructures)
                        {
                            db.LabelStructures.Remove(labelStructure);
                        }
                        db.ElectronicLabels.Remove(elabel);
                    }

                    var rowEffected = db.SaveChanges();
                    return rowEffected > 0;
                }
                return false;
            }
        }
    }
}