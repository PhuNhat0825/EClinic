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
	// Token: 0x0200001F RID: 31
	public partial class ReportThongKeLuongBenh : Form
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00005A23 File Offset: 0x00004A23
		public ReportThongKeLuongBenh()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00005A3C File Offset: 0x00004A3C
		public ReportThongKeLuongBenh(DateTime TuNgay, DateTime DenNgay)
		{
			this._TuNgay = TuNgay;
			this._DenNgay = DenNgay;
			this.InitializeComponent();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005A63 File Offset: 0x00004A63
		private void ReportThongKeLuongBenh_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005A70 File Offset: 0x00004A70
		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			ParamCollection paramCollection = new ParamCollection();
			paramCollection.Add("param1", DbDataType.DateTime, 11, this._TuNgay);
			paramCollection.Add("param2", DbDataType.DateTime, 11, this._DenNgay);
			DataSet dataSet = EClinicDB.FillDataset("sp_ThongKeLuongBenh", paramCollection);
			dataSet.Tables[0].TableName = "ThongKeLuongBenh";
			ThongKeLuongBenh thongKeLuongBenh = new ThongKeLuongBenh();
			thongKeLuongBenh.SetDataSource(dataSet);
			thongKeLuongBenh.SetParameterValue("TuNgay", this._TuNgay);
			thongKeLuongBenh.SetParameterValue("DenNgay", this._DenNgay);
			this.crystalReportViewer1.ReportSource = thongKeLuongBenh;
		}

		// Token: 0x0400002B RID: 43
		private DateTime _TuNgay;

		// Token: 0x0400002C RID: 44
		private DateTime _DenNgay;
	}
}
