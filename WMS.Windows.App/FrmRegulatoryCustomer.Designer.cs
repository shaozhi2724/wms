namespace WMS.Windows.App
{
    partial class FrmRegulatoryCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn7 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn8 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.customValidator1 = new DevComponents.DotNetBar.Validator.CustomValidator();
            this.grdCustomers = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbxCustomerType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxMatch = new DevComponents.Editors.ComboItem();
            this.cbxNotMatch = new DevComponents.Editors.ComboItem();
            this.dealerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnSearchAll = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dealerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(5, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 27);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(138, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 27);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            // 
            // customValidator1
            // 
            this.customValidator1.ErrorMessage = "Your error message here.";
            this.customValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // grdCustomers
            // 
            this.grdCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCustomers.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.None;
            this.grdCustomers.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdCustomers.Location = new System.Drawing.Point(2, 111);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.PrimaryGrid.ActiveRowIndicatorStyle = DevComponents.DotNetBar.SuperGrid.ActiveRowIndicatorStyle.Both;
            this.grdCustomers.PrimaryGrid.AllowRowHeaderResize = true;
            this.grdCustomers.PrimaryGrid.AllowRowResize = true;
            this.grdCustomers.PrimaryGrid.AutoGenerateColumns = false;
            this.grdCustomers.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn5.DataPropertyName = "DealerID";
            gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn5.HeaderText = "DealerID";
            gridColumn5.Name = "colDealerID";
            gridColumn5.ReadOnly = true;
            gridColumn5.Visible = false;
            gridColumn6.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            gridColumn6.DataPropertyName = "DealerName";
            gridColumn6.HeaderText = "本系统单位名称";
            gridColumn6.Name = "colDealerName";
            gridColumn6.ReadOnly = true;
            gridColumn6.RenderType = typeof(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl);
            gridColumn6.Width = 350;
            gridColumn7.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.None;
            gridColumn7.DataPropertyName = "CustomerName";
            gridColumn7.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            gridColumn7.HeaderText = "监管网单位名称";
            gridColumn7.Name = "colCustomerName";
            gridColumn7.RenderType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            gridColumn8.AllowEdit = false;
            gridColumn8.DataPropertyName = "CustomerCode";
            gridColumn8.HeaderText = "监管网单位编码";
            gridColumn8.Name = "colCustomerCode";
            gridColumn8.ReadOnly = true;
            this.grdCustomers.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdCustomers.PrimaryGrid.Columns.Add(gridColumn6);
            this.grdCustomers.PrimaryGrid.Columns.Add(gridColumn7);
            this.grdCustomers.PrimaryGrid.Columns.Add(gridColumn8);
            this.grdCustomers.PrimaryGrid.DefaultRowHeight = 30;
            this.grdCustomers.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCustomers.PrimaryGrid.EnableColumnFiltering = true;
            this.grdCustomers.PrimaryGrid.EnableFiltering = true;
            this.grdCustomers.PrimaryGrid.EnableNoRowsMarkup = true;
            this.grdCustomers.PrimaryGrid.EnableRowFiltering = true;
            this.grdCustomers.PrimaryGrid.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Square;
            this.grdCustomers.PrimaryGrid.ImmediateResize = true;
            this.grdCustomers.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.grdCustomers.PrimaryGrid.MultiSelect = false;
            this.grdCustomers.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdCustomers.PrimaryGrid.PrimaryColumnIndex = 1;
            this.grdCustomers.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdCustomers.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdCustomers.PrimaryGrid.ShowRowGridIndex = true;
            this.grdCustomers.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.grdCustomers.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdCustomers.Size = new System.Drawing.Size(1164, 421);
            this.grdCustomers.TabIndex = 36;
            this.grdCustomers.TouchEnabled = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(2, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(153, 23);
            this.labelX1.TabIndex = 38;
            this.labelX1.Text = "往来单位查询条件：";
            // 
            // cbxCustomerType
            // 
            this.cbxCustomerType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomerType.FormattingEnabled = true;
            this.cbxCustomerType.ItemHeight = 21;
            this.cbxCustomerType.Items.AddRange(new object[] {
            this.cbxMatch,
            this.cbxNotMatch});
            this.cbxCustomerType.Location = new System.Drawing.Point(161, 12);
            this.cbxCustomerType.Name = "cbxCustomerType";
            this.cbxCustomerType.Size = new System.Drawing.Size(289, 27);
            this.cbxCustomerType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxCustomerType.TabIndex = 0;
            this.cbxCustomerType.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerType_SelectedIndexChanged);
            // 
            // cbxMatch
            // 
            this.cbxMatch.Text = "与电子监管网匹配";
            this.cbxMatch.Value = "Yes";
            // 
            // cbxNotMatch
            // 
            this.cbxNotMatch.Text = "与电子监管网数据不一致";
            this.cbxNotMatch.Value = "No";
            // 
            // dealerBindingSource
            // 
            this.dealerBindingSource.AllowNew = false;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(472, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(89, 23);
            this.labelX2.TabIndex = 39;
            this.labelX2.Text = "单位名称：";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.ButtonCustom.Tooltip = "";
            this.txtName.ButtonCustom2.Tooltip = "";
            this.txtName.FocusHighlightEnabled = true;
            this.txtName.Location = new System.Drawing.Point(567, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 27);
            this.txtName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(799, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 27);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchAll.Location = new System.Drawing.Point(931, 12);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(94, 27);
            this.btnSearchAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchAll.TabIndex = 3;
            this.btnSearchAll.Text = "搜索全部";
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // FrmRegulatoryCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 544);
            this.Controls.Add(this.btnSearchAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbxCustomerType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdCustomers);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegulatoryCustomer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电子监管网往来单位匹配";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRegulatoryCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dealerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Validator.CustomValidator customValidator1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdCustomers;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxCustomerType;
        private DevComponents.Editors.ComboItem cbxMatch;
        private DevComponents.Editors.ComboItem cbxNotMatch;
        private System.Windows.Forms.BindingSource dealerBindingSource;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.ButtonX btnSearchAll;
    }
}