using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CrystRptManager;
using SKCDExtCtrl;
using Utility;

namespace EchoAdmin
{
	// Token: 0x02000006 RID: 6
	public partial class ReportRetrieval : Form
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000054D4 File Offset: 0x000044D4
		public ReportRetrieval()
		{
			this.InitializeComponent();
			this.dtpTuNgay.Value = DateTime.Now;
			this.dtpDenNgay.Value = DateTime.Now;
			try
			{
				DataSet dataSet = EClinicDB.FillDataset("SELECT List_Id, List_Name FROM list_dichvu WHERE Enable='1' ORDER BY List_order");
				this.comboLoaiSA.DataSource = dataSet.Tables[0];
				this.comboLoaiSA.DisplayMember = "List_Name";
				this.comboLoaiSA.ValueMember = "List_Id";
			}
			catch
			{
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00005588 File Offset: 0x00004588
		private void ReportRetrieval_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000558B File Offset: 0x0000458B
		private void checkMaSoBN_CheckedChanged(object sender, EventArgs e)
		{
			this.textBoxMaBN.Enabled = this.checkMaSoBN.Checked;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000055A5 File Offset: 0x000045A5
		private void checkHotenBN_CheckedChanged(object sender, EventArgs e)
		{
			this.textBoxHotenBN.Enabled = this.checkHotenBN.Checked;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000055BF File Offset: 0x000045BF
		private void checkLoaiSA_CheckedChanged(object sender, EventArgs e)
		{
			this.comboLoaiSA.Enabled = this.checkLoaiSA.Checked;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000055D9 File Offset: 0x000045D9
		private void checkThoigianSA_CheckedChanged(object sender, EventArgs e)
		{
			this.dtpDenNgay.Enabled = this.checkThoigianSA.Checked;
			this.dtpTuNgay.Enabled = this.checkThoigianSA.Checked;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000560C File Offset: 0x0000460C
		private void outlookGridKQ_CellClick(object sender, DataGridViewCellEventArgs e)
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
				this.outlookGridKQ.GroupTemplate.Column = this.outlookGridKQ.Columns[e.ColumnIndex];
				this.outlookGridKQ.Sort(new DataRowComparer(e.ColumnIndex, direction));
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000056AC File Offset: 0x000046AC
		private void comboLoaiSA_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000056AF File Offset: 0x000046AF
		private void buttonThoat_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000056BC File Offset: 0x000046BC
		private void buttonTim_Click(object sender, EventArgs e)
		{
			string text = "";
			DataSet dataSet = null;
			if (this.TaoCauTruyVanTimKiem(ref text))
			{
				try
				{
					ArrayList arrayList = new ArrayList();
					ArrayList arrayList2 = new ArrayList();
					arrayList.Add("Ho_ten");
					arrayList.Add("Ho");
					arrayList.Add("Ten");
					string text2 = this.XuLyHoten(this.textBoxHotenBN.Text);
					arrayList2.Add(this.textBoxHotenBN.Text);
					arrayList2.Add(this.textBoxHotenBN.Text);
					arrayList2.Add(this.textBoxHotenBN.Text);
					dataSet = EClinicDB.FillDataset(text, null, arrayList, arrayList2);
				}
				catch
				{
				}
			}
			else
			{
				try
				{
					dataSet = EClinicDB.FillDataset(text, true);
				}
				catch
				{
				}
			}
			if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Columns.Count > 0)
			{
				dataSet.Tables[0].TableName = "KET_QUA_TIM_KIEM";
				this.outlookGridKQ.BindData(dataSet, "KET_QUA_TIM_KIEM");
				if (this.outlookGridKQ.Columns.Count > 0)
				{
					this.outlookGridKQ.Columns["SA_id"].HeaderText = "Mã Phiếu";
					this.outlookGridKQ.Columns["SA_id"].Width = 50;
					this.outlookGridKQ.Columns["Benh_nhan_id"].HeaderText = "Mã số";
					this.outlookGridKQ.Columns["Benh_nhan_id"].Width = 50;
					this.outlookGridKQ.Columns["Ho_ten"].HeaderText = "Họ tên bệnh nhân";
					this.outlookGridKQ.Columns["Ho_ten"].Width = 150;
					this.outlookGridKQ.Columns["Gioi_tinh"].HeaderText = "Giới tính";
					this.outlookGridKQ.Columns["Gioi_tinh"].Width = 50;
					this.outlookGridKQ.Columns["Nam_sinh"].HeaderText = "Năm sinh";
					this.outlookGridKQ.Columns["Nam_sinh"].Width = 50;
					this.outlookGridKQ.Columns["List_name"].HeaderText = "Dịch vụ";
					this.outlookGridKQ.Columns["List_name"].Width = 120;
					this.outlookGridKQ.Columns["Ngay"].HeaderText = "Ngày Siêu âm";
					this.outlookGridKQ.Columns["Ngay"].Width = 100;
					this.outlookGridKQ.Columns["List_Type_Code"].Visible = false;
					this.outlookGridKQ.Columns["Loai_SA_id"].Visible = false;
				}
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005A10 File Offset: 0x00004A10
		private string XuLyHoten(string sHoten)
		{
			return "";
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005A28 File Offset: 0x00004A28
		private void buttonInLaiKQ_Click(object sender, EventArgs e)
		{
			if (this.outlookGridKQ.SelectedRows.Count != 0 && !((OutlookGridRow)this.outlookGridKQ.SelectedRows[0]).IsGroupRow)
			{
				string text = this.outlookGridKQ.SelectedRows[0].Cells["SA_id"].Value.ToString();
				try
				{
					EClinicConfig.KetQua_SA_Id_cur = int.Parse(text);
					string sList_Type_Code = this.outlookGridKQ.SelectedRows[0].Cells["List_Type_Code"].Value.ToString();
					Form reportForm = this.GetReportForm(sList_Type_Code);
					if (reportForm != null)
					{
						reportForm.ShowDialog();
					}
					else
					{
						MessageBox.Show(__.T("Không in được kết quả siêu âm có Mã số phiếu siêu âm : " + text), __.T("Thông báo!"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00005B30 File Offset: 0x00004B30
		private void buttonCapnhatKQ_Click(object sender, EventArgs e)
		{
			if (this.outlookGridKQ.SelectedRows.Count != 0 && !((OutlookGridRow)this.outlookGridKQ.SelectedRows[0]).IsGroupRow)
			{
				int num = this.KiemTraCoTheSuaDuocKetQua();
				num = 1;
				if (num == -1)
				{
					MessageBox.Show(__.T("Không tồn tại Kết quả siêu âm."), __.T("Thông báo!"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else if (num == 0)
				{
					MessageBox.Show(__.T("Bác sĩ đang khám không có quyền sửa Kết quả siêu âm này."), __.T("Thông báo!"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					EClinicConfig.KetQua_SA_Id_cur = int.Parse(this.outlookGridKQ.SelectedRows[0].Cells["SA_id"].Value.ToString());
					EClinicConfig.Loai_SA_Code = this.outlookGridKQ.SelectedRows[0].Cells["List_Type_Code"].Value.ToString();
					EClinicConfig.Loai_SA_Id = int.Parse(this.outlookGridKQ.SelectedRows[0].Cells["Loai_SA_id"].Value.ToString());
					try
					{
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005C90 File Offset: 0x00004C90
		private bool TaoCauTruyVanTimKiem(ref string sSQL)
		{
			sSQL = "";
			sSQL = "SELECT kq.SA_id, kq.Benh_nhan_id, bn.Ho_ten , kq.Ngay, list_name, bn.Gioi_tinh, bn.Nam_sinh, List_Type_Code, Loai_SA_id ";
			sSQL += "FROM ketqua_sa kq, Benh_nhan bn, list_dichvu dv ";
			sSQL += "WHERE (kq.Benh_nhan_Id = bn.Benh_nhan_Id) ";
			sSQL += "AND (kq.Loai_SA_id = dv.list_Id) ";
			string text = "";
			if (this.checkThoigianSA.Checked)
			{
				text = "AND (kq.Ngay BETWEEN '" + this.dtpTuNgay.Value.ToString("yyyy/MM/dd") + "' ";
				text = text + "AND '" + this.dtpDenNgay.Value.ToString("yyyy/MM/dd") + "') ";
			}
			if (this.checkMaSoBN.Checked)
			{
				text = text + "AND (kq.Benh_nhan_Id=" + this.textBoxMaBN.Text + ") ";
			}
			if (this.checkLoaiSA.Checked)
			{
				text = text + "AND (dv.List_Id='" + this.comboLoaiSA.SelectedValue.ToString() + "') ";
			}
			if (this.checkHotenBN.Checked)
			{
				text += "AND (";
				text += "(bn.Ho_ten=?0) OR ";
				text += "(bn.Ho=?1) OR ";
				text += "(bn.Ten=?2)";
				text += ") ";
			}
			sSQL = sSQL + text + "ORDER BY kq.Ngay DESC ";
			return this.checkHotenBN.Checked;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005E14 File Offset: 0x00004E14
		private int KiemTraCoTheSuaDuocKetQua()
		{
			string sCommand = "select Nhan_Vien_Id from KETQUA_SA where KetQua_SA_Id=" + EClinicConfig.KetQua_SA_Id_cur.ToString();
			DataSet dataSet = EClinicDB.FillDataset(sCommand);
			int result;
			if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
			{
				if (EClinicConfig.Nhan_Vien_Id.ToString() == dataSet.Tables[0].Rows[0][0].ToString())
				{
					result = 1;
				}
				else
				{
					result = 0;
				}
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005EB8 File Offset: 0x00004EB8
		private Form GetReportForm(string sList_Type_Code)
		{
			switch (sList_Type_Code)
			{
			case "SACHUNG":
				return new ReportSAChung();
			case "SASK2D1":
				return new ReportSAThai2D1();
			case "SATHAI4D":
				return new ReportSAThai4D();
			case "SAMM":
				return new ReportSAMM();
			case "SAKH":
				return null;
			case "SATV":
				return new ReportSATVu();
			case "SATG":
				return new ReportSATGiap();
			case "SATQ":
				return new ReportSATQ();
			case "SATIM":
				return null;
			}
			return null;
		}

		// Token: 0x04000044 RID: 68
		private int prevColIndex = -1;

		// Token: 0x04000045 RID: 69
		private ListSortDirection prevSortDirection = ListSortDirection.Ascending;
	}
}
