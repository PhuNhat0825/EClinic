using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SKCDExtCtrl;
using SKCDExtCtrl.GridFilterFactories;
using SKCDExtCtrl.GridFilters;

namespace SysManager
{
	// Token: 0x02000009 RID: 9
	public partial class Search : Form
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00005E8C File Offset: 0x00004E8C
		public Search()
		{
			this.InitializeComponent();
			this.dataGridViewSearch.CellMouseDoubleClick += this.dataGridViewSearch_CellMouseDoubleClick;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005F24 File Offset: 0x00004F24
		private void dataGridViewSearch_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (this.dataGridViewSearch.SelectedRows.Count > 0)
			{
				this.buttonOK.PerformClick();
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005F5C File Offset: 0x00004F5C
		public Search(string scommandText)
		{
			this.InitializeComponent();
			this._scommandText = scommandText;
			this._dsSearch = EClinicDB.FillDataset(this._scommandText);
			this.Initialize();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005FFC File Offset: 0x00004FFC
		public Search(string scommandText, string sheaderGridColumnText)
		{
			this.InitializeComponent();
			this._scommandText = scommandText;
			this._sheaderGridColumnText = sheaderGridColumnText;
			this._dsSearch = EClinicDB.FillDataset(this._scommandText);
			this.Initialize();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000060A4 File Offset: 0x000050A4
		public Search(DataSet dsSearch, string sheaderGridColumnText)
		{
			this.InitializeComponent();
			this._sheaderGridColumnText = sheaderGridColumnText;
			this._dsSearch = dsSearch;
			this.Initialize();
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00006144 File Offset: 0x00005144
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00006138 File Offset: 0x00005138
		public string HeaderGridColumnText
		{
			get
			{
				return this._sheaderGridColumnText;
			}
			set
			{
				this._sheaderGridColumnText = value;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000615C File Offset: 0x0000515C
		private void Search_Load(object sender, EventArgs e)
		{
			this.textBoxTitle.Text = this._sTitle;
			if (this._sdataMember == string.Empty)
			{
				this.dataGridViewSearch.DataSource = this._dsSearch.Tables[0];
			}
			else
			{
				this.dataGridViewSearch.DataSource = this._dsSearch.Tables[this._sdataMember];
			}
			this.Initialize();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000061DF File Offset: 0x000051DF
		private void Initialize()
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000061E4 File Offset: 0x000051E4
		public int SelectRowIndex
		{
			get
			{
				return this._iRow;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000061FC File Offset: 0x000051FC
		public string SelectMemberValue
		{
			get
			{
				return this._sValue;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00006220 File Offset: 0x00005220
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00006214 File Offset: 0x00005214
		public string TitleTextBox
		{
			get
			{
				return this._sTitle;
			}
			set
			{
				this._sTitle = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00006244 File Offset: 0x00005244
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00006238 File Offset: 0x00005238
		public DataSet DataSoucre
		{
			get
			{
				return this._dsSearch;
			}
			set
			{
				this._dsSearch = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00006268 File Offset: 0x00005268
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000625C File Offset: 0x0000525C
		public string DataMember
		{
			get
			{
				return this._sdataMember;
			}
			set
			{
				this._sdataMember = value;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006280 File Offset: 0x00005280
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this._sValue = string.Empty;
			this._iRow = -1;
			this.key_id = -1;
			base.Close();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000062A4 File Offset: 0x000052A4
		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewSearch.SelectedCells[0].RowIndex >= 0)
			{
				this._iRow = this.dataGridViewSearch.SelectedCells[1].RowIndex;
				if (this._columnMember != string.Empty)
				{
					this._sValue = this.dataGridViewSearch[this._columnMember, this._iRow].Value.ToString();
				}
				else
				{
					this._sValue = this.dataGridViewSearch[1, this._iRow].Value.ToString();
				}
				this.key_id = (int)this.dataGridViewSearch[0, this._iRow].Value;
				base.Close();
			}
			else if (MessageBox.Show("Bạn chưa chọn dòng dữ liệu", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
			{
				base.Close();
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000063A8 File Offset: 0x000053A8
		public int ValueMember
		{
			get
			{
				return this.key_id;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000063CC File Offset: 0x000053CC
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000063C0 File Offset: 0x000053C0
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

		// Token: 0x04000047 RID: 71
		private DataSet _dsSearch = new DataSet();

		// Token: 0x04000048 RID: 72
		private string _sdataMember = string.Empty;

		// Token: 0x04000049 RID: 73
		private string _scommandText = "Select * from NHAN_VIEN";

		// Token: 0x0400004A RID: 74
		private string _sheaderGridColumnText = string.Empty;

		// Token: 0x0400004B RID: 75
		private string _sValue = string.Empty;

		// Token: 0x0400004C RID: 76
		private int _iRow = -1;

		// Token: 0x0400004D RID: 77
		private string _sTitle = string.Empty;

		// Token: 0x0400004E RID: 78
		private int key_id = -1;

		// Token: 0x0400004F RID: 79
		private string _columnMember = string.Empty;
	}
}
