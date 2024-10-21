using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace CrystRptManager.Designs
{
	// Token: 0x0200002D RID: 45
	public class crSATG : ReportClass
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00006854 File Offset: 0x00005854
		// (set) Token: 0x06000194 RID: 404 RVA: 0x0000686B File Offset: 0x0000586B
		public override string ResourceName
		{
			get
			{
				return "crSATG.rpt";
			}
			set
			{
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00006870 File Offset: 0x00005870
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00006894 File Offset: 0x00005894
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000197 RID: 407 RVA: 0x000068B8 File Offset: 0x000058B8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section3
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000198 RID: 408 RVA: 0x000068DC File Offset: 0x000058DC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00006900 File Offset: 0x00005900
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
