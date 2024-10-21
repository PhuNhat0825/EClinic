namespace SysManager
{
	// Token: 0x02000005 RID: 5
	public partial class PhongBanDichVu : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002C RID: 44 RVA: 0x000039DC File Offset: 0x000029DC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003A14 File Offset: 0x00002A14
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.buttonSave = new global::System.Windows.Forms.Button();
			this.buttonEdit = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.radioButtonMasterDichVu = new global::System.Windows.Forms.RadioButton();
			this.radioButtonMasterPhongBan = new global::System.Windows.Forms.RadioButton();
			this.splitContainer2 = new global::System.Windows.Forms.SplitContainer();
			this.checkedListBoxPhongBan = new global::System.Windows.Forms.CheckedListBox();
			this.contextMenuStripPhongBan = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.selectToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.selectAllToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deselectAllToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkedListBoxDichVu = new global::System.Windows.Forms.CheckedListBox();
			this.contextMenuStripDichVu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemSelect = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemSelectAll = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemDeselectAll = new global::System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.contextMenuStripPhongBan.SuspendLayout();
			this.contextMenuStripDichVu.SuspendLayout();
			base.SuspendLayout();
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.buttonCancel);
			this.splitContainer1.Panel1.Controls.Add(this.buttonSave);
			this.splitContainer1.Panel1.Controls.Add(this.buttonEdit);
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new global::System.Drawing.Size(937, 525);
			this.splitContainer1.SplitterDistance = 68;
			this.splitContainer1.TabIndex = 0;
			this.buttonCancel.Location = new global::System.Drawing.Point(367, 14);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(67, 25);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new global::System.EventHandler(this.buttonCancel_Click);
			this.buttonSave.Location = new global::System.Drawing.Point(294, 14);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new global::System.Drawing.Size(67, 25);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new global::System.EventHandler(this.buttonSave_Click);
			this.buttonEdit.Location = new global::System.Drawing.Point(221, 14);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new global::System.Drawing.Size(67, 25);
			this.buttonEdit.TabIndex = 1;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new global::System.EventHandler(this.buttonEdit_Click);
			this.groupBox1.Controls.Add(this.radioButtonMasterDichVu);
			this.groupBox1.Controls.Add(this.radioButtonMasterPhongBan);
			this.groupBox1.Location = new global::System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(184, 61);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Quan hệ Phòng ban - Dịch vụ";
			this.radioButtonMasterDichVu.AutoSize = true;
			this.radioButtonMasterDichVu.Location = new global::System.Drawing.Point(9, 38);
			this.radioButtonMasterDichVu.Name = "radioButtonMasterDichVu";
			this.radioButtonMasterDichVu.Size = new global::System.Drawing.Size(132, 17);
			this.radioButtonMasterDichVu.TabIndex = 1;
			this.radioButtonMasterDichVu.Text = "Dịch vụ --> Phòng ban";
			this.radioButtonMasterDichVu.UseVisualStyleBackColor = true;
			this.radioButtonMasterPhongBan.AutoSize = true;
			this.radioButtonMasterPhongBan.Checked = true;
			this.radioButtonMasterPhongBan.Location = new global::System.Drawing.Point(9, 19);
			this.radioButtonMasterPhongBan.Name = "radioButtonMasterPhongBan";
			this.radioButtonMasterPhongBan.Size = new global::System.Drawing.Size(132, 17);
			this.radioButtonMasterPhongBan.TabIndex = 0;
			this.radioButtonMasterPhongBan.TabStop = true;
			this.radioButtonMasterPhongBan.Text = "Phòng ban --> Dịch vụ";
			this.radioButtonMasterPhongBan.UseVisualStyleBackColor = true;
			this.radioButtonMasterPhongBan.CheckedChanged += new global::System.EventHandler(this.radioButtonMasterPhongBan_CheckedChanged);
			this.splitContainer2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Panel1.Controls.Add(this.checkedListBoxPhongBan);
			this.splitContainer2.Panel2.Controls.Add(this.checkedListBoxDichVu);
			this.splitContainer2.Size = new global::System.Drawing.Size(937, 453);
			this.splitContainer2.SplitterDistance = 312;
			this.splitContainer2.TabIndex = 0;
			this.splitContainer2.SplitterMoved += new global::System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
			this.checkedListBoxPhongBan.CheckOnClick = true;
			this.checkedListBoxPhongBan.ContextMenuStrip = this.contextMenuStripPhongBan;
			this.checkedListBoxPhongBan.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.checkedListBoxPhongBan.FormattingEnabled = true;
			this.checkedListBoxPhongBan.Location = new global::System.Drawing.Point(0, 0);
			this.checkedListBoxPhongBan.MultiColumn = true;
			this.checkedListBoxPhongBan.Name = "checkedListBoxPhongBan";
			this.checkedListBoxPhongBan.Size = new global::System.Drawing.Size(312, 439);
			this.checkedListBoxPhongBan.TabIndex = 0;
			this.checkedListBoxPhongBan.ThreeDCheckBoxes = true;
			this.checkedListBoxPhongBan.SelectedIndexChanged += new global::System.EventHandler(this.checkedListBoxPhongBan_SelectedIndexChanged);
			this.contextMenuStripPhongBan.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.selectToolStripMenuItem,
				this.toolStripMenuItem1,
				this.selectAllToolStripMenuItem,
				this.deselectAllToolStripMenuItem
			});
			this.contextMenuStripPhongBan.Name = "contextMenuStripPhongBan";
			this.contextMenuStripPhongBan.Size = new global::System.Drawing.Size(141, 76);
			this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
			this.selectToolStripMenuItem.Size = new global::System.Drawing.Size(140, 22);
			this.selectToolStripMenuItem.Text = "Select";
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new global::System.Drawing.Size(137, 6);
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.Size = new global::System.Drawing.Size(140, 22);
			this.selectAllToolStripMenuItem.Text = "Select All";
			this.selectAllToolStripMenuItem.Click += new global::System.EventHandler(this.selectAllToolStripMenuItem_Click);
			this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
			this.deselectAllToolStripMenuItem.Size = new global::System.Drawing.Size(140, 22);
			this.deselectAllToolStripMenuItem.Text = "Deselect All";
			this.deselectAllToolStripMenuItem.Click += new global::System.EventHandler(this.deselectAllToolStripMenuItem_Click);
			this.checkedListBoxDichVu.CheckOnClick = true;
			this.checkedListBoxDichVu.ContextMenuStrip = this.contextMenuStripDichVu;
			this.checkedListBoxDichVu.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.checkedListBoxDichVu.FormattingEnabled = true;
			this.checkedListBoxDichVu.Location = new global::System.Drawing.Point(0, 0);
			this.checkedListBoxDichVu.MultiColumn = true;
			this.checkedListBoxDichVu.Name = "checkedListBoxDichVu";
			this.checkedListBoxDichVu.Size = new global::System.Drawing.Size(621, 439);
			this.checkedListBoxDichVu.TabIndex = 0;
			this.checkedListBoxDichVu.ThreeDCheckBoxes = true;
			this.contextMenuStripDichVu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItemSelect,
				this.toolStripSeparator1,
				this.toolStripMenuItemSelectAll,
				this.toolStripMenuItemDeselectAll
			});
			this.contextMenuStripDichVu.Name = "contextMenuStripPhongBan";
			this.contextMenuStripDichVu.Size = new global::System.Drawing.Size(141, 76);
			this.toolStripMenuItemSelect.Name = "toolStripMenuItemSelect";
			this.toolStripMenuItemSelect.Size = new global::System.Drawing.Size(140, 22);
			this.toolStripMenuItemSelect.Text = "Select";
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(137, 6);
			this.toolStripMenuItemSelectAll.Name = "toolStripMenuItemSelectAll";
			this.toolStripMenuItemSelectAll.Size = new global::System.Drawing.Size(140, 22);
			this.toolStripMenuItemSelectAll.Text = "Select All";
			this.toolStripMenuItemSelectAll.Click += new global::System.EventHandler(this.toolStripMenuItem3_Click);
			this.toolStripMenuItemDeselectAll.Name = "toolStripMenuItemDeselectAll";
			this.toolStripMenuItemDeselectAll.Size = new global::System.Drawing.Size(140, 22);
			this.toolStripMenuItemDeselectAll.Text = "Deselect All";
			this.toolStripMenuItemDeselectAll.Click += new global::System.EventHandler(this.toolStripMenuItem4_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(937, 525);
			base.Controls.Add(this.splitContainer1);
			base.Name = "PhongBanDichVu";
			this.Text = "PhongBanDichVu";
			base.Load += new global::System.EventHandler(this.PhongBanDichVu_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			this.contextMenuStripPhongBan.ResumeLayout(false);
			this.contextMenuStripDichVu.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000018 RID: 24
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.SplitContainer splitContainer2;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.CheckedListBox checkedListBoxDichVu;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.CheckedListBox checkedListBoxPhongBan;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStripPhongBan;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStripDichVu;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSelect;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSelectAll;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeselectAll;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.RadioButton radioButtonMasterDichVu;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.RadioButton radioButtonMasterPhongBan;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Button buttonSave;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Button buttonEdit;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Button buttonCancel;
	}
}
