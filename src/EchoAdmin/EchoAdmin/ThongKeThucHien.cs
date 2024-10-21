using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CrystRptManager;
using Utility;

namespace EchoAdmin
{
	// Token: 0x02000009 RID: 9
	public partial class ThongKeThucHien : Form
	{
		// Token: 0x06000054 RID: 84 RVA: 0x0000ABE0 File Offset: 0x00009BE0
		public ThongKeThucHien()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000ABF9 File Offset: 0x00009BF9
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000AC04 File Offset: 0x00009C04
		private void buttonOK_Click(object sender, EventArgs e)
		{
			ReportThongKeLuongBenh reportThongKeLuongBenh = new ReportThongKeLuongBenh(this.dateTimePickerTuNgay.Value, this.dateTimePickerDenNgay.Value);
			reportThongKeLuongBenh.ShowDialog();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000AC35 File Offset: 0x00009C35
		private void ThongKeThucHien_Load(object sender, EventArgs e)
		{
			this.dateTimePickerTuNgay.Value = SKCD_Date.BeginDayOfMonthWorking();
			this.dateTimePickerDenNgay.Value = DateTime.Now;
		}
	}
}
