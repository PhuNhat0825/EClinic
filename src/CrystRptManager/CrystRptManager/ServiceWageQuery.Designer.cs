namespace CrystRptManager
{
	// Token: 0x02000015 RID: 21
	public partial class ServiceWageQuery : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00003E8C File Offset: 0x00002E8C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00003EC4 File Offset: 0x00002EC4
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.dateTimePicker_TuNgay = new global::System.Windows.Forms.DateTimePicker();
			this.dateTimePicker_DenNgay = new global::System.Windows.Forms.DateTimePicker();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button_XemRieng = new global::System.Windows.Forms.Button();
			this.button_XemTatCa = new global::System.Windows.Forms.Button();
			this.butDSBN = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(103, 40);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ ngày:";
			this.dateTimePicker_TuNgay.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_TuNgay.Location = new global::System.Drawing.Point(193, 36);
			this.dateTimePicker_TuNgay.Name = "dateTimePicker_TuNgay";
			this.dateTimePicker_TuNgay.Size = new global::System.Drawing.Size(171, 20);
			this.dateTimePicker_TuNgay.TabIndex = 1;
			this.dateTimePicker_DenNgay.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker_DenNgay.Location = new global::System.Drawing.Point(193, 74);
			this.dateTimePicker_DenNgay.Name = "dateTimePicker_DenNgay";
			this.dateTimePicker_DenNgay.Size = new global::System.Drawing.Size(171, 20);
			this.dateTimePicker_DenNgay.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(103, 78);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(56, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Đến ngày:";
			this.button_XemRieng.Location = new global::System.Drawing.Point(106, 205);
			this.button_XemRieng.Name = "button_XemRieng";
			this.button_XemRieng.Size = new global::System.Drawing.Size(258, 33);
			this.button_XemRieng.TabIndex = 4;
			this.button_XemRieng.Text = "Xem số ca và tiền công của tôi";
			this.button_XemRieng.UseVisualStyleBackColor = true;
			this.button_XemRieng.Visible = false;
			this.button_XemRieng.Click += new global::System.EventHandler(this.button_XemRieng_Click);
			this.button_XemTatCa.Location = new global::System.Drawing.Point(106, 128);
			this.button_XemTatCa.Name = "button_XemTatCa";
			this.button_XemTatCa.Size = new global::System.Drawing.Size(258, 33);
			this.button_XemTatCa.TabIndex = 5;
			this.button_XemTatCa.Text = "Xem số ca và tiền công của Bác sĩ";
			this.button_XemTatCa.UseVisualStyleBackColor = true;
			this.button_XemTatCa.Visible = false;
			this.button_XemTatCa.Click += new global::System.EventHandler(this.button_XemTatCa_Click);
			this.butDSBN.Location = new global::System.Drawing.Point(106, 167);
			this.butDSBN.Name = "butDSBN";
			this.butDSBN.Size = new global::System.Drawing.Size(258, 32);
			this.butDSBN.TabIndex = 6;
			this.butDSBN.Text = "Báo cáo thu ngân";
			this.butDSBN.UseVisualStyleBackColor = true;
			this.butDSBN.Click += new global::System.EventHandler(this.butDSBN_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(483, 299);
			base.Controls.Add(this.butDSBN);
			base.Controls.Add(this.button_XemTatCa);
			base.Controls.Add(this.button_XemRieng);
			base.Controls.Add(this.dateTimePicker_DenNgay);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.dateTimePicker_TuNgay);
			base.Controls.Add(this.label1);
			base.Name = "ServiceWageQuery";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "eClinic - Xem số ca đã thực hiện và tiền công";
			base.Load += new global::System.EventHandler(this.ServiceWageQuery_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000013 RID: 19
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.DateTimePicker dateTimePicker_TuNgay;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.DateTimePicker dateTimePicker_DenNgay;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button button_XemRieng;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Button button_XemTatCa;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Button butDSBN;
	}
}
