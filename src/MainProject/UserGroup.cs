using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utility;

namespace MainProject
{
	// Token: 0x0200000A RID: 10
	public partial class UserGroup : Form
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00008928 File Offset: 0x00007928
		public UserGroup()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00008957 File Offset: 0x00007957
		public UserGroup(string sUserID)
		{
			this.InitializeComponent();
			this.stUserID = sUserID;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00008990 File Offset: 0x00007990
		private void UserGroup_Load(object sender, EventArgs e)
		{
			this.ds.Relations.Clear();
			string sCommand = "select * from sys_groups where Group_Code <> 'ADMIN' order by Group_Id asc";
			if (EClinicConfig.UserGroupTypes == "ADMIN")
			{
				sCommand = "select * from sys_groups order by Group_Id asc";
			}
			EClinicDB.FillDataset(ref this.ds, sCommand, "NHOMSUDUNG");
			this.checkedListBoxGroups.DataSource = this.ds;
			this.checkedListBoxGroups.DisplayMember = "NHOMSUDUNG.Group_Name";
			this.checkedListBoxGroups.ValueMember = "NHOMSUDUNG.Group_Id";
			this.SetTrangThaiUserBanDau(this.stUserID);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00008A24 File Offset: 0x00007A24
		private void SetTrangThaiUserBanDau(string stUserID)
		{
			for (int i = 0; i < this.checkedListBoxGroups.Items.Count; i++)
			{
				string stGroup = this.ds.Tables["NHOMSUDUNG"].Rows[i]["Group_Id"].ToString();
				if (this.checkUserGroups(stUserID, stGroup))
				{
					this.checkedListBoxGroups.SetItemCheckState(i, CheckState.Checked);
				}
				else
				{
					this.checkedListBoxGroups.SetItemCheckState(i, CheckState.Unchecked);
				}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00008AB0 File Offset: 0x00007AB0
		private bool checkUserGroups(string stUserID, string stGroup)
		{
			long num = (long)EClinicDB.ExecuteScalar(string.Concat(new string[]
			{
				"select count(user_id) from sys_usergroups where user_id = '",
				stUserID,
				"' AND group_id = '",
				stGroup,
				"'"
			}));
			return num > 0L;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00008B03 File Offset: 0x00007B03
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00008B10 File Offset: 0x00007B10
		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.checkedListBoxGroups.CheckedIndices)
			{
				int index = (int)obj;
				string text = this.ds.Tables["NHOMSUDUNG"].Rows[index]["Group_Id"].ToString();
				if (!this.DeleteDichVu(this.stUserID))
				{
					MessageBox.Show(__.T("Có lỗi khi cập nhật Hệ thống dữ liệu."));
					return;
				}
				foreach (object obj2 in this.checkedListBoxGroups.CheckedIndices)
				{
					int index2 = (int)obj2;
					string sGroupID = this.ds.Tables["NHOMSUDUNG"].Rows[index2]["Group_Id"].ToString();
					if (!this.InsertNew(this.stUserID, sGroupID))
					{
						MessageBox.Show(__.T("Có lỗi khi cập nhật Hệ thống dữ liệu."));
						return;
					}
				}
			}
			MessageBox.Show(__.T("Cập nhật thành công."));
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00008CC8 File Offset: 0x00007CC8
		private bool DeleteDichVu(string sUserID)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("DELETE FROM sys_usergroups WHERE user_id = {0}", sUserID);
			int num = EClinicDB.ExecuteNonQuery(stringBuilder.ToString());
			return num != -1;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00008D04 File Offset: 0x00007D04
		private bool InsertNew(string sUserID, string sGroupID)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("Insert into sys_usergroups (user_id, Group_id) values ({0}, {1})", sUserID, sGroupID);
			return EClinicDB.ExecuteNonQuery(stringBuilder.ToString()) != -1;
		}

		// Token: 0x04000086 RID: 134
		private DataSet ds = new DataSet();

		// Token: 0x04000087 RID: 135
		private string stUserID = string.Empty;
	}
}
