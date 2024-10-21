using System;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace EchoAdmin.Reports
{
	// Token: 0x0200000B RID: 11
	public class HinhAnhTrucTiep : ReportClass
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000B264 File Offset: 0x0000A264
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0000B27B File Offset: 0x0000A27B
		public override string ResourceName
		{
			get
			{
				return "HinhAnhTrucTiep.rpt";
			}
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000B280 File Offset: 0x0000A280
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section1
		{
			get
			{
				return this.ReportDefinition.Sections[0];
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000B2A4 File Offset: 0x0000A2A4
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section Section2
		{
			get
			{
				return this.ReportDefinition.Sections[1];
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000B2C8 File Offset: 0x0000A2C8
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section PageHeaderSection1
		{
			get
			{
				return this.ReportDefinition.Sections[2];
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000B2EC File Offset: 0x0000A2EC
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section PageHeaderSection2
		{
			get
			{
				return this.ReportDefinition.Sections[3];
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000B310 File Offset: 0x0000A310
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Section PageHeaderSection3
		{
			get
			{
				return this.ReportDefinition.Sections[4];
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000B334 File Offset: 0x0000A334
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section PageHeaderSection4
		{
			get
			{
				return this.ReportDefinition.Sections[5];
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000B358 File Offset: 0x0000A358
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section3
		{
			get
			{
				return this.ReportDefinition.Sections[6];
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000B37C File Offset: 0x0000A37C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section4
		{
			get
			{
				return this.ReportDefinition.Sections[7];
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000B3A0 File Offset: 0x0000A3A0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public Section Section5
		{
			get
			{
				return this.ReportDefinition.Sections[8];
			}
		}
	}
}
