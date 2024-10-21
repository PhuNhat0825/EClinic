using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SKCDExtCtrl;
using Utility;

namespace MainProject
{
	// Token: 0x02000008 RID: 8
	public partial class ChangePasswordForm : Form
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00007CEF File Offset: 0x00006CEF
		public ChangePasswordForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007D0F File Offset: 0x00006D0F
		public ChangePasswordForm(int iNhanVienID)
		{
			this.InitializeComponent();
			this.intNhanVienID = iNhanVienID;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007D38 File Offset: 0x00006D38
		public bool LaMKHopLe()
		{
			return !(this.textBoxMKMoi.Text == "") && !(this.textBoxGoLaiMK.Text != this.textBoxMKMoi.Text);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007D8C File Offset: 0x00006D8C
		public void DoiMatKhau()
		{
			if (!this.LaMKHopLe())
			{
				MessageBox.Show(__.T("Gõ lại Mật khẩu không đúng hoặc Mật khẩu không hợp lệ."), __.T("Thông báo!"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				string sCommand = string.Concat(new object[]
				{
					"UPDATE `sys_users` SET User_Password = PASSWORD('",
					this.textBoxMKMoi.Text,
					"') WHERE Nhan_Vien_Id = '",
					this.intNhanVienID,
					"'"
				});
				try
				{
					EClinicDB.ExecuteNonQuery(sCommand);
					MessageBox.Show(__.T("Đã đổi mật khẩu thành công."));
					base.Close();
				}
				catch
				{
					MessageBox.Show(__.T("Có lỗi trong quá trình thay đổi mật khẩu."), __.T("Thông báo!"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007E60 File Offset: 0x00006E60
		private void buttonDoiMK_Click(object sender, EventArgs e)
		{
			this.DoiMatKhau();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00007E6A File Offset: 0x00006E6A
		private void buttonHuyBo_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007E74 File Offset: 0x00006E74
		private void textBoxMKMoi_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0400007A RID: 122
		private int intNhanVienID = 0;
	}
}
