using System;

namespace WMS.App.Services
{
    public class ExportTicketViewModel
    {
        /// <summary>
        /// 行项目编号 - 单据上的行项目的编号，如第一行为1,第二行为2
        /// </summary>
        public int RowNumber{ get; set; }

        /// <summary>
        /// 流通监管码 - 药监局下发的针对每张单据号的唯一校验码
        /// </summary>
        public string RegulatoryCode { get; set; }

        /// <summary>
        /// 企业编码 - 库存发生移动的企业在系统上的编码
        /// </summary>
        public string CorpCode { get; set; }

        /// <summary>
        /// 单据号 - 企业内部的单据号(复核单号）
        /// </summary>
        public string ReviewCode { get; set; }

        /// <summary>
        /// 制单日期 - 企业系统中该单据创建的日期格式为“YYYYMMDD”如2008年5月3日为 20080503
        /// </summary>
        public DateTime ReviewDate { get; set; }

        /// <summary>
        /// 供应商/客户编码
        /// </summary>
        public string DealerCode { get; set; }

        /// <summary>
        /// 供应商/客户名称
        /// </summary>
        public string DealerName { get; set; }

        /// <summary>
        /// 采购入库地址/销售送货地址
        /// </summary>
        public string DealerAddress { get; set; }

        /// <summary>
        /// 企业出入库类型编码
        /// </summary>
        public string StoreTypeName { get; set; }

        /// <summary>
        /// 企业药品编码 - 药批企业自己公司内部的药品编码
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 批号 - 药品的批号，只能输入半角字符
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// 数量 - 单据上药品数量，保留小数点后两位（各企业自己药品主数据中的最小销售单位计的数量）
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 生产日期 - 药品的生产日期，格式为“YYYYMMDD”如2008年5月3日为 20080503
        /// </summary>
        public DateTime ProduceDate { get; set; }

        /// <summary>
        /// 有效期至 - 药品的有效日期，格式为“YYYYMMDD”如2008年5月3日为 20080503
        /// </summary>
        public DateTime ValidateDate { get; set; }

        /// <summary>
        /// 备注 - 企业内部单据的备注信息
        /// </summary>
        public string ReviewRemark { get; set; }
    }
}