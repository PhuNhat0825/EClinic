using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000013 RID: 19
	public class ThongKeLuongBenh : ReportClass
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00003AC0 File Offset: 0x00002AC0
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00003AD7 File Offset: 0x00002AD7
		public override string ResourceName
		{
			get
			{
				return "ThongKeLuongBenh.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00003ADC File Offset: 0x00002ADC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section ReportHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003B00 File Offset: 0x00002B00
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section PageHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00003B24 File Offset: 0x00002B24
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section GroupHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00003B48 File Offset: 0x00002B48
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section GroupHeaderSection2
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00003B6C File Offset: 0x00002B6C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section GroupHeaderSection3
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00003B90 File Offset: 0x00002B90
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section DetailSection1
		{
			get
			{
				return this.ReportDefinition.Sections[5];
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00003BB4 File Offset: 0x00002BB4
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section GroupFooterSection3
		{
			get
			{
				return this.ReportDefinition.Sections[6];
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00003BD8 File Offset: 0x00002BD8
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section GroupFooterSection2
		{
			get
			{
				return this.ReportDefinition.Sections[7];
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00003BFC File Offset: 0x00002BFC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section GroupFooterSection1
		{
			get
			{
				return this.ReportDefinition.Sections[8];
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003C20 File Offset: 0x00002C20
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section ReportFooterSection1
		{
			get
			{
				return this.ReportDefinition.Sections[9];
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00003C44 File Offset: 0x00002C44
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section PageFooterSection1
		{
			get
			{
				return this.ReportDefinition.Sections[10];
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00003C68 File Offset: 0x00002C68
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_District
		{
			get
			{
				return this.DataDefinition.ParameterFields[0];
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00003C8C File Offset: 0x00002C8C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_TuNgay
		{
			get
			{
				return this.DataDefinition.ParameterFields[1];
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00003CB0 File Offset: 0x00002CB0
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_DenNgay
		{
			get
			{
				return this.DataDefinition.ParameterFields[2];
			}
		}
	}
}
