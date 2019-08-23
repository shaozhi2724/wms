using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IStorageStructureService
    {
        List<StorageStructure> GetAllStorageStructures();
        List<StorageStructure> GetAllELabelControledStorageStructures();
        List<StorageStructure> SearchStorageStructures();
        StorageStructure GetStorageStructure(int entityId);
        StorageStructure SaveStorageStructure(StorageStructure entity);
        bool DeleteStorageStructure(int entityId);
        bool DeleteStorageStructureGraph(int entityId, string structureCode);
    }
}