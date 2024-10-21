using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000009 RID: 9
	public class SieuAmTGiap : ReportClass
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002878 File Offset: 0x00001878
		// (set) Token: 0x06000044 RID: 68 RVA: 0x0000288F File Offset: 0x0000188F
		public override string ResourceName
		{
			get
			{
				return "SieuAmTGiap.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002894 File Offset: 0x00001894
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000028B8 File Offset: 0x000018B8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000028DC File Offset: 0x000018DC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section DetailSection1
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002900 File Offset: 0x00001900
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section DetailSection2
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002924 File Offset: 0x00001924
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002948 File Offset: 0x00001948
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section5
		{
			get
			{
				return this.ReportDefinition.Sections[5];
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000296C File Offset: 0x0000196C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_TitleReport
		{
			get
			{
				return this.DataDefinition.ParameterFields[0];
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002990 File Offset: 0x00001990
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
