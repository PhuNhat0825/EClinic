using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystRptManager.Designs
{
	// Token: 0x02000002 RID: 2
	public class SieuAmPhuKhoa : ReportClass
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000205C File Offset: 0x0000105C
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002073 File Offset: 0x00001073
		public override string ResourceName
		{
			get
			{
				return "SieuAmPhuKhoa.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002078 File Offset: 0x00001078
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section ReportHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000209C File Offset: 0x0000109C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section PageHeaderSection3
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020C0 File Offset: 0x000010C0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section DetailSection5
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020E4 File Offset: 0x000010E4
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section DetailSection6
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002108 File Offset: 0x00001108
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section DetailSection1
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000212C File Offset: 0x0000112C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section DetailSection7
		{
			get
			{
				return this.ReportDefinition.Sections[5];
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002150 File Offset: 0x00001150
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section ReportFooterSection1
		{
			get
			{
				return this.ReportDefinition.Sections[6];
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002174 File Offset: 0x00001174
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section PageFooterSection2
		{
			get
			{
				return this.ReportDefinition.Sections[7];
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002198 File Offset: 0x00001198
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public IParameterField Parameter_District
		{
			get
			{
				return this.DataDefinition.ParameterFields[0];
			}
		}
	}
}
