using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x0200002B RID: 43
	public class SieuAmChung : ReportClass
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00006678 File Offset: 0x00005678
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0000668F File Offset: 0x0000568F
		public override string ResourceName
		{
			get
			{
				return "SieuAmChung.rpt";
			}
			set
			{
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00006694 File Offset: 0x00005694
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000066B8 File Offset: 0x000056B8
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000066DC File Offset: 0x000056DC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section DetailSection1
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00006700 File Offset: 0x00005700
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section DetailSection2
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00006724 File Offset: 0x00005724
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00006748 File Offset: 0x00005748
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section5
		{
			get
			{
				return this.ReportDefinition.Sections[5];
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000676C File Offset: 0x0000576C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_TitleReport
		{
			get
			{
				return this.DataDefinition.ParameterFields[0];
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00006790 File Offset: 0x00005790
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public IParameterField Parameter_District
		{
			get
			{
				return this.DataDefinition.ParameterFields[1];
			}
		}
	}
}
