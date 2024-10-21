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
	// Token: 0x02000031 RID: 49
	public partial class ReportSAThai2D1 : Form
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x00006D1A File Offset: 0x00005D1A
		public ReportSAThai2D1()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00006D3A File Offset: 0x00005D3A
		private void SieuAmThai2D1_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00006D54 File Offset: 0x00005D54
		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			this.cmd = new MySqlCommand("sp_sathai2d1", EClinicDB.EClinicDBConnection);
			this.cmd.CommandType = CommandType.StoredProcedure;
			MySqlParameter mySqlParameter = this.cmd.Parameters.Add("KetQua_Id", MySqlDbType.Int32);
			MySqlParameter mySqlParameter2 = this.cmd.Parameters.Add("DS_Anh_KQ", MySqlDbType.VarChar);
			mySqlParameter.Value = int.Parse(EClinicConfig.KetQua_SA_Id_cur.ToString());
			mySqlParameter2.Direction = ParameterDirection.Output;
			this.cmd.ExecuteNonQuery();
			DataSet dataSet = EClinicDB.FillDataset("BENH_NHAN", this.cmd);
			dataSet.Tables[0].TableName = "SieuAmThai2D_1";
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
			SieuAmThai2D_1 sieuAmThai2D_ = new SieuAmThai2D_1();
			sieuAmThai2D_.SetDataSource(dataSet);
			sieuAmThai2D_.SetParameterValue("TitleReport", EClinicConfig.TitleReport);
			sieuAmThai2D_.SetParameterValue("District", EClinicConfig.GetDistrict());
			this.crystalReportViewer1.ReportSource = sieuAmThai2D_;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00006F24 File Offset: 0x00005F24
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

		// Token: 0x04000034 RID: 52
		private MySqlCommand cmd = null;
	}
}
