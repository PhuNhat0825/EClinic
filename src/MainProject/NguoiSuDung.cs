using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MainProject
{
	// Token: 0x02000003 RID: 3
	public partial class NguoiSuDung : Form
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00004791 File Offset: 0x00003791
		public NguoiSuDung()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000047B8 File Offset: 0x000037B8
		private void NguoiSuDung_Load(object sender, EventArgs e)
		{
			EClinicDB.LoadDatasetIntoDataGridView(ref this.dataGridView1, "NguoiSuDungNhanVien");
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Columns["Nhan_Vien_Id"].Visible = false;
			this.dataGridView1.Columns["User_Id"].Visible = false;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004829 File Offset: 0x00003829
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004834 File Offset: 0x00003834
		private void buttonChangePassword_Click(object sender, EventArgs e)
		{
			string sNhanVienId = this.dataGridView1.CurrentRow.Cells["Nhan_Vien_Id"].Value.ToString();
			KhoiTaoNguoiSuDung khoiTaoNguoiSuDung = new KhoiTaoNguoiSuDung(sNhanVienId);
			khoiTaoNguoiSuDung.ShowDialog();
			EClinicDB.LoadDatasetIntoDataGridView(ref this.dataGridView1, "NguoiSuDungNhanVien");
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004888 File Offset: 0x00003888
		private void buttonPhanQuyen_Click(object sender, EventArgs e)
		{
			UserGroup userGroup = new UserGroup(this.dataGridView1.CurrentRow.Cells["User_Id"].Value.ToString());
			userGroup.ShowDialog();
		}

		// Token: 0x04000042 RID: 66
		private DataSet ds = new DataSet();
	}
}
