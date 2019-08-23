using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IDealerService
    {
        List<Dealer> GetAllDealers();
        void UpdateRegulatoryCustomerName(Dictionary<int, string> customers);
        Dealer GetDealerById(int dealerId);
    }
}