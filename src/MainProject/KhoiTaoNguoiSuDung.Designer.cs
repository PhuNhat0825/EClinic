namespace MainProject
{
	// Token: 0x02000005 RID: 5
	public partial class KhoiTaoNguoiSuDung : global::System.Windows.Forms.Form
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00005498 File Offset: 0x00004498
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000054D0 File Offset: 0x000044D0
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.labelNhanVienID = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.labelHoTen = new global::System.Windows.Forms.Label();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.textBoxUserName = new global::SKCDExtCtrl.AutoTabTextBox();
			this.textBoxPassword = new global::SKCDExtCtrl.AutoTabTextBox();
			this.checkBoxTamNgung = new global::System.Windows.Forms.CheckBox();
			this.label5 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(44, 42);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(83, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nhan Vien ID";
			this.labelNhanVienID.AutoSize = true;
			this.labelNhanVienID.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelNhanVienID.ForeColor = global::System.Drawing.Color.Red;
			this.labelNhanVienID.Location = new global::System.Drawing.Point(141, 42);
			this.labelNhanVienID.Name = "labelNhanVienID";
			this.labelNhanVienID.Size = new global::System.Drawing.Size(83, 13);
			this.labelNhanVienID.TabIndex = 8;
			this.labelNhanVienID.Text = "Nhan Vien ID";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(44, 67);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(49, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Họ Tên";
			this.labelHoTen.AutoSize = true;
			this.labelHoTen.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelHoTen.ForeColor = global::System.Drawing.Color.Red;
			this.labelHoTen.Location = new global::System.Drawing.Point(141, 67);
			this.labelHoTen.Name = "labelHoTen";
			this.labelHoTen.Size = new global::System.Drawing.Size(83, 13);
			this.labelHoTen.TabIndex = 9;
			this.labelHoTen.Text = "Nhan Vien ID";
			this.buttonOK.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonOK.Location = new global::System.Drawing.Point(96, 193);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 29);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "&OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new global::System.EventHandler(this.buttonOK_Click);
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonCancel.Location = new global::System.Drawing.Point(196, 193);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 29);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new global::System.EventHandler(this.buttonCancel_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(44, 98);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(94, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Tên đăng nhập";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(44, 127);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(60, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Mật khẩu";
			this.textBoxUserName.ChangeColorWhenFocus = false;
			this.textBoxUserName.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxUserName.Location = new global::System.Drawing.Point(144, 95);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new global::System.Drawing.Size(192, 20);
			this.textBoxUserName.TabIndex = 0;
			this.textBoxPassword.ChangeColorWhenFocus = false;
			this.textBoxPassword.Location = new global::System.Drawing.Point(144, 124);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new global::System.Drawing.Size(192, 20);
			this.textBoxPassword.TabIndex = 1;
			this.textBoxPassword.UseSystemPasswordChar = true;
			this.checkBoxTamNgung.AutoSize = true;
			this.checkBoxTamNgung.CheckAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxTamNgung.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxTamNgung.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxTamNgung.Location = new global::System.Drawing.Point(247, 38);
			this.checkBoxTamNgung.Name = "checkBoxTamNgung";
			this.checkBoxTamNgung.Size = new global::System.Drawing.Size(89, 17);
			this.checkBoxTamNgung.TabIndex = 10;
			this.checkBoxTamNgung.Text = "Tạm ngưng";
			this.checkBoxTamNgung.UseVisualStyleBackColor = true;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.label5.Location = new global::System.Drawing.Point(47, 158);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(289, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Nếu không thay đổi Mật khẩu thì không nhập mật khẩu mới";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(381, 234);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.checkBoxTamNgung);
			base.Controls.Add(this.textBoxPassword);
			base.Controls.Add(this.textBoxUserName);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.labelHoTen);
			base.Controls.Add(this.labelNhanVienID);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "KhoiTaoNguoiSuDung";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "KHỞI TẠO NGƯỜI ĐĂNG NHẬP";
			base.Load += new global::System.EventHandler(this.NguoiSuDung_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000052 RID: 82
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Label labelNhanVienID;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Label labelHoTen;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400005B RID: 91
		private global::SKCDExtCtrl.AutoTabTextBox textBoxUserName;

		// Token: 0x0400005C RID: 92
		private global::SKCDExtCtrl.AutoTabTextBox textBoxPassword;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.CheckBox checkBoxTamNgung;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.Label label5;
	}
}
