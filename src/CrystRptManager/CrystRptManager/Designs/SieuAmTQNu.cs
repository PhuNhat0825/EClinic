using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000054 RID: 84
	public class SieuAmTQNu : ReportClass
	{
		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x000195FC File Offset: 0x000185FC
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00019613 File Offset: 0x00018613
		public override string ResourceName
		{
			get
			{
				return "SieuAmTQNu.rpt";
			}
			set
			{
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00019618 File Offset: 0x00018618
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x0001963C File Offset: 0x0001863C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00019660 File Offset: 0x00018660
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section DetailSection2
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00019684 File Offset: 0x00018684
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x000196A8 File Offset: 0x000186A8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section5
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x000196CC File Offset: 0x000186CC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_TitleReport
		{
			get
			{
				return this.DataDefinition.ParameterFields[0];
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x000196F0 File Offset: 0x000186F0
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
