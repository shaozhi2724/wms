using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using WMS.App.Services;
using WMS.Model;

namespace WMS.Windows.App
{
    public partial class FrmWarehouse : Office2007Form
    {
        private readonly IWarehouseService _service;
        public FrmWarehouse()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;

            _service = new WarehouseService();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmWarehouseEditor editor = new FrmWarehouseEditor();
            if (DialogResult.Yes == editor.ShowDialog(this))
            {
                BindWarehouses();
            }
        }

        private void FrmWarehouse_Load(object sender, EventArgs e)
        {
            BindWarehouses();
        }

        private void BindWarehouses()
        {
            var allWarehouses = _service.GetAllWarehouses();
            grdWarehouse.PrimaryGrid.DataSource = allWarehouses;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var row = (grdWarehouse.ActiveGrid.ActiveRow as GridRow);

            if (row != null)
            {
                FrmWarehouseEditor editor = new FrmWarehouseEditor(row.DataItem as Warehouse);
                if (DialogResult.Yes == editor.ShowDialog(this))
                {
                    BindWarehouses();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            if (DialogResult.Yes ==
                MessageBoxEx.Show("ȷ��ɾ����", "ϵͳȷ����Ϣ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                var row = (grdWarehouse.ActiveGrid.ActiveRow as GridRow);

                if (row != null)
                {
                    var warehouse = row.DataItem as Warehouse;
                    if (warehouse != null)
                    {
                        var warehouseId = warehouse.WarehouseID;
                        _service.DeleteWarehouse(warehouseId);
                    }
                    BindWarehouses();

                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindWarehouses();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;

            var row = (grdWarehouse.ActiveGrid.ActiveRow as GridRow);

            if (row != null)
            {
                var warehouse = row.DataItem as Warehouse;
                if (warehouse != null)
                {
                    bool isActive = warehouse.IsActive.HasValue && warehouse.IsActive.Value;
                    if (DialogResult.Yes ==
                        MessageBoxEx.Show(string.Format("ȷ��{0}�˲ֿ����л�λ��", isActive ? "ͣ��" : "����"), "ϵͳȷ����Ϣ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        warehouse.IsActive = !isActive;
                        _service.SaveWarehouseStatus(warehouse);
                    }
                }
                BindWarehouses();
                grdWarehouse.ActiveGrid.SetActiveRow(row);
            }
            
        }

        private void grdWarehouse_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            GridRow row = e.NewActiveRow as GridRow;
            if (null != row)
            {
                var wareHouse = row.DataItem as Warehouse;
                bool isActive = wareHouse.IsActive.HasValue && wareHouse.IsActive.Value;
                btnStatus.Text = isActive ? "ͣ��" : "����";
                btnStatus.ImageIndex = isActive ? 5 : 6;

                bar1.Refresh();
            }
        }
    }
}