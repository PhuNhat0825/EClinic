using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000007 RID: 7
	public class SieuAmThai2D_1 : ReportClass
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002678 File Offset: 0x00001678
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0000268F File Offset: 0x0000168F
		public override string ResourceName
		{
			get
			{
				return "SieuAmThai2D_1.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002694 File Offset: 0x00001694
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section ReportHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000026B8 File Offset: 0x000016B8
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section PageHeaderSection3
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000026DC File Offset: 0x000016DC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section DetailSection1
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002700 File Offset: 0x00001700
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section DetailSection3
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002724 File Offset: 0x00001724
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section DetailSection2
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002748 File Offset: 0x00001748
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section ReportFooterSection1
		{
			get
			{
				return this.ReportDefinition.Sections[5];
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0000276C File Offset: 0x0000176C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section PageFooterSection2
		{
			get
			{
				return this.ReportDefinition.Sections[6];
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002790 File Offset: 0x00001790
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public IParameterField Parameter_District
		{
			get
			{
				return this.DataDefinition.ParameterFields[0];
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000027B4 File Offset: 0x000017B4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public IParameterField Parameter_TitleReport
		{
			get
			{
				return this.DataDefinition.ParameterFields[1];
			}
		}
	}
}
