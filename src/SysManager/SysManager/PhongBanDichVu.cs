using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utility;

namespace SysManager
{
	// Token: 0x02000005 RID: 5
	public partial class PhongBanDichVu : Form
	{
		// Token: 0x0600001B RID: 27 RVA: 0x000033D0 File Offset: 0x000023D0
		public PhongBanDichVu()
		{
			this.InitializeComponent();
			this.checkedListBoxPhongBan.ColumnWidth = this.splitContainer2.Panel1.Width / this._coldiv;
			this.checkedListBoxDichVu.ColumnWidth = this.splitContainer2.Panel2.Width / this._coldiv;
			this.checkedListBoxPhongBan.ItemCheck += this.checkedListBoxPhongBan_ItemCheck;
			this.checkedListBoxPhongBan.Validated += this.checkedListBoxPhongBan_Validated;
			this.checkedListBoxDichVu.Validated += this.checkedListBoxDichVu_Validated;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000349B File Offset: 0x0000249B
		private void checkedListBoxDichVu_Validated(object sender, EventArgs e)
		{
			this._changeCheckListBox = true;
			this.buttonSave.Enabled = true;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000034B2 File Offset: 0x000024B2
		private void checkedListBoxPhongBan_Validated(object sender, EventArgs e)
		{
			this._changeCheckListBox = true;
			this.buttonSave.Enabled = true;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000034C9 File Offset: 0x000024C9
		private void checkedListBoxPhongBan_ItemCheck(object sender, ItemCheckEventArgs e)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000034CC File Offset: 0x000024CC
		private void PhongBanDichVu_Load(object sender, EventArgs e)
		{
			this.ds.Relations.Clear();
			EClinicDB.FillDataset(ref this.ds, "select * from dm_dichvu_nhom where (Cap = 1) order by NhomDichVu_Id asc", "DMNhomDichVu");
			EClinicDB.FillDataset(ref this.ds, "select * from dm_phongban order by MaPhongBan asc", "PhongBan");
			EClinicDB.FillDataset(ref this.ds, "select * from dm_dichvu where (Cap = 1) order by NhomDichVu_Id asc", "DMDichVu");
			this.checkedListBoxDichVu.DataSource = this.ds;
			this.checkedListBoxDichVu.DisplayMember = "DMDichVu.TenDichVu";
			this.checkedListBoxDichVu.ValueMember = "DMDichVu.DichVu_Id";
			this.checkedListBoxPhongBan.DataSource = this.ds;
			this.checkedListBoxPhongBan.DisplayMember = "PhongBan.TenPhongBan";
			this.checkedListBoxPhongBan.ValueMember = "PhongBan.PhongBan_Id";
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003598 File Offset: 0x00002598
		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int count = this.checkedListBoxPhongBan.Items.Count;
			for (int i = 0; i < count; i++)
			{
				this.checkedListBoxPhongBan.SetItemChecked(i, true);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000035D8 File Offset: 0x000025D8
		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			int count = this.checkedListBoxDichVu.Items.Count;
			for (int i = 0; i < count; i++)
			{
				this.checkedListBoxDichVu.SetItemChecked(i, true);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003618 File Offset: 0x00002618
		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			int count = this.checkedListBoxDichVu.Items.Count;
			for (int i = 0; i < count; i++)
			{
				this.checkedListBoxDichVu.SetItemCheckState(i, CheckState.Unchecked);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003658 File Offset: 0x00002658
		private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int count = this.checkedListBoxPhongBan.Items.Count;
			for (int i = 0; i < count; i++)
			{
				this.checkedListBoxPhongBan.SetItemChecked(i, false);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003697 File Offset: 0x00002697
		private void checkedListBoxPhongBan_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000369C File Offset: 0x0000269C
		private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
		{
			this.checkedListBoxPhongBan.ColumnWidth = this.splitContainer2.Panel1.Width / this._coldiv;
			this.checkedListBoxDichVu.ColumnWidth = this.splitContainer2.Panel2.Width / this._coldiv;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000036F0 File Offset: 0x000026F0
		private void radioButtonMasterPhongBan_CheckedChanged(object sender, EventArgs e)
		{
			int count = this.checkedListBoxPhongBan.Items.Count;
			for (int i = 0; i < count; i++)
			{
				this.checkedListBoxPhongBan.SetItemCheckState(i, CheckState.Unchecked);
			}
			count = this.checkedListBoxDichVu.Items.Count;
			for (int i = 0; i < count; i++)
			{
				this.checkedListBoxDichVu.SetItemCheckState(i, CheckState.Unchecked);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003760 File Offset: 0x00002760
		private void buttonEdit_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003764 File Offset: 0x00002764
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = DialogResult.No;
			if (this._changeCheckListBox)
			{
				dialogResult = MessageBox.Show(__.T("Thông tin đã có thay đổi. Bạn có muốn lưu không?"), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			}
			if (dialogResult == DialogResult.No)
			{
				base.Close();
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000037B4 File Offset: 0x000027B4
		private void buttonSave_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.checkedListBoxPhongBan.CheckedIndices)
			{
				int index = (int)obj;
				string text = this.ds.Tables["PhongBan"].Rows[index]["PhongBan_id"].ToString();
				if (!this.DeleteDichVu(text))
				{
					MessageBox.Show(__.T("Có lỗi khi cập nhật Hệ thống dữ liệu."));
					return;
				}
				foreach (object obj2 in this.checkedListBoxDichVu.CheckedIndices)
				{
					int index2 = (int)obj2;
					string sDichVuId = this.ds.Tables["DMDichVu"].Rows[index2]["DichVu_id"].ToString();
					if (!this.InsertNew(text, sDichVuId))
					{
						MessageBox.Show(__.T("Có lỗi khi cập nhật Hệ thống dữ liệu."));
						return;
					}
				}
			}
			this._changeCheckListBox = false;
			MessageBox.Show(__.T("Cập nhật thành công."));
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003968 File Offset: 0x00002968
		private bool DeleteDichVu(string sPhongBanID)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("DELETE FROM dm_phongban_dichvu WHERE PhongBan_Id= {0}", sPhongBanID);
			int num = EClinicDB.ExecuteNonQuery(stringBuilder.ToString());
			return num != -1;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000039A4 File Offset: 0x000029A4
		private bool InsertNew(string sPhongBanId, string sDichVuId)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("Insert into dm_phongban_dichvu (PhongBan_Id, DichVu_Id) values ({0}, {1})", sPhongBanId, sDichVuId);
			return EClinicDB.ExecuteNonQuery(stringBuilder.ToString()) != -1;
		}

		// Token: 0x04000015 RID: 21
		private DataSet ds = new DataSet();

		// Token: 0x04000016 RID: 22
		private bool _changeCheckListBox = false;

		// Token: 0x04000017 RID: 23
		private int _coldiv = 3;
	}
}
