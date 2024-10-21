namespace MainProject
{
	// Token: 0x02000009 RID: 9
	public partial class NhomNguoiDung : global::System.Windows.Forms.Form
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00007E78 File Offset: 0x00006E78
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007EB0 File Offset: 0x00006EB0
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.buttonEdit = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			base.SuspendLayout();
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new global::System.Drawing.Point(12, 12);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new global::System.Drawing.Size(939, 446);
			this.dataGridView1.TabIndex = 0;
			this.buttonEdit.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonEdit.Location = new global::System.Drawing.Point(376, 480);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new global::System.Drawing.Size(87, 34);
			this.buttonEdit.TabIndex = 1;
			this.buttonEdit.Text = "&Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new global::System.EventHandler(this.buttonEdit_Click);
			this.buttonCancel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonCancel.Location = new global::System.Drawing.Point(469, 480);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(87, 34);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "&Close";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new global::System.EventHandler(this.buttonCancel_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(963, 526);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonEdit);
			base.Controls.Add(this.dataGridView1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Name = "NhomNguoiDung";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Nhóm người sử dụng";
			base.Load += new global::System.EventHandler(this.NhomNguoiDung_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400007B RID: 123
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Button buttonEdit;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.Button buttonCancel;
	}
}
