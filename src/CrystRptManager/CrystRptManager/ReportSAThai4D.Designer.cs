namespace CrystRptManager
{
	// Token: 0x02000056 RID: 86
	public partial class ReportSAThai4D : global::System.Windows.Forms.Form
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x00019970 File Offset: 0x00018970
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x000199A8 File Offset: 0x000189A8
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
			this.crystalReportViewer1.Size = new global::System.Drawing.Size(510, 342);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.ViewTimeSelectionFormula = "";
			this.crystalReportViewer1.Load += new global::System.EventHandler(this.crystalReportViewer1_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(510, 342);
			base.Controls.Add(this.crystalReportViewer1);
			base.Name = "ReportSAThai4D";
			this.Text = "ReportSAThai4D";
			base.Load += new global::System.EventHandler(this.ReportSAThai4D_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000143 RID: 323
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000144 RID: 324
		private global::CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
	}
}
