namespace CrystRptManager
{
	// Token: 0x02000004 RID: 4
	public partial class ThongKeThuNgan : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002364 File Offset: 0x00001364
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000239C File Offset: 0x0000139C
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
			this.crystalReportViewer1.ShowRefreshButton = false;
			this.crystalReportViewer1.Size = new global::System.Drawing.Size(477, 290);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.ViewTimeSelectionFormula = "";
			this.crystalReportViewer1.Load += new global::System.EventHandler(this.crystalReportViewer1_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(477, 290);
			base.Controls.Add(this.crystalReportViewer1);
			base.Name = "ThongKeThuNgan";
			this.Text = "ThongKeThuNgan";
			base.Load += new global::System.EventHandler(this.ThongKeThuNgan_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000004 RID: 4
		private global::CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
	}
}
