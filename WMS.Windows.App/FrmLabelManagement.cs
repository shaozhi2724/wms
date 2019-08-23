using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WMS.App.Services;
using WMS.Model;

namespace WMS.Windows.App
{
    public partial class FrmLabelManagement : Office2007Form
    {
        private readonly Dictionary<string, string> _eLabelTypes = new Dictionary<string, string>
            {
                {"4位数字标识通道灯","4位数字标识通道灯"},
                {"7位数字电子标签","7位数字电子标签"}
            };
        Dictionary<string, string> _ports = new Dictionary<string, string>();
        private IELabelService _service;
        public FrmLabelManagement()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;
            _service = new ELabelService();
        }

        private void FrmLabelManagement_Load(object sender, EventArgs e)
        {
            BindLabelTree();
            BindLabelTypes();
            BindSerialPorts();

            if (null == treeLabels.SelectedNode)
            {
                return;
            }
            var elabel = treeLabels.SelectedNode.DataKey as ElectronicLabel;

            LoadELabelDetail(elabel);
        }

        private void BindLabelTree()
        {
            var elabels = _service.GetAllElectronicLabels().OrderBy(p => p.LabelCode).ToList();
            treeLabels.DataSource = elabels;
            treeLabels.ExpandAll();

            if (!elabels.Any())
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void BindSerialPorts()
        {
            var names = from p in SerialPort.GetPortNames().Distinct()
                select new
                {
                    Letter = int.Parse(Regex.Replace(p, "COM", "", RegexOptions.IgnoreCase)),
                    Key = p,
                    Value = p
                };
            _ports = names.OrderBy(p => p.Letter).ToDictionary(p => p.Key, v => v.Value);
            if (_ports.Any())
            {
                cbxPorts.DataSource = new BindingSource(_ports, null);
                cbxPorts.DisplayMember = "Value";
                cbxPorts.ValueMember = "Key";
            }
        }

        private void BindLabelTypes()
        {
            cbxLabelType.DataSource = new BindingSource(_eLabelTypes, null);
            cbxLabelType.DisplayMember = "Value";
            cbxLabelType.ValueMember = "Key";
        }

        private void treeLabels_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {

            if (null == treeLabels.SelectedNode)
            {
                return;
            }
            var elabel = treeLabels.SelectedNode.DataKey as ElectronicLabel;
            LoadELabelDetail(elabel);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            panElabel.Tag = DataAction.Add;

            panElabel.TitleText = "电子标签信息 - 添加";

            panElabel.Enabled = true;

            txtAddress.Value = "127.0.0.1";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (null == treeLabels.SelectedNode)
            {
                return;
            }
            var elabel = treeLabels.SelectedNode.DataKey as ElectronicLabel;
            LoadELabelDetail(elabel);
            panElabel.Tag = DataAction.Edit;

            panElabel.TitleText = "电子标签信息 - 修改";
            panElabel.Enabled = true;
        }

        private void LoadELabelDetail(ElectronicLabel elabel)
        {
            if (elabel.ParentLabelID.HasValue)
            {
                txtLabelID.DisplayFormat = new string('0', 4);
                txtLabelID.MaxValue = 9999;
            }
            else
            {
                txtLabelID.DisplayFormat = new string('0', 4);
                txtLabelID.MaxValue = 9999;
            }

            txtLabelID.Value = int.Parse(elabel.LabelCode);
            txtAddress.Value = elabel.LabelAddress;
            cbxLabelType.SelectedValue = elabel.LabelType;

            if (_ports.Any())
            {
                if (_ports.ContainsValue(elabel.LabelPortName))
                {
                    cbxPorts.SelectedValue = elabel.LabelPortName;
                }
                else
                {
                    _ports.Add(elabel.LabelPortName, elabel.LabelPortName);
                    cbxPorts.DataSource = new BindingSource(_ports, null);
                    cbxPorts.DisplayMember = "Value";
                    cbxPorts.ValueMember = "Key";
                    cbxPorts.SelectedValue = elabel.LabelPortName;
                }
            }
            else
            {
                cbxPorts.Text = elabel.LabelPortName;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            if (null == treeLabels.SelectedNode)
            {
                return;
            }
            string confirmMessage = "确定删除？";
            if (treeLabels.SelectedNode.HasChildNodes)
            {
                confirmMessage = "要删除的通道灯具有下级电子标签，其下级电子标签也将一并删除，确定要删除？";
            }
            if (DialogResult.Yes ==
                MessageBoxEx.Show(confirmMessage, "系统确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                var treeViewModel = treeLabels.SelectedNode.DataKey as ElectronicLabel;
                if (null != treeViewModel)
                {
                    var entityID = treeViewModel.LabelID;
                    if (treeLabels.SelectedNode.HasChildNodes)
                    {
                        _service.DeleteElectronicLabelGraph(entityID);
                    }
                    else
                    {
                        _service.DeleteElectronicLabel(entityID);
                    }
                    BindLabelTree();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedNode = treeLabels.SelectedNode;

            ElectronicLabel elabel = null;
            if (null != panElabel.Tag)
            {
                DataAction action = panElabel.Tag is DataAction ? (DataAction)panElabel.Tag : DataAction.Add;

                int? parentLabelID = null;
                if (null != selectedNode)
                {
                    elabel = selectedNode.DataKey as ElectronicLabel;
                    if (null != selectedNode.Parent)
                    {
                        var parentELabel = selectedNode.Parent.DataKey as ElectronicLabel;
                        parentLabelID = parentELabel.LabelID;
                    }
                    else
                    {
                        if (action == DataAction.Add)
                        {
                            parentLabelID = elabel.LabelID;
                        }
                    }
                }
                string labelCode = txtLabelID.Text.Trim();
                string labelType = cbxLabelType.SelectedValue.ToString();
                //通道灯
                if (labelType == _eLabelTypes.First().Key)
                {
                    parentLabelID = null;
                    txtLabelID.DisplayFormat = new string('0', 4);
                    txtLabelID.MaxValue = 9999;
                }
                string labelName = string.Format("{0}({1})", labelType, labelCode);
                string address = txtAddress.Value;
                string port = "";
                if (null != cbxPorts.SelectedItem)
                {
                    port = cbxPorts.SelectedValue.ToString();
                }
                else
                {
                    port = cbxPorts.Text.Trim();
                }

                switch (action)
                {
                    case DataAction.Add:
                        
                        _service.SaveElectronicLabel(new ElectronicLabel
                        {
                            LabelName = labelName,
                            LabelCode = labelCode,
                            LabelAddress = address,
                            LabelPortName = port,
                            ParentLabelID = parentLabelID,
                            LabelType = labelType,
                            CreateDate = DateTime.Now
                        });
                        break;
                    case DataAction.Edit:
                        elabel.LabelName = labelName;
                        elabel.LabelCode = labelCode;
                        elabel.LabelPortName = port;
                        elabel.LabelType = labelType;
                        elabel.LabelAddress = address;
                        elabel.ParentLabelID = parentLabelID;
                        elabel.LastModifyDate = DateTime.Now;
                        _service.SaveElectronicLabel(elabel);
                        break;
                }
                BindLabelTree();

                panElabel.TitleText = "电子标签信息";
                panElabel.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panElabel.TitleText = "电子标签信息";
            panElabel.Tag = null;
            panElabel.Enabled = false;

            if (null == treeLabels.SelectedNode)
            {
                return;
            }
            var elabel = treeLabels.SelectedNode.DataKey as ElectronicLabel;

            LoadELabelDetail(elabel);
        }

        private void cbxLabelType_SelectedValueChanged(object sender, EventArgs e)
        {

            string labelType = cbxLabelType.SelectedValue.ToString();
            //通道灯
            if (labelType == _eLabelTypes.First().Key)
            {
                txtLabelID.DisplayFormat = new string('0', 4);
                txtLabelID.MaxValue = 9999;

                txtLabelID.Value = 2001;
            }
            else
            {
                //电子标签
                txtLabelID.DisplayFormat = new string('0', 4);
                txtLabelID.MaxValue = 9999;

                txtLabelID.Value = 1001;
            }
        }
    }
}