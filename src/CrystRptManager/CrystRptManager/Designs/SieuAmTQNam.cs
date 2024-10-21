using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x0200001A RID: 26
	public class SieuAmTQNam : ReportClass
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000512C File Offset: 0x0000412C
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00005143 File Offset: 0x00004143
		public override string ResourceName
		{
			get
			{
				return "SieuAmTQNam.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00005148 File Offset: 0x00004148
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000516C File Offset: 0x0000416C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00005190 File Offset: 0x00004190
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section DetailSection2
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000051B4 File Offset: 0x000041B4
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000051D8 File Offset: 0x000041D8
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section5
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000051FC File Offset: 0x000041FC
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public IParameterField Parameter_TitleReport
		{
			get
			{
				return this.DataDefinition.ParameterFields[0];
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00005220 File Offset: 0x00004220
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public IParameterField Parameter_District
		{
			get
			{
				return this.DataDefinition.ParameterFields[1];
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00005244 File Offset: 0x00004244
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_pkten
		{
			get
			{
				return this.DataDefinition.ParameterFields[2];
			}
		}
	}
}
