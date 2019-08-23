using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WMS.App.Services;

namespace WMS.Windows.App
{
    public partial class FrmInventoryTaskGen : Office2007Form
    {
        private IStoreBillService _service;
        public FrmInventoryTaskGen()
        {
            InitializeComponent();

            MessageBoxEx.EnableGlass = false;

            _service = new StoreBillService();
        }

        private void FrmInventoryState_Load(object sender, EventArgs e)
        {
            string taskCode = string.Format("PD{0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
            txtInventoryStatisticCode.Text = taskCode;
            datStartDate.Value = DateTime.Today;
            datEndDate.Value = DateTime.Today;
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Yes ==
                MessageBoxEx.Show("确定生成库存盘点任务？", "系统确认框", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    GenerateInventoryStatisticTask();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GenerateInventoryStatisticTask()
        {
            var taskCode = txtInventoryStatisticCode.Text.Trim();
            var startDate = datStartDate.Value.Date;
            var endDate = datEndDate.Value.Date;
            _service.GenerateInventoryStatisticTask(taskCode, startDate, endDate, Program.CurrentUser.UserId);

        }
    }
}
