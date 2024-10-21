using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SKCDExtCtrl;
using SKCDExtCtrl.GridFilterFactories;
using SKCDExtCtrl.GridFilters;
using Utility;

namespace MainProject
{
	// Token: 0x02000007 RID: 7
	public partial class StaffManagerForm : Form
	{
		// Token: 0x0600005A RID: 90 RVA: 0x000071D2 File Offset: 0x000061D2
		public StaffManagerForm()
		{
			this.InitializeComponent();
			this.LoadData();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007210 File Offset: 0x00006210
		public void LoadData()
		{
			this.da.Fill(this.dsNhanVien, "NHAN_VIEN");
			MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(this.da);
			this.dataGridViewNhanVien.DataSource = this.dsNhanVien.Tables["NHAN_VIEN"];
			this.dataGridViewNhanVien.Columns["Nhan_Vien_Id"].Visible = false;
			this.dataGridViewNhanVien.Columns["Don_Vi_Id"].Visible = false;
			this.dataGridViewNhanVien.Columns["Ngay_Sinh"].HeaderText = "Ngày sinh";
			this.dataGridViewNhanVien.Columns["Ho_Ten"].HeaderText = "Họ Tên";
			this.dataGridViewNhanVien.Columns["Ho"].HeaderText = "Họ";
			this.dataGridViewNhanVien.Columns["Ho"].ReadOnly = true;
			this.dataGridViewNhanVien.Columns["Ten"].HeaderText = "Tên";
			this.dataGridViewNhanVien.Columns["Ten"].ReadOnly = true;
			this.dataGridViewNhanVien.Columns["Gioi_Tinh"].HeaderText = "Giới tính";
			this.dataGridViewNhanVien.Columns["Dia_Chi"].HeaderText = "Địa chỉ";
			this.dataGridViewNhanVien.Columns["Dien_Thoai"].HeaderText = "Điện thoại";
			this.dataGridViewNhanVien.Columns["CMND"].HeaderText = "Số CMND";
			this.dataGridViewNhanVien.Columns["Trinh_Do"].HeaderText = "Trình độ";
			this.dataGridViewNhanVien.Columns["Ngay_Tham_Gia"].HeaderText = "Ngày vào làm";
			this.dataGridViewNhanVien.Columns["Chuc_Vu"].HeaderText = "Chức vụ";
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007434 File Offset: 0x00006434
		private void buttonCapNhat_Click(object sender, EventArgs e)
		{
			try
			{
				this.da.Update(this.dsNhanVien, "NHAN_VIEN");
				MessageBox.Show(__.T("Cập nhật thành công !"));
				this.dataGridViewNhanVien.AllowUserToAddRows = false;
				this.dataGridViewNhanVien.AllowUserToDeleteRows = false;
				this.buttonCapNhat.Enabled = false;
				this.buttonEdit.Enabled = true;
			}
			catch
			{
				MessageBox.Show(__.T("Có lỗi xảy ra khi cập nhật bảng Nhân viên."), __.T("Thông báo!"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000074D4 File Offset: 0x000064D4
		private void dataGridViewNhanVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewNhanVien.SelectedCells[0].ColumnIndex == this.dataGridViewNhanVien.Columns["Ho_Ten"].Index)
			{
				StringExt stringExt = new StringExt();
				string[] array = stringExt.StringSplite(this.dataGridViewNhanVien.SelectedCells[0].Value.ToString());
				int rowIndex = this.dataGridViewNhanVien.SelectedCells[0].RowIndex;
				int index = this.dataGridViewNhanVien.Columns["Ho"].Index;
				this.dataGridViewNhanVien.Rows[rowIndex].Cells[index].Value = array[0];
				index = this.dataGridViewNhanVien.Columns["Ten"].Index;
				this.dataGridViewNhanVien.Rows[rowIndex].Cells[index].Value = array[1];
			}
			else if (this.dataGridViewNhanVien.SelectedCells[0].ColumnIndex == this.dataGridViewNhanVien.Columns["Gioi_Tinh"].Index)
			{
				string a = this.dataGridViewNhanVien.SelectedCells[0].Value.ToString();
				if (a == "Nu")
				{
					this.dataGridViewNhanVien.SelectedCells[0].Value = "Nữ";
				}
				else if (a != "Nam" && a != "Nữ")
				{
					MessageBox.Show(__.T("Giới tính nhập vào không hợp lệ. Vui lòng nhập vào Nam hoặc Nữ"), __.T("Thông báo!"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000076C0 File Offset: 0x000066C0
		private void dataGridViewNhanVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			if (e.ColumnIndex == this.dataGridViewNhanVien.Columns["Ngay_Sinh"].Index || e.ColumnIndex == this.dataGridViewNhanVien.Columns["Ngay_Tham_Gia"].Index)
			{
				string[] dateTimeFormats = DateTime.Now.GetDateTimeFormats('d');
				MessageBox.Show(__.T("Ngày nhập vào không hợp lệ. Vui lòng nhập lại. \n(Ví dụ, ngày hôm nay sẽ có dạng : " + dateTimeFormats[0] + ")"), __.T("Thông báo!"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00007758 File Offset: 0x00006758
		private void StaffManagerForm_Load(object sender, EventArgs e)
		{
			this.dataGridViewNhanVien.AllowUserToAddRows = false;
			this.dataGridViewNhanVien.AllowUserToDeleteRows = false;
			this.buttonCapNhat.Enabled = false;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007784 File Offset: 0x00006784
		private void buttonTaoUser_Click(object sender, EventArgs e)
		{
			string sNhanVienId = this.dataGridViewNhanVien.CurrentRow.Cells[0].Value.ToString();
			KhoiTaoNguoiSuDung khoiTaoNguoiSuDung = new KhoiTaoNguoiSuDung(sNhanVienId);
			khoiTaoNguoiSuDung.ShowDialog();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000077C1 File Offset: 0x000067C1
		private void buttonEdit_Click(object sender, EventArgs e)
		{
			this.dataGridViewNhanVien.AllowUserToAddRows = true;
			this.dataGridViewNhanVien.AllowUserToDeleteRows = true;
			this.buttonCapNhat.Enabled = true;
			this.buttonEdit.Enabled = false;
		}

		// Token: 0x04000071 RID: 113
		private MySqlDataAdapter da = EClinicDB.CreateMySqlDataAdapter("Select * from NHAN_VIEN");

		// Token: 0x04000072 RID: 114
		private DataSet dsNhanVien = new DataSet();
	}
}
