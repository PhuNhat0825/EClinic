using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SKCDExtCtrl;
using Utility;

namespace MainProject
{
	// Token: 0x02000005 RID: 5
	public partial class KhoiTaoNguoiSuDung : Form
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00005DB8 File Offset: 0x00004DB8
		public KhoiTaoNguoiSuDung()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005DE3 File Offset: 0x00004DE3
		public KhoiTaoNguoiSuDung(string sNhanVienId)
		{
			this.InitializeComponent();
			this.stNhanVienID = sNhanVienId;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005E18 File Offset: 0x00004E18
		private void NguoiSuDung_Load(object sender, EventArgs e)
		{
			this.labelNhanVienID.Text = this.stNhanVienID;
			string commandText = "select Ho_Ten from nhan_vien where nhan_vien_id = '" + this.stNhanVienID + "'";
			this.labelHoTen.Text = (string)EClinicDB.ExecuteScalar(commandText);
			commandText = "select count(user_id) from sys_users where nhan_vien_id = '" + this.stNhanVienID + "'";
			long num = (long)EClinicDB.ExecuteScalar(commandText);
			if (num > 0L)
			{
				commandText = "select user_name from sys_users where nhan_vien_id = '" + this.stNhanVienID + "'";
				this.textBoxUserName.Text = (string)EClinicDB.ExecuteScalar(commandText);
				this.textBoxUserName.Enabled = false;
				this.bUpdateUser = true;
			}
			else
			{
				this.bUpdateUser = false;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005EE4 File Offset: 0x00004EE4
		private void buttonOK_Click(object sender, EventArgs e)
		{
			string sCommand = string.Empty;
			string sCommand2 = string.Empty;
			if (this.textBoxPassword.Text != string.Empty)
			{
				sCommand = string.Concat(new string[]
				{
					"UPDATE sys_users SET user_password = PASSWORD('",
					this.textBoxPassword.Text,
					"'), TamNgung = '",
					this.checkBoxTamNgung.Checked ? "1" : "0",
					"' where nhan_vien_id = '",
					this.stNhanVienID,
					"'"
				});
				sCommand2 = string.Concat(new string[]
				{
					"INSERT INTO sys_users SET user_name = UPPER('",
					this.textBoxUserName.Text,
					"'), user_password = PASSWORD('",
					this.textBoxPassword.Text,
					"'), nhan_vien_id = '",
					this.stNhanVienID,
					"', TamNgung = '",
					this.checkBoxTamNgung.Checked ? "1" : "0",
					"'"
				});
			}
			else
			{
				sCommand = string.Concat(new string[]
				{
					"UPDATE sys_users SET TamNgung = '",
					this.checkBoxTamNgung.Checked ? "1" : "0",
					"' where nhan_vien_id = '",
					this.stNhanVienID,
					"'"
				});
				sCommand2 = string.Concat(new string[]
				{
					"INSERT INTO sys_users SET user_name = UPPER('",
					this.textBoxUserName.Text,
					"'), nhan_vien_id = '",
					this.stNhanVienID,
					"', TamNgung = '",
					this.checkBoxTamNgung.Checked ? "1" : "0",
					"'"
				});
			}
			if (this.bUpdateUser)
			{
				int num = EClinicDB.ExecuteNonQuery(sCommand);
				if (num == 0 || num == -1)
				{
					MessageBox.Show(__.T("Có lỗi khi cập nhật dữ liệu"));
					return;
				}
			}
			else
			{
				int num = EClinicDB.ExecuteNonQuery(sCommand2);
				if (num == 0 || num == -1)
				{
					MessageBox.Show(__.T("Có lỗi khi thêm dữ liệu"));
					return;
				}
			}
			MessageBox.Show(__.T("Cập nhật dữ liệu thành công"));
			base.Close();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000614F File Offset: 0x0000514F
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0400005F RID: 95
		private string stNhanVienID = string.Empty;

		// Token: 0x04000060 RID: 96
		private bool bUpdateUser = false;
	}
}
