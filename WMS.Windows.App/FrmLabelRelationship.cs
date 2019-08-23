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
    public partial class FrmLabelRelationship : Office2007Form
    {
        private IWarehouseService _warehouseService;
        private IELabelService _eLabelService;
        private IStorageStructureService _service;
        private ILabelStructureService _labelStructureService;

        public FrmLabelRelationship()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _warehouseService = new WarehouseService();
            _eLabelService = new ELabelService();
            _service = new StorageStructureService();
            _labelStructureService = new LabelStructureService();
        }


        private void FrmLabelRelationship_Load(object sender, System.EventArgs e)
        {
            BindStorageStructureTree();
        }

        private void BindStorageStructureTree()
        {
            var warehouses = _warehouseService.GetAllWarehouses();

            var structures = _service.GetAllELabelControledStorageStructures();

            var labelStructures = _labelStructureService.GetAllLabelStructures();
            var elabels = _eLabelService.GetAllElectronicLabels();
            
            List<StorageStructureELabelViewModel> warehouseUnits = new List<StorageStructureELabelViewModel>();
            List<StorageStructureELabelViewModel> storeUnits = new List<StorageStructureELabelViewModel>();
            foreach (var warehouse in warehouses)
            {
                warehouseUnits.Add(new StorageStructureELabelViewModel
                {
                    WarehouseID = warehouse.WarehouseID,
                    StructureCode = warehouse.WarehouseCode,
                    StructureLocation = warehouse.WarehouseAddress,
                    StructureName = warehouse.WarehouseName,
                    StructureType = "仓库"
                });
                storeUnits.AddRange(
                    structures.Where(p => p.WarehouseID == warehouse.WarehouseID)
                        .Select(p => new StorageStructureELabelViewModel
                        {
                            WarehouseID = warehouse.WarehouseID,
                            StructureID = p.StructureID,
                            ParentStructureCode = p.ParentStructureCode,
                            StructureCode = p.StructureCode,
                            StructureLocation = p.StructureLocation,
                            StructureName = p.StructureName,
                            StructureType = p.StructureType
                        }));
            }
            grdWarehouse.BeginUpdate();

            GridPanel panel = grdWarehouse.PrimaryGrid;
            panel.Rows.Clear();
            foreach (var warehouse in warehouseUnits)
            {
                object[] rowItem = new object[] { warehouse.StructureID, warehouse.StructureCode, warehouse.StructureName, warehouse.StructureType, warehouse.LabelCode };
                GridRow row = new GridRow(rowItem);
                row.AllowEdit = false;
                panel.Rows.Add(row);
                
                var areas = storeUnits.Where(
                    p => p.WarehouseID == warehouse.WarehouseID && p.ParentStructureCode == warehouse.StructureCode)
                    .Select(p => new StorageStructureELabelViewModel
                    {
                        WarehouseID = warehouse.WarehouseID,
                        StructureID = p.StructureID,
                        ParentStructureCode = p.ParentStructureCode,
                        StructureCode = p.StructureCode,
                        StructureLocation = p.StructureLocation,
                        StructureName = p.StructureName,
                        StructureType = p.StructureType
                    });
                foreach (var area in areas)
                {
                    var areaLabel = labelStructures.FirstOrDefault(l => l.StructureID == area.StructureID);
                    if (null != areaLabel)
                    {
                        area.LabelID = areaLabel.LabelID;

                        area.ELabel = elabels.FirstOrDefault(p => p.LabelID == areaLabel.LabelID);
                    }
                    object[] areaItem = new object[] { area.StructureID, area.StructureCode, area.StructureName, area.StructureType, null == area.ELabel ? "" : string.Format("{0},{1}", area.ELabel.LabelCode, area.ELabel.LabelName) };
                    GridRow areaRow = new GridRow(areaItem);
                    areaRow.AllowEdit = false;
                    if (null != area.ELabel)
                    {
                        areaRow.GetCell(4).Tag = area.ELabel;
                    }
                    row.Rows.Add(areaRow);
                    var shelfs = storeUnits.Where(
                        p => p.WarehouseID == warehouse.WarehouseID && p.ParentStructureCode == area.StructureCode)
                        .Select(p => new StorageStructureELabelViewModel
                        {
                            WarehouseID = warehouse.WarehouseID,
                            StructureID = p.StructureID,
                            ParentStructureCode = p.ParentStructureCode,
                            StructureCode = p.StructureCode,
                            StructureLocation = p.StructureLocation,
                            StructureName = p.StructureName,
                            StructureType = p.StructureType
                        });
                    foreach (var shelf in shelfs.ToList())
                    {
                        var shelfLabel = labelStructures.FirstOrDefault(l => l.StructureID == shelf.StructureID);
                        if (null != shelfLabel)
                        {
                            shelf.LabelID = shelfLabel.LabelID;
                            shelf.ELabel = elabels.FirstOrDefault(p => p.LabelID == shelfLabel.LabelID);
                        }
                        object[] shelfItem = new object[] { shelf.StructureID, shelf.StructureCode, shelf.StructureName, shelf.StructureType, null == shelf.ELabel ? "" : string.Format("{0},{1}", shelf.ELabel.LabelCode, shelf.ELabel.LabelName) };
                        GridRow shelfRow = new GridRow(shelfItem);
                        shelfRow.AllowEdit = false;
                        if (null != shelf.ELabel)
                        {
                            shelfRow.GetCell(4).Tag = shelf.ELabel;
                        }
                        areaRow.Rows.Add(shelfRow);

                        var positions = (storeUnits.Where(
                            p => p.WarehouseID == warehouse.WarehouseID && p.ParentStructureCode == shelf.StructureCode)
                            .Select(p => new StorageStructureELabelViewModel
                            {
                                WarehouseID = warehouse.WarehouseID,
                                StructureID = p.StructureID,
                                ParentStructureCode = p.ParentStructureCode,
                                StructureCode = p.StructureCode,
                                StructureLocation = p.StructureLocation,
                                StructureName = p.StructureName,
                                StructureType = p.StructureType
                            })).ToList();

                        foreach (var position in positions)
                        {
                            var positionLabel = labelStructures.FirstOrDefault(l => l.StructureID == position.StructureID);
                            if (null != positionLabel)
                            {
                                position.LabelID = positionLabel.LabelID;
                                position.ELabel = elabels.FirstOrDefault(p => p.LabelID == positionLabel.LabelID);
                            }
                            object[] positionItem = new object[] { position.StructureID, position.StructureCode, position.StructureName, position.StructureType, null == position.ELabel ? "" : string.Format("{0},{1}", position.ELabel.LabelCode, position.ELabel.LabelName) };
                            GridRow positionRow = new GridRow(positionItem);
                            positionRow.AllowEdit = true;
                            if (null != position.ELabel)
                            {
                                positionRow.GetCell(4).Tag = position.ELabel;
                            }
                            shelfRow.Rows.Add(positionRow);
                        }

                    }

                }
            }

            grdWarehouse.EndUpdate();

            grdWarehouse.PrimaryGrid.ExpandAll();
        }

        private void grdWarehouse_BeginEdit(object sender, GridEditEventArgs e)
        {
            var editor = e.EditControl as GridComboTreeEditControl;
            if (editor != null)
            {
                if (editor.Columns.Count == 0)
                {
                    DevComponents.AdvTree.ColumnHeader colCode = new DevComponents.AdvTree.ColumnHeader();
                    DevComponents.AdvTree.ColumnHeader colLabelName = new DevComponents.AdvTree.ColumnHeader();

                    // 
                    // colCode
                    // 
                    colCode.DataFieldName = "LabelCode";
                    colCode.Name = "colCode";
                    colCode.Text = "电子标签编码";
                    colCode.Width.Absolute = 100;
                    // 
                    // colLabelName
                    // 
                    colLabelName.DataFieldName = "LabelName";
                    colLabelName.Name = "colLabelName";
                    colLabelName.Text = "电子标签名称";
                    colLabelName.Width.Absolute = 180;

                    editor.Columns.Add(colCode);
                    editor.Columns.Add(colLabelName);
                }
                editor.ParentFieldNames = "LabelID,ParentLabelID";
                var allElectronicLabels = _eLabelService.GetAllElectronicLabels();
                editor.DataSource = allElectronicLabels;
                editor.DropDownWidth = 300;
                editor.DropDownHeight = 300;
                editor.AdvTree.ExpandAll();
                editor.SelectedIndex = -1;
                foreach (Node node in editor.Nodes)
                {
                    node.Selectable = false;
                }
                if (null != e.GridCell.Tag)
                {
                    if (e.GridCell.Tag is Node)
                    {
                        editor.SelectedNode = (Node) e.GridCell.Tag;
                    }
                    else
                    {
                        var elabel = (ElectronicLabel) e.GridCell.Tag;
                        var index = allElectronicLabels.FindIndex(p => p.LabelID == elabel.LabelID);
                        editor.SelectedNode = editor.AdvTree.FindNodeByBindingIndex(index);
                    }
                }
            }
        }

        private void grdWarehouse_CloseEdit(object sender, GridCloseEditEventArgs e)
        {
            GridComboTreeEditControl editor = e.GridCell.GridColumn.EditControl as GridComboTreeEditControl;
            if (null != editor)
            {
                if (null != editor.SelectedNode)
                {
                    e.GridCell.Tag = editor.SelectedNode;
                }
                else
                {
                    e.GridCell.Value = null;
                }
            }
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            BindStorageStructureTree();
            grdWarehouse.Update();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            List<LabelStructure> dirtyLabelStructures = new List<LabelStructure>();
            foreach (GridElement element in grdWarehouse.ActiveGrid.FlatRows)
            {
                var row = element as GridRow;

                if (row != null && row.RowDirty)
                {
                    var structureID = (int)row.GetCell(0).Value;
                    var node = row.GetCell(4).Tag as Node;
                    if (node != null)
                    {
                        var elabel = node.DataKey as ElectronicLabel;
                        dirtyLabelStructures.Add(new LabelStructure
                        {
                            StructureID = structureID,
                            LabelID = elabel.LabelID
                        });
                    }
                }
            }
            _labelStructureService.SaveLabelStructures(dirtyLabelStructures);

            BindStorageStructureTree();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            if (DialogResult.Yes ==
                MessageBoxEx.Show("确定要删除货标关联？", "系统确认框", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1))
            {
                var row = (grdWarehouse.ActiveGrid.ActiveRow as GridRow);

                if (row != null)
                {
                    var structureID = (int)row.GetCell(0).Value;
                    if (row.GetCell(4).Tag is Node)
                    {
                        var node = row.GetCell(4).Tag as Node;
                        if (node != null)
                        {
                            var elabel = node.DataKey as ElectronicLabel;
                            _labelStructureService.DeleteLabelStructure(new LabelStructure
                            {
                                StructureID = structureID,
                                LabelID = elabel.LabelID
                            });
                        }
                    }
                    else
                    {
                        var elabel = row.GetCell(4).Tag as ElectronicLabel;
                        if (elabel != null)
                        {
                            _labelStructureService.DeleteLabelStructure(new LabelStructure
                            {
                                StructureID = structureID,
                                LabelID = elabel.LabelID
                            });
                        }
                    }
                }
                BindStorageStructureTree();
            }
        }

        private void btnRelationshipEdit_Click(object sender, System.EventArgs e)
        {
            FrmLabelRelationshipEdit doc = new FrmLabelRelationshipEdit();
            if (DialogResult.OK == doc.ShowDialog(this))
            {
                BindStorageStructureTree();
                grdWarehouse.Update();
            }
        }

    }
}