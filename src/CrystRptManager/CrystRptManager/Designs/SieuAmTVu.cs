using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000029 RID: 41
	public class SieuAmTVu : ReportClass
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00006454 File Offset: 0x00005454
		// (set) Token: 0x0600016A RID: 362 RVA: 0x0000646B File Offset: 0x0000546B
		public override string ResourceName
		{
			get
			{
				return "SieuAmTVu.rpt";
			}
			set
			{
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00006470 File Offset: 0x00005470
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section ReportHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00006494 File Offset: 0x00005494
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section PageHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000064B8 File Offset: 0x000054B8
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section PageHeaderSection2
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000064DC File Offset: 0x000054DC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section DetailSection1
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00006500 File Offset: 0x00005500
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section DetailSection2
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00006524 File Offset: 0x00005524
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section DetailSection6
		{
			get
			{
				return this.ReportDefinition.Sections[5];
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00006548 File Offset: 0x00005548
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section ReportFooterSection1
		{
			get
			{
				return this.ReportDefinition.Sections[6];
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0000656C File Offset: 0x0000556C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section PageFooterSection1
		{
			get
			{
				return this.ReportDefinition.Sections[7];
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00006590 File Offset: 0x00005590
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public IParameterField Parameter_TitleReport
		{
			get
			{
				return this.DataDefinition.ParameterFields[0];
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000065B4 File Offset: 0x000055B4
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_District
		{
			get
			{
				return this.DataDefinition.ParameterFields[1];
			}
		}
	}
}
