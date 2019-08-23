using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS.Model;

namespace WMS.App.Services
{
    public class DealerService : IDealerService
    {
        public List<Dealer> GetAllDealers()
        {
            using(var db = new WMSContext())
            {
                return db.Dealers.ToList();
            }
        }

        public void UpdateRegulatoryCustomerName(Dictionary<int, string> customers)
        {
            StringBuilder sqlString = new StringBuilder();
            foreach (var customer in customers)
            {
                sqlString.AppendLine(string.Format("UPDATE BFI_Dealer SET Reservation9='{1}' WHERE DealerID={0}",
                                                   customer.Key,
                                                   customer.Value));
            }
            using(var db = new WMSContext())
            {
                db.Database.ExecuteSqlCommand(sqlString.ToString());
            }
        }

        public Dealer GetDealerById(int dealerId)
        {
            using(var db = new WMSContext())
            {
                return db.Dealers.Find(dealerId);
            }
        }
    }
}