namespace SysManager
{
	// Token: 0x02000009 RID: 9
	public partial class Search : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003C RID: 60 RVA: 0x000057C4 File Offset: 0x000047C4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000057FC File Offset: 0x000047FC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::SKCDExtCtrl.GridFilterFactories.DefaultGridFilterFactory defaultGridFilterFactory = new global::SKCDExtCtrl.GridFilterFactories.DefaultGridFilterFactory();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.textBoxTitle = new global::System.Windows.Forms.TextBox();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.dataGridViewSearch = new global::System.Windows.Forms.DataGridView();
			this.dataGridFilterExtenderSearch = new global::SKCDExtCtrl.DataGridFilterExt(this.components);
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewSearch).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridFilterExtenderSearch).BeginInit();
			base.SuspendLayout();
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.BackColor = global::System.Drawing.SystemColors.Control;
			this.splitContainer1.Panel1.Controls.Add(this.textBoxTitle);
			this.splitContainer1.Panel1.Controls.Add(this.buttonCancel);
			this.splitContainer1.Panel1.Controls.Add(this.buttonOK);
			this.splitContainer1.Panel2.BackColor = global::System.Drawing.SystemColors.Control;
			this.splitContainer1.Panel2.Controls.Add(this.dataGridViewSearch);
			this.splitContainer1.Size = new global::System.Drawing.Size(785, 502);
			this.splitContainer1.SplitterDistance = 55;
			this.splitContainer1.TabIndex = 0;
			this.textBoxTitle.BackColor = global::System.Drawing.SystemColors.Control;
			this.textBoxTitle.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBoxTitle.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.textBoxTitle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
			this.textBoxTitle.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.textBoxTitle.Location = new global::System.Drawing.Point(27, 12);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.ReadOnly = true;
			this.textBoxTitle.Size = new global::System.Drawing.Size(578, 28);
			this.textBoxTitle.TabIndex = 2;
			this.buttonCancel.Location = new global::System.Drawing.Point(705, 12);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(68, 28);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new global::System.EventHandler(this.buttonCancel_Click);
			this.buttonOK.Location = new global::System.Drawing.Point(631, 12);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(66, 29);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new global::System.EventHandler(this.buttonOK_Click);
			this.dataGridViewSearch.AllowUserToAddRows = false;
			this.dataGridViewSearch.AllowUserToDeleteRows = false;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.LightGoldenrodYellow;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.dataGridViewSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewSearch.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewSearch.Location = new global::System.Drawing.Point(0, 24);
			this.dataGridViewSearch.MultiSelect = false;
			this.dataGridViewSearch.Name = "dataGridViewSearch";
			this.dataGridViewSearch.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewSearch.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewSearch.Size = new global::System.Drawing.Size(785, 416);
			this.dataGridViewSearch.TabIndex = 0;
			this.dataGridFilterExtenderSearch.DataGridView = this.dataGridViewSearch;
			defaultGridFilterFactory.CreateDistinctGridFilters = false;
			defaultGridFilterFactory.DefaultGridFilterType = typeof(global::SKCDExtCtrl.GridFilters.TextGridFilter);
			defaultGridFilterFactory.DefaultShowDateInBetweenOperator = false;
			defaultGridFilterFactory.DefaultShowNumericInBetweenOperator = false;
			defaultGridFilterFactory.HandleEnumerationTypes = true;
			defaultGridFilterFactory.MaximumDistinctValues = 20;
			this.dataGridFilterExtenderSearch.FilterFactory = defaultGridFilterFactory;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			base.ClientSize = new global::System.Drawing.Size(785, 502);
			base.ControlBox = false;
			base.Controls.Add(this.splitContainer1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Name = "Search";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search";
			base.Load += new global::System.EventHandler(this.Search_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewSearch).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridFilterExtenderSearch).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000040 RID: 64
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.DataGridView dataGridViewSearch;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.TextBox textBoxTitle;

		// Token: 0x04000046 RID: 70
		private global::SKCDExtCtrl.DataGridFilterExt dataGridFilterExtenderSearch;
	}
}
