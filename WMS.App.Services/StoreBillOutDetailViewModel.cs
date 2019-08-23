namespace WMS.App.Services
{
    public class StoreBillOutDetailViewModel : StoreBillDetailViewModel
    {
        public string ProductBarCode { get; set; }
        public string ProductCode { get; set; }
        public int? StoreAmount { get; set; }
        public string AuthorizedNo { get; set; }

        public string PhysicType { get; set; }

        public string ProductLocation
        {
            get;
            set;
        }

        public string ProductSpell
        {
            get;
            set;
        }
    }
}