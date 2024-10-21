namespace CrystRptManager
{
	// Token: 0x0200001E RID: 30
	public partial class ReportSATGiap : global::System.Windows.Forms.Form
	{
		// Token: 0x06000111 RID: 273 RVA: 0x0000570C File Offset: 0x0000470C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00005744 File Offset: 0x00004744
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
			this.crystalReportViewer1.Size = new global::System.Drawing.Size(377, 325);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.ViewTimeSelectionFormula = "";
			this.crystalReportViewer1.Load += new global::System.EventHandler(this.crystalReportViewer1_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(377, 325);
			base.Controls.Add(this.crystalReportViewer1);
			base.Name = "ReportSATGiap";
			this.Text = "ReportSATGiap";
			base.Load += new global::System.EventHandler(this.ReportSATGiap_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000027 RID: 39
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000028 RID: 40
		private global::CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
	}
}
