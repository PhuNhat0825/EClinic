namespace MainProject
{
	// Token: 0x02000008 RID: 8
	public partial class ChangePasswordForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000062 RID: 98 RVA: 0x000077F8 File Offset: 0x000067F8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007830 File Offset: 0x00006830
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.buttonDoiMK = new global::System.Windows.Forms.Button();
			this.buttonHuyBo = new global::System.Windows.Forms.Button();
			this.textBoxMKMoi = new global::SKCDExtCtrl.AutoTabTextBox();
			this.textBoxGoLaiMK = new global::SKCDExtCtrl.AutoTabTextBox();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(20, 57);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(87, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mật khẩu mới:";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(20, 95);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(123, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Gõ lại mật khẩu mới:";
			this.buttonDoiMK.Location = new global::System.Drawing.Point(77, 142);
			this.buttonDoiMK.Name = "buttonDoiMK";
			this.buttonDoiMK.Size = new global::System.Drawing.Size(80, 28);
			this.buttonDoiMK.TabIndex = 2;
			this.buttonDoiMK.Text = "Đổi mật khẩu";
			this.buttonDoiMK.UseVisualStyleBackColor = true;
			this.buttonDoiMK.Click += new global::System.EventHandler(this.buttonDoiMK_Click);
			this.buttonHuyBo.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonHuyBo.Location = new global::System.Drawing.Point(163, 142);
			this.buttonHuyBo.Name = "buttonHuyBo";
			this.buttonHuyBo.Size = new global::System.Drawing.Size(81, 28);
			this.buttonHuyBo.TabIndex = 3;
			this.buttonHuyBo.Text = "Hủy bỏ";
			this.buttonHuyBo.UseVisualStyleBackColor = true;
			this.buttonHuyBo.Click += new global::System.EventHandler(this.buttonHuyBo_Click);
			this.textBoxMKMoi.ChangeColorWhenFocus = false;
			this.textBoxMKMoi.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxMKMoi.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBoxMKMoi.Location = new global::System.Drawing.Point(146, 52);
			this.textBoxMKMoi.Name = "textBoxMKMoi";
			this.textBoxMKMoi.PasswordChar = '*';
			this.textBoxMKMoi.Size = new global::System.Drawing.Size(130, 22);
			this.textBoxMKMoi.TabIndex = 0;
			this.textBoxMKMoi.UseSystemPasswordChar = true;
			this.textBoxMKMoi.TextChanged += new global::System.EventHandler(this.textBoxMKMoi_TextChanged);
			this.textBoxGoLaiMK.ChangeColorWhenFocus = false;
			this.textBoxGoLaiMK.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBoxGoLaiMK.Location = new global::System.Drawing.Point(146, 88);
			this.textBoxGoLaiMK.Name = "textBoxGoLaiMK";
			this.textBoxGoLaiMK.PasswordChar = '*';
			this.textBoxGoLaiMK.Size = new global::System.Drawing.Size(130, 22);
			this.textBoxGoLaiMK.TabIndex = 1;
			this.textBoxGoLaiMK.UseSystemPasswordChar = true;
			base.AcceptButton = this.buttonDoiMK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonHuyBo;
			base.ClientSize = new global::System.Drawing.Size(317, 195);
			base.ControlBox = false;
			base.Controls.Add(this.textBoxGoLaiMK);
			base.Controls.Add(this.textBoxMKMoi);
			base.Controls.Add(this.buttonHuyBo);
			base.Controls.Add(this.buttonDoiMK);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.KeyPreview = true;
			base.Name = "ChangePasswordForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "eClinic - Đổi mật khẩu";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000073 RID: 115
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.Button buttonDoiMK;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Button buttonHuyBo;

		// Token: 0x04000078 RID: 120
		private global::SKCDExtCtrl.AutoTabTextBox textBoxMKMoi;

		// Token: 0x04000079 RID: 121
		private global::SKCDExtCtrl.AutoTabTextBox textBoxGoLaiMK;
	}
}
