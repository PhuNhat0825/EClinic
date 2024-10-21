using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace CrystRptManager.Designs
{
	// Token: 0x02000058 RID: 88
	public class crSAKHAC : ReportClass
	{
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00019F88 File Offset: 0x00018F88
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00019F9F File Offset: 0x00018F9F
		public override string ResourceName
		{
			get
			{
				return "crSAKHAC.rpt";
			}
			set
			{
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00019FA4 File Offset: 0x00018FA4
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00019FC8 File Offset: 0x00018FC8
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00019FEC File Offset: 0x00018FEC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section3
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0001A010 File Offset: 0x00019010
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x0001A034 File Offset: 0x00019034
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section5
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}
	}
}
