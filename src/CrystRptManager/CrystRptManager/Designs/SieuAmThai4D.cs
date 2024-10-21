using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000034 RID: 52
	public class SieuAmThai4D : ReportClass
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00007138 File Offset: 0x00006138
		// (set) Token: 0x060001CE RID: 462 RVA: 0x0000714F File Offset: 0x0000614F
		public override string ResourceName
		{
			get
			{
				return "SieuAmThai4D.rpt";
			}
			set
			{
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00007154 File Offset: 0x00006154
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00007178 File Offset: 0x00006178
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000719C File Offset: 0x0000619C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section DetailSection1
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000071C0 File Offset: 0x000061C0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section DetailSection2
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000071E4 File Offset: 0x000061E4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00007208 File Offset: 0x00006208
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section5
		{
			get
			{
				return this.ReportDefinition.Sections[5];
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000722C File Offset: 0x0000622C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public IParameterField Parameter_TitleReport
		{
			get
			{
				return this.DataDefinition.ParameterFields[0];
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00007250 File Offset: 0x00006250
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
