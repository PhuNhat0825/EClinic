using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace CrystRptManager.Designs
{
	// Token: 0x02000025 RID: 37
	public class ThongTinKhachHang : ReportClass
	{
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000612C File Offset: 0x0000512C
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00006143 File Offset: 0x00005143
		public override string ResourceName
		{
			get
			{
				return "ThongTinKhachHang.rpt";
			}
			set
			{
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00006148 File Offset: 0x00005148
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000616C File Offset: 0x0000516C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00006190 File Offset: 0x00005190
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section3
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000061B4 File Offset: 0x000051B4
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000061D8 File Offset: 0x000051D8
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section5
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}
	}
}
