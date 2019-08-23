using System;
using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IReviewService
    {
        Review GetByStoreId(int storeID, string userRealName);
        Review GetByReviewId(int reviewId);
        List<ReviewDetailViewModel> GetReviewDetails(int reviewId, int reviewAmount, StoreBillOutDetailViewModel storeBillDetail, string reviewResult);
        List<ReviewDetailViewModel> GetReviewDetails(int reviewId);
        void CancelReview(int reviewId);
        bool CompleteReview(int reviewId, bool allowNoCodeReview = false);
        bool CompleteReviewAndBill(int reviewId, bool allowNoCodeReview = false);
        bool IsReviewing(int storeID);
        bool CanReview();
        List<ReviewHistoryViewModel> SearchReviews(string reviewCode, string dealerName, int storeTypeId, DateTime startDate, DateTime endDate, string productName);
        void UpdatePrintTimes(int reviewId);

        //判断MQS中是否有该用户信息
        //判断MQS中是否有该用户的审批流程
        //生成审批流程
        //更改出库状态为 4，申请返单
        string GenerateApproval(string userName, int BillID, string Code, string Result);
        bool HaveReviewCode(string ReviewCode);
    }
}