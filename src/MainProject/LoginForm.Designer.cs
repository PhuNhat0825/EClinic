using System.ComponentModel;

namespace MainProject
{
	// Token: 0x02000004 RID: 4
	public partial class LoginForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00004ED8 File Offset: 0x00003ED8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004F10 File Offset: 0x00003F10
		private void InitializeComponent()
		{
			var resources = new ComponentResourceManager(typeof(LoginForm));
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.textBoxPassword = new global::SKCDExtCtrl.AutoTabTextBox();
			this.textBoxUserID = new global::SKCDExtCtrl.AutoTabTextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.buttonOK.Location = new global::System.Drawing.Point(46, 168);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(82, 30);
			this.buttonOK.TabIndex = 11;
			this.buttonOK.Text = "Đăng nhập";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new global::System.EventHandler(this.buttonOK_Click);
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(215, 168);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(82, 31);
			this.buttonCancel.TabIndex = 12;
			this.buttonCancel.Text = "Hủy bỏ";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new global::System.EventHandler(this.buttonCancel_Click);
			this.textBoxPassword.ChangeColorWhenFocus = true;
			this.textBoxPassword.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 128);
			this.textBoxPassword.Location = new global::System.Drawing.Point(125, 79);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new global::System.Drawing.Size(172, 26);
			this.textBoxPassword.TabIndex = 10;
			this.textBoxPassword.UseSystemPasswordChar = true;
			this.textBoxUserID.ChangeColorWhenFocus = true;
			this.textBoxUserID.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxUserID.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBoxUserID.Location = new global::System.Drawing.Point(125, 47);
			this.textBoxUserID.Name = "textBoxUserID";
			this.textBoxUserID.Size = new global::System.Drawing.Size(172, 26);
			this.textBoxUserID.TabIndex = 9;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 128);
			this.label2.Location = new global::System.Drawing.Point(43, 79);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(64, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Mật khẩu:";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 128);
			this.label1.Location = new global::System.Drawing.Point(43, 47);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(56, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Bí danh:";
			this.pictureBox1.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			this.pictureBox1.InitialImage = (global::System.Drawing.Image)resources.GetObject("pictureBox1.InitialImage");
			this.pictureBox1.Location = new global::System.Drawing.Point(150, 119);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(73, 68);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(354, 234);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.textBoxPassword);
			base.Controls.Add(this.textBoxUserID);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "LoginForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "eClinic - Đăng Nhập";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400004A RID: 74
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x0400004D RID: 77
		private global::SKCDExtCtrl.AutoTabTextBox textBoxPassword;

		// Token: 0x0400004E RID: 78
		private global::SKCDExtCtrl.AutoTabTextBox textBoxUserID;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
