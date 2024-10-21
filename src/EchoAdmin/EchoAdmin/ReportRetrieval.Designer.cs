namespace EchoAdmin
{
	// Token: 0x02000006 RID: 6
	public partial class ReportRetrieval : global::System.Windows.Forms.Form
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000048BC File Offset: 0x000038BC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000048F4 File Offset: 0x000038F4
		private void InitializeComponent()
		{
			this.buttonInLaiKQ = new global::System.Windows.Forms.Button();
			this.buttonCapnhatKQ = new global::System.Windows.Forms.Button();
			this.buttonThoat = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.comboLoaiSA = new global::System.Windows.Forms.ComboBox();
			this.dtpDenNgay = new global::System.Windows.Forms.DateTimePicker();
			this.dtpTuNgay = new global::System.Windows.Forms.DateTimePicker();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.checkThoigianSA = new global::System.Windows.Forms.CheckBox();
			this.textBoxHotenBN = new global::System.Windows.Forms.TextBox();
			this.textBoxMaBN = new global::System.Windows.Forms.TextBox();
			this.checkLoaiSA = new global::System.Windows.Forms.CheckBox();
			this.checkMaSoBN = new global::System.Windows.Forms.CheckBox();
			this.checkHotenBN = new global::System.Windows.Forms.CheckBox();
			this.buttonTim = new global::System.Windows.Forms.Button();
			this.outlookGridKQ = new global::SKCDExtCtrl.OutlookGrid();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.outlookGridKQ).BeginInit();
			base.SuspendLayout();
			this.buttonInLaiKQ.Location = new global::System.Drawing.Point(189, 124);
			this.buttonInLaiKQ.Name = "buttonInLaiKQ";
			this.buttonInLaiKQ.Size = new global::System.Drawing.Size(116, 23);
			this.buttonInLaiKQ.TabIndex = 2;
			this.buttonInLaiKQ.Text = "&In lại kết quả";
			this.buttonInLaiKQ.UseVisualStyleBackColor = true;
			this.buttonInLaiKQ.Click += new global::System.EventHandler(this.buttonInLaiKQ_Click);
			this.buttonCapnhatKQ.Location = new global::System.Drawing.Point(311, 124);
			this.buttonCapnhatKQ.Name = "buttonCapnhatKQ";
			this.buttonCapnhatKQ.Size = new global::System.Drawing.Size(166, 23);
			this.buttonCapnhatKQ.TabIndex = 3;
			this.buttonCapnhatKQ.Text = "&Cập nhật thông tin kết quả";
			this.buttonCapnhatKQ.UseVisualStyleBackColor = true;
			this.buttonCapnhatKQ.Click += new global::System.EventHandler(this.buttonCapnhatKQ_Click);
			this.buttonThoat.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonThoat.Location = new global::System.Drawing.Point(483, 124);
			this.buttonThoat.Name = "buttonThoat";
			this.buttonThoat.Size = new global::System.Drawing.Size(75, 23);
			this.buttonThoat.TabIndex = 4;
			this.buttonThoat.Text = "&Thoát";
			this.buttonThoat.UseVisualStyleBackColor = true;
			this.buttonThoat.Click += new global::System.EventHandler(this.buttonThoat_Click);
			this.groupBox1.Controls.Add(this.comboLoaiSA);
			this.groupBox1.Controls.Add(this.dtpDenNgay);
			this.groupBox1.Controls.Add(this.dtpTuNgay);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.checkThoigianSA);
			this.groupBox1.Controls.Add(this.textBoxHotenBN);
			this.groupBox1.Controls.Add(this.textBoxMaBN);
			this.groupBox1.Controls.Add(this.checkLoaiSA);
			this.groupBox1.Controls.Add(this.checkMaSoBN);
			this.groupBox1.Controls.Add(this.checkHotenBN);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(681, 106);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Điều kiện tìm kiếm";
			this.comboLoaiSA.Enabled = false;
			this.comboLoaiSA.FormattingEnabled = true;
			this.comboLoaiSA.Location = new global::System.Drawing.Point(131, 72);
			this.comboLoaiSA.Name = "comboLoaiSA";
			this.comboLoaiSA.Size = new global::System.Drawing.Size(198, 21);
			this.comboLoaiSA.TabIndex = 9;
			this.comboLoaiSA.SelectedIndexChanged += new global::System.EventHandler(this.comboLoaiSA_SelectedIndexChanged);
			this.dtpDenNgay.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
			this.dtpDenNgay.Enabled = false;
			this.dtpDenNgay.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDenNgay.Location = new global::System.Drawing.Point(421, 71);
			this.dtpDenNgay.Name = "dtpDenNgay";
			this.dtpDenNgay.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.dtpDenNgay.Size = new global::System.Drawing.Size(168, 20);
			this.dtpDenNgay.TabIndex = 8;
			this.dtpTuNgay.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
			this.dtpTuNgay.Enabled = false;
			this.dtpTuNgay.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTuNgay.Location = new global::System.Drawing.Point(421, 46);
			this.dtpTuNgay.Name = "dtpTuNgay";
			this.dtpTuNgay.Size = new global::System.Drawing.Size(168, 20);
			this.dtpTuNgay.TabIndex = 7;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(388, 74);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(27, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Đến";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(392, 50);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(23, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Từ ";
			this.checkThoigianSA.AutoSize = true;
			this.checkThoigianSA.Location = new global::System.Drawing.Point(373, 18);
			this.checkThoigianSA.Name = "checkThoigianSA";
			this.checkThoigianSA.Size = new global::System.Drawing.Size(214, 17);
			this.checkThoigianSA.TabIndex = 6;
			this.checkThoigianSA.Text = "Thời gian Siêu âm : [Ngày/Tháng/Năm]";
			this.checkThoigianSA.UseVisualStyleBackColor = true;
			this.checkThoigianSA.CheckedChanged += new global::System.EventHandler(this.checkThoigianSA_CheckedChanged);
			this.textBoxHotenBN.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxHotenBN.Enabled = false;
			this.textBoxHotenBN.Location = new global::System.Drawing.Point(131, 44);
			this.textBoxHotenBN.Name = "textBoxHotenBN";
			this.textBoxHotenBN.Size = new global::System.Drawing.Size(198, 20);
			this.textBoxHotenBN.TabIndex = 3;
			this.textBoxMaBN.Enabled = false;
			this.textBoxMaBN.Location = new global::System.Drawing.Point(131, 18);
			this.textBoxMaBN.Name = "textBoxMaBN";
			this.textBoxMaBN.Size = new global::System.Drawing.Size(99, 20);
			this.textBoxMaBN.TabIndex = 1;
			this.textBoxMaBN.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.checkLoaiSA.AutoSize = true;
			this.checkLoaiSA.Location = new global::System.Drawing.Point(6, 72);
			this.checkLoaiSA.Name = "checkLoaiSA";
			this.checkLoaiSA.Size = new global::System.Drawing.Size(93, 17);
			this.checkLoaiSA.TabIndex = 4;
			this.checkLoaiSA.Text = "Loại Siêu âm :";
			this.checkLoaiSA.UseVisualStyleBackColor = true;
			this.checkLoaiSA.CheckedChanged += new global::System.EventHandler(this.checkLoaiSA_CheckedChanged);
			this.checkMaSoBN.AutoSize = true;
			this.checkMaSoBN.Location = new global::System.Drawing.Point(6, 19);
			this.checkMaSoBN.Name = "checkMaSoBN";
			this.checkMaSoBN.Size = new global::System.Drawing.Size(115, 17);
			this.checkMaSoBN.TabIndex = 0;
			this.checkMaSoBN.Text = "Mã số bệnh nhân :";
			this.checkMaSoBN.UseVisualStyleBackColor = true;
			this.checkMaSoBN.CheckedChanged += new global::System.EventHandler(this.checkMaSoBN_CheckedChanged);
			this.checkHotenBN.AutoSize = true;
			this.checkHotenBN.Location = new global::System.Drawing.Point(6, 46);
			this.checkHotenBN.Name = "checkHotenBN";
			this.checkHotenBN.Size = new global::System.Drawing.Size(119, 17);
			this.checkHotenBN.TabIndex = 2;
			this.checkHotenBN.Text = "Họ tên Bệnh nhân :";
			this.checkHotenBN.UseVisualStyleBackColor = true;
			this.checkHotenBN.CheckedChanged += new global::System.EventHandler(this.checkHotenBN_CheckedChanged);
			this.buttonTim.Location = new global::System.Drawing.Point(108, 124);
			this.buttonTim.Name = "buttonTim";
			this.buttonTim.Size = new global::System.Drawing.Size(75, 23);
			this.buttonTim.TabIndex = 1;
			this.buttonTim.Text = "Tìm";
			this.buttonTim.UseVisualStyleBackColor = true;
			this.buttonTim.Click += new global::System.EventHandler(this.buttonTim_Click);
			this.outlookGridKQ.AllowUserToAddRows = false;
			this.outlookGridKQ.AllowUserToDeleteRows = false;
			this.outlookGridKQ.CollapseIcon = null;
			this.outlookGridKQ.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.outlookGridKQ.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.outlookGridKQ.ExpandIcon = null;
			this.outlookGridKQ.Location = new global::System.Drawing.Point(12, 153);
			this.outlookGridKQ.MultiSelect = false;
			this.outlookGridKQ.Name = "outlookGridKQ";
			this.outlookGridKQ.ReadOnly = true;
			this.outlookGridKQ.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.outlookGridKQ.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.outlookGridKQ.Size = new global::System.Drawing.Size(681, 297);
			this.outlookGridKQ.TabIndex = 0;
			this.outlookGridKQ.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.outlookGridKQ_CellClick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(705, 462);
			base.Controls.Add(this.buttonTim);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.buttonThoat);
			base.Controls.Add(this.buttonCapnhatKQ);
			base.Controls.Add(this.buttonInLaiKQ);
			base.Controls.Add(this.outlookGridKQ);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ReportRetrieval";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "eClinic - Lấy Kết Quả Siêu Âm";
			base.Load += new global::System.EventHandler(this.ReportRetrieval_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.outlookGridKQ).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000032 RID: 50
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000033 RID: 51
		private global::SKCDExtCtrl.OutlookGrid outlookGridKQ;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Button buttonInLaiKQ;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Button buttonCapnhatKQ;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Button buttonThoat;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.CheckBox checkLoaiSA;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.CheckBox checkMaSoBN;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.CheckBox checkHotenBN;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.TextBox textBoxHotenBN;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.TextBox textBoxMaBN;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.CheckBox checkThoigianSA;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.DateTimePicker dtpDenNgay;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.DateTimePicker dtpTuNgay;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Button buttonTim;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.ComboBox comboLoaiSA;
	}
}
