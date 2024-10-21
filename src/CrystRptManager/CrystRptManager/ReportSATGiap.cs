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
	// Token: 0x0200001E RID: 30
	public partial class ReportSATGiap : Form
	{
		// Token: 0x0600010D RID: 269 RVA: 0x0000546D File Offset: 0x0000446D
		public ReportSATGiap()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000548D File Offset: 0x0000448D
		private void ReportSATGiap_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000054A4 File Offset: 0x000044A4
		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			this.cmd = new MySqlCommand("sp_satgiap", EClinicDB.EClinicDBConnection);
			this.cmd.CommandType = CommandType.StoredProcedure;
			MySqlParameter mySqlParameter = this.cmd.Parameters.Add("KetQua_Id", MySqlDbType.Int32);
			MySqlParameter mySqlParameter2 = this.cmd.Parameters.Add("DS_Anh_KQ", MySqlDbType.VarChar);
			mySqlParameter.Value = int.Parse(EClinicConfig.KetQua_SA_Id_cur.ToString());
			mySqlParameter2.Direction = ParameterDirection.Output;
			this.cmd.ExecuteNonQuery();
			DataSet dataSet = EClinicDB.FillDataset("BENH_NHAN", this.cmd);
			dataSet.Tables[0].TableName = "SieuAmTGiap";
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
			SieuAmTGiap sieuAmTGiap = new SieuAmTGiap();
			sieuAmTGiap.SetDataSource(dataSet);
			sieuAmTGiap.SetParameterValue("TitleReport", EClinicConfig.TitleReport);
			sieuAmTGiap.SetParameterValue("District", EClinicConfig.GetDistrict());
			this.crystalReportViewer1.ReportSource = sieuAmTGiap;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00005674 File Offset: 0x00004674
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

		// Token: 0x04000026 RID: 38
		private MySqlCommand cmd = null;
	}
}
