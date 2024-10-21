using System;
using System.Windows.Forms;
using Utility;

namespace ReceptionAdmin
{
    // Token: 0x02000003 RID: 3
    public partial class ThongKeThuNgan : Form
    {
        // Token: 0x06000004 RID: 4 RVA: 0x0000263D File Offset: 0x0000163D
        public ThongKeThuNgan()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000005 RID: 5 RVA: 0x00002656 File Offset: 0x00001656
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        // Token: 0x06000006 RID: 6 RVA: 0x00002660 File Offset: 0x00001660
        private void buttonOK_Click(object sender, EventArgs e)
        {
            CrystRptManager.ThongKeThuNgan thongKeThuNgan = new CrystRptManager.ThongKeThuNgan(this.dateTimePickerTuNgay.Value, this.dateTimePickerDenNgay.Value);
            thongKeThuNgan.Show();
        }

        // Token: 0x06000007 RID: 7 RVA: 0x00002691 File Offset: 0x00001691
        private void ThongKeThuNgan_Load(object sender, EventArgs e)
        {
            this.dateTimePickerTuNgay.Value = SKCD_Date.BeginDayOfMonthWorking();
            this.dateTimePickerDenNgay.Value = DateTime.Now;
        }
    }
}
