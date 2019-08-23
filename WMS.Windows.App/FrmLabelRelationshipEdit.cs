using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using WMS.App.Services;
using WMS.Model;

namespace WMS.Windows.App
{
    public partial class FrmLabelRelationshipEdit : Office2007Form
    {
        private IWarehouseService _warehouseService;
        private IELabelService _eLabelService;
        private IStorageStructureService _service;
        private ILabelStructureService _labelStructureService;
        public FrmLabelRelationshipEdit()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _warehouseService = new WarehouseService();
            _eLabelService = new ELabelService();
            _service = new StorageStructureService();
            _labelStructureService = new LabelStructureService();
        }


        private void FrmRelationshipEdit_Load(object sender, System.EventArgs e)
        {
            BindLabels();
            BindStructures();
        }

        private void BindLabels()
        {
            var labels = _eLabelService.GetAllElectronicLabels().Where(p => p.ParentLabelID != null).ToList();
            
            cbxELabels.DataSource = labels;
        }

        private void BindStructures()
        {
            var structures = _service.GetAllELabelControledStorageStructures().Where(p => p.StructureType == "»õÎ»").ToList();
            grdStructures.PrimaryGrid.DataSource = structures;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            var existedLabelStructures = _labelStructureService.GetAllLabelStructures();
            List<LabelStructure> dirtyLabelStructures = new List<LabelStructure>();
            foreach (GridElement element in grdWarehouse.ActiveGrid.FlatRows)
            {
                var row = element as GridRow;

                if (row != null)
                {
                    var model = row.DataItem as LabelStructureViewModel;
                    if (!existedLabelStructures.Any(
                            p => p.LabelID == model.LabelID && p.StructureID == model.StructureID))
                    {
                        dirtyLabelStructures.Add(new LabelStructure
                        {
                            LabelID = model.LabelID,
                            StructureID = model.StructureID,
                            CreateDate = DateTime.Now
                        });
                    }
                }
            }
            _labelStructureService.SaveLabelStructures(dirtyLabelStructures);

            grdWarehouse.PrimaryGrid.DataSource = null;

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            var labelStructures = grdWarehouse.PrimaryGrid.DataSource as List<LabelStructureViewModel>;
            var selectedElements = grdWarehouse.GetSelectedRows();
            foreach (GridElement gridElement in selectedElements)
            {
                var row = gridElement as GridRow;
                var relation = row.DataItem as LabelStructureViewModel;
                var labelStructure = labelStructures.FirstOrDefault(p => p.LabelID == relation.LabelID && p.StructureID == relation.StructureID);
                if (null != labelStructure)
                {
                    labelStructures.Remove(relation);
                }
            }
            grdWarehouse.PrimaryGrid.DataSource = labelStructures;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            int labelId = (int) cbxELabels.SelectedValue;
            string lableCode = (cbxELabels.SelectedItem as ElectronicLabel).LabelCode;
            var labelStructures = new List<LabelStructureViewModel>();
            var selectedElements = grdStructures.GetSelectedRows();
            foreach (GridElement gridElement in selectedElements)
            {
                var row = gridElement as GridRow;
                var structure = row.DataItem as StorageStructure;
                var labelStructureViewModel = new LabelStructureViewModel
                {
                    LabelID = labelId,
                    LabelCode = lableCode,
                    StructureID = structure.StructureID,
                    StructureCode = structure.StructureCode
                };
                if (!labelStructures.Any(p => p.LabelID == labelStructureViewModel.LabelID && p.StructureID == labelStructureViewModel.StructureID))
                {
                    labelStructures.Add(labelStructureViewModel);
                }
            }
            grdWarehouse.PrimaryGrid.DataSource = labelStructures;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
            this.Close();
        }

    }

    public class LabelStructureViewModel : LabelStructure
    {
        public string LabelCode { get; set; }
        public string StructureCode { get; set; }
    }
}