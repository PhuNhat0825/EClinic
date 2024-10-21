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
	// Token: 0x02000016 RID: 22
	public partial class ReportSATVu : Form
	{
		// Token: 0x060000CA RID: 202 RVA: 0x00004342 File Offset: 0x00003342
		public ReportSATVu()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00004364 File Offset: 0x00003364
		private void ReportSATVu_Load(object sender, EventArgs e)
		{
			this.crystalReportViewer1.BringToFront();
			this.crystalReportViewer1.DisplayGroupTree = false;
			this.crystalReportViewer1.ShowGroupTreeButton = false;
			this.crystalReportViewer1.ShowTextSearchButton = false;
			this.crystalReportViewer1.ShowCloseButton = false;
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000043CC File Offset: 0x000033CC
		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			this.cmd = new MySqlCommand("sp_satvu", EClinicDB.EClinicDBConnection);
			this.cmd.CommandType = CommandType.StoredProcedure;
			MySqlParameter mySqlParameter = this.cmd.Parameters.Add("KetQua_Id", MySqlDbType.Int32);
			MySqlParameter mySqlParameter2 = this.cmd.Parameters.Add("DS_Anh_KQ", MySqlDbType.VarChar);
			mySqlParameter.Value = int.Parse(EClinicConfig.KetQua_SA_Id_cur.ToString());
			mySqlParameter2.Direction = ParameterDirection.Output;
			this.cmd.ExecuteNonQuery();
			DataSet dataSet = EClinicDB.FillDataset("BENH_NHAN", this.cmd);
			dataSet.Tables[0].TableName = "SieuAmTVu";
			DataTable dataTable = new DataTable("image");
			dataTable.Columns.Add("image", typeof(byte[]));
			dataSet.Tables.Add(dataTable);
			string text = mySqlParameter2.Value.ToString();
			char[] separator = new char[]
			{
				'+',
				' ',
				',',
				'.',
				':',
				'\t'
			};
			string[] array = text.Split(separator);
			DataRow dataRow = dataSet.Tables["image"].NewRow();
			int num = 0;
			foreach (string idx in array)
			{
				dataRow[0] = this.ReadImageFromData(idx);
				num++;
			}
			dataSet.Tables["image"].Rows.Add(dataRow);
			SieuAmTVu sieuAmTVu = new SieuAmTVu();
			sieuAmTVu.SetDataSource(dataSet);
			sieuAmTVu.SetParameterValue("TitleReport", EClinicConfig.TitleReport);
			sieuAmTVu.SetParameterValue("District", EClinicConfig.GetDistrict());
			this.crystalReportViewer1.ReportSource = sieuAmTVu;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000459C File Offset: 0x0000359C
		private byte[] ReadImageFromData(string idx)
		{
			byte[] result;
			if (idx != "")
			{
				string sCommand = "SELECT `image`, `filesize` from `hinh_anh` WHERE `hinh_anh`.`Hinh_Anh_Id` = " + idx;
				MySqlDataReader mySqlDataReader = EClinicDB.ExecuteReader(sCommand);
				if (!mySqlDataReader.HasRows)
				{
					throw new Exception("There are no BLOBs to save");
				}
				mySqlDataReader.Read();
				int @int = mySqlDataReader.GetInt32(mySqlDataReader.GetOrdinal("filesize"));
				byte[] array = new byte[@int];
				mySqlDataReader.GetBytes(mySqlDataReader.GetOrdinal("image"), 0L, array, 0, @int);
				mySqlDataReader.Close();
				result = array;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0400001B RID: 27
		private MySqlCommand cmd = null;
	}
}
