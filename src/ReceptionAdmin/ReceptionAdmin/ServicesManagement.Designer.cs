namespace ReceptionAdmin
{
	// Token: 0x02000009 RID: 9
	public partial class ServicesManagement : global::System.Windows.Forms.Form
	{
		// Token: 0x0600006D RID: 109 RVA: 0x0000BBF0 File Offset: 0x0000ABF0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000BC28 File Offset: 0x0000AC28
		private void InitializeComponent()
		{
			this.button_CapNhat = new global::System.Windows.Forms.Button();
			this.dataGridView_DichVu = new global::System.Windows.Forms.DataGridView();
			this.label1 = new global::System.Windows.Forms.Label();
			this.buttonThoat = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView_DichVu).BeginInit();
			base.SuspendLayout();
			this.button_CapNhat.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.button_CapNhat.Location = new global::System.Drawing.Point(414, 299);
			this.button_CapNhat.Name = "button_CapNhat";
			this.button_CapNhat.Size = new global::System.Drawing.Size(72, 24);
			this.button_CapNhat.TabIndex = 1;
			this.button_CapNhat.Text = "Cập nhật";
			this.button_CapNhat.UseVisualStyleBackColor = true;
			this.button_CapNhat.Click += new global::System.EventHandler(this.button_CapNhat_Click);
			this.dataGridView_DichVu.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_DichVu.Location = new global::System.Drawing.Point(12, 54);
			this.dataGridView_DichVu.Name = "dataGridView_DichVu";
			this.dataGridView_DichVu.RowHeadersVisible = false;
			this.dataGridView_DichVu.Size = new global::System.Drawing.Size(555, 236);
			this.dataGridView_DichVu.TabIndex = 2;
			this.dataGridView_DichVu.CellValueChanged += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DichVu_CellValueChanged);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Arial", 27f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Blue;
			this.label1.Location = new global::System.Drawing.Point(73, 6);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(400, 43);
			this.label1.TabIndex = 3;
			this.label1.Text = "Danh sách các dịch vụ";
			this.buttonThoat.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonThoat.Location = new global::System.Drawing.Point(492, 299);
			this.buttonThoat.Name = "buttonThoat";
			this.buttonThoat.Size = new global::System.Drawing.Size(75, 23);
			this.buttonThoat.TabIndex = 4;
			this.buttonThoat.Text = "Thoát";
			this.buttonThoat.UseVisualStyleBackColor = true;
			this.buttonThoat.Click += new global::System.EventHandler(this.buttonThoat_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(581, 332);
			base.Controls.Add(this.buttonThoat);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.dataGridView_DichVu);
			base.Controls.Add(this.button_CapNhat);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ServicesManagement";
			base.ShowInTaskbar = false;
			this.Text = "Quản lý dịch vụ";
			base.Load += new global::System.EventHandler(this.ServicesManagement_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView_DichVu).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000AC RID: 172
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.Button button_CapNhat;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.DataGridView dataGridView_DichVu;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.Button buttonThoat;
	}
}
