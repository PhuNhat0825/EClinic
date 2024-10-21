using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000022 RID: 34
	public class SieuAmMM : ReportClass
	{
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00005CA0 File Offset: 0x00004CA0
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00005CB7 File Offset: 0x00004CB7
		public override string ResourceName
		{
			get
			{
				return "SieuAmMM.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00005CBC File Offset: 0x00004CBC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00005CE0 File Offset: 0x00004CE0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00005D04 File Offset: 0x00004D04
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section DetailSection1
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00005D28 File Offset: 0x00004D28
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section DetailSection2
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00005D4C File Offset: 0x00004D4C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00005D70 File Offset: 0x00004D70
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section5
		{
			get
			{
				return this.ReportDefinition.Sections[5];
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00005D94 File Offset: 0x00004D94
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_TitleReport
		{
			get
			{
				return this.DataDefinition.ParameterFields[0];
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00005DB8 File Offset: 0x00004DB8
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
