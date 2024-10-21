namespace MainProject
{
	// Token: 0x02000003 RID: 3
	public partial class NguoiSuDung : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003E RID: 62 RVA: 0x000048C8 File Offset: 0x000038C8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004900 File Offset: 0x00003900
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.buttonChangePassword = new global::System.Windows.Forms.Button();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.buttonPhanQuyen = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Blue;
			this.label1.Location = new global::System.Drawing.Point(345, 18);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(196, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "DANH SÁCH NGƯỜI DÙNG";
			this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new global::System.Drawing.Point(12, 51);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new global::System.Drawing.Size(842, 432);
			this.dataGridView1.TabIndex = 1;
			this.buttonChangePassword.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.buttonChangePassword.Location = new global::System.Drawing.Point(297, 508);
			this.buttonChangePassword.Name = "buttonChangePassword";
			this.buttonChangePassword.Size = new global::System.Drawing.Size(103, 30);
			this.buttonChangePassword.TabIndex = 2;
			this.buttonChangePassword.Text = "Đổi mật khẩu";
			this.buttonChangePassword.UseVisualStyleBackColor = true;
			this.buttonChangePassword.Click += new global::System.EventHandler(this.buttonChangePassword_Click);
			this.buttonClose.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonClose.Location = new global::System.Drawing.Point(520, 508);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(100, 30);
			this.buttonClose.TabIndex = 2;
			this.buttonClose.Text = "&Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.buttonPhanQuyen.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonPhanQuyen.Location = new global::System.Drawing.Point(406, 508);
			this.buttonPhanQuyen.Name = "buttonPhanQuyen";
			this.buttonPhanQuyen.Size = new global::System.Drawing.Size(108, 30);
			this.buttonPhanQuyen.TabIndex = 3;
			this.buttonPhanQuyen.Text = "&Phân quyền";
			this.buttonPhanQuyen.UseVisualStyleBackColor = true;
			this.buttonPhanQuyen.Click += new global::System.EventHandler(this.buttonPhanQuyen_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(866, 550);
			base.Controls.Add(this.buttonPhanQuyen);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.buttonChangePassword);
			base.Controls.Add(this.dataGridView1);
			base.Controls.Add(this.label1);
			base.Name = "NguoiSuDung";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Người sử dụng";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.NguoiSuDung_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000043 RID: 67
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Button buttonChangePassword;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Button buttonPhanQuyen;
	}
}
