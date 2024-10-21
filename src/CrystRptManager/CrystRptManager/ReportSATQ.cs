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
	// Token: 0x0200000C RID: 12
	public partial class ReportSATQ : Form
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00002FF6 File Offset: 0x00001FF6
		public ReportSATQ()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003016 File Offset: 0x00002016
		private void ReportSATQ_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003034 File Offset: 0x00002034
		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			string cmdText = "sp_satq_nam";
			string tableName = "SieuAmTQNam";
			string text = EClinicConfig.BenhNhan_Gioi.ToString();
			string text2 = text;
			if (text2 != null)
			{
				if (!(text2 == "Nam"))
				{
					if (text2 == "Nữ")
					{
						cmdText = "sp_satq_nu";
						tableName = "SieuAmTQNu";
					}
				}
				else
				{
					cmdText = "sp_satq_nam";
					tableName = "SieuAmTQNam";
				}
			}
			this.cmd = new MySqlCommand(cmdText, EClinicDB.EClinicDBConnection);
			this.cmd.CommandType = CommandType.StoredProcedure;
			MySqlParameter mySqlParameter = this.cmd.Parameters.Add("KetQua_Id", MySqlDbType.Int32);
			MySqlParameter mySqlParameter2 = this.cmd.Parameters.Add("DS_Anh_KQ", MySqlDbType.VarChar);
			mySqlParameter.Value = int.Parse(EClinicConfig.KetQua_SA_Id_cur.ToString());
			mySqlParameter2.Direction = ParameterDirection.Output;
			this.cmd.ExecuteNonQuery();
			DataSet dataSet = EClinicDB.FillDataset("BENH_NHAN", this.cmd);
			dataSet.Tables[0].TableName = tableName;
			DataTable dataTable = new DataTable("image");
			dataTable.Columns.Add("image", typeof(byte[]));
			dataSet.Tables.Add(dataTable);
			string text3 = mySqlParameter2.Value.ToString();
			char[] separator = new char[]
			{
				'+',
				' ',
				',',
				'.',
				':',
				'\t'
			};
			string[] array = text3.Split(separator);
			DataRow dataRow = dataSet.Tables["image"].NewRow();
			int num = 0;
			foreach (string idx in array)
			{
				dataRow[0] = this.ReadImageFromData(idx);
				num++;
			}
			dataSet.Tables["image"].Rows.Add(dataRow);
			text2 = text;
			if (text2 != null)
			{
				if (!(text2 == "Nam"))
				{
					if (text2 == "Nữ")
					{
						SieuAmTQNu sieuAmTQNu = new SieuAmTQNu();
						sieuAmTQNu.SetDataSource(dataSet);
						sieuAmTQNu.SetParameterValue("TitleReport", EClinicConfig.TitleReport);
						sieuAmTQNu.SetParameterValue("District", EClinicConfig.GetDistrict());
						this.crystalReportViewer1.ReportSource = sieuAmTQNu;
					}
				}
				else
				{
					SieuAmTQNam sieuAmTQNam = new SieuAmTQNam();
					sieuAmTQNam.SetDataSource(dataSet);
					sieuAmTQNam.SetParameterValue("TitleReport", EClinicConfig.TitleReport);
					sieuAmTQNam.SetParameterValue("District", EClinicConfig.GetDistrict());
					this.crystalReportViewer1.ReportSource = sieuAmTQNam;
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000032D4 File Offset: 0x000022D4
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

		// Token: 0x04000010 RID: 16
		private MySqlCommand cmd = null;
	}
}
