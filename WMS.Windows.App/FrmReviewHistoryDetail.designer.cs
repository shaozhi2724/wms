namespace WMS.Windows.App
{
    partial class FrmReviewHistoryDetail
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn15 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn16 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn17 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn18 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn19 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn20 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn21 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn22 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn23 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn24 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn25 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn26 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn27 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn28 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.panReviewDetail = new DevComponents.DotNetBar.ExpandablePanel();
            this.grdReviewDetail = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.btnPrintTicket = new DevComponents.DotNetBar.ButtonX();
            this.btnBackPrint = new DevComponents.DotNetBar.ButtonX();
            this.panReviewDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.Location = new System.Drawing.Point(676, 500);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 37);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "´òÓ¡Ëæ»õÍ¬ÐÐ(ÏúÊÛ)";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panReviewDetail
            // 
            this.panReviewDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panReviewDetail.CanvasColor = System.Drawing.SystemColors.Control;
            this.panReviewDetail.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panReviewDetail.Controls.Add(this.grdReviewDetail);
            this.panReviewDetail.DisabledBackColor = System.Drawing.Color.Empty;
            this.panReviewDetail.ExpandButtonVisible = false;
            this.panReviewDetail.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panReviewDetail.HideControlsWhenCollapsed = true;
            this.panReviewDetail.Location = new System.Drawing.Point(0, 0);
            this.panReviewDetail.Name = "panReviewDetail";
            this.panReviewDetail.Size = new System.Drawing.Size(1229, 484);
            this.panReviewDetail.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panReviewDetail.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panReviewDetail.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panReviewDetail.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panReviewDetail.Style.GradientAngle = 90;
            this.panReviewDetail.TabIndex = 16;
            this.panReviewDetail.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panReviewDetail.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panReviewDetail.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.panReviewDetail.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panReviewDetail.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panReviewDetail.TitleStyle.GradientAngle = 90;
            this.panReviewDetail.TitleText = "¸´ºËÃ÷Ï¸";
            // 
            // grdReviewDetail
            // 
            this.grdReviewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReviewDetail.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdReviewDetail.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdReviewDetail.Location = new System.Drawing.Point(0, 26);
            this.grdReviewDetail.Name = "grdReviewDetail";
            this.grdReviewDetail.PrimaryGrid.AllowEdit = false;
            this.grdReviewDetail.PrimaryGrid.AutoGenerateColumns = false;
            this.grdReviewDetail.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn15.CellStyles.Default.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            gridColumn15.DataPropertyName = "DetailID";
            gridColumn15.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn15.HeaderText = "ÐòºÅ";
            gridColumn15.Name = "colDetailID";
            gridColumn15.Visible = false;
            gridColumn16.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn16.CellStyles.Default.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            gridColumn16.DataPropertyName = "ProductBarCode";
            gridColumn16.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn16.HeaderText = "ÌõÂë";
            gridColumn16.Name = "colProductBarCode";
            gridColumn17.CellStyles.Default.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            gridColumn17.DataPropertyName = "ProductCode";
            gridColumn17.HeaderText = "Ò©Æ·±àºÅ";
            gridColumn17.Name = "colProductCode";
            gridColumn18.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.AllCells;
            gridColumn18.CellStyles.Default.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn18.DataPropertyName = "ProductName";
            gridColumn18.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn18.HeaderText = "Ò©Æ·Ãû³Æ";
            gridColumn18.Name = "colProductName";
            gridColumn19.CellStyles.Default.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            gridColumn19.DataPropertyName = "ProductSpec";
            gridColumn19.HeaderText = "ÖÆ¼Á¹æ¸ñ";
            gridColumn19.Name = "colProductSpec";
            gridColumn20.CellStyles.Default.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            gridColumn20.DataPropertyName = "PackageSpec";
            gridColumn20.HeaderText = "°ü×°¹æ¸ñ";
            gridColumn20.Name = "colPackageSpec";
            gridColumn21.CellStyles.Default.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            gridColumn21.DataPropertyName = "ProducerName";
            gridColumn21.HeaderText = "Éú²ú³§ÉÌ";
            gridColumn21.Name = "colProducerName";
            gridColumn22.CellStyles.Default.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            gridColumn22.DataPropertyName = "BatchNo";
            gridColumn22.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn22.HeaderText = "ÅúºÅ";
            gridColumn22.Name = "colBatchNo";
            gridColumn23.CellStyles.Default.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            gridColumn23.DataPropertyName = "PhysicType";
            gridColumn23.HeaderText = "¼ÁÐÍ";
            gridColumn23.Name = "colPhysicType";
            gridColumn24.CellStyles.Default.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn24.DataPropertyName = "ProductLocation";
            gridColumn24.HeaderText = "²úµØ";
            gridColumn24.Name = "colProductLocation";
            gridColumn25.CellStyles.Default.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            gridColumn25.DataPropertyName = "ProduceDate";
            gridColumn25.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn25.HeaderText = "Éú²úÈÕÆÚ";
            gridColumn25.Name = "colProduceDate";
            gridColumn26.CellStyles.Default.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            gridColumn26.DataPropertyName = "ValidateDate";
            gridColumn26.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn26.HeaderText = "ÓÐÐ§ÆÚ";
            gridColumn26.Name = "colValidateDate";
            gridColumn27.CellStyles.Default.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F);
            gridColumn27.DataPropertyName = "Amount";
            gridColumn27.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn27.HeaderText = "¸´ºËÊýÁ¿";
            gridColumn27.Name = "coReviewAmount";
            gridColumn28.CellStyles.Default.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn28.DataPropertyName = "ReviewResult";
            gridColumn28.HeaderText = "ÖÊÁ¿×´¿ö";
            gridColumn28.Name = "colReviewResult";
            this.grdReviewDetail.PrimaryGrid.Columns.Add(gridColumn15);
            this.grdReviewDetail.PrimaryGrid.Columns.Add(gridColumn16);
            this.grdReviewDetail.PrimaryGrid.Columns.Add(gridColumn17);
            this.grdReviewDetail.PrimaryGrid.Columns.Add(gridColumn18);
            this.grdReviewDetail.PrimaryGrid.Columns.Add(gridColumn19);
            this.grdReviewDetail.PrimaryGrid.Columns.Add(gridColumn20);
            this.grdReviewDetail.PrimaryGrid.Columns.Add(gridColumn21);
            this.grdReviewDetail.PrimaryGrid.Columns.Add(gridColumn22);
            this.grdReviewDetail.PrimaryGrid.Columns.Add(gridColumn23);
            this.grdReviewDetail.PrimaryGrid.Columns.Add(gridColumn24);
            this.grdReviewDetail.PrimaryGrid.Columns.Add(gridColumn25);
            this.grdReviewDetail.PrimaryGrid.Columns.Add(gridColumn26);
            this.grdReviewDetail.PrimaryGrid.Columns.Add(gridColumn27);
            this.grdReviewDetail.PrimaryGrid.Columns.Add(gridColumn28);
            this.grdReviewDetail.PrimaryGrid.MultiSelect = false;
            this.grdReviewDetail.PrimaryGrid.NoRowsText = "ÔÝÎÞ¼ÇÂ¼";
            this.grdReviewDetail.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdReviewDetail.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdReviewDetail.PrimaryGrid.ShowRowGridIndex = true;
            this.grdReviewDetail.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdReviewDetail.Size = new System.Drawing.Size(1229, 458);
            this.grdReviewDetail.TabIndex = 0;
            this.grdReviewDetail.Text = "superGridControl2";
            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintTicket.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintTicket.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrintTicket.Location = new System.Drawing.Point(402, 500);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.Size = new System.Drawing.Size(99, 37);
            this.btnPrintTicket.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrintTicket.TabIndex = 17;
            this.btnPrintTicket.Text = "´òÓ¡Ð¡Æ±";
            this.btnPrintTicket.Click += new System.EventHandler(this.btnPrintTicket_Click);
            // 
            // btnBackPrint
            // 
            this.btnBackPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBackPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBackPrint.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBackPrint.Location = new System.Drawing.Point(529, 500);
            this.btnBackPrint.Name = "btnBackPrint";
            this.btnBackPrint.Size = new System.Drawing.Size(118, 37);
            this.btnBackPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBackPrint.TabIndex = 3;
            this.btnBackPrint.Text = "´òÓ¡Ëæ»õÍ¬ÐÐ(²ÉÍË)";
            this.btnBackPrint.Click += new System.EventHandler(this.btnBackPrint_Click);
            // 
            // FrmReviewHistoryDetail
            // 
            this.ClientSize = new System.Drawing.Size(1226, 549);
            this.Controls.Add(this.btnPrintTicket);
            this.Controls.Add(this.panReviewDetail);
            this.Controls.Add(this.btnBackPrint);
            this.Controls.Add(this.btnPrint);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReviewHistoryDetail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "³ö¿â¸´ºËÃ÷Ï¸";
            this.panReviewDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.ExpandablePanel panReviewDetail;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdReviewDetail;
        private DevComponents.DotNetBar.ButtonX btnPrintTicket;
        private DevComponents.DotNetBar.ButtonX btnBackPrint;


    }
}