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
	// Token: 0x02000017 RID: 23
	public partial class ReportManager : Form
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x000049A4 File Offset: 0x000039A4
		public ReportManager()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000049F0 File Offset: 0x000039F0
		public ReportManager(string procedure_name, string dtTable_name, string KetQua_Id)
		{
			this.iKetQua_Id = KetQua_Id;
			this.sp_name = procedure_name;
			this.sDatatable_name = dtTable_name;
			this.InitializeComponent();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004A54 File Offset: 0x00003A54
		private byte[] ReadImageFromData(string idx)
		{
			string connectionString = EClinicDB.ConnectionString;
			this.conn = new MySqlConnection(connectionString);
			this.conn.Open();
			byte[] result;
			if (idx != "")
			{
				string cmdText = "SELECT `image`, `filesize` from `hinh_anh` WHERE `hinh_anh`.`Hinh_Anh_Id` = " + idx;
				this.cmd = new MySqlCommand(cmdText, this.conn);
				MySqlDataReader mySqlDataReader = this.cmd.ExecuteReader();
				if (!mySqlDataReader.HasRows)
				{
					throw new Exception("There are no BLOBs to save");
				}
				mySqlDataReader.Read();
				int @int = mySqlDataReader.GetInt32(mySqlDataReader.GetOrdinal("filesize"));
				byte[] array = new byte[@int];
				mySqlDataReader.GetBytes(mySqlDataReader.GetOrdinal("image"), 0L, array, 0, @int);
				mySqlDataReader.Close();
				this.conn.Close();
				result = array;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004B44 File Offset: 0x00003B44
		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			this.cmd = new MySqlCommand(this.sp_name, EClinicDB.EClinicDBConnection);
			this.cmd.CommandType = CommandType.StoredProcedure;
			MySqlParameter mySqlParameter = this.cmd.Parameters.Add("KetQua_Id", MySqlDbType.Int32);
			MySqlParameter mySqlParameter2 = this.cmd.Parameters.Add("DS_Anh_KQ", MySqlDbType.VarChar);
			MySqlParameter mySqlParameter3 = this.cmd.Parameters.Add("sex", MySqlDbType.VarChar);
			mySqlParameter.Value = int.Parse(this.iKetQua_Id);
			mySqlParameter2.Direction = ParameterDirection.Output;
			mySqlParameter3.Direction = ParameterDirection.Output;
			this.cmd.ExecuteNonQuery();
			string text = mySqlParameter3.Value.ToString();
			DataSet dataSet = EClinicDB.FillDataset("BENH_NHAN", this.cmd);
			dataSet.Tables[0].TableName = this.sDatatable_name;
			DataTable dataTable = new DataTable("Images");
			dataTable.Columns.Add("Image1", typeof(byte[]));
			dataTable.Columns.Add("Image2", typeof(byte[]));
			dataTable.Columns.Add("Image3", typeof(byte[]));
			dataTable.Columns.Add("Image4", typeof(byte[]));
			dataSet.Tables.Add(dataTable);
			string text2 = mySqlParameter2.Value.ToString();
			char[] separator = new char[]
			{
				'+',
				' ',
				',',
				'.',
				':',
				'\t'
			};
			string[] array = text2.Split(separator);
			DataRow dataRow = dataSet.Tables["Images"].NewRow();
			int num = 0;
			foreach (string idx in array)
			{
				dataRow[num] = this.ReadImageFromData(idx);
				num++;
			}
			dataSet.Tables["Images"].Rows.Add(dataRow);
			crSATQ_Nam crSATQ_Nam = new crSATQ_Nam();
			string text3 = this.sDatatable_name;
			switch (text3)
			{
			case "SATQ":
				text3 = text;
				if (text3 != null)
				{
					if (!(text3 == "Nam"))
					{
						if (text3 == "Nữ")
						{
							crSATQ_Nu crSATQ_Nu = new crSATQ_Nu();
							crSATQ_Nu.SetDataSource(dataSet);
							this.crystalReportViewer1.ReportSource = crSATQ_Nu;
						}
					}
					else
					{
						crSATQ_Nam crSATQ_Nam2 = new crSATQ_Nam();
						crSATQ_Nam2.SetDataSource(dataSet);
						this.crystalReportViewer1.ReportSource = crSATQ_Nam2;
					}
				}
				goto IL_3F9;
			case "SATG":
			{
				crSATG crSATG = new crSATG();
				crSATG.SetDataSource(dataSet);
				this.crystalReportViewer1.ReportSource = crSATG;
				goto IL_3F9;
			}
			case "SATV":
			{
				crSATV crSATV = new crSATV();
				crSATV.SetDataSource(dataSet);
				this.crystalReportViewer1.ReportSource = crSATV;
				goto IL_3F9;
			}
			case "SASK":
			{
				crSASK crSASK = new crSASK();
				crSASK.SetDataSource(dataSet);
				this.crystalReportViewer1.ReportSource = crSASK;
				goto IL_3F9;
			}
			case "SAKHAC":
			{
				crSAKHAC crSAKHAC = new crSAKHAC();
				crSAKHAC.SetDataSource(dataSet);
				this.crystalReportViewer1.ReportSource = crSAKHAC;
				goto IL_3F9;
			}
			case "SATIM":
			{
				crSATIM crSATIM = new crSATIM();
				crSATIM.SetDataSource(dataSet);
				crSATIM.SetParameterValue("District", EClinicConfig.GetDistrict());
				this.crystalReportViewer1.ReportSource = crSATIM;
				goto IL_3F9;
			}
			}
			crSATQ_Nam.SetDataSource(dataSet);
			this.crystalReportViewer1.ReportSource = crSATQ_Nam;
			IL_3F9:
			this.Text = "eClinic 1.0 - Kết quả siêu âm";
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004F58 File Offset: 0x00003F58
		private void ReportManager_Load(object sender, EventArgs e)
		{
			this.crystalReportViewer1.BringToFront();
			this.crystalReportViewer1.DisplayGroupTree = false;
			this.crystalReportViewer1.ShowGroupTreeButton = false;
			this.crystalReportViewer1.ShowTextSearchButton = false;
			this.crystalReportViewer1.ShowCloseButton = false;
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x04000021 RID: 33
		private MySqlConnection conn;

		// Token: 0x04000022 RID: 34
		private MySqlCommand cmd = null;

		// Token: 0x04000023 RID: 35
		private string iKetQua_Id = "2";

		// Token: 0x04000024 RID: 36
		private string sp_name = "sp_satongquat";

		// Token: 0x04000025 RID: 37
		private string sDatatable_name = "SATQ";
	}
}
