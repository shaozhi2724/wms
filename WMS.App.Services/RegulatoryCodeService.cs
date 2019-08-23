using System;
using System.Collections.Generic;
using System.Linq;
using WMS.Model;

namespace WMS.App.Services
{
    public class RegulatoryCodeService : IRegulatoryCodeService
    {
        public int ImportCodes(List<CodeViewModel> codes, string corpCode)
        {
            int result = 0;
            using (var db = new WMSContext())
            {
                foreach (var codeViewModel in codes)
                {
                    if (!db.RegulatoryCodes.Any(p => p.Code == codeViewModel.Code))
                    {
                        db.RegulatoryCodes.Add(new RegulatoryCode
                        {
                            Code = codeViewModel.Code,
                            CorpCode = corpCode,
                            StatusID = 0,
                            StatusName = "未使用",
                            CreateDate = DateTime.Now
                        });
                    }
                }
                result = db.SaveChanges();
            }

            return result;
        }

        public List<ExportTicketViewModel> GenExportTickets()
        {
            using (var db = new WMSContext())
            {
                //取出已关联复核单的流通监管码
                var codesForSaleBill = from rc in db.RegulatoryCodes
                    where rc.StatusID == 1
                    join r in db.Reviews on rc.ReviewCode equals r.ReviewCode
                    join s in db.StoreBills on r.StoreOutID equals s.StoreID
                    join rd in db.ReviewDetails on r.ReviewID equals rd.ReviewID
                    join b in db.Bills on r.SaleBillID equals b.BillID
                    join p in db.Products on rd.ProductID equals p.ProductID
                    select new ExportTicketViewModel
                    {
                        Amount = rd.Amount.Value,
                        BatchNo = rd.BatchNo,
                        ReviewCode = r.ReviewCode,
                        ReviewDate = r.CreateDate.Value,
                        ReviewRemark = r.ReviewRemark,
                        //ReviewCode = b.BillCode,
                        //ReviewDate = s.LastModifyDate.Value,
                        //ReviewRemark = b.BillRemark,
                        CorpCode = rc.CorpCode,
                        RegulatoryCode = rc.Code,
                        ProductCode = p.ProductCode,
                        ProduceDate = rd.ProduceDate.Value,
                        ValidateDate = rd.ValidateDate.Value,
                        DealerCode = b.DealerCode,
                        DealerName = b.DealerName,
                        DealerAddress = b.DealerAddress,
                        StoreTypeName = s.StoreTypeName
                    };
                //取出已关联复核单的流通监管码
                var codesForPurcharseBill = from rc in db.RegulatoryCodes
                           where rc.StatusID == 1
                           join s in db.StoreBills on rc.ReviewCode equals s.StoreCode
                           join rd in db.StoreBillDetails on s.StoreID equals rd.StoreID
                           join b in db.Bills on s.PurchaseBillID equals b.BillID
                           join p in db.Products on rd.ProductID equals p.ProductID
                           select new ExportTicketViewModel
                           {
                               Amount = rd.Amount.Value,
                               BatchNo = rd.BatchNo,
                               ReviewCode = s.StoreCode,
                               ReviewDate = s.LastModifyDate.Value,
                               ReviewRemark = s.StoreRemark,
                               CorpCode = rc.CorpCode,
                               RegulatoryCode = rc.Code,
                               ProductCode = p.ProductCode,
                               ProduceDate = rd.ProduceDate.Value,
                               ValidateDate = rd.ValidateDate.Value,
                               DealerCode = b.DealerCode,
                               DealerName = b.DealerName,
                               DealerAddress = b.DealerAddress,
                               StoreTypeName = s.StoreTypeName
                           };
                return codesForSaleBill.Union(codesForPurcharseBill).ToList();
            }
        }

        public void UpdateCodesStatusToExported(List<string> codes)
        {
            using (var db = new WMSContext())
            {
                var regulatoryCodes = db.RegulatoryCodes.Where(p => codes.Contains(p.Code) && p.StatusID == 1).ToList();
                foreach (var regulatoryCode in regulatoryCodes)
                {
                    regulatoryCode.StatusID = 2;
                    regulatoryCode.StatusName = "已导出";
                    regulatoryCode.ExportDate = DateTime.Now;
                }

                db.SaveChanges();

            }
        }

        public RegulatoryCodeStatisticViewMode GetStatistics()
        {
            var result = new RegulatoryCodeStatisticViewMode();
            using (var db = new WMSContext())
            {
                var data = (from s in db.RegulatoryCodes
                    group s by s.StatusID
                    into g
                    select new
                    {
                        StatusID = g.Key,
                        Count = g.Count()
                    }).ToList();
                if (null != data && data.Any())
                {
                    foreach (var item in data)
                    {
                        switch (item.StatusID)
                        {
                            case 0:
                                result.UnUsedCount = item.Count;
                                break;
                            case 1:
                                result.UsedCount = item.Count;
                                break;
                            case 2:
                                result.ExportedCount = item.Count;
                                break;
                        }
                    }
                    result.TotalCount = data.Sum(p => p.Count);
                }
            }
            return result;
        }

        public void SaveScannedRegulatoryCodes(StoreBillOutDetailViewModel storeBillOutDetail, string regulatoryCode, string createUsername)
        {
            using (var db = new WMSContext())
            {
                if (!db.WMSScannedRegulatoryCodes.Any(p => p.StoreID == storeBillOutDetail.StoreID
                                                           && p.ScannedRegulatoryCode == regulatoryCode))
                {
                    var code = new WMSScannedRegulatoryCode
                               {
                                   StoreID = storeBillOutDetail.StoreID,
                                   StoreCode = storeBillOutDetail.StoreCode,
                                   ProductID = storeBillOutDetail.ProductID,
                                   ProductCode = storeBillOutDetail.ProductCode,
                                   ProductBarcode = storeBillOutDetail.ProductBarCode,
                                   ScannedRegulatoryCode = regulatoryCode,
                                   CreateDate = DateTime.Now,
                                   CreateUsername = createUsername
                               };
                    db.WMSScannedRegulatoryCodes.Add(code);
                    db.SaveChanges();
                }
            }
        }

        public List<WMSScannedRegulatoryCode> GetScannedRegulatoryCodes(int storeId)
        {

            using(var db = new WMSContext())
            {
                return db.WMSScannedRegulatoryCodes.Where(p => p.StoreID == storeId).OrderByDescending(p => p.CreateDate).ToList();
            }
        }
    }
}