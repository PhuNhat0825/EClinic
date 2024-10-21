using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000027 RID: 39
	public class ThongKeThuNgan : ReportClass
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000629C File Offset: 0x0000529C
		// (set) Token: 0x06000157 RID: 343 RVA: 0x000062B3 File Offset: 0x000052B3
		public override string ResourceName
		{
			get
			{
				return "ThongKeThuNgan.rpt";
			}
			set
			{
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000062B8 File Offset: 0x000052B8
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section ReportHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000062DC File Offset: 0x000052DC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section PageHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00006300 File Offset: 0x00005300
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section DetailSection1
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00006324 File Offset: 0x00005324
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section ReportFooterSection1
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00006348 File Offset: 0x00005348
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section PageFooterSection1
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0000636C File Offset: 0x0000536C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public IParameterField Parameter_TuNgay
		{
			get
			{
				return this.DataDefinition.ParameterFields[0];
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00006390 File Offset: 0x00005390
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public IParameterField Parameter_DenNgay
		{
			get
			{
				return this.DataDefinition.ParameterFields[1];
			}
		}
	}
}
