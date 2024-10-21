namespace ReceptionAdmin
{
	// Token: 0x02000003 RID: 3
	public partial class ThongKeThuNgan : global::System.Windows.Forms.Form
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002078 File Offset: 0x00001078
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020B0 File Offset: 0x000010B0
		private void InitializeComponent()
		{
			this.dateTimePickerTuNgay = new global::System.Windows.Forms.DateTimePicker();
			this.dateTimePickerDenNgay = new global::System.Windows.Forms.DateTimePicker();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.label3 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.dateTimePickerTuNgay.CalendarFont = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.dateTimePickerTuNgay.CustomFormat = "dd / MM / yyyy  HH : mm : ss";
			this.dateTimePickerTuNgay.DropDownAlign = global::System.Windows.Forms.LeftRightAlignment.Right;
			this.dateTimePickerTuNgay.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerTuNgay.Location = new global::System.Drawing.Point(132, 84);
			this.dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
			this.dateTimePickerTuNgay.Size = new global::System.Drawing.Size(184, 20);
			this.dateTimePickerTuNgay.TabIndex = 0;
			this.dateTimePickerDenNgay.CalendarFont = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.dateTimePickerDenNgay.CustomFormat = "dd / MM / yyyy  HH : mm : ss";
			this.dateTimePickerDenNgay.DropDownAlign = global::System.Windows.Forms.LeftRightAlignment.Right;
			this.dateTimePickerDenNgay.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDenNgay.Location = new global::System.Drawing.Point(132, 126);
			this.dateTimePickerDenNgay.Name = "dateTimePickerDenNgay";
			this.dateTimePickerDenNgay.Size = new global::System.Drawing.Size(184, 20);
			this.dateTimePickerDenNgay.TabIndex = 1;
			this.buttonOK.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonOK.Location = new global::System.Drawing.Point(106, 180);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(88, 34);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "&Chấp nhận";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new global::System.EventHandler(this.buttonOK_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(51, 88);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(52, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Từ ngày :";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(51, 130);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(59, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Đến ngày :";
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonCancel.Location = new global::System.Drawing.Point(209, 180);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(85, 34);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "&Thoát";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new global::System.EventHandler(this.buttonCancel_Click);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label3.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.label3.Location = new global::System.Drawing.Point(68, 30);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(269, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "THỐNG KÊ DOANH THU";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AcceptButton = this.buttonOK;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.buttonCancel;
			base.ClientSize = new global::System.Drawing.Size(412, 241);
			base.ControlBox = false;
			base.Controls.Add(this.label3);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.dateTimePickerDenNgay);
			base.Controls.Add(this.dateTimePickerTuNgay);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ThongKeThuNgan";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Báo cáo thu ngân";
			base.Load += new global::System.EventHandler(this.ThongKeThuNgan_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.DateTimePicker dateTimePickerTuNgay;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.DateTimePicker dateTimePickerDenNgay;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label label3;
	}
}
