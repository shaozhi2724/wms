namespace WMS.Windows.App
{
    partial class FrmStoreOutReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStoreOutReview));
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnReview = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.panStoreOut = new DevComponents.DotNetBar.ExpandablePanel();
            this.grdStoreOutDetail = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.panSearchBill = new DevComponents.DotNetBar.ExpandablePanel();
            this.txtReviewIdentity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtStoreType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtStoreOutCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblStoreOutType = new DevComponents.DotNetBar.LabelX();
            this.txtProviderName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblProviderName = new DevComponents.DotNetBar.LabelX();
            this.lblStoreOutCode = new DevComponents.DotNetBar.LabelX();
            this.btnDelReview = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.panStoreOut.SuspendLayout();
            this.panSearchBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bar1.Images = this.imageList;
            this.bar1.ImagesLarge = this.imageList;
            this.bar1.ImagesMedium = this.imageList;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnReview,
            this.btnRefresh,
            this.btnDelReview});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(919, 57);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.bar1.TabIndex = 20;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "refresh.png");
            this.imageList.Images.SetKeyName(1, "cancel.png");
            this.imageList.Images.SetKeyName(2, "save.png");
            this.imageList.Images.SetKeyName(3, "review.png");
            this.imageList.Images.SetKeyName(4, "search.png");
            // 
            // btnReview
            // 
            this.btnReview.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnReview.ImageIndex = 3;
            this.btnReview.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReview.Name = "btnReview";
            this.btnReview.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar;
            this.btnReview.Text = "复核";
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageIndex = 0;
            this.btnRefresh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panStoreOut
            // 
            this.panStoreOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panStoreOut.CanvasColor = System.Drawing.SystemColors.Control;
            this.panStoreOut.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panStoreOut.Controls.Add(this.grdStoreOutDetail);
            this.panStoreOut.DisabledBackColor = System.Drawing.Color.Empty;
            this.panStoreOut.ExpandButtonVisible = false;
            this.panStoreOut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panStoreOut.HideControlsWhenCollapsed = true;
            this.panStoreOut.Location = new System.Drawing.Point(0, 173);
            this.panStoreOut.Name = "panStoreOut";
            this.panStoreOut.Size = new System.Drawing.Size(919, 348);
            this.panStoreOut.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panStoreOut.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panStoreOut.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panStoreOut.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panStoreOut.Style.GradientAngle = 90;
            this.panStoreOut.TabIndex = 22;
            this.panStoreOut.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panStoreOut.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panStoreOut.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panStoreOut.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panStoreOut.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panStoreOut.TitleStyle.GradientAngle = 90;
            this.panStoreOut.TitleText = "出库单列表";
            // 
            // grdStoreOutDetail
            // 
            this.grdStoreOutDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStoreOutDetail.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdStoreOutDetail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdStoreOutDetail.Location = new System.Drawing.Point(0, 26);
            this.grdStoreOutDetail.Name = "grdStoreOutDetail";
            this.grdStoreOutDetail.PrimaryGrid.AllowEdit = false;
            this.grdStoreOutDetail.PrimaryGrid.AutoGenerateColumns = false;
            this.grdStoreOutDetail.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn1.DataPropertyName = "StoreID";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn1.HeaderText = "序号";
            gridColumn1.Name = "colStoreID";
            gridColumn1.Visible = false;
            gridColumn2.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn2.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn2.DataPropertyName = "StoreCode";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn2.HeaderText = "出库单号";
            gridColumn2.Name = "colStoreOutCode";
            gridColumn2.Width = 200;
            gridColumn3.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn3.DataPropertyName = "DealerName";
            gridColumn3.HeaderText = "客户名称";
            gridColumn3.Name = "colProviderName";
            gridColumn3.Width = 150;
            gridColumn4.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn4.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn4.DataPropertyName = "StoreTypeName";
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn4.HeaderText = "出库类型";
            gridColumn4.Name = "colStoreType";
            gridColumn4.Width = 150;
            gridColumn5.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn5.DataPropertyName = "CreateDate";
            gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn5.HeaderText = "创建日期";
            gridColumn5.Name = "colCreateDate";
            gridColumn5.ReadOnly = true;
            gridColumn6.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn6.DataPropertyName = "StoreStatusName";
            gridColumn6.HeaderText = "出库状态";
            gridColumn6.Name = "colStatus";
            gridColumn6.Width = 150;
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn3);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn4);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdStoreOutDetail.PrimaryGrid.Columns.Add(gridColumn6);
            this.grdStoreOutDetail.PrimaryGrid.MultiSelect = false;
            this.grdStoreOutDetail.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdStoreOutDetail.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdStoreOutDetail.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdStoreOutDetail.PrimaryGrid.ShowRowGridIndex = true;
            this.grdStoreOutDetail.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdStoreOutDetail.Size = new System.Drawing.Size(919, 322);
            this.grdStoreOutDetail.TabIndex = 0;
            this.grdStoreOutDetail.Text = "superGridControl2";
            this.grdStoreOutDetail.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.grdStoreOutDetail_RowActivated);
            // 
            // panSearchBill
            // 
            this.panSearchBill.CanvasColor = System.Drawing.SystemColors.Control;
            this.panSearchBill.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panSearchBill.Controls.Add(this.txtReviewIdentity);
            this.panSearchBill.Controls.Add(this.labelX1);
            this.panSearchBill.Controls.Add(this.txtStoreType);
            this.panSearchBill.Controls.Add(this.txtStoreOutCode);
            this.panSearchBill.Controls.Add(this.lblStoreOutType);
            this.panSearchBill.Controls.Add(this.txtProviderName);
            this.panSearchBill.Controls.Add(this.lblProviderName);
            this.panSearchBill.Controls.Add(this.lblStoreOutCode);
            this.panSearchBill.DisabledBackColor = System.Drawing.Color.Empty;
            this.panSearchBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearchBill.ExpandButtonVisible = false;
            this.panSearchBill.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panSearchBill.HideControlsWhenCollapsed = true;
            this.panSearchBill.Location = new System.Drawing.Point(0, 57);
            this.panSearchBill.Name = "panSearchBill";
            this.panSearchBill.Size = new System.Drawing.Size(919, 108);
            this.panSearchBill.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panSearchBill.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panSearchBill.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panSearchBill.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panSearchBill.Style.GradientAngle = 90;
            this.panSearchBill.TabIndex = 21;
            this.panSearchBill.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panSearchBill.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panSearchBill.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panSearchBill.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panSearchBill.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panSearchBill.TitleStyle.GradientAngle = 90;
            this.panSearchBill.TitleText = "出库信息";
            // 
            // txtReviewIdentity
            // 
            // 
            // 
            // 
            this.txtReviewIdentity.Border.Class = "TextBoxBorder";
            this.txtReviewIdentity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReviewIdentity.ButtonCustom.Tooltip = "";
            this.txtReviewIdentity.ButtonCustom2.Tooltip = "";
            this.txtReviewIdentity.Location = new System.Drawing.Point(114, 41);
            this.txtReviewIdentity.Name = "txtReviewIdentity";
            this.txtReviewIdentity.PreventEnterBeep = true;
            this.txtReviewIdentity.Size = new System.Drawing.Size(338, 23);
            this.txtReviewIdentity.TabIndex = 18;
            this.txtReviewIdentity.WatermarkFont = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReviewIdentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReviewIdentity_KeyPress);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(15, 40);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(93, 23);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "复核标识：";
            // 
            // txtStoreType
            // 
            // 
            // 
            // 
            this.txtStoreType.Border.Class = "TextBoxBorder";
            this.txtStoreType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStoreType.ButtonCustom.Tooltip = "";
            this.txtStoreType.ButtonCustom2.Tooltip = "";
            this.txtStoreType.Location = new System.Drawing.Point(565, 74);
            this.txtStoreType.Name = "txtStoreType";
            this.txtStoreType.PreventEnterBeep = true;
            this.txtStoreType.ReadOnly = true;
            this.txtStoreType.Size = new System.Drawing.Size(342, 23);
            this.txtStoreType.TabIndex = 17;
            this.txtStoreType.WatermarkFont = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // txtStoreOutCode
            // 
            // 
            // 
            // 
            this.txtStoreOutCode.Border.Class = "TextBoxBorder";
            this.txtStoreOutCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStoreOutCode.ButtonCustom.Tooltip = "";
            this.txtStoreOutCode.ButtonCustom2.Tooltip = "";
            this.txtStoreOutCode.Location = new System.Drawing.Point(565, 41);
            this.txtStoreOutCode.Name = "txtStoreOutCode";
            this.txtStoreOutCode.PreventEnterBeep = true;
            this.txtStoreOutCode.ReadOnly = true;
            this.txtStoreOutCode.Size = new System.Drawing.Size(342, 23);
            this.txtStoreOutCode.TabIndex = 0;
            this.txtStoreOutCode.WatermarkFont = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // lblStoreOutType
            // 
            // 
            // 
            // 
            this.lblStoreOutType.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblStoreOutType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreOutType.Location = new System.Drawing.Point(467, 74);
            this.lblStoreOutType.Name = "lblStoreOutType";
            this.lblStoreOutType.Size = new System.Drawing.Size(89, 23);
            this.lblStoreOutType.TabIndex = 13;
            this.lblStoreOutType.Text = "出库类型：";
            // 
            // txtProviderName
            // 
            // 
            // 
            // 
            this.txtProviderName.Border.Class = "TextBoxBorder";
            this.txtProviderName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProviderName.ButtonCustom.Tooltip = "";
            this.txtProviderName.ButtonCustom2.Tooltip = "";
            this.txtProviderName.Location = new System.Drawing.Point(114, 74);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.PreventEnterBeep = true;
            this.txtProviderName.ReadOnly = true;
            this.txtProviderName.Size = new System.Drawing.Size(338, 23);
            this.txtProviderName.TabIndex = 1;
            this.txtProviderName.WatermarkFont = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblProviderName
            // 
            // 
            // 
            // 
            this.lblProviderName.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblProviderName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProviderName.Location = new System.Drawing.Point(15, 73);
            this.lblProviderName.Name = "lblProviderName";
            this.lblProviderName.Size = new System.Drawing.Size(93, 23);
            this.lblProviderName.TabIndex = 7;
            this.lblProviderName.Text = "客户名称：";
            // 
            // lblStoreOutCode
            // 
            // 
            // 
            // 
            this.lblStoreOutCode.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.lblStoreOutCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblStoreOutCode.Location = new System.Drawing.Point(470, 40);
            this.lblStoreOutCode.Name = "lblStoreOutCode";
            this.lblStoreOutCode.Size = new System.Drawing.Size(89, 23);
            this.lblStoreOutCode.TabIndex = 5;
            this.lblStoreOutCode.Text = "出库单号：";
            // 
            // btnDelReview
            // 
            this.btnDelReview.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDelReview.ImageIndex = 1;
            this.btnDelReview.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDelReview.Name = "btnDelReview";
            this.btnDelReview.Text = "返单";
            this.btnDelReview.Click += new System.EventHandler(this.btnDelReview_Click);
            // 
            // FrmStoreOutReview
            // 
            this.ClientSize = new System.Drawing.Size(919, 522);
            this.Controls.Add(this.panStoreOut);
            this.Controls.Add(this.panSearchBill);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmStoreOutReview";
            this.Text = "出库复核";
            this.Load += new System.EventHandler(this.FrmStoreOutReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.panStoreOut.ResumeLayout(false);
            this.panSearchBill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnReview;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private System.Windows.Forms.ImageList imageList;
        private DevComponents.DotNetBar.ExpandablePanel panStoreOut;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdStoreOutDetail;
        private DevComponents.DotNetBar.ExpandablePanel panSearchBill;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStoreOutCode;
        private DevComponents.DotNetBar.LabelX lblStoreOutType;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProviderName;
        private DevComponents.DotNetBar.LabelX lblProviderName;
        private DevComponents.DotNetBar.LabelX lblStoreOutCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStoreType;
        private DevComponents.DotNetBar.Controls.TextBoxX txtReviewIdentity;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonItem btnDelReview;
    }
}