using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace WMS.WinCE.App.Models
{
    public class InventoryDemolitionViewModel
    {
        public int DemolitionID { get; set; }
        public int StoreBillDetailID { get; set; }
        public int EntireCargoAmount { get; set; }
        public string EntireCargoStructureCode { get; set; }
        public int EntireCargoStructureID { get; set; }
        public string EntireCargoStructureName { get; set; }
        public int ScatteredCargoAmount { get; set; }
        public string ScatteredCargoStructureCode { get; set; }
        public int ScatteredCargoStructureID { get; set; }
        public string ScatteredCargoStructureName { get; set; }
    }
}
