using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface ILabelStructureService
    {
        List<LabelStructure> GetAllLabelStructures();
        List<LabelStructure> SearchElectronicLabels();
        LabelStructure SaveLabelStructure(LabelStructure entity);
        void SaveLabelStructures(List<LabelStructure> dirtyLabelStructures);
        bool DeleteLabelStructure(LabelStructure entityId);
    }
}