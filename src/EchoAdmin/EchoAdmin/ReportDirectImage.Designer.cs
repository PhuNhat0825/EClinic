namespace EchoAdmin
{
	// Token: 0x02000003 RID: 3
	public partial class ReportDirectImage : global::System.Windows.Forms.Form
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002908 File Offset: 0x00001908
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			global::Utility.GeneralUtility.ArrayCaptureImages.Clear();
			base.Dispose(disposing);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000294C File Offset: 0x0000194C
		private void InitializeComponent()
		{
			this.crystalReportViewer1 = new global::CrystalDecisions.Windows.Forms.CrystalReportViewer();
			base.SuspendLayout();
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.DisplayGroupTree = false;
			this.crystalReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.EnableToolTips = false;
			this.crystalReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ShowExportButton = false;
			this.crystalReportViewer1.ShowGroupTreeButton = false;
			this.crystalReportViewer1.ShowRefreshButton = false;
			this.crystalReportViewer1.ShowTextSearchButton = false;
			this.crystalReportViewer1.Size = new global::System.Drawing.Size(715, 433);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.Load += new global::System.EventHandler(this.crystalReportViewer1_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(715, 433);
			base.Controls.Add(this.crystalReportViewer1);
			base.Name = "ReportDirectImage";
			this.Text = "EchoAdmin - In hình trực tiếp";
			base.Load += new global::System.EventHandler(this.ReportDirectImage_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x0400000E RID: 14
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400000F RID: 15
		private global::CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
	}
}
