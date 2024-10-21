using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Utility;

namespace SysManager
{
	// Token: 0x02000006 RID: 6
	public partial class QuanLyDichVu : Form
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000045C8 File Offset: 0x000035C8
		public QuanLyDichVu()
		{
			this.InitializeComponent();
			base.Size = new Size(1024, 768);
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "EClinic - Quản lý dịch vụ";
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000462C File Offset: 0x0000362C
		private void ThietLapHienThiCacLuoi()
		{
			for (int i = 0; i < this.dataGridViewDsDichVu.Columns.Count; i++)
			{
				this.dataGridViewDsDichVu.Columns[i].Visible = false;
			}
			this.dataGridViewDsDichVu.Columns["DichVu_Id"].Visible = true;
			this.dataGridViewDsDichVu.Columns["DichVu_Id"].HeaderText = "Mã DV";
			this.dataGridViewDsDichVu.Columns["DichVu_Id"].Width = 50;
			this.dataGridViewDsDichVu.Columns["DichVu_Id"].DisplayIndex = 1;
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg01"].Visible = true;
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg01"].HeaderText = "Mã nhóm";
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg01"].ToolTipText = "Nhóm dịch vụ Siêu âm: SAM";
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg01"].Width = 50;
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg01"].DisplayIndex = 2;
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg02"].Visible = true;
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg02"].HeaderText = "Mã loại";
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg02"].ToolTipText = "Subgroup của dịch vụ siêu âm";
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg02"].Width = 50;
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg02"].DisplayIndex = 3;
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg03"].Visible = true;
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg03"].HeaderText = "Mã thứ tự nhóm";
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg03"].ToolTipText = "Thứ tự dịch vụ trong subgroup";
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg03"].Width = 50;
			this.dataGridViewDsDichVu.Columns["MaDichVu_Seg03"].DisplayIndex = 4;
			this.dataGridViewDsDichVu.Columns["TenDichVu"].Visible = true;
			this.dataGridViewDsDichVu.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
			this.dataGridViewDsDichVu.Columns["TenDichVu"].Width = 230;
			this.dataGridViewDsDichVu.Columns["TenDichVu"].DisplayIndex = 5;
			this.dataGridViewDsDichVu.Columns["Idx"].Visible = true;
			this.dataGridViewDsDichVu.Columns["Idx"].HeaderText = "Thứ tự";
			this.dataGridViewDsDichVu.Columns["Idx"].ToolTipText = "Thứ tự được sắp xếp hiện ra trong combobox dịch vụ";
			this.dataGridViewDsDichVu.Columns["Idx"].Width = 50;
			this.dataGridViewDsDichVu.Columns["Idx"].DisplayIndex = 6;
			this.dataGridViewDsDichVu.Columns["TamNgung"].Visible = true;
			this.dataGridViewDsDichVu.Columns["TamNgung"].HeaderText = "Tạm ngưng";
			this.dataGridViewDsDichVu.Columns["TamNgung"].Width = 50;
			this.dataGridViewDsDichVu.Columns["TamNgung"].DisplayIndex = 7;
			for (int i = 0; i < this.dataGridViewDonGiaDichVu.Columns.Count; i++)
			{
				this.dataGridViewDonGiaDichVu.Columns[i].Visible = false;
			}
			this.dataGridViewDonGiaDichVu.Columns["DonGia"].Visible = true;
			this.dataGridViewDonGiaDichVu.Columns["DonGia"].HeaderText = "Đơn giá";
			this.dataGridViewDonGiaDichVu.Columns["DonGia"].DefaultCellStyle.Format = "N0";
			this.dataGridViewDonGiaDichVu.Columns["DonGia"].Width = 50;
			this.dataGridViewDonGiaDichVu.Columns["DonGia"].DisplayIndex = 1;
			this.dataGridViewDonGiaDichVu.Columns["GiaTienCong"].Visible = true;
			this.dataGridViewDonGiaDichVu.Columns["GiaTienCong"].HeaderText = "Tiền công";
			this.dataGridViewDonGiaDichVu.Columns["GiaTienCong"].DefaultCellStyle.Format = "N0";
			this.dataGridViewDonGiaDichVu.Columns["GiaTienCong"].Width = 50;
			this.dataGridViewDonGiaDichVu.Columns["GiaTienCong"].DisplayIndex = 2;
			this.dataGridViewDonGiaDichVu.Columns["NgayHieuLuc"].Visible = true;
			this.dataGridViewDonGiaDichVu.Columns["NgayHieuLuc"].HeaderText = "Ngày hiệu lực";
			this.dataGridViewDonGiaDichVu.Columns["NgayHieuLuc"].DefaultCellStyle.Format = "d";
			this.dataGridViewDonGiaDichVu.Columns["NgayHieuLuc"].Width = 80;
			this.dataGridViewDonGiaDichVu.Columns["NgayHieuLuc"].DisplayIndex = 3;
			this.dataGridViewDonGiaDichVu.Columns["NgayHetHieuLuc"].Visible = true;
			this.dataGridViewDonGiaDichVu.Columns["NgayHetHieuLuc"].HeaderText = "Ngày hết hiệu lực";
			this.dataGridViewDonGiaDichVu.Columns["NgayHetHieuLuc"].DefaultCellStyle.Format = "d";
			this.dataGridViewDonGiaDichVu.Columns["NgayHetHieuLuc"].Width = 80;
			this.dataGridViewDonGiaDichVu.Columns["NgayHetHieuLuc"].DisplayIndex = 4;
			this.dataGridViewDonGiaDichVu.Columns.Remove("TamNgung");
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			dataGridViewCheckBoxColumn.HeaderText = "Tạm Ngưng";
			dataGridViewCheckBoxColumn.Name = "TamNgung";
			dataGridViewCheckBoxColumn.DataPropertyName = "TamNgung";
			dataGridViewCheckBoxColumn.FalseValue = 0;
			dataGridViewCheckBoxColumn.TrueValue = 1;
			dataGridViewCheckBoxColumn.Width = 50;
			this.dataGridViewDonGiaDichVu.Columns.Add(dataGridViewCheckBoxColumn);
			this.dataGridViewDonGiaDichVu.Columns["TamNgung"].DisplayIndex = 5;
			if (EClinicConfig.UserGroupTypes == "ADMIN")
			{
				this.dataGridViewDsDichVu.AllowUserToAddRows = true;
				this.dataGridViewDsDichVu.AllowUserToDeleteRows = true;
			}
			else
			{
				this.dataGridViewDsDichVu.AllowUserToAddRows = false;
				this.dataGridViewDsDichVu.AllowUserToDeleteRows = false;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004DAC File Offset: 0x00003DAC
		private void QuanLyDichVu_Load(object sender, EventArgs e)
		{
			this.ds.Relations.Clear();
			EClinicDB.FillDataset(ref this.ds, "select * from dm_dichvu_nhom where (Cap = 1) order by NhomDichVu_Id asc", "DMNhomDichVu");
			this.daDichVu = EClinicDB.CreateMySqlDataAdapter("select * from dm_dichvu where (Cap = 1) order by NhomDichVu_Id asc");
			this.daDichVu.Fill(this.ds, "DMDichVu");
			this.cbDichVu = new MySqlCommandBuilder(this.daDichVu);
			this.daDonGia = EClinicDB.CreateMySqlDataAdapter("select * from dm_dichvu_dongia order by DichVu_Id asc");
			this.daDonGia.Fill(this.ds, "GiaDichVu");
			this.cbDonGia = new MySqlCommandBuilder(this.daDonGia);
			this.ds.Relations.Add("NhomDV_DichVu", this.ds.Tables["DMNhomDichVu"].Columns["NhomDichVu_Id"], this.ds.Tables["DMDichVu"].Columns["NhomDichVu_Id"], false);
			this.ds.Relations.Add("DichVu_DonGia", this.ds.Tables["DMDichVu"].Columns["DichVu_Id"], this.ds.Tables["GiaDichVu"].Columns["DichVu_Id"], false);
			this.comboBoxNhomDichVu.DataSource = this.ds;
			this.comboBoxNhomDichVu.DisplayMember = "DMNhomDichVu.TenNhomDichVu";
			this.comboBoxNhomDichVu.ValueMember = "NhomDichVu_Id";
			this.comboBoxNhomDichVu.SelectedIndex = 0;
			this.dataGridViewDsDichVu.DataSource = this.ds;
			this.dataGridViewDsDichVu.DataMember = "DMNhomDichVu.NhomDV_DichVu";
			this.dataGridViewDonGiaDichVu.DataSource = this.ds;
			this.dataGridViewDonGiaDichVu.DataMember = "DMNhomDichVu.NhomDV_DichVu.DichVu_DonGia";
			this.ThietLapHienThiCacLuoi();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004F9D File Offset: 0x00003F9D
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004FA7 File Offset: 0x00003FA7
		private void comboBoxNhomDichVu_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004FAC File Offset: 0x00003FAC
		private void buttonOK_Click(object sender, EventArgs e)
		{
			try
			{
				this.daDichVu.Update(this.ds, "DMDichVu");
				this.daDonGia.Update(this.ds, "GiaDichVu");
				MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
			catch
			{
				MessageBox.Show("Có lỗi xảy ra khi cập nhật dữ liệu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005028 File Offset: 0x00004028
		public void ShowForm()
		{
			base.Show();
		}

		// Token: 0x0400002D RID: 45
		private DataSet ds = new DataSet();

		// Token: 0x0400002E RID: 46
		private MySqlDataAdapter daDichVu;

		// Token: 0x0400002F RID: 47
		private MySqlCommandBuilder cbDichVu;

		// Token: 0x04000030 RID: 48
		private MySqlDataAdapter daDonGia;

		// Token: 0x04000031 RID: 49
		private MySqlCommandBuilder cbDonGia;

		// Token: 0x04000032 RID: 50
		private string _scommandText = string.Empty;
	}
}
