using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SKCDExtCtrl;
using SKCDExtCtrl.GridFilterFactories;
using SKCDExtCtrl.GridFilters;

namespace EchoAdmin
{
	// Token: 0x02000002 RID: 2
	public partial class TimKetQuaSieuAm : Form
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002418 File Offset: 0x00001418
		public TimKetQuaSieuAm()
		{
			this.InitializeComponent();
			this.dataGridView1.DoubleClick += this.dataGridView1_DoubleClick;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000024A4 File Offset: 0x000014A4
		public TimKetQuaSieuAm(DataSet ds)
		{
			this.InitializeComponent();
			this.dataGridView1.DoubleClick += this.dataGridView1_DoubleClick;
			this._dsSearch = ds;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002538 File Offset: 0x00001538
		private void TimKetQuaSieuAm_Load(object sender, EventArgs e)
		{
			this.dataGridView1.DataSource = this._dsSearch.Tables[0];
			this.dataGridView1.Columns["CLSKetQua_Id"].Visible = false;
			this.dataGridView1.Columns["BenhNhan_Id"].Visible = false;
			this.dataGridView1.Columns["CLSYeuCau_Id"].Visible = false;
			this.dataGridView1.Columns["YeuCauChiTiet_Id"].Visible = false;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000025D4 File Offset: 0x000015D4
		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
			if (this.dataGridView1.SelectedRows.Count > 0)
			{
				this.buttonOK.PerformClick();
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000260C File Offset: 0x0000160C
		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (this.dataGridView1.SelectedCells[0].RowIndex >= 0)
			{
				this._iRow = this.dataGridView1.SelectedCells[1].RowIndex;
				if (this._columnMember != string.Empty)
				{
					this._sValue = this.dataGridView1[this._columnMember, this._iRow].Value.ToString();
				}
				else
				{
					this._sValue = this.dataGridView1[1, this._iRow].Value.ToString();
				}
				this.key_id = (int)this.dataGridView1[0, this._iRow].Value;
				base.Close();
			}
			else if (MessageBox.Show("Bạn chưa chọn dòng dữ liệu", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
			{
				base.Close();
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002710 File Offset: 0x00001710
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this._sValue = string.Empty;
			this._iRow = -1;
			this.key_id = -1;
			base.Close();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002734 File Offset: 0x00001734
		public int SelectRowIndex
		{
			get
			{
				return this._iRow;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000274C File Offset: 0x0000174C
		public string SelectMemberValue
		{
			get
			{
				return this._sValue;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002764 File Offset: 0x00001764
		public int ValueMember
		{
			get
			{
				return this.key_id;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002788 File Offset: 0x00001788
		// (set) Token: 0x0600000C RID: 12 RVA: 0x0000277C File Offset: 0x0000177C
		public string ColumnMember
		{
			get
			{
				return this._columnMember;
			}
			set
			{
				this._columnMember = value;
			}
		}

		// Token: 0x04000006 RID: 6
		private DataSet _dsSearch = new DataSet();

		// Token: 0x04000007 RID: 7
		private string _sdataMember = string.Empty;

		// Token: 0x04000008 RID: 8
		private string _sheaderGridColumnText = string.Empty;

		// Token: 0x04000009 RID: 9
		private string _sValue = string.Empty;

		// Token: 0x0400000A RID: 10
		private int _iRow = -1;

		// Token: 0x0400000B RID: 11
		private string _sTitle = string.Empty;

		// Token: 0x0400000C RID: 12
		private int key_id = -1;

		// Token: 0x0400000D RID: 13
		private string _columnMember = string.Empty;
	}
}
