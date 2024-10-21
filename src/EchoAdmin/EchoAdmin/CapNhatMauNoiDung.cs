using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DBInteraction;
using SKCDExtCtrl;
using Utility;

namespace EchoAdmin
{
	// Token: 0x02000004 RID: 4
	public partial class CapNhatMauNoiDung : Form
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002ABE File Offset: 0x00001ABE
		public CapNhatMauNoiDung()
		{
			this.InitializeComponent();
			this.listBoxMauSieuAm.SelectedValueChanged += this.listBoxMauSieuAm_SelectedValueChanged;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002B00 File Offset: 0x00001B00
		private void buttonExit_Click(object sender, EventArgs e)
		{
			if (this.buttonSave.Tag != "STANDBY")
			{
				MessageBox.Show("Cần phải cập nhật dữ liệu trước khi đóng cửa sổ này");
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002B3C File Offset: 0x00001B3C
		private void CapNhatMauNoiDung_Load(object sender, EventArgs e)
		{
			this.SetTrangThaiNutLenh(CapNhatMauNoiDung.ButtonStat.StartUp);
			this.LoadComboData();
			if (EClinicConfig.UserGroupTypes != "ADMIN")
			{
				this.buttonCancel.Visible = false;
				this.buttonAddNew.Visible = false;
				this.buttonDelete.Visible = false;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002B98 File Offset: 0x00001B98
		private void listBoxMauSieuAm_SelectedValueChanged(object sender, EventArgs e)
		{
			if (!this.bLoadBanDau)
			{
				this.iDichVu_GiaTriChuan = int.Parse(StringExt.StringZero(this.listBoxMauSieuAm.SelectedValue));
				this.LoadNoiDungMau(this.iDichVu_GiaTriChuan);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002BDC File Offset: 0x00001BDC
		private void LoadNoiDungMau(int iMauKetQua)
		{
			if (this.ds.Tables.Contains("NoiDungMauKetQua"))
			{
				this.ds.Tables["NoiDungMauKetQua"].Clear();
			}
			ParamCollection paramCollection = new ParamCollection();
			paramCollection.Add("DataGroup", DbDataType.VarString, 50, "NoiDungMauKetQua");
			paramCollection.Add("FiltData", DbDataType.Int32, 11, iMauKetQua);
			EClinicDB.FillDataset(ref this.ds, "sp_Sys_GetListDataGridView", CommandType.StoredProcedure, paramCollection, "NoiDungMauKetQua");
			if (this.ds.Tables["NoiDungMauKetQua"].Rows.Count > 0)
			{
				DataRow dataRow = this.ds.Tables["NoiDungMauKetQua"].Rows[0];
				this.textBoxTitleAlias.Text = StringExt.StringNull(dataRow["Title_Alias"]);
				this.textBoxTitleReport.Text = StringExt.StringNull(dataRow["Title"]);
				this.richTextBoxExtendedMoTa.RichTextBox.Rtf = StringExt.StringNull(dataRow["Text_001"]);
				this.richTextBoxKetLuan.Rtf = StringExt.StringNull(dataRow["KetLuan"]);
				this.richTextBoxGhiChu.Rtf = StringExt.StringNull(dataRow["GhiChu"]);
				this.checkBoxTamNgung.Checked = (int.Parse(StringExt.StringZero(dataRow["TamNgung"])) == 1);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002D74 File Offset: 0x00001D74
		private void LoadComboData()
		{
			if (this.ds != null)
			{
				if (this.ds.Tables.Contains("NhomSieuAm"))
				{
					this.ds.Tables["NhomSieuAm"].Clear();
				}
				if (this.ds.Tables.Contains("KetQuaSieuAmMau"))
				{
					this.ds.Tables["KetQuaSieuAmMau"].Clear();
				}
			}
			ParamCollection paramCollection = new ParamCollection();
			paramCollection.Add("DataGroup", DbDataType.VarString, 50, "NhomSieuAm");
			paramCollection.Add("FiltData", DbDataType.VarString, 250, string.Empty);
			EClinicDB.FillDataset(ref this.ds, "sp_Sys_GetListDataGridView", CommandType.StoredProcedure, paramCollection, "NhomSieuAm");
			paramCollection.Clear();
			paramCollection.Add("DataGroup", DbDataType.VarString, 50, "KetQuaSieuAmMau");
			paramCollection.Add("FiltData", DbDataType.VarString, 250, string.Empty);
			EClinicDB.FillDataset(ref this.ds, "sp_Sys_GetListDataGridView", CommandType.StoredProcedure, paramCollection, "KetQuaSieuAmMau");
			this.ds.Relations.Clear();
			this.ds.Relations.Add("Nhom_Mau", this.ds.Tables["NhomSieuAm"].Columns["DichVu_Id"], this.ds.Tables["KetQuaSieuAmMau"].Columns["DichVu_Id"], false);
			this.comboBoxNhomSieuAm.DataSource = this.ds;
			this.comboBoxNhomSieuAm.DisplayMember = "NhomSieuAm.TenDichVu";
			this.comboBoxNhomSieuAm.ValueMember = "NhomSieuAm.DichVu_Id";
			this.listBoxMauSieuAm.DataSource = this.ds;
			this.listBoxMauSieuAm.DisplayMember = "NhomSieuAm.Nhom_Mau.Title_Alias";
			this.listBoxMauSieuAm.ValueMember = "NhomSieuAm.Nhom_Mau.DichVu_GiaTriChuan_Id";
			if (this.listBoxMauSieuAm.Items.Count > 0)
			{
				this.buttonDelete.Enabled = true;
			}
			else
			{
				this.buttonDelete.Enabled = false;
			}
			this.bLoadBanDau = false;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002FAC File Offset: 0x00001FAC
		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			ParamCollection paramCollection = new ParamCollection();
			if (this.buttonSave.Tag == "INSERT")
			{
				paramCollection.Add("GroupCommand", DbDataType.VarString, 10, "INSERT");
			}
			else
			{
				paramCollection.Add("GroupCommand", DbDataType.VarString, 10, "UPDATE");
			}
			paramCollection.Add("DichVu_GiaTriChuan_Id", DbDataType.Int32, 11, int.Parse(StringExt.StringZero(this.listBoxMauSieuAm.SelectedValue)));
			paramCollection.Add("DichVu_Id", DbDataType.Int32, 11, int.Parse(StringExt.StringZero(this.comboBoxNhomSieuAm.SelectedValue)));
			paramCollection.Add("Title", DbDataType.VarChar, 255, this.textBoxTitleReport.Text);
			paramCollection.Add("Title_Alias", DbDataType.VarChar, 255, this.textBoxTitleAlias.Text);
			paramCollection.Add("Text_001", DbDataType.String, 5000, this.richTextBoxExtendedMoTa.RichTextBox.Rtf);
			paramCollection.Add("KetLuan", DbDataType.String, 5000, this.richTextBoxKetLuan.Rtf);
			paramCollection.Add("GhiChu", DbDataType.String, 5000, this.richTextBoxGhiChu.Rtf);
			paramCollection.Add("TamNgung", DbDataType.Int32, 1, this.checkBoxTamNgung.Checked ? 1 : 0);
			if (EClinicDB.ExecuteNonQuery("sp_dichvu_giatrichuan", CommandType.StoredProcedure, paramCollection) > 0)
			{
				MessageBox.Show("Cập nhật dữ liệu thành công!");
				this.SetTrangThaiNutLenh(CapNhatMauNoiDung.ButtonStat.Update);
				this.LoadComboData();
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003150 File Offset: 0x00002150
		private void buttonAddNew_Click(object sender, EventArgs e)
		{
			this.SetTrangThaiNutLenh(CapNhatMauNoiDung.ButtonStat.AddNew);
			this.textBoxTitleAlias.Text = string.Empty;
			this.textBoxTitleReport.Text = string.Empty;
			this.richTextBoxGhiChu.Rtf = string.Empty;
			this.richTextBoxKetLuan.Rtf = string.Empty;
			this.richTextBoxExtendedMoTa.RichTextBox.Rtf = string.Empty;
			this.checkBoxTamNgung.Checked = false;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000031D0 File Offset: 0x000021D0
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (this.buttonSave.Tag != "STANDBY")
			{
				MessageBox.Show("Cần phải cập nhật dữ liệu trước khi xóa dữ liệu");
			}
			else
			{
				DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không ?", "Lưu ý", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					ParamCollection paramCollection = new ParamCollection();
					paramCollection.Add("GroupCommand", DbDataType.VarString, 10, "DELETE");
					paramCollection.Add("DichVu_GiaTriChuan_Id", DbDataType.Int32, 11, int.Parse(StringExt.StringZero(this.listBoxMauSieuAm.SelectedValue)));
					paramCollection.Add("DichVu_Id", DbDataType.Int32, 11, 0);
					paramCollection.Add("Title", DbDataType.VarChar, 255, string.Empty);
					paramCollection.Add("Title_Alias", DbDataType.VarChar, 255, string.Empty);
					paramCollection.Add("Text_001", DbDataType.String, 5000, string.Empty);
					paramCollection.Add("KetLuan", DbDataType.String, 5000, string.Empty);
					paramCollection.Add("GhiChu", DbDataType.String, 5000, string.Empty);
					paramCollection.Add("TamNgung", DbDataType.Int32, 1, 0);
					if (EClinicDB.ExecuteNonQuery("sp_dichvu_giatrichuan", CommandType.StoredProcedure, paramCollection) > 0)
					{
						MessageBox.Show("Xóa dữ liệu thành công!");
					}
					this.LoadComboData();
				}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000333D File Offset: 0x0000233D
		private void buttonEdit_Click(object sender, EventArgs e)
		{
			this.SetTrangThaiNutLenh(CapNhatMauNoiDung.ButtonStat.Edit);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003348 File Offset: 0x00002348
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.SetTrangThaiNutLenh(CapNhatMauNoiDung.ButtonStat.Cancel);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003354 File Offset: 0x00002354
		private void SetTrangThaiNutLenh(CapNhatMauNoiDung.ButtonStat butStat)
		{
			switch (butStat)
			{
			case CapNhatMauNoiDung.ButtonStat.StartUp:
				this.buttonCancel.Enabled = false;
				this.buttonSave.Enabled = false;
				this.buttonSave.Tag = "STANDBY";
				this.buttonEdit.Enabled = true;
				this.buttonDelete.Enabled = true;
				this.buttonAddNew.Enabled = true;
				this.buttonExit.Enabled = true;
				this.listBoxMauSieuAm.Enabled = true;
				this.comboBoxNhomSieuAm.Enabled = true;
				break;
			case CapNhatMauNoiDung.ButtonStat.Edit:
				this.buttonAddNew.Enabled = false;
				this.buttonSave.Enabled = true;
				this.buttonSave.Tag = "UPDATE";
				this.buttonEdit.Enabled = false;
				this.buttonDelete.Enabled = false;
				this.buttonExit.Enabled = false;
				this.listBoxMauSieuAm.Enabled = false;
				this.comboBoxNhomSieuAm.Enabled = false;
				break;
			case CapNhatMauNoiDung.ButtonStat.Save:
				this.buttonCancel.Enabled = false;
				this.buttonSave.Enabled = false;
				this.buttonSave.Tag = "STANDBY";
				this.buttonEdit.Enabled = true;
				this.buttonDelete.Enabled = true;
				this.buttonAddNew.Enabled = true;
				this.buttonExit.Enabled = true;
				this.listBoxMauSieuAm.Enabled = true;
				this.comboBoxNhomSieuAm.Enabled = true;
				break;
			case CapNhatMauNoiDung.ButtonStat.Update:
				this.buttonCancel.Enabled = false;
				this.buttonSave.Enabled = false;
				this.buttonSave.Tag = "STANDBY";
				this.buttonEdit.Enabled = true;
				this.buttonDelete.Enabled = true;
				this.buttonAddNew.Enabled = true;
				this.buttonExit.Enabled = true;
				this.listBoxMauSieuAm.Enabled = true;
				this.comboBoxNhomSieuAm.Enabled = true;
				break;
			case CapNhatMauNoiDung.ButtonStat.Cancel:
				this.buttonCancel.Enabled = false;
				this.buttonSave.Enabled = false;
				this.buttonSave.Tag = "STANDBY";
				this.buttonEdit.Enabled = true;
				this.buttonDelete.Enabled = true;
				this.buttonAddNew.Enabled = true;
				this.buttonExit.Enabled = true;
				this.listBoxMauSieuAm.Enabled = true;
				this.comboBoxNhomSieuAm.Enabled = true;
				break;
			case CapNhatMauNoiDung.ButtonStat.AddNew:
				this.buttonCancel.Enabled = true;
				this.buttonSave.Enabled = true;
				this.buttonSave.Tag = "INSERT";
				this.buttonDelete.Enabled = false;
				this.buttonAddNew.Enabled = false;
				this.buttonEdit.Enabled = false;
				this.buttonExit.Enabled = false;
				this.listBoxMauSieuAm.Enabled = false;
				this.comboBoxNhomSieuAm.Enabled = false;
				break;
			default:
				this.buttonCancel.Enabled = false;
				this.buttonSave.Enabled = false;
				this.buttonSave.Tag = "STANDBY";
				this.buttonEdit.Enabled = true;
				this.buttonDelete.Enabled = true;
				this.buttonAddNew.Enabled = true;
				this.buttonExit.Enabled = true;
				this.listBoxMauSieuAm.Enabled = true;
				this.comboBoxNhomSieuAm.Enabled = true;
				break;
			}
		}

		// Token: 0x04000010 RID: 16
		private DataSet ds;

		// Token: 0x04000011 RID: 17
		private bool bLoadBanDau = true;

		// Token: 0x04000012 RID: 18
		private int iDichVu_GiaTriChuan = 0;

		// Token: 0x02000005 RID: 5
		private enum ButtonStat
		{
			// Token: 0x0400002C RID: 44
			StartUp,
			// Token: 0x0400002D RID: 45
			Edit,
			// Token: 0x0400002E RID: 46
			Save,
			// Token: 0x0400002F RID: 47
			Update,
			// Token: 0x04000030 RID: 48
			Cancel,
			// Token: 0x04000031 RID: 49
			AddNew
		}
	}
}
