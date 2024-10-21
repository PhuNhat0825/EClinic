using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Utility;

namespace CrystRptManager
{
	// Token: 0x02000015 RID: 21
	public partial class ServiceWageQuery : Form
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x00003D6C File Offset: 0x00002D6C
		public ServiceWageQuery(int userLevel)
		{
			this.InitializeComponent();
			if (userLevel > 2)
			{
				this.button_XemTatCa.Visible = true;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003DAC File Offset: 0x00002DAC
		private void button_XemTatCa_Click(object sender, EventArgs e)
		{
			Form form = new ReportThongKeLuongBenh(this.dateTimePicker_TuNgay.Value, this.dateTimePicker_DenNgay.Value);
			form.ShowDialog();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003DDD File Offset: 0x00002DDD
		private void button_XemRieng_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Chưa hỗ trợ chức năng này.");
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003DEC File Offset: 0x00002DEC
		private void ServiceWageQuery_Load(object sender, EventArgs e)
		{
			this.dateTimePicker_DenNgay.Format = DateTimePickerFormat.Custom;
			this.dateTimePicker_DenNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dateTimePicker_DenNgay.Value = DateTime.Today;
			this.dateTimePicker_TuNgay.Format = DateTimePickerFormat.Custom;
			this.dateTimePicker_TuNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dateTimePicker_TuNgay.Value = SKCD_Date.BeginDayOfMonthWorking();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003E58 File Offset: 0x00002E58
		private void butDSBN_Click(object sender, EventArgs e)
		{
			ThongKeThuNgan thongKeThuNgan = new ThongKeThuNgan(this.dateTimePicker_TuNgay.Value, this.dateTimePicker_DenNgay.Value);
			thongKeThuNgan.ShowDialog();
		}
	}
}
