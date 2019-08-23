namespace WMS.Windows.App
{
    partial class FrmLabelManagement
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.treeLabels = new DevComponents.AdvTree.AdvTree();
            this.colCode = new DevComponents.AdvTree.ColumnHeader();
            this.colLabelName = new DevComponents.AdvTree.ColumnHeader();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtLabelID = new DevComponents.Editors.IntegerInput();
            this.txtAddress = new DevComponents.Editors.IpAddressInput();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.cbxLabelType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxPorts = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.panElabel = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.treeLabels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLabelID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            this.panElabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeLabels
            // 
            this.treeLabels.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeLabels.AllowDrop = true;
            this.treeLabels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeLabels.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeLabels.BackgroundStyle.Class = "TreeBorderKey";
            this.treeLabels.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeLabels.Columns.Add(this.colCode);
            this.treeLabels.Columns.Add(this.colLabelName);
            this.treeLabels.GridRowLines = true;
            this.treeLabels.HotTracking = true;
            this.treeLabels.Location = new System.Drawing.Point(0, 26);
            this.treeLabels.Name = "treeLabels";
            this.treeLabels.NodesConnector = this.nodeConnector1;
            this.treeLabels.NodeStyle = this.elementStyle1;
            this.treeLabels.ParentFieldNames = "LabelID,ParentLabelID";
            this.treeLabels.PathSeparator = ";";
            this.treeLabels.Size = new System.Drawing.Size(409, 388);
            this.treeLabels.Styles.Add(this.elementStyle1);
            this.treeLabels.Styles.Add(this.elementStyle2);
            this.treeLabels.TabIndex = 7;
            this.treeLabels.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.treeLabels_AfterNodeSelect);
            // 
            // colCode
            // 
            this.colCode.DataFieldName = "LabelCode";
            this.colCode.Name = "colCode";
            this.colCode.Text = "电子标签编码";
            this.colCode.Width.Absolute = 150;
            // 
            // colLabelName
            // 
            this.colLabelName.DataFieldName = "LabelName";
            this.colLabelName.Name = "colLabelName";
            this.colLabelName.Text = "电子标签名称";
            this.colLabelName.Width.Absolute = 230;
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle2
            // 
            this.elementStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.elementStyle2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.elementStyle2.BackColorGradientAngle = 90;
            this.elementStyle2.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderBottomWidth = 1;
            this.elementStyle2.BorderColor = System.Drawing.Color.DarkGray;
            this.elementStyle2.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderLeftWidth = 1;
            this.elementStyle2.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderRightWidth = 1;
            this.elementStyle2.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.elementStyle2.BorderTopWidth = 1;
            this.elementStyle2.CornerDiameter = 4;
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Description = "Blue";
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.PaddingBottom = 1;
            this.elementStyle2.PaddingLeft = 1;
            this.elementStyle2.PaddingRight = 1;
            this.elementStyle2.PaddingTop = 1;
            this.elementStyle2.TextColor = System.Drawing.Color.Black;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(37, 43);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(76, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "标签ID：";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(37, 97);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(76, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "标签名称：";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(37, 197);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(76, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "端口：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(37, 148);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(76, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "机器地址：";
            // 
            // txtLabelID
            // 
            // 
            // 
            // 
            this.txtLabelID.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtLabelID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLabelID.ButtonCalculator.Tooltip = "";
            this.txtLabelID.ButtonClear.Tooltip = "";
            this.txtLabelID.ButtonCustom.Tooltip = "";
            this.txtLabelID.ButtonCustom2.Tooltip = "";
            this.txtLabelID.ButtonDropDown.Tooltip = "";
            this.txtLabelID.ButtonFreeText.Checked = true;
            this.txtLabelID.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtLabelID.ButtonFreeText.Tooltip = "";
            this.txtLabelID.DisplayFormat = "0000";
            this.txtLabelID.FreeTextEntryMode = true;
            this.highlighter.SetHighlightOnFocus(this.txtLabelID, true);
            this.txtLabelID.Location = new System.Drawing.Point(119, 43);
            this.txtLabelID.MaxValue = 9999;
            this.txtLabelID.MinValue = 1;
            this.txtLabelID.Name = "txtLabelID";
            this.txtLabelID.ShowUpDown = true;
            this.txtLabelID.Size = new System.Drawing.Size(148, 27);
            this.txtLabelID.TabIndex = 0;
            this.txtLabelID.Value = 1001;
            // 
            // txtAddress
            // 
            this.txtAddress.AutoOverwrite = true;
            // 
            // 
            // 
            this.txtAddress.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.ButtonClear.Tooltip = "";
            this.txtAddress.ButtonCustom.Tooltip = "";
            this.txtAddress.ButtonCustom2.Tooltip = "";
            this.txtAddress.ButtonDropDown.Tooltip = "";
            this.txtAddress.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtAddress.ButtonFreeText.Tooltip = "";
            this.txtAddress.ButtonFreeText.Visible = true;
            this.highlighter.SetHighlightOnFocus(this.txtAddress, true);
            this.txtAddress.Location = new System.Drawing.Point(119, 148);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(148, 27);
            this.txtAddress.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Value = "127.0.0.1";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.highlighter.SetHighlightOnFocus(this.btnEdit, true);
            this.btnEdit.Location = new System.Drawing.Point(534, 26);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.highlighter.SetHighlightOnFocus(this.btnDelete, true);
            this.btnDelete.Location = new System.Drawing.Point(638, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.highlighter.SetHighlightOnFocus(this.btnAdd, true);
            this.btnAdd.Location = new System.Drawing.Point(426, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxLabelType
            // 
            this.cbxLabelType.DisplayMember = "Text";
            this.cbxLabelType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLabelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLabelType.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cbxLabelType, true);
            this.cbxLabelType.ItemHeight = 21;
            this.cbxLabelType.Location = new System.Drawing.Point(119, 98);
            this.cbxLabelType.Name = "cbxLabelType";
            this.cbxLabelType.Size = new System.Drawing.Size(148, 27);
            this.cbxLabelType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxLabelType.TabIndex = 1;
            this.cbxLabelType.WatermarkText = "7位数字电子标签";
            this.cbxLabelType.SelectedValueChanged += new System.EventHandler(this.cbxLabelType_SelectedValueChanged);
            // 
            // cbxPorts
            // 
            this.cbxPorts.DisplayMember = "Text";
            this.cbxPorts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPorts.FormattingEnabled = true;
            this.highlighter.SetHighlightOnFocus(this.cbxPorts, true);
            this.cbxPorts.ItemHeight = 21;
            this.cbxPorts.Location = new System.Drawing.Point(119, 197);
            this.cbxPorts.Name = "cbxPorts";
            this.cbxPorts.Size = new System.Drawing.Size(148, 27);
            this.cbxPorts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxPorts.TabIndex = 3;
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // panElabel
            // 
            this.panElabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panElabel.CanvasColor = System.Drawing.SystemColors.Control;
            this.panElabel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panElabel.Controls.Add(this.cbxPorts);
            this.panElabel.Controls.Add(this.txtLabelID);
            this.panElabel.Controls.Add(this.btnCancel);
            this.panElabel.Controls.Add(this.cbxLabelType);
            this.panElabel.Controls.Add(this.btnSave);
            this.panElabel.Controls.Add(this.labelX4);
            this.panElabel.Controls.Add(this.labelX1);
            this.panElabel.Controls.Add(this.txtAddress);
            this.panElabel.Controls.Add(this.labelX3);
            this.panElabel.Controls.Add(this.labelX2);
            this.panElabel.DisabledBackColor = System.Drawing.Color.Empty;
            this.panElabel.Enabled = false;
            this.panElabel.ExpandButtonVisible = false;
            this.panElabel.HideControlsWhenCollapsed = true;
            this.panElabel.Location = new System.Drawing.Point(415, 68);
            this.panElabel.Name = "panElabel";
            this.panElabel.Size = new System.Drawing.Size(391, 346);
            this.panElabel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panElabel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panElabel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panElabel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panElabel.Style.GradientAngle = 90;
            this.panElabel.TabIndex = 9;
            this.panElabel.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panElabel.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panElabel.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panElabel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panElabel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panElabel.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panElabel.TitleStyle.GradientAngle = 90;
            this.panElabel.TitleText = "电子标签设置";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(165, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(57, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmLabelManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 426);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panElabel);
            this.Controls.Add(this.treeLabels);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLabelManagement";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "标签管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLabelManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeLabels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLabelID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            this.panElabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.AdvTree.AdvTree treeLabels;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.IntegerInput txtLabelID;
        private DevComponents.Editors.IpAddressInput txtAddress;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxLabelType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxPorts;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.AdvTree.ColumnHeader colCode;
        private DevComponents.AdvTree.ColumnHeader colLabelName;
        private DevComponents.DotNetBar.ExpandablePanel panElabel;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;

    }
}