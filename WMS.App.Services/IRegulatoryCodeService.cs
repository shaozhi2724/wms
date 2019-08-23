using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IRegulatoryCodeService
    {
        int ImportCodes(List<CodeViewModel> codes, string corpCode);

        List<ExportTicketViewModel> GenExportTickets();
        void UpdateCodesStatusToExported(List<string> codes);

        RegulatoryCodeStatisticViewMode GetStatistics();
        void SaveScannedRegulatoryCodes(StoreBillOutDetailViewModel storeBillOutDetail, string regulatoryCode, string createUsername);
        List<WMSScannedRegulatoryCode> GetScannedRegulatoryCodes(int storeId);
    }
}