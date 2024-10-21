namespace CrystRptManager
{
	// Token: 0x0200000C RID: 12
	public partial class ReportSATQ : global::System.Windows.Forms.Form
	{
		// Token: 0x0600006B RID: 107 RVA: 0x0000336C File Offset: 0x0000236C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000033A4 File Offset: 0x000023A4
		private void InitializeComponent()
		{
			this.crystalReportViewer1 = new global::CrystalDecisions.Windows.Forms.CrystalReportViewer();
			base.SuspendLayout();
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.DisplayGroupTree = false;
			this.crystalReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.SelectionFormula = "";
			this.crystalReportViewer1.ShowGotoPageButton = false;
			this.crystalReportViewer1.ShowGroupTreeButton = false;
			this.crystalReportViewer1.ShowRefreshButton = false;
			this.crystalReportViewer1.Size = new global::System.Drawing.Size(796, 476);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.ViewTimeSelectionFormula = "";
			this.crystalReportViewer1.Load += new global::System.EventHandler(this.crystalReportViewer1_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(796, 476);
			base.Controls.Add(this.crystalReportViewer1);
			base.Name = "ReportSATQ";
			this.Text = "ReportSATQ";
			base.Load += new global::System.EventHandler(this.ReportSATQ_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000011 RID: 17
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000012 RID: 18
		private global::CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
	}
}
