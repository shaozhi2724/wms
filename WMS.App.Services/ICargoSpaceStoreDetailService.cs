using System;
using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface ICargoSpaceStoreDetailService
    {
        List<CargoSpaceStoreDetail> GetAllCargoSpaceStoreDetails();
        List<CargoSpaceStoreDetail> SearchCargoSpaceStoreDetails();
        CargoSpaceStoreDetail SaveCargoSpaceStoreDetail(CargoSpaceStoreDetail entity);
        bool DeleteCargoSpaceStoreDetail(int entityId);
        bool UpdateBatchNo(int detailId, string oldBatchNo, string newBatchNo);
        bool UpdateBatchNo(int detailId, string oldBatchNo, string newBatchNo, DateTime productionDate, DateTime validDate);
        void CleanStore();
        bool UpdateBatchNoAndAmount(int detailId, string oldBatchNo, string newBatchNo, int oldAmount, int newAmount, DateTime productionDate, DateTime validDate, string changeUsername);
        int GetStructureID(string StructureCode);
        bool SaveStoreDetail(int structureID, int productID, string productBatchNumber, DateTime productionDate, DateTime productValidDate, int productAmount, string manufacturer, string dosageForm, string packagingSpecification);
    }
}