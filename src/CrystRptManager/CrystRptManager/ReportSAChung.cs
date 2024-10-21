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
	// Token: 0x0200005A RID: 90
	public partial class ReportSAChung : Form
	{
		// Token: 0x06000756 RID: 1878 RVA: 0x0001A29A File Offset: 0x0001929A
		public ReportSAChung()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0001A2BA File Offset: 0x000192BA
		private void ReportSAChung_Load(object sender, EventArgs e)
		{
			this.Text = "EClinic.EchoAdmin -- Kết quả siêu âm";
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0001A2E4 File Offset: 0x000192E4
		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			this.cmd = new MySqlCommand("sp_sachung", EClinicDB.EClinicDBConnection);
			this.cmd.CommandType = CommandType.StoredProcedure;
			MySqlParameter mySqlParameter = this.cmd.Parameters.Add("KetQua_Id", MySqlDbType.Int32);
			MySqlParameter mySqlParameter2 = this.cmd.Parameters.Add("DS_Anh_KQ", MySqlDbType.VarChar);
			mySqlParameter.Value = int.Parse(EClinicConfig.KetQua_SA_Id_cur.ToString());
			mySqlParameter2.Direction = ParameterDirection.Output;
			this.cmd.ExecuteNonQuery();
			DataSet dataSet = EClinicDB.FillDataset("BENH_NHAN", this.cmd);
			dataSet.Tables[0].TableName = "SieuAmChung";
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
			SieuAmChung sieuAmChung = new SieuAmChung();
			sieuAmChung.SetDataSource(dataSet);
			sieuAmChung.SetParameterValue("TitleReport", EClinicConfig.TitleReport);
			sieuAmChung.SetParameterValue("District", EClinicConfig.GetDistrict());
			this.crystalReportViewer1.ReportSource = sieuAmChung;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0001A4B4 File Offset: 0x000194B4
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

		// Token: 0x0400014C RID: 332
		private MySqlCommand cmd = null;
	}
}
