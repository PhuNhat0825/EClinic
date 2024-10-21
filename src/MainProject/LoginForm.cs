using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SKCDExtCtrl;
using Utility;

namespace MainProject
{
	// Token: 0x02000004 RID: 4
	public partial class LoginForm : Form
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00004D23 File Offset: 0x00003D23
		public LoginForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00004D44 File Offset: 0x00003D44
		public bool DangNhapThanhCong
		{
			get
			{
				return this.dangNhapThanhCong;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004D5C File Offset: 0x00003D5C
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.No;
			base.Close();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00004D70 File Offset: 0x00003D70
		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (this.CheckLogin(this.textBoxUserID.Text.ToLower(), this.textBoxPassword.Text.ToString()))
			{
				this.dangNhapThanhCong = true;
			}
			else
			{
				MessageBox.Show("Sai Bí danh và Mật khẩu !", "Lỗi đăng nhập", MessageBoxButtons.OK);
				this.textBoxUserID.Focus();
			}
			if (this.dangNhapThanhCong)
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004DE8 File Offset: 0x00003DE8
		private bool CheckLogin(string username, string password)
		{
			string commandText = string.Concat(new string[]
			{
				"select count(user_id) as countid from sys_users where user_name = '",
				username,
				"' and user_password = password('",
				password,
				"')"
			});
			int num = int.Parse(EClinicDB.ExecuteScalar(commandText).ToString());
			bool result;
			if (num > 0)
			{
				commandText = string.Concat(new string[]
				{
					"select nhan_vien_id from sys_users where user_name = '",
					username,
					"' and user_password = password('",
					password,
					"')"
				});
				EClinicConfig.NhanVienLoginID = int.Parse(EClinicDB.ExecuteScalar(commandText).ToString());
				commandText = string.Concat(new string[]
				{
					"select user_id from sys_users where user_name = '",
					username,
					"' and user_password = password('",
					password,
					"')"
				});
				EClinicConfig.UserIdLogin = int.Parse(EClinicDB.ExecuteScalar(commandText).ToString());
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04000049 RID: 73
		private bool dangNhapThanhCong = false;
	}
}
