using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using CrystRptManager;
using DBInteraction;
using SKCDExtCtrl;
using SysManager;
using Utility;

namespace ReceptionAdmin
{
	// Token: 0x02000008 RID: 8
	public partial class ReceptionAdmin : Form
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00008E0C File Offset: 0x00007E0C
		public ReceptionAdmin()
		{
			this.InitializeComponent();
			this.textBoxMaYT.KeyPress += this.textBoxMaYT_KeyPress;
			this.textBoxDVCode.KeyPress += this.textBoxDVCode_KeyPress;
			this.textBoxMienGiam.KeyPress += this.textBoxMienGiam_KeyPress;
			this.textBoxDonGia.KeyPress += this.textBoxDonGia_KeyPress;
			this.textBoxPreMaYT.Text = EClinicConfig.PreMaYTe;
			this.textBoxPreMaYT.Enabled = false;
			this.buttonInTheBN.Enabled = false;
			base.Size = EClinicConfig.FullSizeWindows;
			this.dataGridViewDichVu.RowsAdded += this.dataGridView1_RowsAdded;
			this.dataGridViewDichVu.UserDeletingRow += this.dataGridView1_UserDeletingRow;
			this.dataGridViewDichVu.KeyUp += this.dataGridView1_KeyUp;
			this.dataGridViewDichVu.MouseUp += this.dataGridView1_MouseUp;
			this.dataGridViewExtYeuCau.CellValueChanged += this.dataGridViewExtYeuCau_CellValueChanged;
			this.dataGridViewExtYeuCau.CurrentCellDirtyStateChanged += this.dataGridViewExtYeuCau_CurrentCellDirtyStateChanged;
			this.dataGridViewExtYeuCau.CellMouseDown += this.dataGridViewExtYeuCau_CellMouseDown;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00008F96 File Offset: 0x00007F96
		private void dataGridViewExtYeuCau_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			this.bPhongBanThayDoi = true;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00008FA0 File Offset: 0x00007FA0
		private void dataGridViewExtYeuCau_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dataGridViewExtYeuCau.IsCurrentCellDirty)
			{
				this.dataGridViewExtYeuCau.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00008FD4 File Offset: 0x00007FD4
		private void dataGridViewExtYeuCau_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewExtYeuCau.Columns[e.ColumnIndex].Name == "PhongBan_Id" && this.bPhongBanThayDoi)
			{
				this.bPhongBanThayDoi = false;
				DialogResult dialogResult = MessageBox.Show("Bạn muốn thay đổi Phòng thực hiện", "Lưu ý", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					try
					{
						if (this.CapNhatPhongThucHien(int.Parse(this.dataGridViewExtYeuCau.Rows[e.RowIndex].Cells["YeuCauChiTiet_Id"].Value.ToString()), int.Parse(this.dataGridViewExtYeuCau.Rows[e.RowIndex].Cells["PhongBan_Id"].Value.ToString())))
						{
							MessageBox.Show("Cập nhật phòng thực hiện cho số phiếu yêu cầu " + this.dataGridViewExtYeuCau.Rows[0].Cells["SoPhieuYeuCau"].Value.ToString() + " thành công.");
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(string.Concat(new object[]
						{
							ex.Message,
							"\n",
							ex.Source,
							"\n",
							ex.InnerException
						}));
					}
					this.dataGridViewExtYeuCau.Invalidate();
				}
				this.buttonDSChuaDichVu.PerformClick();
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000916C File Offset: 0x0000816C
		private bool CapNhatPhongThucHien(int iYeuCauChiTiet, int iPhongBan)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("UPDATE `clsyeucauchitiet` SET  PhongBan_Id = {1} WHERE YeuCauChiTiet_Id = {0}", iYeuCauChiTiet, iPhongBan);
			int num = EClinicDB.ExecuteNonQuery(stringBuilder.ToString());
			return num != 0 && num != -1;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000091BE File Offset: 0x000081BE
		private void textBoxDonGia_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000091CC File Offset: 0x000081CC
		private void textBoxMienGiam_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00009204 File Offset: 0x00008204
		private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			MessageBox.Show(__.T("Bạn đã xóa dịch vụ " + this.dataGridViewDichVu.Rows[e.Row.Index].Cells[0].Value.ToString()), "Xác nhận", MessageBoxButtons.OK);
			this.CapNhatTrangThaiHoaDon();
			this.CapNhatTrangThaiNutLenh();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000926B File Offset: 0x0000826B
		private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
		{
			this.CapNhatTrangThaiHoaDon();
			this.CapNhatTrangThaiNutLenh();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000927C File Offset: 0x0000827C
		private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
		{
			this.CapNhatTrangThaiHoaDon();
			this.CapNhatTrangThaiNutLenh();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000928D File Offset: 0x0000828D
		private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.CapNhatTrangThaiHoaDon();
			this.CapNhatTrangThaiNutLenh();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000092A0 File Offset: 0x000082A0
		private void textBoxDVCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			string text = this.textBoxDVCode.Text;
			if (e.KeyChar == '\r' && text != string.Empty)
			{
				string sCommand = "select DichVu_Id, NhomDichVu_Id from dm_dichvu where MaDichVu = '" + text + "'";
				DataSet dataSet = EClinicDB.FillDataset(sCommand);
				DataRow dataRow = dataSet.Tables[0].Rows[0];
				this.comboBoxDichVuTen.SelectedValue = (int)dataRow["DichVu_Id"];
				this.comboBoxDichVuNhom.SelectedValue = (int)dataRow["NhomDichVu_Id"];
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00009350 File Offset: 0x00008350
		private void textBoxMaYT_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				string commandText = string.Concat(new string[]
				{
					"select BenhNhan_Id from dm_benhnhan where MaYTe = '",
					EClinicConfig.PreMaYTe,
					".",
					this.textBoxMaYT.Text,
					"'"
				});
				object intInput = EClinicDB.ExecuteScalar(commandText, CommandType.Text);
				EClinicConfig.BenhNhanID = int.Parse(StringExt.StringZero(intInput));
				if (this.LoadDuLieuBenhNhan())
				{
					this.buttonCapNhatBN.Enabled = true;
					this.buttonInTheBN.Enabled = true;
				}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000093F4 File Offset: 0x000083F4
		private void buttonThemDichVu_Click(object sender, EventArgs e)
		{
			string[] values = new string[]
			{
				this.comboBoxDichVuTen.Text,
				this.comboBoxDVPhongBan.SelectedValue.ToString(),
				this.comboBoxDVPhongBan.Text,
				this.textBoxDonGia.Text.ToString(),
				this.textBoxMienGiam.Text,
				this.textBoxLyDoMienGiam.Text,
				this.dateTimePickerTienNhan.Value.ToString(),
				this.comboBoxDichVuTen.SelectedValue.ToString(),
				EClinicConfig.BenhNhanID.ToString(),
				string.Empty
			};
			this.dataGridViewDichVu.Rows.Add(values);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000094C4 File Offset: 0x000084C4
		private void ReceptionAdmin_Load(object sender, EventArgs e)
		{
			this.ds.Relations.Clear();
			this.LoadDiaPhuong();
			this.LoadQuocGia();
			this.LoadNgheNghiep();
			this.LoadDoiTuong();
			this.LoadGioiTinh();
			this.LoadLyDoTiepNhan();
			this.LoadHinhThucTiepNhan();
			this.LoadColumnDataGridView();
			this.CapNhatCacControlQuanLyThongTinBN(false);
			this.CapNhatTrangThaiNutLenh();
			this.dateTimePickerTienNhan.Value = DateTime.Now;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000953C File Offset: 0x0000853C
		private void CapNhatCacControlQuanLyThongTinBN(bool bStatus)
		{
			this.textBoxDiaChi.ReadOnly = bStatus;
			this.textBoxDienThoai.ReadOnly = bStatus;
			this.textBoxHoTenBN.ReadOnly = bStatus;
			this.textBoxNamSinh.ReadOnly = bStatus;
			this.textBoxTuoi.ReadOnly = bStatus;
			this.comboBoxGioiTinh.Enabled = !bStatus;
			this.comboBoxNgheNghiep.Enabled = !bStatus;
			this.comboBoxQuanHuyen.Enabled = !bStatus;
			this.comboBoxTinhThanh.Enabled = !bStatus;
			this.comboBoxQuocTich.Enabled = !bStatus;
			this.buttonCapNhatBN.Enabled = !bStatus;
			if (bStatus)
			{
				this.comboBoxGioi.DropDownStyle = ComboBoxStyle.Simple;
				this.comboBoxNgheNghiep.DropDownStyle = ComboBoxStyle.Simple;
				this.comboBoxQuanHuyen.DropDownStyle = ComboBoxStyle.Simple;
				this.comboBoxTinhThanh.DropDownStyle = ComboBoxStyle.Simple;
				this.comboBoxQuocTich.DropDownStyle = ComboBoxStyle.Simple;
				this.comboBoxGioiTinh.DropDownStyle = ComboBoxStyle.Simple;
			}
			else
			{
				this.comboBoxGioi.DropDownStyle = ComboBoxStyle.DropDownList;
				this.comboBoxNgheNghiep.DropDownStyle = ComboBoxStyle.DropDownList;
				this.comboBoxQuanHuyen.DropDownStyle = ComboBoxStyle.DropDownList;
				this.comboBoxTinhThanh.DropDownStyle = ComboBoxStyle.DropDownList;
				this.comboBoxQuocTich.DropDownStyle = ComboBoxStyle.DropDownList;
				this.comboBoxGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00009698 File Offset: 0x00008698
		private void LoadDiaPhuong()
		{
			EClinicDB.FillDataset(ref this.ds, "select * from dm_donvihanhchinh where (CapDonVi = '2' and `TamNgung` = 0)", "Tinh_Thanh");
			EClinicDB.FillDataset(ref this.ds, "select * from dm_donvihanhchinh where (CapDonVi = '3' and `TamNgung` = 0)", "Quan_Huyen");
			this.ds.Relations.Add("TinhThanh_QuanHuyen", this.ds.Tables["Tinh_Thanh"].Columns["DonViHanhChinh_Id"], this.ds.Tables["Quan_Huyen"].Columns["CapTren_Id"]);
			this.comboBoxTinhThanh.DataSource = this.ds;
			this.comboBoxTinhThanh.DisplayMember = "Tinh_Thanh.TenDonVi";
			this.comboBoxTinhThanh.ValueMember = "Tinh_Thanh.MaDonVi";
			this.comboBoxQuanHuyen.DataSource = this.ds;
			this.comboBoxQuanHuyen.DisplayMember = "Tinh_Thanh.TinhThanh_QuanHuyen.TenDonVi";
			this.comboBoxQuanHuyen.ValueMember = "Tinh_Thanh.TinhThanh_QuanHuyen.MaDonVi";
			this.comboBoxTinhThanh.SelectedValue = EClinicConfig.GetProvinceCode();
			this.comboBoxQuanHuyen.SelectedValue = EClinicConfig.GetDistrictCode();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000097BC File Offset: 0x000087BC
		private void LoadQuocGia()
		{
			EClinicDB.FillDataset(ref this.ds, "select * from dm_tudien where ((Dictionary_Type_Code = 'QuocGia') and (Enable = 1)) order by Dictionary_Code asc", "Quoc_Tich");
			this.comboBoxQuocTich.DataSource = this.ds.Tables["Quoc_Tich"];
			this.comboBoxQuocTich.DisplayMember = "Dictionary_Name";
			this.comboBoxQuocTich.ValueMember = "Dictionary_Id";
			this.comboBoxQuocTich.SelectedValue = EClinicConfig.CountryID;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000983C File Offset: 0x0000883C
		private void LoadGioiTinh()
		{
			EClinicDB.FillDataset(ref this.ds, "select * from dm_tudien where ((Dictionary_Type_Code = 'GioiTinh') and (Enable = 1)) order by Dictionary_Code asc", "GioiTinh");
			this.comboBoxGioiTinh.DataSource = this.ds.Tables["GioiTinh"];
			this.comboBoxGioiTinh.DisplayMember = "Dictionary_Name";
			this.comboBoxGioiTinh.ValueMember = "Dictionary_Id";
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000098A4 File Offset: 0x000088A4
		private void LoadNgheNghiep()
		{
			EClinicDB.FillDataset(ref this.ds, "select * from dm_tudien where ((Dictionary_Type_Code = 'NgheNghiep') and (Enable = 1)) order by Dictionary_Code asc", "Nghe_Nghiep");
			this.comboBoxNgheNghiep.DataSource = this.ds.Tables["Nghe_Nghiep"];
			this.comboBoxNgheNghiep.DisplayMember = "Dictionary_Name";
			this.comboBoxNgheNghiep.ValueMember = "Dictionary_Id";
			this.comboBoxNgheNghiep.DropDownWidth = 300;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000991C File Offset: 0x0000891C
		private void LoadDoiTuong()
		{
			EClinicDB.FillDataset(ref this.ds, "select * from dm_tudien where ((Dictionary_Type_Code = 'NhomDoiTuong') and (Enable = 1)) order by Dictionary_Code asc", "Doi_Tuong");
			this.comboBoxDoiTuong.DataSource = this.ds.Tables["Doi_Tuong"];
			this.comboBoxDoiTuong.DisplayMember = "Dictionary_Name";
			this.comboBoxDoiTuong.ValueMember = "Dictionary_Id";
			this.comboBoxDoiTuong.SelectedIndex = 1;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00009990 File Offset: 0x00008990
		private void LoadLyDoTiepNhan()
		{
			EClinicDB.FillDataset(ref this.ds, "select * from dm_tudien where ((Dictionary_Type_Code = 'LyDoTiepNhan') and (Enable = 1)) order by Dictionary_Code asc", "LyDoTiepNhan");
			this.comboBoxLyDoVV.DataSource = this.ds.Tables["LyDoTiepNhan"];
			this.comboBoxLyDoVV.DisplayMember = "Dictionary_Name";
			this.comboBoxLyDoVV.ValueMember = "Dictionary_Id";
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000099F8 File Offset: 0x000089F8
		private void LoadHinhThucTiepNhan()
		{
			EClinicDB.FillDataset(ref this.ds, "select * from dm_tudien where ((Dictionary_Type_Code = 'HinhThucTiepNhan') and (Enable = 1)) order by Dictionary_Code asc", "HinhThucTiepNhan");
			this.comboBoxHinhThuc.DataSource = this.ds.Tables["HinhThucTiepNhan"];
			this.comboBoxHinhThuc.DisplayMember = "Dictionary_Name";
			this.comboBoxHinhThuc.ValueMember = "Dictionary_Id";
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00009A60 File Offset: 0x00008A60
		private void LoadColumnDataGridView()
		{
			ParamCollection paramCollection = new ParamCollection();
			paramCollection.Add("DataGroup", DbDataType.VarChar, 50, "DanhMucDichVu");
			paramCollection.Add("FiltData", DbDataType.VarChar, 11, string.Empty);
			EClinicDB.FillDataset(ref this.ds, "sp_Sys_GetListDataGridView", CommandType.StoredProcedure, paramCollection, "DMDichVu");
			paramCollection.Clear();
			paramCollection.Add("DataGroup", DbDataType.VarChar, 50, "DanhMucNhomDichVu");
			paramCollection.Add("FiltData", DbDataType.VarChar, 11, string.Empty);
			EClinicDB.FillDataset(ref this.ds, "sp_Sys_GetListDataGridView", CommandType.StoredProcedure, paramCollection, "DMNhomDichVu");
			paramCollection.Clear();
			paramCollection.Add("DataGroup", DbDataType.VarChar, 50, "PhongThucHienDichVu");
			paramCollection.Add("FiltData", DbDataType.VarChar, 11, string.Empty);
			EClinicDB.FillDataset(ref this.ds, "sp_Sys_GetListDataGridView", CommandType.StoredProcedure, paramCollection, "DMPhongBan");
			paramCollection.Clear();
			paramCollection.Add("DataGroup", DbDataType.VarChar, 50, "PhongBan_DichVu");
			paramCollection.Add("FiltData", DbDataType.VarChar, 11, string.Empty);
			EClinicDB.FillDataset(ref this.ds, "sp_Sys_GetListDataGridView", CommandType.StoredProcedure, paramCollection, "PhongBan_DichVu");
			paramCollection.Clear();
			paramCollection.Add("DataGroup", DbDataType.VarChar, 50, "GiaDichVu");
			paramCollection.Add("FiltData", DbDataType.VarChar, 11, string.Empty);
			EClinicDB.FillDataset(ref this.ds, "sp_Sys_GetListDataGridView", CommandType.StoredProcedure, paramCollection, "GiaDichVu");
			this.ds.Relations.Add("NhomDV_DichVu", this.ds.Tables["DMNhomDichVu"].Columns["NhomDichVu_Id"], this.ds.Tables["DMDichVu"].Columns["NhomDichVu_Id"], false);
			this.ds.Relations.Add("PBan_DichVu", this.ds.Tables["DMDichVu"].Columns["DichVu_Id"], this.ds.Tables["DMPhongBan"].Columns["DichVu_Id"], false);
			this.ds.Relations.Add("DichVu_DonGia", this.ds.Tables["DMDichVu"].Columns["DichVu_Id"], this.ds.Tables["GiaDichVu"].Columns["DichVu_Id"], false);
			this.comboBoxDichVuNhom.DataSource = this.ds.Tables["DMNhomDichVu"];
			this.comboBoxDichVuNhom.DisplayMember = "TenNhomDichVu";
			this.comboBoxDichVuNhom.ValueMember = "NhomDichVu_Id";
			this.comboBoxDichVuTen.DataSource = this.ds.Tables["DMNhomDichVu"];
			this.comboBoxDichVuTen.DisplayMember = "NhomDV_DichVu.TenDichVu";
			this.comboBoxDichVuTen.ValueMember = "NhomDV_DichVu.DichVu_Id";
			this.comboBoxDVPhongBan.DataSource = this.ds.Tables["DMNhomDichVu"];
			this.comboBoxDVPhongBan.DisplayMember = "NhomDV_DichVu.PBan_DichVu.TenPhongBan";
			this.comboBoxDVPhongBan.ValueMember = "NhomDV_DichVu.PBan_DichVu.PhongBan_Id";
			Binding binding = new Binding("Text", this.ds.Tables["DMNhomDichVu"], "NhomDV_DichVu.DichVu_DonGia.DonGia");
			this.textBoxDonGia.DataBindings.Add(binding);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00009DF8 File Offset: 0x00008DF8
		private void textBoxTuoi_TextChanged(object sender, EventArgs e)
		{
			int num = SKCD_Date.YearOfWorking() - (int)short.Parse(StringExt.StringZero(this.textBoxTuoi.Text));
			if (this.textBoxTuoi.Focused)
			{
				this.textBoxNamSinh.Text = num.ToString();
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00009E48 File Offset: 0x00008E48
		private void textBoxNamSinh_TextChanged(object sender, EventArgs e)
		{
			int num = SKCD_Date.YearOfWorking() - (int)short.Parse(StringExt.StringZero(this.textBoxNamSinh.Text));
			if (this.textBoxNamSinh.Focused)
			{
				this.textBoxTuoi.Text = num.ToString();
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00009E98 File Offset: 0x00008E98
		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Search search = new Search();
			ParamCollection paramCollection = new ParamCollection();
			paramCollection.Add("DataGroup", DbDataType.VarChar, 50, "ThongTinBenhNhan");
			paramCollection.Add("FiltData", DbDataType.VarChar, 11, string.Empty);
			DataSet dataSoucre = EClinicDB.FillDatasetDecrypt("sp_Sys_GetListDataGridView", paramCollection, "dm_benhnhan");
			search.DataSoucre = dataSoucre;
			search.ColumnMember = "MaYTe";
			search.TitleTextBox = "DANH SÁCH BỆNH NHÂN";
			search.ShowDialog();
			if (search.ValueMember >= 0)
			{
				this.textBoxMaYT.Text = search.SelectMemberValue.Substring(6).ToString();
				this.textBoxPreMaYT.Text = search.SelectMemberValue.Substring(0, 5).ToString();
				EClinicConfig.BenhNhanID = search.ValueMember;
				if (this.LoadDuLieuBenhNhan())
				{
					this.buttonCapNhatBN.Enabled = true;
					this.buttonInTheBN.Enabled = true;
				}
			}
			this.CapNhatTrangThaiNutLenh();
			this.CapNhatCacControlQuanLyThongTinBN(false);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00009FA4 File Offset: 0x00008FA4
		private bool LoadDuLieuBenhNhan()
		{
			ParamCollection paramCollection = new ParamCollection();
			paramCollection.Add("DataGroup", DbDataType.VarChar, 50, "DanhMucBenhNhan");
			paramCollection.Add("FiltData", DbDataType.Int32, 11, EClinicConfig.BenhNhanID);
			DataSet dataSet = EClinicDB.FillDatasetDecrypt("sp_Sys_GetListDataGridView", paramCollection, "dm_benhnhan");
			bool result;
			if (dataSet.Tables[0].Rows.Count > 0)
			{
				DataRow dataRow = dataSet.Tables[0].Rows[0];
				this.textBoxHoTenBN.Text = StringExt.StringNull(dataRow["Ho_Ten"]);
				this.comboBoxGioiTinh.Text = StringExt.StringNull(dataRow["Gioi_Tinh"]);
				this.textBoxNamSinh.Text = StringExt.StringNull(dataRow["Nam_Sinh"]);
				this.textBoxDiaChi.Text = StringExt.StringNull(dataRow["Dia_Chi"]);
				this.comboBoxTinhThanh.SelectedValue = StringExt.StringZero(dataRow["Tinh_Thanh_Id"]);
				this.comboBoxQuanHuyen.SelectedValue = StringExt.StringZero(dataRow["Quan_Huyen_Id"]);
				this.comboBoxDoiTuong.SelectedValue = StringExt.StringZero(dataRow["DoiTuong_Id"]);
				this.comboBoxNgheNghiep.SelectedValue = StringExt.StringZero(dataRow["Nghe_Nghiep_Id"]);
				this.textBoxDienThoai.Text = StringExt.StringNull(dataRow["Dien_Thoai"]);
				this.comboBoxQuocTich.SelectedValue = StringExt.StringZero(dataRow["QuocTich_Id"]);
				this.comboBoxNguoiGioiThieu.SelectedValue = StringExt.StringZero(dataRow["NguoiGioiThieu_Id"]);
				this.textBoxEmail.Text = StringExt.StringNull(dataRow["Email"]);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000A18F File Offset: 0x0000918F
		private void buttonEditBN_Click(object sender, EventArgs e)
		{
			this.CapNhatThongTinBenhNhan();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000A19C File Offset: 0x0000919C
		private void CapNhatTrangThaiNutLenh()
		{
			if (this.textBoxDonGia.Text == string.Empty || this.comboBoxDichVuTen.SelectedValue == null || this.textBoxMaYT.Text == string.Empty)
			{
				this.buttonThemDichVu.Enabled = false;
			}
			else
			{
				this.buttonThemDichVu.Enabled = true;
			}
			if (this.dataGridViewDichVu.RowCount > 0)
			{
				this.buttonLuuDichVu.Enabled = true;
			}
			else
			{
				this.buttonLuuDichVu.Enabled = false;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000A244 File Offset: 0x00009244
		private void CapNhatTextBoxMaDV()
		{
			string commandText = "select MaDichVu from dm_dichvu where dichvu_id = '" + ((this.comboBoxDichVuTen.SelectedValue != null) ? this.comboBoxDichVuTen.SelectedValue.ToString() : "") + "'";
			object obj = EClinicDB.ExecuteScalar(commandText, CommandType.Text);
			if (!this.textBoxDVCode.Focused)
			{
				if (obj != null)
				{
					this.textBoxDVCode.Text = obj.ToString();
				}
				else
				{
					this.textBoxDVCode.Text = "";
				}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000A2D0 File Offset: 0x000092D0
		private void comboBoxDichVuNhom_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.CapNhatTextBoxMaDV();
			this.CapNhatTrangThaiNutLenh();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000A2E1 File Offset: 0x000092E1
		private void comboBoxDichVuTen_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.CapNhatTextBoxMaDV();
			this.CapNhatTrangThaiNutLenh();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000A2F2 File Offset: 0x000092F2
		private void comboBoxDVPhongBan_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.CapNhatTrangThaiNutLenh();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000A2FC File Offset: 0x000092FC
		private void CapNhatTrangThaiHoaDon()
		{
			this.intTongDV = 0;
			this.intMienGiam = 0;
			this.intBNPhaiTra = 0;
			NumberFormatInfo numberFormat = new CultureInfo("vi-VN", false).NumberFormat;
			numberFormat.NumberGroupSeparator = ".";
			numberFormat.NumberDecimalSeparator = ",";
			numberFormat.NumberDecimalDigits = 0;
			int count = this.dataGridViewDichVu.Rows.Count;
			if (count > 0)
			{
				for (int i = 0; i < count; i++)
				{
					this.intTongDV += int.Parse(StringExt.StringZero(this.dataGridViewDichVu.Rows[i].Cells[3].Value), NumberStyles.Float);
					this.intMienGiam += int.Parse(StringExt.StringZero(this.dataGridViewDichVu.Rows[i].Cells[4].Value), NumberStyles.Float);
				}
			}
			this.labelTongDV.Text = this.intTongDV.ToString("N", numberFormat) + " ĐVN";
			this.labelMienGiam.Text = this.intMienGiam.ToString("N", numberFormat) + " ĐVN";
			this.intBNPhaiTra = this.intTongDV - this.intMienGiam;
			this.labelBNPhaiTra.Text = this.intBNPhaiTra.ToString("N", numberFormat) + " ĐVN";
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000A48C File Offset: 0x0000948C
		private void buttonInMaVach_Click(object sender, EventArgs e)
		{
			ParamCollection paramCollection = new ParamCollection();
			paramCollection.Add("param1", DbDataType.Int32, 11, EClinicConfig.BenhNhanID);
			DataSet dataSet = EClinicDB.FillDatasetDecrypt("sp_TheKhamBenh", paramCollection, "dm_benhnhan");
			dataSet.Tables[0].TableName = "TheKhamBenh";
			new ReportCommon("Reports\\TheKhamBenh.rpt", dataSet)
			{
				ReportName = string.Empty
			}.Show();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000A501 File Offset: 0x00009501
		private void textBoxMaYT_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000A504 File Offset: 0x00009504
		private void CapNhatThongTinBenhNhan()
		{
			string text = string.Empty;
			StringExt stringExt = new StringExt();
			string[] array = stringExt.StringSplite(this.textBoxHoTenBN.Text.Trim());
			if (this.textBoxNamSinh.Text != string.Empty)
			{
				text = Convert.ToInt32(this.textBoxNamSinh.Text) + "-01-01";
				string sSQL = string.Concat(new string[]
				{
					"update DM_BENHNHAN set   Ho_Ten=(?0),   Ho=(?1),   Ten=(?2),   Gioi_Tinh='",
					this.comboBoxGioiTinh.Text,
					"',   Email='",
					this.textBoxEmail.Text,
					"',   Ngay_Sinh=(?3),   Nam_Sinh=(?4),   Dia_Chi=(?5),   QuocTich_Id ='",
					StringExt.StringNull(this.comboBoxQuocTich.SelectedValue),
					"',   Tinh_Thanh_Id ='",
					StringExt.StringNull(this.comboBoxTinhThanh.SelectedValue),
					"',   Quan_Huyen_Id ='",
					StringExt.StringNull(this.comboBoxQuanHuyen.SelectedValue),
					"',   Nghe_Nghiep_Id ='",
					StringExt.StringNull(this.comboBoxNgheNghiep.SelectedValue),
					"',   DoiTuong_Id ='",
					StringExt.StringNull(this.comboBoxDoiTuong.SelectedValue),
					"',   Dien_Thoai=(?6)  where BenhNhan_Id='",
					EClinicConfig.BenhNhanID.ToString(),
					"'"
				});
				string[] asFieldNames = new string[]
				{
					"Ho_Ten",
					"Ho",
					"Ten",
					"Ngay_Sinh",
					"Nam_Sinh",
					"Dia_Chi",
					"Dien_Thoai"
				};
				string[] asFieldValues = new string[]
				{
					this.textBoxHoTenBN.Text,
					array[0],
					array[1],
					text,
					this.textBoxNamSinh.Text,
					this.textBoxDiaChi.Text,
					this.textBoxDienThoai.Text
				};
				try
				{
					if (EClinicDB.ExecuteNonQuery(sSQL, asFieldNames, asFieldValues) > 0)
					{
						MessageBox.Show(__.T("Cập nhật thông tin bệnh nhân thành công."));
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Concat(new object[]
					{
						ex.Message,
						"\n",
						ex.Source,
						"\n",
						ex.InnerException
					}));
				}
			}
			else
			{
				MessageBox.Show(__.T("Cần nhập tuổi"));
				this.textBoxNamSinh.Focus();
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000A7C8 File Offset: 0x000097C8
		private void buttonLuuDichVu_Click(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			if (this.dataGridViewDichVu.Rows.Count > 0)
			{
				foreach (object obj in ((IEnumerable)this.dataGridViewDichVu.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					int num = int.Parse(dataGridViewRow.Cells["DichVu_Id"].Value.ToString());
					int intBenhNhan = int.Parse(dataGridViewRow.Cells["BenhNhan_Id"].Value.ToString());
					int intPhongThucHien = int.Parse(StringExt.StringZero(dataGridViewRow.Cells["PhongThucHien_Id"].Value));
					int iDonGia = int.Parse(StringExt.StringZero(dataGridViewRow.Cells["DonGia"].Value));
					int iMienGiam = int.Parse(StringExt.StringZero(dataGridViewRow.Cells["MienGiam"].Value));
					string item = this.MaNhomDichVu(num);
					if (!list.Contains(item))
					{
						list.Add(item);
					}
					list2.Add(this.TaoMoiYeuCauTuDichVu(intBenhNhan, num, intPhongThucHien, iDonGia, iMienGiam, num));
				}
				foreach (string value in list)
				{
				}
				StringBuilder stringBuilder = new StringBuilder("Đăng ký thành công các yêu cầu ");
				foreach (string value in list2)
				{
					stringBuilder.Append(value);
					stringBuilder.Append(" + ");
				}
				stringBuilder.Remove(stringBuilder.Length - 3, 3);
				this.buttonDSChuaDichVu.PerformClick();
			}
			if (!this.HoaDonUpdate())
			{
				int num2 = this.HoaDonInsert();
				if (num2 == -1)
				{
					MessageBox.Show(__.T("Có lỗi khi lưu yêu cầu dịch vụ"));
					return;
				}
				DialogResult dialogResult = MessageBox.Show("Bạn có muốn In hóa đơn?", "Lưu ý", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					this.InHoaDonDichVu(num2);
				}
				this.dataGridViewDichVu.Rows.Clear();
				this.TaiLapCacGiaTriMacDinhChoCacControl();
			}
			MessageBox.Show(__.T("Lưu yêu cầu dịch vụ thành công"));
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000AAB8 File Offset: 0x00009AB8
		private void InHoaDonDichVu(int intHoaDonID)
		{
			ParamCollection paramCollection = new ParamCollection();
			paramCollection.Add("param1", DbDataType.Int32, 11, intHoaDonID);
			DataSet dataSet = EClinicDB.FillDatasetDecrypt("sp_InHoaDon", paramCollection, "dm_benhnhan");
			dataSet.Tables[0].TableName = "PhieuYeuCau";
			new ReportCommon("Reports\\PhieuYeuCau.rpt", dataSet)
			{
				ReportName = string.Empty
			}.Show();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000AB2C File Offset: 0x00009B2C
		private string TaoMoiYeuCauTuDichVu(int intBenhNhan, int intDichVu_Id, int intPhongThucHien, int iDonGia, int iMienGiam, int iDichVu)
		{
			string text = (string)EClinicDB.ExecuteScalar("sp_TaoMoiPhieuYeuCau", CommandType.StoredProcedure);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("INSERT INTO `clsyeucau`(SoPhieuYeuCau, NgayYeuCau, ThoiGianYeuCau, NoiThucHien_Id, BenhNhan_Id, HuyYeuCau, TrangThai, DichVu_Id) ", new object[0]);
			stringBuilder.AppendFormat("VALUES ( '{0}', now(), now(), {1}, {2}, 0, 'ChuaThucHien', {3})", new object[]
			{
				text,
				intPhongThucHien,
				intBenhNhan,
				iDichVu
			});
			try
			{
				EClinicDB.ExecuteNonQuery(stringBuilder.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Concat(new object[]
				{
					ex.Message,
					"\n",
					ex.Source,
					"\n",
					ex.InnerException
				}));
				return string.Empty;
			}
			int num = int.Parse(EClinicDB.ExecuteScalar("SELECT MAX(yc.CLSYeuCau_Id) AS FIELD_1 FROM clsyeucau yc").ToString());
			stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("INSERT INTO `clsyeucauchitiet`(CLSYeuCau_Id, DichVu_Id, PhongBan_Id, DonGia, MienGiam, DaThuTien, TrangThai) ", new object[0]);
			stringBuilder.AppendFormat("VALUES( {0}, {1}, {2}, {3}, {4}, 1, 'ChuaThucHien')", new object[]
			{
				num,
				intDichVu_Id,
				intPhongThucHien,
				iDonGia,
				this.intMienGiam
			});
			try
			{
				EClinicDB.ExecuteNonQuery(stringBuilder.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Concat(new object[]
				{
					ex.Message,
					"\n",
					ex.Source,
					"\n",
					ex.InnerException
				}));
				return string.Empty;
			}
			return text;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000AD04 File Offset: 0x00009D04
		private bool DichVuTraLoiRieng(int DichVu_Id)
		{
			ParamCollection paramCollection = new ParamCollection();
			paramCollection.Add("param1", DbDataType.Int32, 11, DichVu_Id, ParameterDirection.Input);
			int num = int.Parse(EClinicDB.ExecuteScalar("sp_DichVuTraLoiRieng", CommandType.StoredProcedure, paramCollection).ToString());
			return num == 1;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000AD54 File Offset: 0x00009D54
		private string MaNhomDichVu(int DichVu_Id)
		{
			return (string)EClinicDB.ExecuteScalar("SELECT `dm_dichvu`.`MaDichVu_Seg01` FROM `dm_dichvu` WHERE `dm_dichvu`.`DichVu_Id` = '" + DichVu_Id.ToString() + "'");
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000AD88 File Offset: 0x00009D88
		private int HoaDonInsert()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("INSERT INTO `hoadon`(SoHoaDon,LoaiHoaDon,NgayHoaDon,BenhNhan_Id,GiaTriHoaDon,GiaTriThucThu,DaThanhToan,NgayTao, NguoiThuTien_Id) VALUES ('{0}', 'T', now(), {1}, {2}, {3}, 0, now(), {4})", new object[]
			{
				this.TaoMoiSoHoaDon("T"),
				EClinicConfig.BenhNhanID,
				this.intTongDV,
				this.intBNPhaiTra,
				EClinicConfig.NhanVienLoginID
			});
			int num = EClinicDB.ExecuteNonQuery(stringBuilder.ToString());
			int result;
			if (num == 0 || num == -1)
			{
				result = -1;
			}
			else
			{
				int num2 = (int)EClinicDB.ExecuteScalar("Select max(Hoadon_Id) from HoaDon", CommandType.Text);
				int count = this.dataGridViewDichVu.Rows.Count;
				if (count > 0)
				{
					for (int i = 0; i < count; i++)
					{
						if (!this.DichVuInsert(num2, this.dataGridViewDichVu.Rows[i].Cells["DichVu_Id"].Value.ToString(), StringExt.StringNull(this.dataGridViewDichVu.Rows[i].Cells["PhongThucHien_Id"].Value), StringExt.StringZero(this.dataGridViewDichVu.Rows[i].Cells["DonGia"].Value), StringExt.StringZero(this.dataGridViewDichVu.Rows[i].Cells["MienGiam"].Value), StringExt.StringNull(this.dataGridViewDichVu.Rows[i].Cells["LyDoMienGiam"].Value), this.dataGridViewDichVu.Rows[i].Cells["BenhNhan_Id"].Value.ToString()))
						{
							break;
						}
					}
				}
				result = num2;
			}
			return result;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000AF8C File Offset: 0x00009F8C
		private bool DichVuInsert(int intMaxHoaDonID, string sDichVuId, string sPhongBanId, string sDonGia, string sMienGiam, string sLyDoMienGiam, string sBenhNhanId)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("INSERT HoaDonChiTiet SET HoaDon_Id = '{0}', DichVu_Id = '{1}', PhongBan_Id = '{2}', GiaTienThucThu = '{3}', MienGiam = '{4}', LydoMienGiam = '{5}',BenhNhan_Id = '{6}'", new object[]
			{
				intMaxHoaDonID,
				sDichVuId,
				sPhongBanId,
				sDonGia,
				sMienGiam,
				sLyDoMienGiam,
				sBenhNhanId
			});
			int num = EClinicDB.ExecuteNonQuery(stringBuilder.ToString());
			return num != 0 && num != -1;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000B004 File Offset: 0x0000A004
		private bool HoaDonUpdate()
		{
			StringBuilder stringBuilder = new StringBuilder();
			return false;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000B020 File Offset: 0x0000A020
		private string TaoMoiSoHoaDon(string stringLoaiHoaDon)
		{
			ParamCollection paramCollection = new ParamCollection();
			paramCollection.Add("param1", DbDataType.VarChar, 2, stringLoaiHoaDon, ParameterDirection.Input);
			paramCollection.Add("param2", DbDataType.VarChar, 20, string.Empty, ParameterDirection.Output);
			EClinicDB.ExecuteNonQuery("sp_TaoMoiSoHoaDon", CommandType.StoredProcedure, paramCollection);
			return paramCollection[1].Value.ToString();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000B07F File Offset: 0x0000A07F
		private void buttonDVDaThucHien_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000B084 File Offset: 0x0000A084
		private void buttonDSChuaDichVu_Click(object sender, EventArgs e)
		{
			string customHeaderText = "YeuCauChiTiet_Id|YeuCauChiTiet_Id|0; SoPhieuYeuCau|Số phiếu yêu cầu|80; Ho_Ten|Bệnh nhân|120; TenDichVu|Dịch vụ|100; PhongBan_Id|Phòng thực hiện|80";
			ParamCollection paramCollection = new ParamCollection();
			paramCollection.Add("DataGroup", DbDataType.VarString, 50, "YeuCauDangCho");
			paramCollection.Add("FiltData", DbDataType.VarString, 250, string.Empty);
			DataSet dataSet = EClinicDB.FillDatasetDecrypt("sp_Sys_GetListDataGridView", paramCollection, "dm_benhnhan");
			dataSet.Tables["Table"].TableName = "YeuCauDangCho";
			paramCollection.Clear();
			paramCollection.Add("DataGroup", DbDataType.VarChar, 50, "DanhMucPhongBanTheoDichVu");
			paramCollection.Add("FiltData", DbDataType.VarChar, 11, string.Empty);
			EClinicDB.FillDataset(ref dataSet, "sp_Sys_GetListDataGridView", CommandType.StoredProcedure, paramCollection, "DanhMucPhongBan");
			dataSet.Relations.Clear();
			dataSet.Relations.Add("DanhMucPhongBanTheoDichVu", dataSet.Tables["YeuCauDangCho"].Columns["DichVu_Id"], dataSet.Tables["DanhMucPhongBan"].Columns["DichVu_Id"], false);
			this.dataGridViewExtYeuCau.DataSource = dataSet;
			this.dataGridViewExtYeuCau.DataMember = dataSet.Tables["YeuCauDangCho"].TableName;
			DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
			dataGridViewComboBoxColumn.DataPropertyName = "PhongBan_Id";
			dataGridViewComboBoxColumn.Name = "PhongBan_Id";
			dataGridViewComboBoxColumn.DropDownWidth = 100;
			dataGridViewComboBoxColumn.Width = 100;
			dataGridViewComboBoxColumn.MaxDropDownItems = 10;
			dataGridViewComboBoxColumn.FlatStyle = FlatStyle.Flat;
			dataGridViewComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
			dataGridViewComboBoxColumn.DataSource = dataSet;
			dataGridViewComboBoxColumn.DisplayMember = "YeuCauDangCho.DanhMucPhongBanTheoDichVu.TenPhongBan";
			dataGridViewComboBoxColumn.ValueMember = "YeuCauDangCho.DanhMucPhongBanTheoDichVu.PhongBan_Id";
			for (int i = 0; i < this.dataGridViewExtYeuCau.Columns.Count; i++)
			{
				if (this.dataGridViewExtYeuCau.Columns[i].Name == "PhongBan_Id")
				{
					this.dataGridViewExtYeuCau.Columns.RemoveAt(i);
					this.dataGridViewExtYeuCau.Columns.Add(dataGridViewComboBoxColumn);
					dataGridViewComboBoxColumn.DisplayIndex = i;
				}
			}
			this.dataGridViewExtYeuCau.HeaderColumnState = DataGridViewExt.CustomHeaderState.HideColumn;
			this.dataGridViewExtYeuCau.CustomHeaderText = customHeaderText;
			this.dataGridViewExtYeuCau.Columns["SoPhieuYeuCau"].ReadOnly = true;
			this.dataGridViewExtYeuCau.Columns["Ho_Ten"].ReadOnly = true;
			this.dataGridViewExtYeuCau.Columns["TenDichVu"].ReadOnly = true;
			this.bPhongBanThayDoi = false;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000B328 File Offset: 0x0000A328
		private void ThietLapGiaTriMacDinhChoCacControl()
		{
			this.textBoxHoTenBN.Text = "";
			this.comboBoxTinhThanh.SelectedValue = StringExt.StringZero(EClinicConfig.GetProvinceCode());
			this.textBoxDiaChi.Text = "";
			this.textBoxDienThoai.Text = "";
			this.comboBoxNgheNghiep.Text = "";
			this.textBoxNamSinh.Text = "";
			this.comboBoxQuanHuyen.SelectedValue = StringExt.StringZero(EClinicConfig.GetDistrictCode());
			this.textBoxEmail.Text = "";
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000B3C8 File Offset: 0x0000A3C8
		private void TaiLapCacGiaTriMacDinhChoCacControl()
		{
			this.buttonTaoMoiBN.Enabled = true;
			this.textBoxHoTenBN.Text = "";
			this.textBoxDiaChi.Text = "";
			this.textBoxDienThoai.Text = "";
			this.comboBoxNgheNghiep.Text = "";
			this.textBoxNamSinh.Text = "";
			this.textBoxEmail.Text = "";
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000B44C File Offset: 0x0000A44C
		private string LayMaYTBNMoiNhat()
		{
			EClinicConfig.BenhNhanID = (int)EClinicDB.ExecuteScalar("select max(BenhNhan_Id) from dm_benhnhan", CommandType.Text);
			string text = (string)EClinicDB.ExecuteScalar("select MaYTe from dm_benhnhan where BenhNhan_Id = " + EClinicConfig.BenhNhanID.ToString(), CommandType.Text);
			return text.Split(new char[]
			{
				'.'
			})[1];
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000B4B0 File Offset: 0x0000A4B0
		private void ThemBNMoi()
		{
			string text = string.Empty;
			StringExt stringExt = new StringExt();
			string[] array = stringExt.StringSplite(this.textBoxHoTenBN.Text);
			string text2 = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
			if (this.textBoxNamSinh.Text != string.Empty)
			{
				text = Convert.ToInt32(this.textBoxNamSinh.Text) + "-01-01";
				string sSQL = string.Concat(new object[]
				{
					"insert into DM_BENHNHAN (BenhNhan_Id, MaYTe, BHYT_Id, Ho_Ten, Ho, Ten, GioiTinh, Gioi_Tinh, Ngay_Sinh, Nam_Sinh,                        Dia_Chi, Dan_Toc_Id, Tinh_Thanh_Id, Quan_Huyen_Id, Xa_Phuong_Id, Nghe_Nghiep_Id,                        Dien_Thoai, Nhom_Mau_Id, Nhom_Mau_Rh_Id, Tien_Su_Di_Ung, Nhan_Vien_Id, DoiTuong_Id,                        QuocTich_Id, Email, NguoiGioiThieu_Id, Ngay_Khoi_Tao)       values (0, 0 , 'BHYT_001', ?0, ?1, ?2, ' ', '",
					this.comboBoxGioiTinh.Text,
					"',              ?3, ?4, ?5, 291, '",
					this.comboBoxTinhThanh.SelectedValue,
					"','",
					this.comboBoxQuanHuyen.SelectedValue,
					"',              '1', '",
					this.comboBoxNgheNghiep.SelectedValue,
					"', ?6, '1', '1', 'Không', ",
					EClinicConfig.Nhan_Vien_Id,
					",",
					this.comboBoxDoiTuong.SelectedValue,
					",",
					this.comboBoxQuocTich.SelectedValue,
					", '",
					this.textBoxEmail.Text,
					"', 0, '",
					text2,
					"')"
				});
				string[] asFieldNames = new string[]
				{
					"Ho_Ten",
					"Ho",
					"Ten",
					"Ngay_Sinh",
					"Nam_Sinh",
					"Dia_Chi",
					"Dien_Thoai"
				};
				string[] asFieldValues = new string[]
				{
					this.textBoxHoTenBN.Text,
					array[0],
					array[1],
					text,
					this.textBoxNamSinh.Text,
					this.textBoxDiaChi.Text,
					this.textBoxDienThoai.Text
				};
				try
				{
					if (EClinicDB.ExecuteNonQuery(sSQL, asFieldNames, asFieldValues) > 0)
					{
						this.textBoxMaYT.ReadOnly = false;
						this.textBoxMaYT.Text = this.LayMaYTBNMoiNhat();
						MessageBox.Show(__.T("Thêm bệnh nhân mới thành công."));
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Concat(new object[]
					{
						ex.Message,
						"\n",
						ex.Source,
						"\n",
						ex.InnerException
					}));
				}
			}
			else
			{
				MessageBox.Show(__.T("Cần nhập tuổi"));
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000B78C File Offset: 0x0000A78C
		private void buttonTaoMoiBN_Click(object sender, EventArgs e)
		{
			if (this.buttonTaoMoiBN.Tag == "New")
			{
				this.textBoxMaYT.ReadOnly = true;
				this.textBoxDiaChi.Text = "";
				this.textBoxDienThoai.Text = "";
				this.textBoxHoTenBN.Text = "";
				this.textBoxMaYT.Text = "";
				this.buttonTaoMoiBN.Tag = "Add";
				this.buttonTaoMoiBN.Text = "&Thêm mới";
			}
			else
			{
				if (this.textBoxHoTenBN.Text != string.Empty)
				{
					this.ThemBNMoi();
				}
				this.textBoxMaYT.ReadOnly = false;
				this.buttonTaoMoiBN.Tag = "New";
				this.buttonTaoMoiBN.Text = "&Tạo mới";
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000B880 File Offset: 0x0000A880
		private void textBoxHoTenBN_Leave(object sender, EventArgs e)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000B884 File Offset: 0x0000A884
		private void buttonDoanhThu_Click(object sender, EventArgs e)
		{
			ThongKeThuNgan thongKeThuNgan = new ThongKeThuNgan();
			thongKeThuNgan.ShowDialog();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000B89F File Offset: 0x0000A89F
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x040000A5 RID: 165
		private DataSet ds = new DataSet();

		// Token: 0x040000A6 RID: 166
		private int intTongDV = 0;

		// Token: 0x040000A7 RID: 167
		private int intMienGiam = 0;

		// Token: 0x040000A8 RID: 168
		private int intBNPhaiTra = 0;

		// Token: 0x040000A9 RID: 169
		private bool bPhongBanThayDoi = false;
	}
}
