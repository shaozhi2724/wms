using WMS.Model;

namespace WMS.App.Services
{
    public class StorageStructureELabelViewModel : StorageStructureTreeViewModel
    {
        public int? LabelID { get; set; }
        public string LabelCode { get; set; }
        public ElectronicLabel ELabel { get; set; }
    }
}