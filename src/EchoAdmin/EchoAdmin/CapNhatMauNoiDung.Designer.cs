namespace EchoAdmin
{
	// Token: 0x02000004 RID: 4
	public partial class CapNhatMauNoiDung : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000036E8 File Offset: 0x000026E8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003720 File Offset: 0x00002720
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.buttonEdit = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.buttonExit = new global::System.Windows.Forms.Button();
			this.buttonDelete = new global::System.Windows.Forms.Button();
			this.buttonAddNew = new global::System.Windows.Forms.Button();
			this.buttonSave = new global::System.Windows.Forms.Button();
			this.listBoxMauSieuAm = new global::System.Windows.Forms.ListBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.comboBoxNhomSieuAm = new global::System.Windows.Forms.ComboBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.checkBoxTamNgung = new global::System.Windows.Forms.CheckBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.richTextBoxGhiChu = new global::System.Windows.Forms.RichTextBox();
			this.richTextBoxKetLuan = new global::System.Windows.Forms.RichTextBox();
			this.textBoxTitleReport = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.textBoxTitleAlias = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.richTextBoxExtendedMoTa = new global::SKCDExtCtrl.RichTextBoxExt();
			this.label3 = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.buttonCancel);
			this.groupBox1.Controls.Add(this.buttonEdit);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.buttonExit);
			this.groupBox1.Controls.Add(this.buttonDelete);
			this.groupBox1.Controls.Add(this.buttonAddNew);
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Controls.Add(this.listBoxMauSieuAm);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.comboBoxNhomSieuAm);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(315, 518);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "MẪU SIÊU ÂM";
			this.buttonCancel.Location = new global::System.Drawing.Point(36, 476);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 26);
			this.buttonCancel.TabIndex = 9;
			this.buttonCancel.Text = "Bỏ qua";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new global::System.EventHandler(this.buttonCancel_Click);
			this.buttonEdit.Location = new global::System.Drawing.Point(120, 444);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new global::System.Drawing.Size(75, 26);
			this.buttonEdit.TabIndex = 8;
			this.buttonEdit.Text = "Sửa";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new global::System.EventHandler(this.buttonEdit_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(6, 74);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(73, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Mẫu kết quả :";
			this.buttonExit.Location = new global::System.Drawing.Point(201, 476);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new global::System.Drawing.Size(75, 26);
			this.buttonExit.TabIndex = 6;
			this.buttonExit.Text = "Thoát";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new global::System.EventHandler(this.buttonExit_Click);
			this.buttonDelete.Location = new global::System.Drawing.Point(201, 444);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new global::System.Drawing.Size(75, 26);
			this.buttonDelete.TabIndex = 5;
			this.buttonDelete.Text = "Xóa";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new global::System.EventHandler(this.buttonDelete_Click);
			this.buttonAddNew.Location = new global::System.Drawing.Point(36, 444);
			this.buttonAddNew.Name = "buttonAddNew";
			this.buttonAddNew.Size = new global::System.Drawing.Size(75, 26);
			this.buttonAddNew.TabIndex = 4;
			this.buttonAddNew.Text = "Mới";
			this.buttonAddNew.UseVisualStyleBackColor = true;
			this.buttonAddNew.Click += new global::System.EventHandler(this.buttonAddNew_Click);
			this.buttonSave.Location = new global::System.Drawing.Point(120, 476);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new global::System.Drawing.Size(75, 26);
			this.buttonSave.TabIndex = 3;
			this.buttonSave.Text = "Lưu";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new global::System.EventHandler(this.buttonUpdate_Click);
			this.listBoxMauSieuAm.FormattingEnabled = true;
			this.listBoxMauSieuAm.Location = new global::System.Drawing.Point(9, 90);
			this.listBoxMauSieuAm.Name = "listBoxMauSieuAm";
			this.listBoxMauSieuAm.Size = new global::System.Drawing.Size(300, 329);
			this.listBoxMauSieuAm.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 32);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(80, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nhóm siêu âm :";
			this.comboBoxNhomSieuAm.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxNhomSieuAm.FormattingEnabled = true;
			this.comboBoxNhomSieuAm.Location = new global::System.Drawing.Point(92, 29);
			this.comboBoxNhomSieuAm.Name = "comboBoxNhomSieuAm";
			this.comboBoxNhomSieuAm.Size = new global::System.Drawing.Size(217, 21);
			this.comboBoxNhomSieuAm.TabIndex = 0;
			this.groupBox2.Controls.Add(this.checkBoxTamNgung);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.richTextBoxGhiChu);
			this.groupBox2.Controls.Add(this.richTextBoxKetLuan);
			this.groupBox2.Controls.Add(this.textBoxTitleReport);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBoxTitleAlias);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.richTextBoxExtendedMoTa);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new global::System.Drawing.Point(333, 11);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(671, 648);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "NỘI DUNG MẪU KẾT QUẢ";
			this.checkBoxTamNgung.AutoSize = true;
			this.checkBoxTamNgung.CheckAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxTamNgung.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.checkBoxTamNgung.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.checkBoxTamNgung.Location = new global::System.Drawing.Point(574, 48);
			this.checkBoxTamNgung.Name = "checkBoxTamNgung";
			this.checkBoxTamNgung.Size = new global::System.Drawing.Size(89, 17);
			this.checkBoxTamNgung.TabIndex = 20;
			this.checkBoxTamNgung.Text = "Tạm ngưng";
			this.checkBoxTamNgung.UseVisualStyleBackColor = true;
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.label7.Location = new global::System.Drawing.Point(8, 581);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(57, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "Lời dặn :";
			this.richTextBoxGhiChu.Font = new global::System.Drawing.Font("Times New Roman", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBoxGhiChu.Location = new global::System.Drawing.Point(9, 597);
			this.richTextBoxGhiChu.Name = "richTextBoxGhiChu";
			this.richTextBoxGhiChu.Size = new global::System.Drawing.Size(654, 40);
			this.richTextBoxGhiChu.TabIndex = 17;
			this.richTextBoxGhiChu.Text = "";
			this.richTextBoxKetLuan.Font = new global::System.Drawing.Font("Times New Roman", 12.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBoxKetLuan.Location = new global::System.Drawing.Point(9, 522);
			this.richTextBoxKetLuan.Name = "richTextBoxKetLuan";
			this.richTextBoxKetLuan.Size = new global::System.Drawing.Size(654, 56);
			this.richTextBoxKetLuan.TabIndex = 16;
			this.richTextBoxKetLuan.Text = "";
			this.textBoxTitleReport.Location = new global::System.Drawing.Point(107, 19);
			this.textBoxTitleReport.Name = "textBoxTitleReport";
			this.textBoxTitleReport.Size = new global::System.Drawing.Size(556, 20);
			this.textBoxTitleReport.TabIndex = 15;
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.label6.Location = new global::System.Drawing.Point(6, 22);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(101, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Tiêu đề Report :";
			this.textBoxTitleAlias.Location = new global::System.Drawing.Point(107, 45);
			this.textBoxTitleAlias.Name = "textBoxTitleAlias";
			this.textBoxTitleAlias.Size = new global::System.Drawing.Size(461, 20);
			this.textBoxTitleAlias.TabIndex = 13;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.label5.Location = new global::System.Drawing.Point(6, 48);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(99, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Tiêu đề Combox";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.label4.Location = new global::System.Drawing.Point(6, 506);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(62, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Kết luận :";
			this.richTextBoxExtendedMoTa.AcceptsTab = false;
			this.richTextBoxExtendedMoTa.AutoWordSelection = true;
			this.richTextBoxExtendedMoTa.DetectURLs = true;
			this.richTextBoxExtendedMoTa.Location = new global::System.Drawing.Point(9, 91);
			this.richTextBoxExtendedMoTa.Name = "richTextBoxExtendedMoTa";
			this.richTextBoxExtendedMoTa.ReadOnly = false;
			this.richTextBoxExtendedMoTa.RichTextBox.AutoWordSelection = true;
			this.richTextBoxExtendedMoTa.RichTextBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.richTextBoxExtendedMoTa.RichTextBox.Location = new global::System.Drawing.Point(0, 26);
			this.richTextBoxExtendedMoTa.RichTextBox.Name = "rtb1";
			this.richTextBoxExtendedMoTa.RichTextBox.Size = new global::System.Drawing.Size(654, 386);
			this.richTextBoxExtendedMoTa.RichTextBox.TabIndex = 1;
			this.richTextBoxExtendedMoTa.ShowBold = true;
			this.richTextBoxExtendedMoTa.ShowCenterJustify = true;
			this.richTextBoxExtendedMoTa.ShowColors = true;
			this.richTextBoxExtendedMoTa.ShowCopy = true;
			this.richTextBoxExtendedMoTa.ShowCut = true;
			this.richTextBoxExtendedMoTa.ShowFont = true;
			this.richTextBoxExtendedMoTa.ShowFontSize = true;
			this.richTextBoxExtendedMoTa.ShowItalic = true;
			this.richTextBoxExtendedMoTa.ShowLeftJustify = true;
			this.richTextBoxExtendedMoTa.ShowOpen = true;
			this.richTextBoxExtendedMoTa.ShowPaste = true;
			this.richTextBoxExtendedMoTa.ShowRedo = true;
			this.richTextBoxExtendedMoTa.ShowRightJustify = true;
			this.richTextBoxExtendedMoTa.ShowSave = true;
			this.richTextBoxExtendedMoTa.ShowStamp = true;
			this.richTextBoxExtendedMoTa.ShowStrikeout = true;
			this.richTextBoxExtendedMoTa.ShowToolBarText = false;
			this.richTextBoxExtendedMoTa.ShowUnderline = true;
			this.richTextBoxExtendedMoTa.ShowUndo = true;
			this.richTextBoxExtendedMoTa.Size = new global::System.Drawing.Size(654, 412);
			this.richTextBoxExtendedMoTa.StampAction = global::SKCDExtCtrl.RichTextBoxExt.StampActions.EditedBy;
			this.richTextBoxExtendedMoTa.StampColor = global::System.Drawing.Color.Blue;
			this.richTextBoxExtendedMoTa.TabIndex = 9;
			this.richTextBoxExtendedMoTa.Toolbar.Appearance = global::System.Windows.Forms.ToolBarAppearance.Flat;
			this.richTextBoxExtendedMoTa.Toolbar.ButtonSize = new global::System.Drawing.Size(16, 16);
			this.richTextBoxExtendedMoTa.Toolbar.Divider = false;
			this.richTextBoxExtendedMoTa.Toolbar.DropDownArrows = true;
			this.richTextBoxExtendedMoTa.Toolbar.Location = new global::System.Drawing.Point(0, 0);
			this.richTextBoxExtendedMoTa.Toolbar.Name = "tb1";
			this.richTextBoxExtendedMoTa.Toolbar.ShowToolTips = true;
			this.richTextBoxExtendedMoTa.Toolbar.Size = new global::System.Drawing.Size(654, 26);
			this.richTextBoxExtendedMoTa.Toolbar.TabIndex = 0;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.label3.Location = new global::System.Drawing.Point(6, 75);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(47, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Mô tả :";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1016, 671);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Name = "CapNhatMauNoiDung";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cập nhật mẫu kết quả siêu âm";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.CapNhatMauNoiDung_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000013 RID: 19
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.ComboBox comboBoxNhomSieuAm;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ListBox listBoxMauSieuAm;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button buttonSave;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Button buttonAddNew;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Button buttonDelete;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Button buttonExit;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400001F RID: 31
		private global::SKCDExtCtrl.RichTextBoxExt richTextBoxExtendedMoTa;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.TextBox textBoxTitleAlias;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.RichTextBox richTextBoxKetLuan;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.TextBox textBoxTitleReport;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.RichTextBox richTextBoxGhiChu;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.CheckBox checkBoxTamNgung;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Button buttonEdit;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Button buttonCancel;
	}
}
