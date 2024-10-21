namespace CrystRptManager
{
	// Token: 0x02000016 RID: 22
	public partial class ReportSATVu : global::System.Windows.Forms.Form
	{
		// Token: 0x060000CE RID: 206 RVA: 0x00004634 File Offset: 0x00003634
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000466C File Offset: 0x0000366C
		private void InitializeComponent()
		{
			this.crystalReportViewer1 = new global::CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.sieuAmTVu1 = new global::CrystRptManager.Designs.SieuAmTVu();
			base.SuspendLayout();
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.DisplayGroupTree = false;
			this.crystalReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.SelectionFormula = "";
			this.crystalReportViewer1.Size = new global::System.Drawing.Size(781, 456);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.ViewTimeSelectionFormula = "";
			this.crystalReportViewer1.Load += new global::System.EventHandler(this.crystalReportViewer1_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(781, 456);
			base.Controls.Add(this.crystalReportViewer1);
			base.Name = "ReportSATVu";
			this.Text = "ReportSATVu";
			base.Load += new global::System.EventHandler(this.ReportSATVu_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x0400001C RID: 28
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001D RID: 29
		private global::CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

		// Token: 0x0400001E RID: 30
		private global::CrystRptManager.Designs.SieuAmTVu sieuAmTVu1;
	}
}
