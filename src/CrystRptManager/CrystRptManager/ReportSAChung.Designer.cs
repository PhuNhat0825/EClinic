namespace CrystRptManager
{
	// Token: 0x0200005A RID: 90
	public partial class ReportSAChung : global::System.Windows.Forms.Form
	{
		// Token: 0x06000754 RID: 1876 RVA: 0x0001A0F0 File Offset: 0x000190F0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0001A128 File Offset: 0x00019128
		private void InitializeComponent()
		{
			this.crystalReportViewer1 = new global::CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.sieuAmChung1 = new global::CrystRptManager.Designs.SieuAmChung();
			base.SuspendLayout();
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.AutoSize = true;
			this.crystalReportViewer1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.DisplayGroupTree = false;
			this.crystalReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.SelectionFormula = "";
			this.crystalReportViewer1.Size = new global::System.Drawing.Size(829, 502);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.ViewTimeSelectionFormula = "";
			this.crystalReportViewer1.Load += new global::System.EventHandler(this.crystalReportViewer1_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(829, 502);
			base.Controls.Add(this.crystalReportViewer1);
			base.Name = "ReportSAChung";
			this.Text = "ReportSAChung";
			base.Load += new global::System.EventHandler(this.ReportSAChung_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000149 RID: 329
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400014A RID: 330
		private global::CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

		// Token: 0x0400014B RID: 331
		private global::CrystRptManager.Designs.SieuAmChung sieuAmChung1;
	}
}
