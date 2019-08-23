using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using WMS.App.Services;
using WMS.Model;

namespace WMS.Windows.App
{
    public partial class FrmWarehouseUnit : Office2007Form
    {
        private IWarehouseService _warehouseService;
        private IStorageStructureService _service;
        
        private string _selectedNodeLevel;
        private readonly Dictionary<string, string> _storeTypes = new Dictionary<string, string>
        {
            {"����","����"},
            {"����","����"},
            {"��λ","��λ"},
            {"����","����"}
        };
        private readonly Dictionary<string, string> _structureTypes = new Dictionary<string, string>
            {
                {"Z","����"},
                {"L","���"},
                {"T","�˻�"},
                {"B","���ϸ�Ʒ"}
            };
        public FrmWarehouseUnit()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _warehouseService = new WarehouseService();
            _service = new StorageStructureService();
        }

        private void swbCodeGenType_ValueChanged(object sender, EventArgs e)
        {
            bool isSingleCode = swbCodeGenType.Value;
            lblStartCode.Visible = !isSingleCode;
            lblEndCode.Visible = !isSingleCode;
            txtEndCode.Visible = !isSingleCode;
            txtUnitName.Enabled = isSingleCode;
            if (isSingleCode)
            {
                if (!string.IsNullOrEmpty(lblCurrentUnitName.Text))
                {
                    lblCurrentUnitName.Text = string.Empty;
                }
                lblCurrentUnitCode.Text = txtStartCode.Text;
                
            }
            else
            {
                lblCurrentUnitCode.Text = string.Concat(txtStartCode.Text, " - ", txtEndCode.Text);

            }
            
            if (!string.IsNullOrEmpty(txtUnitName.Text))
            {
                lblCurrentUnitName.Text = string.Concat(lblCurrentUnitCode.Text, txtUnitName.Text.Trim());
            }
        }

        private void cbxStoreType_SelectedValueChanged(object sender, EventArgs e)
        {
            var isArea = false;
            var isShelf = false;
            if (null != cbxStoreType.SelectedValue)
            {
                isArea = cbxStoreType.SelectedValue.ToString().Equals("����");
                isShelf = cbxStoreType.SelectedValue.ToString().Equals("����");
            }
            chkIsActive.Visible = !isArea && !isShelf;
            //��������ѡ�������ͺͻ�������
            lblStructureType.Enabled = isArea;
            cbxStructureType.Enabled = isArea;

            lblControlType.Enabled = isArea;
            cbxControlType.Enabled = isArea;

            //�����ͻ���ֻ��ʹ�õ������룬���ܶ������
            bool isGeneratorDisabled = isShelf || isArea;
            if (isGeneratorDisabled)
            {
                swbCodeGenType.Value = true;
            }
            swbCodeGenType.IsReadOnly = isGeneratorDisabled;
            //���������Ҫ�޸ĵ�ǰ�洢��Ԫ����
            ChangeUnitNameByCodeGenType();

            //��ѡ�����ڵ���ʾĬ�ϵ��ϼ��洢��Ԫ���뼰����
            if (treeStoreUnit.SelectedNodes.Count > 0)
            {
                var dataAction = panStoreUnit.Tag is DataAction ? (DataAction) panStoreUnit.Tag : DataAction.Add;
                if (dataAction == DataAction.Add)
                {
                    lblParentUnitCode.Text = treeStoreUnit.SelectedNode.Cells[0].Text;
                    lblParentUnitName.Text = treeStoreUnit.SelectedNode.Cells[1].Text;
                }
            }

            //�������ܹ�ѡ��С��Ԫ
            chkIsMinUnit.Enabled = !isArea;
            if (isArea)
            {
                chkIsMinUnit.Checked = false;
                txtBarcode.Text = string.Empty;
                txtBarcode.Enabled = false;

                //��������ѡ�����,�������Զ������
                txtStartCode.Enabled = false;
                txtEndCode.Enabled = false;
                txtAreaCode.Enabled = true;
                if (cbxStructureType.Enabled)
                {
                    txtAreaCode.Text = cbxStructureType.SelectedValue.ToString();
                }

                swbCodeGenType.Enabled = false;
                if (null != cbxStructureType.SelectedValue)
                {
                    lblCurrentUnitCode.Text = cbxStructureType.SelectedValue.ToString();
                }

            }
            else
            {
                txtStartCode.Enabled = true;
                txtEndCode.Enabled = true;
                txtAreaCode.Text = string.Empty;
                txtAreaCode.Enabled = false;
                if (swbCodeGenType.Value)
                {
                    lblCurrentUnitCode.Text = txtStartCode.Text;
                }
                else
                {
                    lblCurrentUnitCode.Text = string.Concat(txtStartCode.Text, " - ", txtEndCode.Text);
                }
                swbCodeGenType.Enabled = true;
            }

        }

        private void chkIsMinUnit_CheckedChanged(object sender, EventArgs e)
        {
            ChangeMinUnitBarcode();
        }

        private void ChangeMinUnitBarcode()
        {
            var isMinUnit = chkIsMinUnit.Checked;
            lblBarcode.Enabled = txtBarcode.Enabled = isMinUnit;

            string barCode = string.Empty;
            if (isMinUnit)
            {
                barCode = string.Concat(lblParentUnitCode.Text.Trim(), lblCurrentUnitCode.Text.Trim());
            }
            txtBarcode.Text = barCode;
        }

        private void RestrcitStoreTypeBySelectedNodeLevel()
        {
            DataAction dataAction = panStoreUnit.Tag is DataAction ? (DataAction) panStoreUnit.Tag : DataAction.Add;
            bool isAdd = dataAction == DataAction.Add;
            var storeTypes = new Dictionary<string, string>();
            foreach (var storeType in _storeTypes)
            {
                storeTypes.Add(storeType.Key, storeType.Value);
            }

            switch (_selectedNodeLevel)
            {
                case "W":
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    break;
                case "A":
                    if (isAdd)
                    {
                        storeTypes.Remove("����");
                    }
                    else
                    {
                        storeTypes.Remove("����");
                        storeTypes.Remove("��λ");
                        storeTypes.Remove("����");

                        swbCodeGenType.Enabled = false;
                        txtStartCode.Enabled = false;
                        txtEndCode.Enabled = false;
                    }
                    btnSave.Enabled = true;
                    break;
                case "S":
                    if (isAdd)
                    {
                        storeTypes.Remove("����");
                        storeTypes.Remove("����");
                    }
                    else
                    {
                        storeTypes.Remove("����");
                        storeTypes.Remove("��λ");
                        storeTypes.Remove("����");
                    }
                    btnSave.Enabled = true;
                    break;
                case "P":
                    storeTypes.Remove("����");
                    storeTypes.Remove("����");
                    btnSave.Enabled = true;
                    break;
                default:
                    return;
            }
            //cbxStoreType.DataSource = storeTypes;
            cbxStoreType.DataSource = new BindingSource(storeTypes, null);
            cbxStoreType.DisplayMember = "Value";
            cbxStoreType.ValueMember = "Key";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panStoreUnit.Tag = DataAction.Add;
            var isSelectedMinLevel = _selectedNodeLevel != "P";
            if (_selectedNodeLevel == "W")
            {
                panStoreUnit.Enabled = true;
            }
            else
            {
                panStoreUnit.Enabled = isSelectedMinLevel;
            }
            RestrcitStoreTypeBySelectedNodeLevel();
            txtUnitName.Text = "";
            lblCurrentUnitName.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panStoreUnit.Tag = DataAction.Edit;
            RestrcitStoreTypeBySelectedNodeLevel();
            panStoreUnit.Enabled = true;
            var selectedNode = treeStoreUnit.SelectedNode;
            var parentNode = selectedNode.Parent;
            if (null == selectedNode)
            {
                return;
            }
            var selectedUnit = selectedNode.DataKey as StorageStructureTreeViewModel;
            StorageStructureTreeViewModel parentUnit = null;
            if (null != parentNode)
            {
                parentUnit = parentNode.DataKey as StorageStructureTreeViewModel;
            }
            if (null != selectedUnit)
            {
                LoadStorageStructureDetail(selectedUnit, parentUnit);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBoxEx.UseSystemLocalizedString = true;
            MessageBoxEx.EnableGlass = false;
            if (null == treeStoreUnit.SelectedNode)
            {
                return;
            }
            string confirmMessage = "ȷ��ɾ����";
            if (treeStoreUnit.SelectedNode.HasChildNodes)
            {
                confirmMessage = "Ҫɾ���Ĵ洢��Ԫ�����¼���Ԫ�����¼���ԪҲ��һ��ɾ����ȷ��Ҫɾ����";
            }
            if (DialogResult.Yes ==
                MessageBoxEx.Show(confirmMessage, "ϵͳȷ����Ϣ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                var treeViewModel = treeStoreUnit.SelectedNode.DataKey as StorageStructureTreeViewModel;
                if (null != treeViewModel)
                {
                    var entityID = treeViewModel.StructureID;
                    if (treeStoreUnit.SelectedNode.HasChildNodes)
                    {
                        _service.DeleteStorageStructureGraph(entityID, treeViewModel.StructureCode);
                    }
                    else
                    {
                        _service.DeleteStorageStructure(entityID);
                    }
                    BindStorageStructureTree();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedNode = treeStoreUnit.SelectedNode;
            if (null == selectedNode)
            {
                return;
            }
            var parentUnit = selectedNode.DataKey as StorageStructureTreeViewModel;
            if (null == parentUnit)
            {
                return;
            }
            if (null != panStoreUnit.Tag)
            {
                int warehouseID = parentUnit.WarehouseID;
                string storeType = cbxStoreType.SelectedValue.ToString();
                string areaType = string.Empty;
                if (null != cbxStructureType.SelectedItem)
                {
                    areaType = _structureTypes[cbxStructureType.SelectedValue.ToString()];
                }
                int structureStyle = (int) cbxControlType.SelectedValue;
                string storeUnitName = string.Concat(lblParentUnitName.Text, lblCurrentUnitName.Text.Trim());
                int startCode = txtStartCode.Value;
                int endCode = txtEndCode.Value;
                string location = txtLocation.Text.Trim();
                string charge = txtCharge.Text.Trim();
                bool isMinUnit = chkIsMinUnit.Checked;
                string barCode = txtBarcode.Text.Trim();
                string areaCode = txtAreaCode.Text.Trim();
                string parentStructureCode = lblParentUnitCode.Text;
                DataAction action = panStoreUnit.Tag is DataAction ? (DataAction) panStoreUnit.Tag : DataAction.Add;
                switch (action)
                {
                    case DataAction.Add:
                        if (swbCodeGenType.Value)
                        {
                            //����
                            _service.SaveStorageStructure(new StorageStructure
                            {
                                WarehouseID = warehouseID,
                                StructureName = storeUnitName,
                                StructureType = storeType,
                                AreaType = areaType,
                                IsMinStructure = isMinUnit,
                                StructureBarCode = barCode,
                                ParentStructureCode = parentUnit.StructureCode,
                                StructureCode = string.Concat(lblParentUnitCode.Text, lblCurrentUnitCode.Text),
                                StructureLocation = location,
                                StructureLeader = charge,
                                StructureStyle = structureStyle,
                                IsActive = chkIsActive.Checked
                            });
                        }
                        else
                        {
                            //���
                            if (startCode != endCode)
                            {
                                var codes = Enumerable.Range(startCode, endCode - startCode + 1);
                                foreach (var code in codes)
                                {
                                    string currentCode = code.ToString().PadLeft(2, '0');
                                    string currentUnitName = string.Concat(parentUnit.StructureName, currentCode,
                                        txtUnitName.Text.Trim());
                                    if (!txtUnitName.Enabled)
                                    {
                                        currentUnitName = string.Concat(parentUnit.StructureName, currentCode,
                                            cbxStoreType.SelectedValue.ToString());
                                    }
                                    string currentStructureCode = string.Concat(lblParentUnitCode.Text, currentCode);
                                    _service.SaveStorageStructure(new StorageStructure
                                    {
                                        WarehouseID = warehouseID,
                                        StructureName = currentUnitName,
                                        StructureType = storeType,
                                        AreaType = areaType,
                                        IsMinStructure = isMinUnit,
                                        StructureBarCode = currentStructureCode,
                                        ParentStructureCode = parentUnit.StructureCode,
                                        StructureCode = currentStructureCode,
                                        StructureLocation = location,
                                        StructureLeader = charge,
                                        StructureStyle = structureStyle,
                                        IsActive = chkIsActive.Checked
                                    });
                                }
                            }
                        }
                        break;
                    case DataAction.Edit:
                        if (swbCodeGenType.Value)
                        {
                            //����
                            var currentStructure = _service.GetStorageStructure(parentUnit.StructureID);
                            currentStructure.WarehouseID = warehouseID;
                            currentStructure.StructureName = storeUnitName;
                            currentStructure.StructureType = storeType;
                            currentStructure.AreaType = areaType;
                            currentStructure.IsMinStructure = isMinUnit;
                            if (isMinUnit)
                            {
                                currentStructure.StructureBarCode = barCode;
                            }
                            else
                            {
                                currentStructure.StructureBarCode = null;
                            }
                            currentStructure.ParentStructureCode = currentStructure.ParentStructureCode;
                            currentStructure.StructureCode = string.Concat(lblParentUnitCode.Text,
                                lblCurrentUnitCode.Text);
                            currentStructure.StructureLocation = location;
                            currentStructure.StructureLeader = charge;
                            currentStructure.StructureStyle = structureStyle;
                            currentStructure.IsActive = chkIsActive.Checked;
                            _service.SaveStorageStructure(currentStructure);
                        }
                        break;
                }
                BindStorageStructureTree();
                panStoreUnit.Enabled = false;
            }
            treeStoreUnit.SelectedNode = selectedNode;
        }

        private void treeStoreUnit_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            if (null == treeStoreUnit.SelectedNode)
            {
                return;
            }
            var treeViewModel = treeStoreUnit.SelectedNode.DataKey as StorageStructureTreeViewModel;
            if (null != treeViewModel)
            {
                _selectedNodeLevel = ParseNodeLevel(treeViewModel.StructureType);
                var isSelectedMinLevel = _selectedNodeLevel == "P";
                btnAdd.Enabled = !isSelectedMinLevel;
                if (panStoreUnit.Enabled && isSelectedMinLevel)
                {
                    panStoreUnit.Enabled = false;
                }
                btnEdit.Enabled = btnDelete.Enabled = null != treeStoreUnit.SelectedNode;
                chkIsActive.Checked = treeViewModel.IsActive;
                //RestrcitStoreTypeBySelectedNodeLevel();

                //LoadStorageStructureDetail(treeViewModel);
            }
            btnEdit.PerformClick();
            panStoreUnit.Enabled = false;
        }

        private void LoadStorageStructureDetail(StorageStructureTreeViewModel currentModel, StorageStructureTreeViewModel parentModel = null)
        {
            if (null != currentModel && currentModel.StructureID > 0)
            {
                var structure = _service.GetStorageStructure(currentModel.StructureID);
                if (null != parentModel)
                {
                    if (structure.StructureType != "����")
                    {
                        var currentCodeValue =
                            int.Parse(new Regex(parentModel.StructureCode).Replace(structure.StructureCode, "", 1));

                        txtStartCode.Value = currentCodeValue;
                    }
                    txtUnitName.Text = new Regex(txtStartCode.Text).Replace(new Regex(parentModel.StructureName).Replace(structure.StructureName, "", 1), "", 1);
                }
                else
                {
                    txtUnitName.Text = structure.StructureName;
                }
                cbxStoreType.SelectedValue = structure.StructureType;
                if (!string.IsNullOrWhiteSpace(structure.AreaType))
                {
                    cbxStructureType.SelectedValue = _structureTypes.FirstOrDefault(x => x.Value == structure.AreaType).Key;
                }

                if (structure.StructureStyle.HasValue)
                {
                    if (structure.StructureType == "����")
                    {
                        cbxControlType.SelectedValue = structure.StructureStyle.Value;

                        lblCurrentUnitCode.Text = cbxStructureType.SelectedValue.ToString();
                    }
                    else
                    {
                        cbxControlType.SelectedValue = structure.StructureStyle.Value;
                    }
                }
                else
                {
                    if (null != parentModel)
                    {
                        cbxControlType.SelectedValue = parentModel.StructureStyle;
                    }
                    else
                    {
                        cbxControlType.SelectedValue = 0;
                    }
                }
                txtAreaCode.Text = new Regex(structure.ParentStructureCode).Replace(structure.StructureCode, "", 1);
                if (txtAreaCode.Enabled)
                {
                    lblCurrentUnitCode.Text = txtAreaCode.Text.Trim();
                }
                txtCharge.Text = structure.StructureLeader;
                txtLocation.Text = structure.StructureLocation;
                txtBarcode.Text = structure.StructureBarCode;
                chkIsMinUnit.Checked = structure.IsMinStructure.HasValue && structure.IsMinStructure.Value;
                if (null != parentModel)
                {
                    lblParentUnitCode.Text = parentModel.StructureCode;
                    lblParentUnitName.Text = parentModel.StructureName;
                }
            }
        }

        private string ParseNodeLevel(string nodeText)
        {
            switch (nodeText)
            {
                case "�ֿ�":
                    return "W";
                case "����":
                    return "A";
                case "����":
                    return "S";
                case "��λ":
                case "����":
                    return "P";
                default:
                    return string.Empty;
            }
        }

        private void txtStartCode_ValueChanged(object sender, EventArgs e)
        {
            lblCurrentUnitCode.Text = txtStartCode.Text;

            ChangeMinUnitBarcode();
            if (!string.IsNullOrEmpty(txtUnitName.Text))
            {
                lblCurrentUnitName.Text = string.Concat(lblCurrentUnitCode.Text, txtUnitName.Text.Trim());
            }
        }

        private void txtEndCode_ValueChanged(object sender, EventArgs e)
        {
            ChangeUnitNameByCodeGenType();
            lblCurrentUnitCode.Text = string.Concat(txtStartCode.Text, " - ", txtEndCode.Text);

            if (!string.IsNullOrEmpty(txtUnitName.Text))
            {
                lblCurrentUnitName.Text = string.Concat(lblCurrentUnitCode.Text, txtUnitName.Text.Trim());
            }
        }

        private void ChangeUnitNameByCodeGenType()
        {
            //�������ʱ
            if (!swbCodeGenType.Value)
            {
                txtUnitName.Enabled = false;
                if (null != cbxStoreType.SelectedItem)
                {
                    lblCurrentUnitName.Text = string.Concat(txtStartCode.Text, " - ", txtEndCode.Text, cbxStoreType.SelectedItem.ToString());
                }
            }
        }

        private void txtUnitName_TextChanged(object sender, EventArgs e)
        {
            if (cbxStoreType.SelectedValue.ToString() == "����")
            {
                lblCurrentUnitName.Text = txtUnitName.Text.Trim();
            }
            else
            {
                lblCurrentUnitName.Text = string.Concat(lblCurrentUnitCode.Text, txtUnitName.Text.Trim());
            }
        }

        private void cbxStructureType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxStructureType.Enabled)
            {
                if (null != cbxStructureType.SelectedValue)
                {
                    txtStartCode.Enabled = false;
                    txtEndCode.Enabled = false;
                    txtAreaCode.Enabled = true;
                    txtAreaCode.Text = cbxStructureType.SelectedValue.ToString();
                    lblCurrentUnitCode.Text = cbxStructureType.SelectedValue.ToString();

                    swbCodeGenType.Enabled = false;
                }
            }
            else
            {
                txtStartCode.Enabled = true;
                txtEndCode.Enabled = true;
                txtAreaCode.Text = string.Empty;
                lblCurrentUnitCode.Text = string.Empty;
                swbCodeGenType.Enabled = true;
            }

        }

        private void FrmWarehouseUnit_Load(object sender, EventArgs e)
        {
            BindStorageStructureTree();

            BindStructureTypes();

            BindControlTypes();
        }

        private void BindStorageStructureTree()
        {
            var warehouses = _warehouseService.GetAllWarehouses();

            var structures = _service.GetAllStorageStructures();

            List<StorageStructureTreeViewModel> data = new List<StorageStructureTreeViewModel>();
            foreach (var warehouse in warehouses)
            {
                data.Add(new StorageStructureTreeViewModel
                {
                    WarehouseID = warehouse.WarehouseID,
                    StructureCode = warehouse.WarehouseCode,
                    StructureLocation = warehouse.WarehouseAddress,
                    StructureBarCode = "",
                    StructureName = warehouse.WarehouseName,
                    StructureType = "�ֿ�",
                    StructureStyle = 0,
                    IsActive = warehouse.IsActive ?? true
                });

                data.AddRange(
                    structures.Where(p => p.WarehouseID == warehouse.WarehouseID)
                        .Select(p => new StorageStructureTreeViewModel
                        {
                            WarehouseID = warehouse.WarehouseID,
                            StructureID = p.StructureID,
                            ParentStructureCode = p.ParentStructureCode,
                            StructureCode = p.StructureCode,
                            StructureBarCode = p.StructureBarCode,
                            StructureLocation = p.StructureLocation,
                            StructureName = p.StructureName,
                            StructureType = p.StructureType,
                            StructureStyle = p.StructureStyle.HasValue ? p.StructureStyle.Value : 0,
                            IsActive = p.IsActive ?? true
                        }));
            }

            treeStoreUnit.DataSource = data;
            treeStoreUnit.ExpandAll();
        }


        private void BindStructureTypes()
        {
            
            cbxStructureType.DataSource = new BindingSource(_structureTypes, null);
            cbxStructureType.DisplayMember = "Value";
            cbxStructureType.ValueMember = "Key";
        }

        private void BindControlTypes()
        {
            Dictionary<int, string> types = new Dictionary<int, string>
            {
                {0,"�޿���"},
                {1,"���ӱ�ǩ����"},
                {2,"PDA����"}
            };
            cbxControlType.DataSource = new BindingSource(types, null);
            cbxControlType.DisplayMember = "Value";
            cbxControlType.ValueMember = "Key";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
            panStoreUnit.Tag = null;
            panStoreUnit.Enabled = false;
        }

        private void txtAreaCode_TextChanged(object sender, EventArgs e)
        {
            lblCurrentUnitCode.Text = txtAreaCode.Text.Trim();
        }

        private void treeStoreUnit_AfterExpand(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {

            StorageStructureTreeViewModel data = e.Node.DataKey as StorageStructureTreeViewModel;
            if(null != data)
            {
                foreach (Cell cell in e.Node.Cells)
                {
                    if (!data.IsActive)
                    {
                        cell.StyleNormal = new ElementStyle(Color.Red);
                    }
                    cell.Text = cell.Text.Replace("True","��").Replace("False","��");
                }
            }
        }
    }
}