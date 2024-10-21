using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using CrystRptManager.Designs;
using MySql.Data.MySqlClient;
using Utility;

namespace CrystRptManager
{
	// Token: 0x02000024 RID: 36
	public partial class ReportPhieuYeucau : Form
	{
		// Token: 0x06000140 RID: 320 RVA: 0x00006014 File Offset: 0x00005014
		public ReportPhieuYeucau()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006034 File Offset: 0x00005034
		public ReportPhieuYeucau(int idx)
		{
			this.yeucau_id = idx;
			this.InitializeComponent();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000605B File Offset: 0x0000505B
		private void ReportPhieuYeucau_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00006068 File Offset: 0x00005068
		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			this.cmd = new MySqlCommand("sp_phieuyeucau", EClinicDB.EClinicDBConnection);
			this.cmd.CommandType = CommandType.StoredProcedure;
			MySqlParameter mySqlParameter = this.cmd.Parameters.Add("param1", MySqlDbType.Int32);
			mySqlParameter.Value = this.yeucau_id;
			this.cmd.ExecuteNonQuery();
			DataSet dataSet = EClinicDB.FillDataset("BENH_NHAN", this.cmd);
			dataSet.Tables[0].TableName = "PhieuYeuCau";
			PhieuYeuCau phieuYeuCau = new PhieuYeuCau();
			phieuYeuCau.SetDataSource(dataSet);
			phieuYeuCau.SetParameterValue("District", EClinicConfig.GetDistrict());
			this.crystalReportViewer1.ReportSource = phieuYeuCau;
		}

		// Token: 0x0400002F RID: 47
		private MySqlCommand cmd = null;

		// Token: 0x04000030 RID: 48
		private int yeucau_id;
	}
}
