using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Objects;
using System.Data.Objects.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using WMS.Model;

namespace WMS.App.Services
{
    public class ReviewService : IReviewService
    {
        public Review GetByStoreId(int storeID, string userRealName)
        {
            using (var db = new WMSContext())
            {
                var review = db.Reviews.SingleOrDefault(p => p.StoreOutID == storeID);
                if (null == review)
                {
                    var storeBill = db.StoreBills.Find(storeID);
                    review = new Review
                    {
                        ReviewCode = storeBill.SaleBillCode,//Regex.Replace(storeBill.StoreCode, @"[^\d]*", ""),//GenerateReviewCode(),
                        ReviewDate = DateTime.Now,
                        StoreOutID = storeID,
                        StoreOutCode = storeBill.StoreCode,
                        CreateDate = DateTime.Now,
                        SaleBillID = storeBill.SaleBillID,
                        SaleBillCode = storeBill.SaleBillCode,
                        ReviewPerson = userRealName
                    };
                    var createdReview = db.Reviews.Add(review);
                    db.SaveChanges();
                    return createdReview;
                }
                return review;
            }
        }
        public bool IsReviewing(int storeID)
        {
            using (var db = new WMSContext())
            {
                var review = db.Reviews.SingleOrDefault(p => p.StoreOutID == storeID);
                return (null != review);
            }
        }

        public Review GetByReviewId(int reviewId)
        {
            using (var db = new WMSContext())
            {
                return db.Reviews.SingleOrDefault(p => p.ReviewID == reviewId);
            }
        }

        public List<ReviewDetailViewModel> GetReviewDetails(int reviewId, int reviewAmount,
            StoreBillOutDetailViewModel storeBillDetail, string reviewResult)
        {
            using (var db = new WMSContext())
            {
                if (reviewAmount > storeBillDetail.Amount)
                {
                    throw new Exception("复核数量大于出库数量，请核对后重试！");
                }
                var reviewDetail = new ReviewDetail
                {
                    ReviewID = reviewId,
                    ReviewAmount = reviewAmount,
                    Amount = storeBillDetail.Amount,
                    ProductID = storeBillDetail.ProductID,
                    BatchNo = storeBillDetail.BatchNo,
                    DetailID = storeBillDetail.DetailID,
                    ProduceDate = storeBillDetail.ProduceDate,
                    ValidateDate = storeBillDetail.ValidateDate,
                    ReviewResult = reviewResult,
                    DetailRemark = storeBillDetail.DetailRemark,
                    CreateDate = DateTime.Now,
                };

                db.ReviewDetails.Add(reviewDetail);

                db.SaveChanges();

                db.WMSReviewHistories.Add(new WMSReviewHistory
                {
                    ReviewID = reviewId,
                    DetailID = reviewDetail.DetailID,
                    ProductID = reviewDetail.ProductID,
                    BatchNo = reviewDetail.BatchNo,
                    ProduceDate = reviewDetail.ProduceDate,
                    ValidateDate = reviewDetail.ValidateDate,
                    Amount = storeBillDetail.Amount,
                    ReviewAmount = reviewAmount,
                    ReviewResult = reviewResult,
                    CreateDate = DateTime.Now
                });
                db.SaveChanges();
                var reviewDetails = db.ReviewDetails.Where(p => p.ReviewID == reviewId).ToList();
                var billDetails = from sd in db.StoreBillDetails
                    where sd.StoreID == storeBillDetail.StoreID
                    join p in db.Products on sd.ProductID equals p.ProductID into g
                    from gp in g.DefaultIfEmpty()
                    select new StoreBillOutDetailViewModel
                    {
                        StoreID = sd.StoreID,
                        ProductID = gp.ProductID,
                        ProductBarCode = gp.ProductBarCode,
                        ProductName = gp.ProductName,
                        ProductCode = gp.ProductCode,
                        Amount = sd.Amount,
                        StoreAmount = sd.StoreAmount,
                        BatchNo = sd.BatchNo,
                        DetailID = sd.DetailID,
                        ProductSpec = gp.ProductSpec,
                        PackageSpec = gp.PackageSpec,
                        ProducerName = gp.ProducerName,
                        ProduceDate = sd.ProduceDate,
                        ValidateDate = sd.ValidateDate,
                        AuthorizedNo = gp.AuthorizedNo,
                        PhysicType = gp.PhysicType,
                        ProductLocation = gp.Reservation1

                    };
                var result =
                    (from r in reviewDetails
                        join d in billDetails on new {ProductID = r.ProductID, BatchNo = r.BatchNo} equals
                            new {ProductID = d.ProductID, BatchNo = d.BatchNo} into g
                        from gp in g.DefaultIfEmpty()
                        select new ReviewDetailViewModel
                        {
                            DetailID = r.DetailID,
                            ProductID = r.ProductID,
                            ProductBarCode = gp.ProductBarCode,
                            ProductName = gp.ProductName,
                            ProductCode = gp.ProductCode,
                            ProducerName = gp.ProducerName,
                            Amount = r.ReviewAmount,
                            BatchNo = gp.BatchNo,
                            ProductSpec = gp.ProductSpec,
                            PackageSpec = gp.PackageSpec,
                            ProduceDate = gp.ProduceDate,
                            ValidateDate = gp.ValidateDate,
                            AuthorizedNo = gp.AuthorizedNo,
                            PhysicType = gp.PhysicType,
                            ProductLocation = gp.ProductLocation,
                            ReviewResult = r.ReviewResult
                        }).ToList();
                return result;
            }
        }

        public List<ReviewDetailViewModel> GetReviewDetails(int reviewId)
        {
            using (var db = new WMSContext())
            {
                var review = db.Reviews.FirstOrDefault(p => p.ReviewID == reviewId);

                var reviewDetails = db.ReviewDetails.Where(p => p.ReviewID == reviewId).ToList();
                var billDetails = from sd in db.StoreBillDetails
                                  where sd.StoreID == review.StoreOutID
                    join p in db.Products on sd.ProductID equals p.ProductID into g
                    from gp in g.DefaultIfEmpty()
                    select new StoreBillOutDetailViewModel
                    {
                        StoreID = sd.StoreID,
                        ProductID = gp.ProductID,
                        ProductBarCode = gp.ProductBarCode,
                        ProductName = gp.ProductName,
                        ProductCode = gp.ProductCode,
                        Amount = sd.Amount,
                        StoreAmount = sd.StoreAmount,
                        BatchNo = sd.BatchNo,
                        DetailID = sd.DetailID,
                        ProductSpec = gp.ProductSpec,
                        PackageSpec = gp.PackageSpec,
                        ProducerName = gp.ProducerName,
                        ProduceDate = sd.ProduceDate,
                        ValidateDate = sd.ValidateDate,
                        AuthorizedNo = gp.AuthorizedNo,
                        PhysicType = gp.PhysicType,
                        ProductLocation = gp.Reservation1
                    };
                var result = from r in reviewDetails
                    join d in billDetails on new {ProductID = r.ProductID, BatchNo = r.BatchNo} equals
                        new {ProductID = d.ProductID, BatchNo = d.BatchNo} into g
                    from gp in g.DefaultIfEmpty()
                    select new ReviewDetailViewModel
                    {
                        DetailID = r.DetailID,
                        ProductID = r.ProductID,
                        ProductBarCode = gp.ProductBarCode,
                        ProductName = gp.ProductName,
                        ProductCode = gp.ProductCode,
                        ProducerName = gp.ProducerName,
                        Amount = r.ReviewAmount,
                        BatchNo = gp.BatchNo,
                        ProductSpec = gp.ProductSpec,
                        PackageSpec = gp.PackageSpec,
                        ProduceDate = r.ProduceDate,
                        ValidateDate = r.ValidateDate,
                        AuthorizedNo = gp.AuthorizedNo,
                        PhysicType = gp.PhysicType,
                        ProductLocation = gp.ProductLocation,
                        ReviewResult = r.ReviewResult
                    };
                return result.ToList();
            }
        }

        public void CancelReview(int reviewId)
        {
            using (var db = new WMSContext())
            {
                if (reviewId > 0)
                {
                    var details = db.ReviewDetails.Where(p => p.ReviewID == reviewId).ToList();
                    var review = db.Reviews.FirstOrDefault(p => p.ReviewID == reviewId);
                    var reviewHistories = db.WMSReviewHistories.Where(p => p.ReviewID == reviewId).ToList();
                    foreach (var reviewHistory in reviewHistories)
                    {
                        db.WMSReviewHistories.Remove(reviewHistory);
                    }
                    foreach (var reviewDetail in details)
                    {
                        db.ReviewDetails.Remove(reviewDetail);
                    }
                    db.SaveChanges();
                    if (null != review)
                    {
                        db.Reviews.Remove(review);
                    }
                    db.SaveChanges();
                }
            }
        }

        public bool CompleteReview(int reviewId, bool allowNoCodeReview = false)
        {
            using (var db = new WMSContext())
            {
                var review = db.Reviews.FirstOrDefault(p => p.ReviewID == reviewId);
                if (null != review)
                {
                    review.StatusID = 1;
                    review.StatusName = "复核成功";

                    var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreID == review.StoreOutID);
                    if (null != storeBill)
                    {
                        storeBill.ReviewID = reviewId;
                        storeBill.ReviewCode = review.ReviewCode;

                        storeBill.StoreStatusID = ((int) StoreBillStatuses.Reviewed).ToString();
                        storeBill.StoreStatusName = "已复核";
                    }
                    var identities = db.StoreOutReviewIdentities.Where(p => p.StoreID == review.StoreOutID);
                    foreach(var storeOutReviewIdentity in identities)
                    {
                        storeOutReviewIdentity.IsReviewed = true;
                        storeOutReviewIdentity.ReviewCode = review.ReviewCode;
                        storeOutReviewIdentity.ReviewDate = review.ReviewDate;
                        storeOutReviewIdentity.ReviewPerson = review.ReviewPerson;
                    }
                    if (!allowNoCodeReview)
                    {
                        var regulatoryCode = db.RegulatoryCodes.FirstOrDefault(p => p.StatusID == 0 && (p.ReviewCode == null || p.ReviewCode == ""));
                        if (null == regulatoryCode)
                        {
                            CancelReview(reviewId);
                            throw new Exception("无可用流通监管码！请导入流通监管码后再进行复核！");
                        }

                        regulatoryCode.ReviewCode = review.ReviewCode;
                        regulatoryCode.StatusID = 1;
                        regulatoryCode.StatusName = "已关联";
                        regulatoryCode.RelationDate = DateTime.Now;
                    }
                    int result = db.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }

        public bool CompleteReviewAndBill(int reviewId, bool allowNoCodeReview = false)
        {
            int result = 0;
            using (var db = new WMSContext())
            {
                var review = db.Reviews.FirstOrDefault(p => p.ReviewID == reviewId);
                if (null != review)
                {
                    review.StatusID = 1;
                    review.StatusName = "复核成功";

                    var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreID == review.StoreOutID);
                    if (null != storeBill)
                    {
                        storeBill.ReviewID = reviewId;
                        storeBill.ReviewCode = review.ReviewCode;

                        storeBill.StoreStatusID = ((int)StoreBillStatuses.Reviewed).ToString();
                        storeBill.StoreStatusName = "已复核";
                    }

                    var bill = db.Bills.FirstOrDefault(p => p.BillID == review.SaleBillID);
                    if (null != bill)
                    {
                        bill.BillStatus = 4;
                        bill.BillStatusName = "已复核";
                    }
                    var identities = db.StoreOutReviewIdentities.Where(p => p.StoreID == review.StoreOutID);
                    foreach (var storeOutReviewIdentity in identities)
                    {
                        storeOutReviewIdentity.IsReviewed = true;
                        storeOutReviewIdentity.ReviewCode = review.ReviewCode;
                        storeOutReviewIdentity.ReviewDate = review.ReviewDate;
                        storeOutReviewIdentity.ReviewPerson = review.ReviewPerson;
                    }
                    if (!allowNoCodeReview)
                    {
                        var regulatoryCode = db.RegulatoryCodes.FirstOrDefault(p => p.StatusID == 0 && (p.ReviewCode == null || p.ReviewCode == ""));
                        if (null == regulatoryCode)
                        {
                            CancelReview(reviewId);
                            throw new Exception("无可用流通监管码！请导入流通监管码后再进行复核！");
                        }
                        regulatoryCode.ReviewCode = review.ReviewCode;
                        regulatoryCode.StatusID = 1;
                        regulatoryCode.StatusName = "已关联";
                        regulatoryCode.RelationDate = DateTime.Now;
                    }
                    result = db.SaveChanges();
                }
            }
            return result > 0;
        }

        public bool CanReview()
        {
            using (var db = new WMSContext())
            {
                return db.RegulatoryCodes.Any(p => p.StatusID == 0);
            }
        }

        public List<ReviewHistoryViewModel> SearchReviews(string reviewCode, string dealerName, int storeTypeId, DateTime startDate, DateTime endDate, string productName)
        {
            using (var db = new WMSContext())
            {
                endDate = endDate.Date.AddDays(1).AddSeconds(-1);
                var reviews = from r in db.Reviews
                    join d in db.StoreBills on r.StoreOutID equals d.StoreID
                    select new {Review = r, StoreBill = d};
                if (!string.IsNullOrWhiteSpace(reviewCode))
                {
                    reviews = reviews.Where(p => p.Review.ReviewCode.Contains(reviewCode));
                }
                if (!string.IsNullOrWhiteSpace(dealerName))
                {
                    reviews = reviews.Where(p => p.StoreBill.DealerName.Contains(dealerName));
                }
                if (storeTypeId > 0)
                {
                    reviews = reviews.Where(p => p.StoreBill.StoreTypeID == storeTypeId);
                }
                if (DateTime.MinValue != startDate)
                {
                    reviews = reviews.Where(p => p.Review.ReviewDate.HasValue && p.Review.ReviewDate >= startDate);
                }

                if (DateTime.MinValue != endDate)
                {
                    if (startDate.Date == endDate.Date)
                    {
                        endDate = startDate.Date.AddDays(1).AddSeconds(-1);
                    }
                    reviews = reviews.Where(p => p.Review.ReviewDate.HasValue && p.Review.ReviewDate <= endDate);
                }

                var models = reviews.Select(p => new ReviewHistoryViewModel
                {
                    ReviewID = p.Review.ReviewID,
                    ReviewCode = p.Review.ReviewCode,
                    ReviewDate = p.Review.ReviewDate,
                    StoreID = p.StoreBill.StoreID,
                    StoreOutCode = p.Review.StoreOutCode,
                    SaleBillCode = p.Review.SaleBillCode,
                    StatusName = p.Review.StatusName,
                    StoreTypeName = p.StoreBill.StoreTypeName,
                    DealerName = p.StoreBill.DealerName,
                    ReviewPerson = p.Review.ReviewPerson,
                    PrintTimes = p.Review.Reservation1
                });

                if (!string.IsNullOrWhiteSpace(productName))
                {
                    var data = from r in models
                        join sbd in db.StoreBillDetails on r.StoreID equals sbd.StoreID into g
                        select
                            new
                            {
                                Review = r,
                                Products =
                                    from s in g
                                    join p in db.Products on s.ProductID equals p.ProductID
                                    select p.ProductName
                            };
                    models = from s in data
                        where s.Products.Any(p => p.Contains(productName))
                        select s.Review;
                }
                return models.ToList();
            }
        }

        public string GenerateApproval(string userName,int BillID, string Code, string Result)
        {
            string mes = "";

            using (var db = new WMSContext())
            {
                //判断MQS中是否有该用户信息
                var users = db.ATC_User.FirstOrDefault(p => p.UserName == userName);

                if (users == null)
                {
                    mes = "MQS用户中不包含该用户信息。不能申请返单。";
                    return mes;
                }
                else
                {
                    //判断MQS中是否有该用户的审批流程
                    var userpages = db.ATC_UserPage.Where(p => p.UserID == users.UserID && p.DocumentCode == "ReviewBack").OrderBy(p => p.ApprovalSort).ToList();
                    if (userpages.Count == 0)
                    {
                        mes = "MQS系统中不包含该用户的审批流程。不能申请返单。";
                        return mes;
                    }
                    else
                    {
                        //生成审批流程
                        int i = 1;
                        DateTime dt = DateTime.Now;
                        foreach (var item in userpages)
                        {
                            ATC_Approve app = new ATC_Approve();
                            app.ApproveCode = "FD" + Code + "0" + i;
                            app.InternalNo = "FD" + Code;
                            app.ApproveTitle = "返单，编号：" + Code;
                            app.ApproveOrder = i;
                            app.DocumentCode = "ReviewBack";
                            app.BillCode = Code;
                            app.CreateUserID = users.UserID;
                            app.CreateDate = dt;
                            app.ApprovalUserID = item.ApprovalUserID;
                            app.IsPass = false;
                            app.IsWhole = item.IsWhole;
                            app.ApprovalContent = "返单，单号：" + Code + "申请审批。";
                            if (i == 1)
                            {
                                app.ApprovalDate = DateTime.Now;
                                app.IsApprovaled = true;
                                app.ApprovalSuggestion = Result;
                                app.ApprovalResult = Result;
                                app.ApprovalRemark = "";
                            }
                            else
                            {
                                app.IsApprovaled = false;
                            }
                            db.ATC_Approve.Add(app);

                            ATC_ApproveNotification appnot = new ATC_ApproveNotification();
                            appnot.ApproveCode = "FD" + Code + "0" + i;
                            appnot.OwnerUserID = item.ApprovalUserID;
                            appnot.Message = userName + " 于 " + dt.ToString("yyyy-MM-dd hh:mm:ss") + " 申请返单（单号 " + Code + "）。请您审批。";
                            appnot.CreateUserID = users.UserID;
                            appnot.CreateDate = dt;
                            appnot.CreateUserName = userName;

                            if (i == 1)
                            {
                                appnot.IsRead = true;
                                appnot.ReadTime = dt;
                            }
                            else
                            {
                                appnot.IsRead = false;
                            }
                            appnot.FormClass = "ReviewBack";
                            appnot.TargetID = BillID;
                            appnot.TargetCode = Code;
                            db.ATC_ApproveNotification.Add(appnot);

                            db.SaveChanges();
                            i += 1;
                        }
                        //添加返单审批列表
                        BUS_ReviewBack rb = new BUS_ReviewBack();
                        rb.BillID = BillID;
                        rb.Code = Code;
                        rb.Cause = Result;
                        rb.SubUserName = userName;
                        rb.SubDate = dt;
                        rb.AppStatus = "未通过";
                        db.BUS_ReviewBack.Add(rb);

                        //更改出库状态为 4，申请返单
                        var storeBill = db.StoreBills.FirstOrDefault(p => p.StoreCode == Code);
                        storeBill.StoreStatusID = "5";
                        storeBill.StoreStatusName = "申请返单";
                        db.SaveChanges();

                        mes = "提交成功。";
                        return mes;
                    }
                }
            }
        }
        public bool HaveReviewCode(string ReviewCode)
        {
            using (var db = new WMSContext())
            {
                var review = db.Reviews.FirstOrDefault(p => p.ReviewCode == ReviewCode);
                if (null != review)
                {
                    return true;
                }
            }
            return false;
        }

        public void UpdatePrintTimes(int reviewId)
        {
            using (var db = new WMSContext())
            {
                var review = db.Reviews.Find(reviewId);
                if (null != review)
                {
                    int printTimes = 0;
                    int currentPrintTimes = 0;
                    if (!string.IsNullOrWhiteSpace(review.Reservation1))
                    {
                        int.TryParse(review.Reservation1, out currentPrintTimes);
                    }

                    printTimes = currentPrintTimes + 1;
                    review.Reservation1 = printTimes.ToString();

                }
                db.SaveChanges();
            }
        }

        private string GenerateReviewCode()
        {
            return string.Concat("FH",DateTime.Now.ToString("yyyyMMddHHmmss"));
        }


    }

    public class ReviewHistoryViewModel
    {
        public int ReviewID { get; set; }
        public string ReviewCode { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string StoreOutCode { get; set; }
        public string StatusName { get; set; }
        public string DealerName { get; set; }
        public string SaleBillCode { get; set; }
        public string StoreTypeName { get; set; }

        public int StoreID { get; set; }
        public string ReviewPerson { get; set; }

        public string PrintTimes { get; set; }
    }

    public class ReviewDetailViewModel : ReviewDetail
    {
        public string ProductBarCode { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProducerName { get; set; }
        public string ProductSpec { get; set; }
        public string PackageSpec { get; set; }
        public string AuthorizedNo { get; set; }

        public string PhysicType { get; set; }
        public string ProductLocation { get; set; }
    }
}