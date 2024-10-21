namespace CrystRptManager
{
	// Token: 0x02000057 RID: 87
	public partial class ReportSAMM : global::System.Windows.Forms.Form
	{
		// Token: 0x0600073D RID: 1853 RVA: 0x00019AFC File Offset: 0x00018AFC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00019B34 File Offset: 0x00018B34
		private void InitializeComponent()
		{
			this.crystalReportViewer1 = new global::CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.sieuAmMM1 = new global::CrystRptManager.Designs.SieuAmMM();
			base.SuspendLayout();
			this.crystalReportViewer1.ActiveViewIndex = 0;
			this.crystalReportViewer1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.DisplayGroupTree = false;
			this.crystalReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = this.sieuAmMM1;
			this.crystalReportViewer1.Size = new global::System.Drawing.Size(735, 466);
			this.crystalReportViewer1.TabIndex = 1;
			this.crystalReportViewer1.Load += new global::System.EventHandler(this.crystalReportViewer1_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(735, 466);
			base.Controls.Add(this.crystalReportViewer1);
			base.Name = "ReportSAMM";
			this.Text = "EchoAdmin - Kết quả Siêu âm mạch máu";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.ReportSAMM_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000145 RID: 325
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000146 RID: 326
		private global::CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

		// Token: 0x04000147 RID: 327
		private global::CrystRptManager.Designs.SieuAmMM sieuAmMM1;
	}
}
