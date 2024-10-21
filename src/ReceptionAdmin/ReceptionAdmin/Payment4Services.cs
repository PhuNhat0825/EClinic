using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SKCDExtCtrl;
using Utility;

namespace ReceptionAdmin
{
	// Token: 0x02000004 RID: 4
	public partial class Payment4Services : Form
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000032BA File Offset: 0x000022BA
		public Payment4Services()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000032E4 File Offset: 0x000022E4
		private void Payment4Services2_Load(object sender, EventArgs e)
		{
			DataSet dataSet = EClinicDB.FillDataset("SELECT dv.Dich_Vu_Id, dv.Ten AS 'Tên dịch vụ', ndv.Ten_Nhom AS 'Nhóm dịch vụ' FROM dich_vu dv, nhom_dich_vu ndv WHERE dv.Nhom_DV_Id = ndv.Nhom_DV_Id");
			if (dataSet != null && dataSet.Tables.Count != 0)
			{
				this.multiComboDichvu.Table = dataSet.Tables[0];
				this.multiComboDichvu.ColumnsToDisplay = new string[]
				{
					"Tên dịch vụ",
					"Nhóm dịch vụ"
				};
				this.multiComboDichvu.DisplayMember = "Tên dịch vụ";
				this.multiComboDichvu.ValueMember = "Dich_Vu_Id";
				this.multiComboDichvu.SelectedIndex = 0;
				this.LoadNhanVien();
				this.ShowDetailsInGrid();
			}
			else
			{
				MessageBox.Show(__.T("Có lỗi khi tải dữ liệu Dịch vụ."));
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000033A8 File Offset: 0x000023A8
		private void outlookGridThongtin_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 && e.ColumnIndex >= 0)
			{
				ListSortDirection direction = ListSortDirection.Ascending;
				if (e.ColumnIndex == this.prevColIndex)
				{
					direction = ((this.prevSortDirection == ListSortDirection.Descending) ? ListSortDirection.Ascending : ListSortDirection.Descending);
				}
				this.prevColIndex = e.ColumnIndex;
				this.prevSortDirection = direction;
				this.outlookGridThongtin.GroupTemplate.Column = this.outlookGridThongtin.Columns[e.ColumnIndex];
				this.outlookGridThongtin.Sort(new DataRowComparer(e.ColumnIndex, direction));
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003448 File Offset: 0x00002448
		private void checkedListDSNV_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = this.checkedListDSNV.SelectedIndex;
			if (selectedIndex != -1)
			{
				string sNhanvien_Id = this._dtNhanvien.Rows[selectedIndex]["Nhan_Vien_Id"].ToString();
				this.ShowDetailsInGrid(sNhanvien_Id);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003495 File Offset: 0x00002495
		private void buttonThoat_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000034A0 File Offset: 0x000024A0
		private void buttonChonHet_Click(object sender, EventArgs e)
		{
			int count = this.checkedListDSNV.Items.Count;
			for (int i = 0; i < count; i++)
			{
				this.checkedListDSNV.SetItemChecked(i, true);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000034E0 File Offset: 0x000024E0
		private void buttonBoChon_Click(object sender, EventArgs e)
		{
			int count = this.checkedListDSNV.Items.Count;
			for (int i = 0; i < count; i++)
			{
				this.checkedListDSNV.SetItemChecked(i, false);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000351F File Offset: 0x0000251F
		private void buttonXemToanBo_Click(object sender, EventArgs e)
		{
			this.ShowDetailsInGrid();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000352C File Offset: 0x0000252C
		private void buttonCapNhat_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.checkedListDSNV.CheckedIndices)
			{
				int index = (int)obj;
				string sNhanVienId = this._dtNhanvien.Rows[index]["Nhan_vien_id"].ToString();
				if (!this.UpdateNew(sNhanVienId))
				{
					if (!this.InsertNew(sNhanVienId))
					{
						MessageBox.Show(__.T("Có lỗi khi cập nhật Hệ thống dữ liệu."));
						return;
					}
				}
			}
			this.ShowDetailsInGrid();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000035E8 File Offset: 0x000025E8
		private void LoadNhanVien()
		{
			DataSet dataSet = EClinicDB.FillDataset("SELECT Nhan_Vien_Id, Ho_Ten, Trinh_Do, Chuc_Vu, Ngay_Sinh FROM nhan_vien ORDER BY ten");
			if (dataSet != null && dataSet.Tables.Count != 0)
			{
				this._dtNhanvien = dataSet.Tables[0];
				this.checkedListDSNV.Items.Clear();
				foreach (object obj in this._dtNhanvien.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					this.checkedListDSNV.Items.Add(dataRow["Ho_ten"].ToString());
				}
			}
			else
			{
				MessageBox.Show(__.T("Có lỗi khi tải dữ liệu Nhân viên."));
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000036D0 File Offset: 0x000026D0
		private void ShowDetailsInGrid(string sNhanvien_Id)
		{
			string text = "select NHAN_VIEN.Nhan_Vien_Id as Nhan_Vien_Id, NHAN_VIEN.Ho_Ten as Ho_Ten, DICH_VU.Ten as Ten_Dich_Vu, NHAN_VIEN_DICH_VU.Tien_Cong as Tien_Cong, Dich_vu.Dich_vu_Id from NHAN_VIEN, NHAN_VIEN_DICH_VU, DICH_VU where (NHAN_VIEN.Nhan_Vien_Id = NHAN_VIEN_DICH_VU.Nhan_Vien_Id) and (DICH_VU.Dich_Vu_Id = NHAN_VIEN_DICH_VU.Dich_Vu_Id) ";
			if (sNhanvien_Id != string.Empty)
			{
				text = text + "AND (NHAN_VIEN.Nhan_vien_id= " + sNhanvien_Id + ") ";
			}
			DataSet dataSet = EClinicDB.FillDataset(text, true);
			if (dataSet != null && dataSet.Tables.Count != 0)
			{
				if (dataSet.Tables[0].Rows.Count > 0)
				{
					dataSet.Tables[0].TableName = "TIEN_CONG_DICH_VU";
					this.outlookGridThongtin.BindData(dataSet, "TIEN_CONG_DICH_VU");
					this.outlookGridThongtin.Columns["Nhan_Vien_Id"].HeaderText = "Mã nhân viên";
					this.outlookGridThongtin.Columns["Nhan_Vien_Id"].Width = 40;
					this.outlookGridThongtin.Columns["Ho_Ten"].HeaderText = "Họ tên";
					this.outlookGridThongtin.Columns["Ho_Ten"].Width = 100;
					this.outlookGridThongtin.Columns["Ten_Dich_Vu"].HeaderText = "Tên dịch vụ";
					this.outlookGridThongtin.Columns["Ten_Dich_Vu"].Width = 100;
					this.outlookGridThongtin.Columns["Tien_Cong"].HeaderText = "Tiền công";
					this.outlookGridThongtin.Columns["Tien_Cong"].Width = 50;
					this.outlookGridThongtin.Columns["Dich_vu_Id"].Visible = false;
					this.outlookGridThongtin.GroupTemplate.Column = this.outlookGridThongtin.Columns[3];
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000038AF File Offset: 0x000028AF
		private void ShowDetailsInGrid()
		{
			this.ShowDetailsInGrid(string.Empty);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000038C0 File Offset: 0x000028C0
		private bool InsertNew(string sNhanVienId)
		{
			string sSQL = string.Concat(new string[]
			{
				"Insert into NHAN_VIEN_DICH_VU (Nhan_Vien_Id, Dich_Vu_Id, Tien_Cong) values (",
				sNhanVienId,
				",",
				this.multiComboDichvu.SelectedValue,
				",?0)"
			});
			string[] asFieldNames = new string[]
			{
				"Tien_Cong"
			};
			string[] asFieldValues = new string[]
			{
				this.filterTextTiencong.Text.Replace(".", "")
			};
			return EClinicDB.ExecuteNonQuery(sSQL, asFieldNames, asFieldValues) != -1;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003960 File Offset: 0x00002960
		private bool UpdateNew(string sNhanVienId)
		{
			string sSQL = "update NHAN_VIEN_DICH_VU set Tien_Cong=?0  where Nhan_Vien_Id=" + sNhanVienId + " and Dich_Vu_Id=" + this.multiComboDichvu.SelectedValue;
			string[] asFieldNames = new string[]
			{
				"Tien_Cong"
			};
			string[] asFieldValues = new string[]
			{
				this.filterTextTiencong.Text.Replace(".", "")
			};
			int num = EClinicDB.ExecuteNonQuery(sSQL, asFieldNames, asFieldValues);
			return num != 0 && num != -1;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000039F0 File Offset: 0x000029F0
		private bool DeleteNew(string sMaNhanVien, string sMaDichVu)
		{
			string sCommand = "DELETE Nhan_vien_dich_vu WHERE Nhan_vien_id=" + sMaNhanVien + " AND Dich_vu_id=" + sMaDichVu;
			int num = EClinicDB.ExecuteNonQuery(sCommand);
			return num != -1;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003A24 File Offset: 0x00002A24
		private void buttonXoaDichVu_Click(object sender, EventArgs e)
		{
			if (this.outlookGridThongtin.SelectedRows.Count != 0 && !((OutlookGridRow)this.outlookGridThongtin.SelectedRows[0]).IsGroupRow)
			{
				string sMaNhanVien = this.outlookGridThongtin.SelectedRows[0].Cells["SA_id"].Value.ToString();
				string sMaDichVu = this.outlookGridThongtin.SelectedRows[0].Cells["Dich_vu_Id"].Value.ToString();
				if (!this.DeleteNew(sMaNhanVien, sMaDichVu))
				{
					MessageBox.Show(__.T("Có lỗi khi cập nhật Hệ thống dữ liệu."));
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003AE0 File Offset: 0x00002AE0
		private void buttonQuanlyDichvu_Click(object sender, EventArgs e)
		{
			ServicesManagement servicesManagement = new ServicesManagement();
			servicesManagement.ShowDialog();
		}

		// Token: 0x0400001B RID: 27
		private DataTable _dtNhanvien;

		// Token: 0x0400001C RID: 28
		private int prevColIndex = -1;

		// Token: 0x0400001D RID: 29
		private ListSortDirection prevSortDirection = ListSortDirection.Ascending;
	}
}
