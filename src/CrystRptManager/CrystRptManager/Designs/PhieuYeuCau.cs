using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x0200002F RID: 47
	public class PhieuYeuCau : ReportClass
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x000069C4 File Offset: 0x000059C4
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x000069DB File Offset: 0x000059DB
		public override string ResourceName
		{
			get
			{
				return "PhieuYeuCau.rpt";
			}
			set
			{
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000069E0 File Offset: 0x000059E0
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section ReportHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00006A04 File Offset: 0x00005A04
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section PageHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00006A28 File Offset: 0x00005A28
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section DetailSection1
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00006A4C File Offset: 0x00005A4C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section ReportFooterSection1
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00006A70 File Offset: 0x00005A70
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section PageFooterSection1
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00006A94 File Offset: 0x00005A94
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_District
		{
			get
			{
				return this.DataDefinition.ParameterFields[0];
			}
		}
	}
}
