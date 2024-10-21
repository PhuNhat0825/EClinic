namespace ReceptionAdmin
{
	// Token: 0x02000004 RID: 4
	public partial class Payment4Services : global::System.Windows.Forms.Form
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000026B8 File Offset: 0x000016B8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000026F0 File Offset: 0x000016F0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.buttonBoChon = new global::System.Windows.Forms.Button();
			this.buttonChonHet = new global::System.Windows.Forms.Button();
			this.checkedListDSNV = new global::System.Windows.Forms.CheckedListBox();
			this.toolTipMain = new global::System.Windows.Forms.ToolTip(this.components);
			this.buttonThoat = new global::System.Windows.Forms.Button();
			this.buttonCapNhat = new global::System.Windows.Forms.Button();
			this.buttonXemToanBo = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.buttonXoaDichVu = new global::System.Windows.Forms.Button();
			this.outlookGridThongtin = new global::SKCDExtCtrl.OutlookGrid();
			this.multiComboDichvu = new global::SKCDExtCtrl.MultiColumnComboBox();
			this.filterTextTiencong = new global::SKCDExtCtrl.FilterTextBox();
			this.buttonQuanlyDichvu = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.outlookGridThongtin).BeginInit();
			base.SuspendLayout();
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(12, 44);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(84, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tiền công / ca :";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(162, 44);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(38, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "(đồng)";
			this.groupBox1.Controls.Add(this.buttonBoChon);
			this.groupBox1.Controls.Add(this.buttonChonHet);
			this.groupBox1.Controls.Add(this.checkedListDSNV);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 94);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(206, 308);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách nhân viên";
			this.buttonBoChon.Location = new global::System.Drawing.Point(105, 279);
			this.buttonBoChon.Name = "buttonBoChon";
			this.buttonBoChon.Size = new global::System.Drawing.Size(75, 23);
			this.buttonBoChon.TabIndex = 2;
			this.buttonBoChon.Text = "&Bỏ chọn";
			this.toolTipMain.SetToolTip(this.buttonBoChon, "Huỷ chọn toàn bộ nhân viên đã được chọn.");
			this.buttonBoChon.UseVisualStyleBackColor = true;
			this.buttonBoChon.Click += new global::System.EventHandler(this.buttonBoChon_Click);
			this.buttonChonHet.Location = new global::System.Drawing.Point(24, 279);
			this.buttonChonHet.Name = "buttonChonHet";
			this.buttonChonHet.Size = new global::System.Drawing.Size(75, 23);
			this.buttonChonHet.TabIndex = 1;
			this.buttonChonHet.Text = "&Chọn hết";
			this.toolTipMain.SetToolTip(this.buttonChonHet, "Chọn toàn bộ nhân viên trong danh sách");
			this.buttonChonHet.UseVisualStyleBackColor = true;
			this.buttonChonHet.Click += new global::System.EventHandler(this.buttonChonHet_Click);
			this.checkedListDSNV.FormattingEnabled = true;
			this.checkedListDSNV.Location = new global::System.Drawing.Point(6, 19);
			this.checkedListDSNV.Name = "checkedListDSNV";
			this.checkedListDSNV.Size = new global::System.Drawing.Size(194, 259);
			this.checkedListDSNV.TabIndex = 0;
			this.toolTipMain.SetToolTip(this.checkedListDSNV, "Danh sách nhân viên");
			this.checkedListDSNV.SelectedIndexChanged += new global::System.EventHandler(this.checkedListDSNV_SelectedIndexChanged);
			this.buttonThoat.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonThoat.Location = new global::System.Drawing.Point(533, 373);
			this.buttonThoat.Name = "buttonThoat";
			this.buttonThoat.Size = new global::System.Drawing.Size(75, 23);
			this.buttonThoat.TabIndex = 8;
			this.buttonThoat.Text = "Thoát";
			this.toolTipMain.SetToolTip(this.buttonThoat, "Thoát khỏi hệ thống quản lý tiền công dịch vụ");
			this.buttonThoat.UseVisualStyleBackColor = true;
			this.buttonThoat.Click += new global::System.EventHandler(this.buttonThoat_Click);
			this.buttonCapNhat.Location = new global::System.Drawing.Point(156, 19);
			this.buttonCapNhat.Name = "buttonCapNhat";
			this.buttonCapNhat.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCapNhat.TabIndex = 0;
			this.buttonCapNhat.Text = "Cập nhật";
			this.toolTipMain.SetToolTip(this.buttonCapNhat, "Cập nhật tiền dịch vụ của các nhân viên đang được chọn");
			this.buttonCapNhat.UseVisualStyleBackColor = true;
			this.buttonCapNhat.Click += new global::System.EventHandler(this.buttonCapNhat_Click);
			this.buttonXemToanBo.Location = new global::System.Drawing.Point(65, 19);
			this.buttonXemToanBo.Name = "buttonXemToanBo";
			this.buttonXemToanBo.Size = new global::System.Drawing.Size(85, 23);
			this.buttonXemToanBo.TabIndex = 2;
			this.buttonXemToanBo.Text = "Xem toàn bộ";
			this.toolTipMain.SetToolTip(this.buttonXemToanBo, "Xem toàn bộ Tiền dịch vụ của nhân viên");
			this.buttonXemToanBo.UseVisualStyleBackColor = true;
			this.buttonXemToanBo.Click += new global::System.EventHandler(this.buttonXemToanBo_Click);
			this.groupBox2.Controls.Add(this.multiComboDichvu);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.filterTextTiencong);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new global::System.Drawing.Point(12, 17);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(206, 71);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dịch vụ";
			this.groupBox3.Controls.Add(this.buttonXoaDichVu);
			this.groupBox3.Controls.Add(this.buttonXemToanBo);
			this.groupBox3.Controls.Add(this.outlookGridThongtin);
			this.groupBox3.Controls.Add(this.buttonCapNhat);
			this.groupBox3.Location = new global::System.Drawing.Point(224, 17);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(384, 353);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thông tin giá tiền dịch vụ";
			this.buttonXoaDichVu.Location = new global::System.Drawing.Point(237, 19);
			this.buttonXoaDichVu.Name = "buttonXoaDichVu";
			this.buttonXoaDichVu.Size = new global::System.Drawing.Size(85, 23);
			this.buttonXoaDichVu.TabIndex = 3;
			this.buttonXoaDichVu.Text = "Xoá dịch vụ";
			this.toolTipMain.SetToolTip(this.buttonXoaDichVu, "Xoá dịch vụ của nhân viên đang được chọn trong danh sách");
			this.buttonXoaDichVu.UseVisualStyleBackColor = true;
			this.buttonXoaDichVu.Click += new global::System.EventHandler(this.buttonXoaDichVu_Click);
			this.outlookGridThongtin.AllowUserToAddRows = false;
			this.outlookGridThongtin.AllowUserToDeleteRows = false;
			this.outlookGridThongtin.CollapseIcon = null;
			this.outlookGridThongtin.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.outlookGridThongtin.ExpandIcon = null;
			this.outlookGridThongtin.Location = new global::System.Drawing.Point(6, 48);
			this.outlookGridThongtin.Name = "outlookGridThongtin";
			this.outlookGridThongtin.Size = new global::System.Drawing.Size(372, 299);
			this.outlookGridThongtin.TabIndex = 1;
			this.outlookGridThongtin.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.outlookGridThongtin_CellClick);
			this.multiComboDichvu.DropDownHeight = 1;
			this.multiComboDichvu.FormattingEnabled = true;
			this.multiComboDichvu.IntegralHeight = false;
			this.multiComboDichvu.Location = new global::System.Drawing.Point(15, 16);
			this.multiComboDichvu.MaxDropDownItems = 1;
			this.multiComboDichvu.Name = "multiComboDichvu";
			this.multiComboDichvu.SelectedValue = null;
			this.multiComboDichvu.Size = new global::System.Drawing.Size(185, 21);
			this.multiComboDichvu.TabIndex = 1;
			this.toolTipMain.SetToolTip(this.multiComboDichvu, "Danh sách các dịch vụ của Hệ thống");
			this.filterTextTiencong.Location = new global::System.Drawing.Point(94, 41);
			this.filterTextTiencong.MustContain = ".0123456789";
			this.filterTextTiencong.Name = "filterTextTiencong";
			this.filterTextTiencong.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.filterTextTiencong.Size = new global::System.Drawing.Size(62, 20);
			this.filterTextTiencong.TabIndex = 2;
			this.filterTextTiencong.Text = "1000";
			this.toolTipMain.SetToolTip(this.filterTextTiencong, "Giá tiền công cho 1 ca ứng với dịch vụ trên");
			this.buttonQuanlyDichvu.Location = new global::System.Drawing.Point(224, 379);
			this.buttonQuanlyDichvu.Name = "buttonQuanlyDichvu";
			this.buttonQuanlyDichvu.Size = new global::System.Drawing.Size(124, 23);
			this.buttonQuanlyDichvu.TabIndex = 4;
			this.buttonQuanlyDichvu.Text = "Quản lý loại Dịch vụ ..";
			this.buttonQuanlyDichvu.UseVisualStyleBackColor = true;
			this.buttonQuanlyDichvu.Click += new global::System.EventHandler(this.buttonQuanlyDichvu_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(620, 414);
			base.Controls.Add(this.buttonQuanlyDichvu);
			base.Controls.Add(this.buttonThoat);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Payment4Services2";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "eClinic - Quản Lý Tiền Công Dịch Vụ";
			base.Load += new global::System.EventHandler(this.Payment4Services2_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.outlookGridThongtin).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000009 RID: 9
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400000A RID: 10
		private global::SKCDExtCtrl.MultiColumnComboBox multiComboDichvu;

		// Token: 0x0400000B RID: 11
		private global::SKCDExtCtrl.FilterTextBox filterTextTiencong;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Button buttonBoChon;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Button buttonChonHet;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.CheckedListBox checkedListDSNV;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.ToolTip toolTipMain;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Button buttonThoat;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Button buttonXemToanBo;

		// Token: 0x04000017 RID: 23
		private global::SKCDExtCtrl.OutlookGrid outlookGridThongtin;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button buttonCapNhat;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Button buttonXoaDichVu;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Button buttonQuanlyDichvu;
	}
}
