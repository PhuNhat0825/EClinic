using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace CrystRptManager.Designs
{
	// Token: 0x02000032 RID: 50
	public class crSATV : ReportClass
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00006FC8 File Offset: 0x00005FC8
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00006FDF File Offset: 0x00005FDF
		public override string ResourceName
		{
			get
			{
				return "crSATV.rpt";
			}
			set
			{
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00006FE4 File Offset: 0x00005FE4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00007008 File Offset: 0x00006008
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000702C File Offset: 0x0000602C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section3
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00007050 File Offset: 0x00006050
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00007074 File Offset: 0x00006074
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
