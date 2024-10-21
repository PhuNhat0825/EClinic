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
	// Token: 0x02000056 RID: 86
	public partial class ReportSAThai4D : Form
	{
		// Token: 0x06000737 RID: 1847 RVA: 0x000197A9 File Offset: 0x000187A9
		public ReportSAThai4D()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x000197C9 File Offset: 0x000187C9
		private void ReportSAThai4D_Load(object sender, EventArgs e)
		{
			this.Text = "EClinic.EchoAdmin -- Kết quả siêu âm";
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000197E0 File Offset: 0x000187E0
		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			this.cmd = new MySqlCommand("sp_sathai4d", EClinicDB.EClinicDBConnection);
			this.cmd.CommandType = CommandType.StoredProcedure;
			MySqlParameter mySqlParameter = this.cmd.Parameters.Add("KetQua_Id", MySqlDbType.Int32);
			MySqlParameter mySqlParameter2 = this.cmd.Parameters.Add("DS_Anh_KQ", MySqlDbType.VarChar);
			mySqlParameter.Value = int.Parse(EClinicConfig.KetQua_SA_Id_cur.ToString());
			mySqlParameter2.Direction = ParameterDirection.Output;
			this.cmd.ExecuteNonQuery();
			DataSet dataSet = EClinicDB.FillDataset("BENH_NHAN", this.cmd);
			dataSet.Tables[0].TableName = "SieuAm4D";
			SieuAmThai4D sieuAmThai4D = new SieuAmThai4D();
			sieuAmThai4D.SetDataSource(dataSet);
			sieuAmThai4D.SetParameterValue("TitleReport", EClinicConfig.TitleReport);
			sieuAmThai4D.SetParameterValue("District", EClinicConfig.GetDistrict());
			this.crystalReportViewer1.ReportSource = sieuAmThai4D;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000198D8 File Offset: 0x000188D8
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

		// Token: 0x04000142 RID: 322
		private MySqlCommand cmd = null;
	}
}
