namespace WMS.Windows.App
{
    partial class FrmUserManagement
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserManagement));
            this.grdUsers = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUsers
            // 
            this.grdUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdUsers.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grdUsers.Location = new System.Drawing.Point(0, 63);
            this.grdUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.PrimaryGrid.AllowEdit = false;
            this.grdUsers.PrimaryGrid.AutoGenerateColumns = false;
            this.grdUsers.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            gridColumn1.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn1.DataPropertyName = "UserID";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn1.HeaderText = "序号";
            gridColumn1.Name = "colUserID";
            gridColumn1.Visible = false;
            gridColumn2.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn2.DataPropertyName = "Username";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn2.HeaderText = "用户名";
            gridColumn2.Name = "colUsername";
            gridColumn3.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            gridColumn3.DataPropertyName = "Realname";
            gridColumn3.HeaderText = "姓名";
            gridColumn3.Name = "colRealname";
            gridColumn4.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn4.DataPropertyName = "Rolename";
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl);
            gridColumn4.HeaderText = "角色";
            gridColumn4.Name = "colRoleName";
            gridColumn4.Width = 200;
            gridColumn5.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn5.DataPropertyName = "IsActive";
            gridColumn5.HeaderText = "状态";
            gridColumn5.Name = "colIsActive";
            gridColumn5.Width = 200;
            gridColumn6.CellStyles.Default.Font = new System.Drawing.Font("微软雅黑", 9F);
            gridColumn6.DataPropertyName = "CreateDate";
            gridColumn6.HeaderText = "创建日期";
            gridColumn6.Name = "colCreateDate";
            gridColumn6.RenderType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            this.grdUsers.PrimaryGrid.Columns.Add(gridColumn1);
            this.grdUsers.PrimaryGrid.Columns.Add(gridColumn2);
            this.grdUsers.PrimaryGrid.Columns.Add(gridColumn3);
            this.grdUsers.PrimaryGrid.Columns.Add(gridColumn4);
            this.grdUsers.PrimaryGrid.Columns.Add(gridColumn5);
            this.grdUsers.PrimaryGrid.Columns.Add(gridColumn6);
            this.grdUsers.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.grdUsers.PrimaryGrid.MultiSelect = false;
            this.grdUsers.PrimaryGrid.NoRowsText = "暂无记录";
            this.grdUsers.PrimaryGrid.RowHeaderIndexOffset = 1;
            this.grdUsers.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.grdUsers.PrimaryGrid.ShowRowGridIndex = true;
            this.grdUsers.PrimaryGrid.UseAlternateRowStyle = true;
            this.grdUsers.Size = new System.Drawing.Size(1088, 497);
            this.grdUsers.TabIndex = 13;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "refresh.png");
            this.imageList.Images.SetKeyName(1, "cancel.png");
            this.imageList.Images.SetKeyName(2, "save.png");
            this.imageList.Images.SetKeyName(3, "add.png");
            this.imageList.Images.SetKeyName(4, "edit.png");
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
            this.btnRefresh,
            this.btnAdd,
            this.btnEdit,
            this.btnDelete});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1088, 63);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.bar1.TabIndex = 21;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnRefresh.ImageIndex = 0;
            this.btnRefresh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageIndex = 3;
            this.btnAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageIndex = 4;
            this.btnEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "禁用";
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 591);
            this.Controls.Add(this.grdUsers);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmUserManagement";
            this.Text = "用户管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grdUsers;
        private System.Windows.Forms.ImageList imageList;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
    }
}