using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IELabelService
    {
        List<ElectronicLabel> GetAllElectronicLabels();
        List<ElectronicLabel> SearchElectronicLabels();
        List<ElectronicLabel> GetControlledLabelsByAddress(string address);
        ElectronicLabel SaveElectronicLabel(ElectronicLabel entity);
        bool DeleteElectronicLabel(int entityId);
        bool DeleteElectronicLabelGraph(int entityId);
    }
}