namespace CrystRptManager
{
	// Token: 0x0200001F RID: 31
	public partial class ReportThongKeLuongBenh : global::System.Windows.Forms.Form
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00005898 File Offset: 0x00004898
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000058D0 File Offset: 0x000048D0
		private void InitializeComponent()
		{
			this.crystalReportViewer1 = new global::CrystalDecisions.Windows.Forms.CrystalReportViewer();
			base.SuspendLayout();
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.SelectionFormula = "";
			this.crystalReportViewer1.ShowRefreshButton = false;
			this.crystalReportViewer1.Size = new global::System.Drawing.Size(557, 385);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.ViewTimeSelectionFormula = "";
			this.crystalReportViewer1.Load += new global::System.EventHandler(this.crystalReportViewer1_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(557, 385);
			base.Controls.Add(this.crystalReportViewer1);
			base.Name = "ReportThongKeLuongBenh";
			this.Text = "ReportThongKeLuongBenh";
			base.Load += new global::System.EventHandler(this.ReportThongKeLuongBenh_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000029 RID: 41
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400002A RID: 42
		private global::CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
	}
}
