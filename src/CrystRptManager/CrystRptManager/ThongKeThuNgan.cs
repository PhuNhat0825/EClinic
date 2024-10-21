using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using CrystRptManager.Designs;
using DBInteraction;

namespace CrystRptManager
{
	// Token: 0x02000004 RID: 4
	public partial class ThongKeThuNgan : Form
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002251 File Offset: 0x00001251
		public ThongKeThuNgan()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000226A File Offset: 0x0000126A
		public ThongKeThuNgan(DateTime TuNgay, DateTime DenNgay)
		{
			this._TuNgay = TuNgay;
			this._DenNgay = DenNgay;
			this.InitializeComponent();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002291 File Offset: 0x00001291
		private void ThongKeThuNgan_Load(object sender, EventArgs e)
		{
			this.Text = "EClinic - Thống kê doanh thu";
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000022A8 File Offset: 0x000012A8
		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			ParamCollection paramCollection = new ParamCollection();
			paramCollection.Add("param1", DbDataType.DateTime, 11, this._TuNgay);
			paramCollection.Add("param2", DbDataType.DateTime, 11, this._DenNgay);
			DataSet dataSet = EClinicDB.FillDatasetDecrypt("sp_ThongKeThuNgan", paramCollection, "dm_benhnhan");
			dataSet.Tables[0].TableName = "ThongKeThuNgan";
			CrystRptManager.Designs.ThongKeThuNgan thongKeThuNgan = new CrystRptManager.Designs.ThongKeThuNgan();
			thongKeThuNgan.SetDataSource(dataSet);
			thongKeThuNgan.SetParameterValue("TuNgay", this._TuNgay);
			thongKeThuNgan.SetParameterValue("DenNgay", this._DenNgay);
			this.crystalReportViewer1.ReportSource = thongKeThuNgan;
		}

		// Token: 0x04000001 RID: 1
		private DateTime _TuNgay;

		// Token: 0x04000002 RID: 2
		private DateTime _DenNgay;
	}
}
