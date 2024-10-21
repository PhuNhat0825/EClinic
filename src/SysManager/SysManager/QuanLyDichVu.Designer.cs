namespace SysManager
{
	// Token: 0x02000006 RID: 6
	public partial class QuanLyDichVu : global::System.Windows.Forms.Form
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00005034 File Offset: 0x00004034
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000506C File Offset: 0x0000406C
		private void InitializeComponent()
		{
			this.comboBoxNhomDichVu = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.dataGridViewDsDichVu = new global::System.Windows.Forms.DataGridView();
			this.dataGridViewDonGiaDichVu = new global::System.Windows.Forms.DataGridView();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewDsDichVu).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewDonGiaDichVu).BeginInit();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.comboBoxNhomDichVu.Enabled = false;
			this.comboBoxNhomDichVu.FormattingEnabled = true;
			this.comboBoxNhomDichVu.Location = new global::System.Drawing.Point(15, 25);
			this.comboBoxNhomDichVu.Name = "comboBoxNhomDichVu";
			this.comboBoxNhomDichVu.Size = new global::System.Drawing.Size(182, 21);
			this.comboBoxNhomDichVu.TabIndex = 0;
			this.comboBoxNhomDichVu.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxNhomDichVu_SelectedIndexChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(79, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nhóm dịch vụ :";
			this.dataGridViewDsDichVu.AllowUserToOrderColumns = true;
			this.dataGridViewDsDichVu.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDsDichVu.Location = new global::System.Drawing.Point(12, 85);
			this.dataGridViewDsDichVu.Name = "dataGridViewDsDichVu";
			this.dataGridViewDsDichVu.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridViewDsDichVu.RowTemplate.DefaultCellStyle.NullValue = null;
			this.dataGridViewDsDichVu.ShowCellErrors = false;
			this.dataGridViewDsDichVu.Size = new global::System.Drawing.Size(607, 485);
			this.dataGridViewDsDichVu.TabIndex = 0;
			this.dataGridViewDonGiaDichVu.AllowUserToOrderColumns = true;
			this.dataGridViewDonGiaDichVu.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDonGiaDichVu.Location = new global::System.Drawing.Point(625, 85);
			this.dataGridViewDonGiaDichVu.Name = "dataGridViewDonGiaDichVu";
			this.dataGridViewDonGiaDichVu.ShowCellErrors = false;
			this.dataGridViewDonGiaDichVu.Size = new global::System.Drawing.Size(368, 485);
			this.dataGridViewDonGiaDichVu.TabIndex = 1;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(9, 69);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(103, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Danh sách dịch vụ :";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(622, 69);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(88, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Đơn giá dịch vụ :";
			this.button1.Location = new global::System.Drawing.Point(221, 21);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(61, 25);
			this.button1.TabIndex = 2;
			this.button1.Text = "Tạo &mới";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.buttonOK.Location = new global::System.Drawing.Point(295, 21);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(61, 25);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "&Lưu";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new global::System.EventHandler(this.buttonOK_Click);
			this.buttonCancel.Location = new global::System.Drawing.Point(369, 22);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(61, 25);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "&Thoát";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new global::System.EventHandler(this.buttonCancel_Click);
			this.panel1.Controls.Add(this.dataGridViewDsDichVu);
			this.panel1.Controls.Add(this.dataGridViewDonGiaDichVu);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.buttonCancel);
			this.panel1.Controls.Add(this.comboBoxNhomDichVu);
			this.panel1.Controls.Add(this.buttonOK);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(1005, 582);
			this.panel1.TabIndex = 9;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1005, 582);
			base.Controls.Add(this.panel1);
			base.Name = "QuanLyDichVu";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "QuanLyDichVu";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.QuanLyDichVu_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewDsDichVu).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewDonGiaDichVu).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000033 RID: 51
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.ComboBox comboBoxNhomDichVu;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.DataGridView dataGridViewDonGiaDichVu;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.DataGridView dataGridViewDsDichVu;
	}
}
