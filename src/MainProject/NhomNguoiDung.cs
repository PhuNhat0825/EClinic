using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Utility;

namespace MainProject
{
	// Token: 0x02000009 RID: 9
	public partial class NhomNguoiDung : Form
	{
		// Token: 0x0600006D RID: 109 RVA: 0x000081F2 File Offset: 0x000071F2
		public NhomNguoiDung()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00008224 File Offset: 0x00007224
		private void NhomNguoiDung_Load(object sender, EventArgs e)
		{
			string sCommand = "Select * from sys_groups where Group_Code <> 'ADMIN'";
			if (EClinicConfig.UserGroupTypes == "ADMIN")
			{
				sCommand = "Select * from sys_groups";
			}
			this.da = EClinicDB.CreateMySqlDataAdapter(sCommand);
			this.LoadData();
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00008281 File Offset: 0x00007281
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000828C File Offset: 0x0000728C
		public void LoadData()
		{
			this.da.Fill(this.ds, "NHOMSUDUNG");
			MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(this.da);
			this.dataGridView1.DataSource = this.ds.Tables["NHOMSUDUNG"];
			this.dataGridView1.Columns["Group_Id"].Visible = false;
			this.dataGridView1.Columns["Group_Code"].HeaderText = "Mã Nhóm";
			this.dataGridView1.Columns["Group_Name"].HeaderText = "Tên Nhóm";
			this.dataGridView1.Columns["Group_Name"].Width = 150;
			this.dataGridView1.Columns["DefaultGroup"].HeaderText = "Nhóm Mặc định";
			this.dataGridView1.Columns["DefaultGroup"].ToolTipText = "Chỉ nhận các giá trị 0 hoặc 1";
			this.dataGridView1.Columns["TamNgung"].HeaderText = "Tạm ngưng";
			this.dataGridView1.Columns["TamNgung"].ToolTipText = "Chỉ nhận các giá trị 0 hoặc 1";
			this.dataGridView1.Columns["Description"].HeaderText = "Mô tả đặc tính";
			this.dataGridView1.Columns["Creation_Date"].HeaderText = "Ngày khởi tạo";
			this.dataGridView1.Columns["Creation_Date"].Width = 200;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000843C File Offset: 0x0000743C
		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (this.buttonEdit.Text == "&Save")
			{
				try
				{
					this.da.Update(this.ds, "NHOMSUDUNG");
					MessageBox.Show(__.T("Cập nhật thành công !"));
					this.SetStateButton("EDIT");
				}
				catch
				{
					MessageBox.Show(__.T("Có lỗi xảy ra khi cập nhật bảng Nhóm người dùng."), __.T("Thông báo!"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				this.SetStateButton("SAVE");
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000084E4 File Offset: 0x000074E4
		private void SetStateButton(string sState)
		{
			if (sState == "SAVE")
			{
				this.dataGridView1.AllowUserToAddRows = true;
				this.buttonEdit.Text = "&Save";
				this.buttonCancel.Enabled = false;
			}
			else
			{
				this.dataGridView1.AllowUserToAddRows = false;
				this.buttonEdit.Text = "&Edit";
				this.buttonCancel.Enabled = true;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008560 File Offset: 0x00007560
		private void buttonMembers_Click(object sender, EventArgs e)
		{
			UserGroup userGroup = new UserGroup();
			userGroup.ShowDialog();
		}

		// Token: 0x0400007F RID: 127
		private DataSet ds = new DataSet();

		// Token: 0x04000080 RID: 128
		private MySqlDataAdapter da = new MySqlDataAdapter();
	}
}
