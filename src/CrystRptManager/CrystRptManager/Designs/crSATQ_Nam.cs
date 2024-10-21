using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace CrystRptManager.Designs
{
	// Token: 0x0200000D RID: 13
	public class crSATQ_Nam : ReportClass
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000352C File Offset: 0x0000252C
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00003543 File Offset: 0x00002543
		public override string ResourceName
		{
			get
			{
				return "crSATQ_Nam.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00003548 File Offset: 0x00002548
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000356C File Offset: 0x0000256C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00003590 File Offset: 0x00002590
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section3
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000035B4 File Offset: 0x000025B4
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000035D8 File Offset: 0x000025D8
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
