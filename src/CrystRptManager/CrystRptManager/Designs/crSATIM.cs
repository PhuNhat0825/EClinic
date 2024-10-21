using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000011 RID: 17
	public class crSATIM : ReportClass
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00003878 File Offset: 0x00002878
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000388F File Offset: 0x0000288F
		public override string ResourceName
		{
			get
			{
				return "crSATIM.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00003894 File Offset: 0x00002894
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section ReportHeaderSection4
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000038B8 File Offset: 0x000028B8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000038DC File Offset: 0x000028DC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section ReportHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00003900 File Offset: 0x00002900
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section ReportHeaderSection2
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00003924 File Offset: 0x00002924
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section ReportHeaderSection3
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00003948 File Offset: 0x00002948
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section PageHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[5];
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000396C File Offset: 0x0000296C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section3
		{
			get
			{
				return this.ReportDefinition.Sections[6];
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00003990 File Offset: 0x00002990
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[7];
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000039B4 File Offset: 0x000029B4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section5
		{
			get
			{
				return this.ReportDefinition.Sections[8];
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000039D8 File Offset: 0x000029D8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public IParameterField Parameter_banquyen
		{
			get
			{
				return this.DataDefinition.ParameterFields[0];
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000039FC File Offset: 0x000029FC
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
