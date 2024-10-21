namespace CrystRptManager
{
	// Token: 0x02000024 RID: 36
	public partial class ReportPhieuYeucau : global::System.Windows.Forms.Form
	{
		// Token: 0x0600013E RID: 318 RVA: 0x00005E74 File Offset: 0x00004E74
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00005EAC File Offset: 0x00004EAC
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
			this.crystalReportViewer1.ShowExportButton = false;
			this.crystalReportViewer1.Size = new global::System.Drawing.Size(602, 380);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.ViewTimeSelectionFormula = "";
			this.crystalReportViewer1.Load += new global::System.EventHandler(this.crystalReportViewer1_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(602, 380);
			base.Controls.Add(this.crystalReportViewer1);
			base.Name = "ReportPhieuYeucau";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ReportPhieuYeucau";
			base.Load += new global::System.EventHandler(this.ReportPhieuYeucau_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x0400002D RID: 45
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400002E RID: 46
		private global::CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
	}
}
