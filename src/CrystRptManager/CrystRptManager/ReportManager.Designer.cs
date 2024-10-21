namespace CrystRptManager
{
	// Token: 0x02000017 RID: 23
	public partial class ReportManager : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x000047CC File Offset: 0x000037CC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
			global::EClinicDB.CloseConnection();
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000480C File Offset: 0x0000380C
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
			this.crystalReportViewer1.ShowCloseButton = false;
			this.crystalReportViewer1.ShowGotoPageButton = false;
			this.crystalReportViewer1.ShowGroupTreeButton = false;
			this.crystalReportViewer1.ShowTextSearchButton = false;
			this.crystalReportViewer1.Size = new global::System.Drawing.Size(748, 458);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.ViewTimeSelectionFormula = "";
			this.crystalReportViewer1.Load += new global::System.EventHandler(this.crystalReportViewer1_Load);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(748, 458);
			base.Controls.Add(this.crystalReportViewer1);
			base.Name = "ReportManager";
			base.ShowInTaskbar = false;
			this.Text = "eClinic - Kết quả Siêu âm";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.ReportManager_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x0400001F RID: 31
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000020 RID: 32
		private global::CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
	}
}
