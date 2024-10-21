namespace CrystRptManager
{
	// Token: 0x02000031 RID: 49
	public partial class ReportSAThai2D1 : global::System.Windows.Forms.Form
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00006B50 File Offset: 0x00005B50
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00006B88 File Offset: 0x00005B88
		private void InitializeComponent()
		{
			this.crystalReportViewer1 = new global::CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.sieuAmThai2D_11 = new global::CrystRptManager.Designs.SieuAmThai2D_1();
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
			this.crystalReportViewer1.ShowTextSearchButton = false;
			this.crystalReportViewer1.Size = new global::System.Drawing.Size(776, 480);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.ViewTimeSelectionFormula = "";
			this.crystalReportViewer1.Load += new global::System.EventHandler(this.crystalReportViewer1_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(776, 480);
			base.Controls.Add(this.crystalReportViewer1);
			base.Name = "SieuAmThai2D1";
			this.Text = "SieuAmThai2D1";
			base.Load += new global::System.EventHandler(this.SieuAmThai2D1_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000031 RID: 49
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000032 RID: 50
		private global::CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

		// Token: 0x04000033 RID: 51
		private global::CrystRptManager.Designs.SieuAmThai2D_1 sieuAmThai2D_11;
	}
}
