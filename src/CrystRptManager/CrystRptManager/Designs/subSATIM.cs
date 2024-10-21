using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace CrystRptManager.Designs
{
	// Token: 0x0200000F RID: 15
	public class subSATIM : ReportClass
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000369C File Offset: 0x0000269C
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000036B3 File Offset: 0x000026B3
		public override string ResourceName
		{
			get
			{
				return "subSATIM.rpt";
			}
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000036B8 File Offset: 0x000026B8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section ReportHeaderSection3
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000036DC File Offset: 0x000026DC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section ReportHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00003700 File Offset: 0x00002700
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section ReportHeaderSection2
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00003724 File Offset: 0x00002724
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section PageHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00003748 File Offset: 0x00002748
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section DetailSection1
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000376C File Offset: 0x0000276C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section ReportFooterSection1
		{
			get
			{
				return this.ReportDefinition.Sections[5];
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003790 File Offset: 0x00002790
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section ReportFooterSection2
		{
			get
			{
				return this.ReportDefinition.Sections[6];
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000037B4 File Offset: 0x000027B4
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section PageFooterSection1
		{
			get
			{
				return this.ReportDefinition.Sections[7];
			}
		}
	}
}
